﻿using MediaPortal.Common;
using MediaPortal.Common.General;
using MediaPortal.Common.Localization;
using MediaPortal.Common.Messaging;
using MediaPortal.Common.PathManager;
using MediaPortal.Common.Services.Settings;
using MediaPortal.Common.Settings;
using MediaPortal.UI.Presentation.DataObjects;
using MediaPortal.UI.Presentation.Models;
using MediaPortal.UI.Presentation.Screens;
using MediaPortal.UI.Presentation.Workflow;
using OnlineVideos.CrossDomain;
using OnlineVideos.Downloading;
using System;
using System.Collections.Generic;
using System.Linq;
using OnlineVideos.MediaPortal2.Models;

namespace OnlineVideos.MediaPortal2
{
    public class OnlineVideosWorkflowModel : IWorkflowModel
    {
        public OnlineVideosWorkflowModel()
        {
            SiteGroupsList = new ItemsList();
            SitesList = new ItemsList();

            ConfigurationHelper.InitEnvironment();

            // create a message queue where we listen to changes to the sites
            _messageQueue = new AsynchronousMessageQueue(this, new string[] { OnlineVideosMessaging.CHANNEL });
            _messageQueue.MessageReceived += new MessageReceivedHandler(OnlineVideosMessageReceived);

            // listen to changes of configuration settings
            _settingsWatcher = new SettingsChangeWatcher<Configuration.Settings>();
            _settingsWatcher.SettingsChanged += OnlineVideosSettingsChanged;
        }

        protected AsynchronousMessageQueue _messageQueue;
        protected SettingsChangeWatcher<Configuration.Settings> _settingsWatcher;
        bool sitesListHasAllSites = false;

        SiteViewModel _focusedSite;
        public SiteViewModel FocusedSite
        {
            get { return _focusedSite; }
            set { if (value != null) _focusedSite = value; }
        }

        protected AbstractProperty _searchStringProperty = new WProperty(typeof(string), string.Empty);
        public AbstractProperty SearchStringProperty { get { return _searchStringProperty; } }
        public string SearchString
        {
            get { return (string)_searchStringProperty.GetValue(); }
            set { _searchStringProperty.SetValue(value); }
        }

        public SiteViewModel SelectedSite { get; protected set; }
        public CategoryViewModel SelectedCategory { get; protected set; }
        public VideoViewModel SelectedVideo { get; protected set; }
        public VideoViewModel SelectedDetailsVideo { get; protected set; }

        public ItemsList SiteGroupsList { get; protected set; }
        public ItemsList SitesList { get; protected set; }
        public ItemsList CategoriesList { get; protected set; }
        public ItemsList VideosList { get; protected set; }
        public List<VideoViewModel> DetailsVideosList { get; protected set; }

        public void SelectSiteGroup(SiteGroupViewModel siteGroupModel)
        {
            if (BackgroundTask.Instance.IsExecuting) return;
            SitesList.Clear();
            foreach (string siteName in siteGroupModel.Sites)
            {
                var siteutils = OnlineVideoSettings.Instance.SiteUtilsList;
                SitesList.Add(new SiteViewModel(siteutils[siteName]));
            }
            sitesListHasAllSites = false;
            SitesList.FireChange();
            IWorkflowManager workflowManager = ServiceRegistration.Get<IWorkflowManager>();
            workflowManager.NavigatePushAsync(Guids.WorkflowStateSites, new NavigationContextConfig() { NavigationContextDisplayLabel = siteGroupModel.Labels["Name"].ToString() });
        }

        public void SelectSite(SiteViewModel siteModel)
        {
            if (BackgroundTask.Instance.IsExecuting) return;
            if (!siteModel.Site.Settings.DynamicCategoriesDiscovered)
            {
                BackgroundTask.Instance.Start<bool>(
                    () =>
                    {
                        siteModel.Site.DiscoverDynamicCategories();
                        return true;
                    },
                    (success, result) =>
                    {
                        if (success)
                        {
                            SelectedSite = siteModel;
                            ShowCategories(siteModel.Site.Settings.Categories, SelectedSite.Name);
                        }
                    },
                    Translation.Instance.GettingDynamicCategories);
            }
            else
            {
                SelectedSite = siteModel;
                ShowCategories(siteModel.Site.Settings.Categories, SelectedSite.Name);
            }
        }

        public void SelectCategory(CategoryViewModel categoryModel)
        {
            if (BackgroundTask.Instance.IsExecuting) return;
            if (categoryModel.Category is NextPageCategory)
            {
                // discover and append next page categories
                BackgroundTask.Instance.Start<bool>(
                    () =>
                    {
                        SelectedSite.Site.DiscoverNextPageCategories(categoryModel.Category as NextPageCategory);
                        return true;
                    },
                    (success, result) =>
                    {
                        if (success)
                        {
                            int selectNr = CategoriesList.Count - 1;
                            CategoriesList.Clear();
                            IList<Category> catList = categoryModel.Category.ParentCategory == null ? (IList<Category>)SelectedSite.Site.Settings.Categories : categoryModel.Category.ParentCategory.SubCategories;
                            foreach (Category c in catList) CategoriesList.Add(new CategoryViewModel(c) { Selected = CategoriesList.Count == selectNr });
                            ImageDownloader.GetImages<Category>(catList);
                            CategoriesList.FireChange();
                        }
                    },
                    Translation.Instance.GettingNextPageVideos);
            }
            else
            {
                if (categoryModel.Category.HasSubCategories)
                {
                    if (!categoryModel.Category.SubCategoriesDiscovered)
                    {
                        // discover and show subcategories
                        BackgroundTask.Instance.Start<bool>(
                            () =>
                            {
                                SelectedSite.Site.DiscoverSubCategories(categoryModel.Category);
                                return true;
                            },
                            (success, result) =>
                            {
                                if (success)
                                {
                                    SelectedCategory = categoryModel;
                                    ShowCategories(categoryModel.Category.SubCategories, categoryModel.Name);
                                }
                            },
                            Translation.Instance.GettingDynamicCategories);
                    }
                    else
                    {
                        SelectedCategory = categoryModel;
                        ShowCategories(categoryModel.Category.SubCategories, categoryModel.Name);
                    }
                }
                else
                {
                    // discover and show videos of this category
                    BackgroundTask.Instance.Start<List<VideoInfo>>(
                        () =>
                        {
                            return SelectedSite.Site.GetVideos(categoryModel.Category);
                        },
                        (success, videos) =>
                        {
                            if (success)
                            {
                                ShowVideos(categoryModel, videos);
                            }
                        },
                        Translation.Instance.GettingCategoryVideos);
                }
            }
        }

        public void SelectVideo(VideoViewModel videoModel)
        {
            if (BackgroundTask.Instance.IsExecuting) return;
            if (videoModel.VideoInfo == null)
            {
                // discover and append next page videos
                BackgroundTask.Instance.Start<List<VideoInfo>>(
                    () =>
                    {
                        return SelectedSite.Site.GetNextPageVideos();
                    },
                    (success, nextPageVideos) =>
                    {
                        if (success)
                        {
                            VideosList.Remove(videoModel);
                            int selectNr = VideosList.Count;
                            nextPageVideos.ForEach(r => { r.CleanDescriptionAndTitle(); VideosList.Add(new VideoViewModel(r, SelectedCategory != null ? SelectedCategory.Category : null, SelectedSite.Site.Settings, false) { Selected = VideosList.Count == selectNr }); });
                            if (SelectedSite.Site.HasNextPage) VideosList.Add(new VideoViewModel(Translation.Instance.NextPage, "NextPage.png"));
                            VideosList.FireChange();
                            ImageDownloader.GetImages<VideoInfo>(nextPageVideos);
                        }
                    },
                    Translation.Instance.GettingNextPageVideos);
            }
            else
            {
                if (SelectedSite.Site is Sites.IChoice && videoModel.VideoInfo.HasDetails)
                {
                    // get details videos and show details view
                    BackgroundTask.Instance.Start<List<DetailVideoInfo>>(
                        () =>
                        {
                            return ((Sites.IChoice)SelectedSite.Site).GetVideoChoices(videoModel.VideoInfo);
                        },
                        (success, choices) =>
                        {
                            if (success)
                            {
                                SelectedVideo = videoModel;
                                ShowDetails(choices);
                            }
                        },
                        Translation.Instance.GettingVideoDetails);
                }
                else
                {
                    // get playback urls and play or show dialog to select playback options
                    BackgroundTask.Instance.Start<List<string>>(
                        () =>
                        {
                            return SelectedSite.Site.GetMultipleVideoUrls(videoModel.VideoInfo);
                        },
                        (success, urls) =>
                        {
                            if (success)
                            {
                                if (SelectedSite.Site.Settings.Player != PlayerType.Browser)
                                    Helpers.UriUtils.RemoveInvalidUrls(urls);
                                // if no valid urls were returned show error msg
                                if (urls == null || urls.Count == 0)
                                {
                                    ServiceRegistration.Get<IDialogManager>().ShowDialog("[OnlineVideos.Error]", "[OnlineVideos.UnableToPlayVideo]", DialogType.OkDialog, false, DialogButtonType.Ok);
                                }
                                else
                                {
                                    SelectedVideo = videoModel;
                                    SelectedVideo.ChoosePlaybackOptions(urls[0], (url) => { urls[0] = url; SelectedVideo.Play(urls); });
                                }
                            }
                        },
                        Translation.Instance.GettingPlaybackUrlsForVideo);
                }
            }
        }

        public void SelectDetailsVideo(VideoViewModel videoModel)
        {
            if (BackgroundTask.Instance.IsExecuting) return;
            BackgroundTask.Instance.Start<List<string>>(
                () =>
                {
                    return SelectedSite.Site.GetMultipleVideoUrls(videoModel.VideoInfo);
                },
                (success, urls) =>
                {
                    if (success)
                    {
                        if (SelectedSite.Site.Settings.Player != PlayerType.Browser)
                            Helpers.UriUtils.RemoveInvalidUrls(urls);
                        // if no valid urls were returned show error msg
                        if (urls == null || urls.Count == 0)
                        {
                            ServiceRegistration.Get<IDialogManager>().ShowDialog("[OnlineVideos.Error]", "[OnlineVideos.UnableToPlayVideo]", DialogType.OkDialog, false, DialogButtonType.Ok);
                        }
                        else
                        {
                            SelectedDetailsVideo = videoModel;
                            SelectedDetailsVideo.ChoosePlaybackOptions(urls[0], (url) => { urls[0] = url; SelectedDetailsVideo.Play(urls); });
                        }
                    }
                },
                Translation.Instance.GettingPlaybackUrlsForVideo);
        }

        public void StartSearch()
        {
            if (BackgroundTask.Instance.IsExecuting) return;
            BackgroundTask.Instance.Start<List<SearchResultItem>>(
                () =>
                {
                    return SelectedSite.Site.Search(SearchString);

                },
                (success, result) =>
                {
                    if (success && result != null && result.Count > 0)
                    {
                        ShowSearchResults(result, Translation.Instance.SearchResults + " [" + SearchString + "]");
                    }
                },
                Translation.Instance.GettingSearchResults);
        }

        public void PushNavigationToOnlineVideosRoot()
        {
            var settings = ServiceRegistration.Get<ISettingsManager>().Load<Configuration.Settings>();

            // when going to sites we need to rebuild the list of sites with all sites if not already done
            if (!settings.GroupSitesByLanguage && !sitesListHasAllSites)
            {
                BuildSitesList();
            }

            ServiceRegistration.Get<IWorkflowManager>().NavigatePushAsync(settings.GroupSitesByLanguage ? Guids.WorkflowStateSiteGroups : Guids.WorkflowStateSites);
        }

        void RebuildSitesList()
        {
            BuildSitesList();
            BuildAutomaticSitesGroups();
        }

        void BuildSitesList()
        {
            SitesList.Clear();
            foreach (var site in OnlineVideoSettings.Instance.SiteUtilsList)
            {
                if (site.Value.Settings.IsEnabled &&
                    (!site.Value.Settings.ConfirmAge || !OnlineVideoSettings.Instance.UseAgeConfirmation || OnlineVideoSettings.Instance.AgeConfirmed))
                {
                    SitesList.Add(new SiteViewModel(site.Value));
                }
            }
            sitesListHasAllSites = true;
            SitesList.FireChange();
        }

        void BuildAutomaticSitesGroups()
        {
            SiteGroupsList.Clear();
            Dictionary<string, List<string>> sitenames = new Dictionary<string, List<string>>();
            var siteutils = OnlineVideoSettings.Instance.SiteUtilsList;
            foreach (string name in siteutils.Keys)
            {
                Sites.SiteUtilBase aSite;
                if (siteutils.TryGetValue(name, out aSite) && !(aSite is Sites.FavoriteUtil) && !(aSite is Sites.DownloadedVideoUtil))
                {
                    string key = string.IsNullOrEmpty(aSite.Settings.Language) ? "--" : aSite.Settings.Language;
                    List<string> listForLang = null;
                    if (!sitenames.TryGetValue(key, out listForLang)) { listForLang = new List<string>(); sitenames.Add(key, listForLang); }
                    listForLang.Add(aSite.Settings.Name);
                }
            }
            foreach (string aLang in sitenames.Keys.ToList().OrderBy(l => l))
            {
                SiteGroupsList.Add(new SiteGroupViewModel(LanguageCodeLocalizedConverter.GetLanguageInUserLocale(aLang),
                    string.Format(@"LanguageFlagsBig\{0}.png", aLang),
                    sitenames[aLang]));
            }
            SiteGroupsList.FireChange();
        }

        void ShowCategories(IList<Category> categories, string navigationLabel)
        {
            CategoriesList = new ItemsList();
            foreach (Category c in categories) CategoriesList.Add(new CategoryViewModel(c));
            ImageDownloader.GetImages<Category>(categories);
            IWorkflowManager workflowManager = ServiceRegistration.Get<IWorkflowManager>();
            workflowManager.NavigatePushAsync(Guids.WorkflowStateCategories, new NavigationContextConfig() { NavigationContextDisplayLabel = navigationLabel });
        }

        void ShowVideos(CategoryViewModel category, List<VideoInfo> videos)
        {
            SelectedCategory = category;
            VideosList = new ItemsList();
            videos.ForEach(r => { r.CleanDescriptionAndTitle(); VideosList.Add(new VideoViewModel(r, SelectedCategory != null ? SelectedCategory.Category : null, SelectedSite.Site.Settings, false)); });

            if (SelectedSite.Site.HasNextPage) VideosList.Add(new VideoViewModel(Translation.Instance.NextPage, "NextPage.png"));

            ImageDownloader.GetImages<VideoInfo>(videos);
            IWorkflowManager workflowManager = ServiceRegistration.Get<IWorkflowManager>();
            workflowManager.NavigatePushAsync(Guids.WorkflowStateVideos, new NavigationContextConfig() { NavigationContextDisplayLabel = SelectedCategory.Name });
        }

        void ShowDetails(List<DetailVideoInfo> choices)
        {
            DetailsVideosList = new List<VideoViewModel>();
            choices.ForEach(r => { r.CleanDescriptionAndTitle(); DetailsVideosList.Add(new VideoViewModel(r, SelectedCategory != null ? SelectedCategory.Category : null, SelectedSite.Site.Settings, true)); });
            ImageDownloader.GetImages<DetailVideoInfo>(choices);
            IWorkflowManager workflowManager = ServiceRegistration.Get<IWorkflowManager>();
            workflowManager.NavigatePushAsync(Guids.WorkflowStateDetails, new NavigationContextConfig() { NavigationContextDisplayLabel = SelectedVideo.Title });
        }

        internal void ShowSearchResults(List<SearchResultItem> result, string title)
        {
            // pop all states up to the site state from the current navigation stack
            IWorkflowManager workflowManager = ServiceRegistration.Get<IWorkflowManager>();
            while (workflowManager.NavigationContextStack.Peek().Predecessor != null && 
                workflowManager.NavigationContextStack.Peek().Predecessor.WorkflowState.StateId != Guids.WorkflowStateSites)
            {
                workflowManager.NavigationContextStack.Pop();
            }
            // create a "fake" Category as Parent for a results items
            var searchCategory = new CategoryViewModel(
                new Category()
                {
                    Name = title,
                    HasSubCategories = result[0] is Category,
                    SubCategoriesDiscovered = true
                });
            // display results
            if (result[0] is VideoInfo)
            {
                ShowVideos(searchCategory, result.ConvertAll(i => i as VideoInfo));
            }
            else
            {
                searchCategory.Category.SubCategories = result.ConvertAll(i => { (i as Category).ParentCategory = searchCategory.Category; return i as Category; });
                SelectedCategory = searchCategory;
                ShowCategories(searchCategory.Category.SubCategories, searchCategory.Name);
            }
        }

        void OnlineVideosMessageReceived(AsynchronousMessageQueue queue, SystemMessage message)
        {
            if (message.ChannelName == OnlineVideosMessaging.CHANNEL)
            {
                OnlineVideosMessaging.MessageType messageType = (OnlineVideosMessaging.MessageType)message.MessageType;
                switch (messageType)
                {
                    case OnlineVideosMessaging.MessageType.SitesUpdated:
                        bool? updateResult = (bool?)message.MessageData[OnlineVideosMessaging.UPDATE_RESULT];
                        if (updateResult != false)
                        {
                            if (OnlineVideoSettings.Instance.IsSiteUtilsListBuilt())
                            {
                                if (updateResult == true)
                                {
                                    Log.Info("Reloading SiteUtil Dlls at runtime.");
                                    DownloadManager.Instance.StopAll();
                                    // now reload the appdomain
                                    OnlineVideoSettings.Reload();
                                    TranslationLoader.SetTranslationsToSingleton();
                                    GC.Collect();
                                    GC.WaitForFullGCComplete();
                                }
                            }
                            OnlineVideoSettings.Instance.BuildSiteUtilsList();
                            RebuildSitesList();
                        }
                        else
                        {
                            // called when entering OnlineVideos first time (after sites have been updated)
                            if (!OnlineVideoSettings.Instance.IsSiteUtilsListBuilt())
                            {
                                // show the busy indicator, because loading site dlls takes some seconds
                                ServiceRegistration.Get<ISuperLayerManager>().ShowBusyScreen();
                                try
                                {
                                    OnlineVideoSettings.Instance.BuildSiteUtilsList();
                                    RebuildSitesList();
                                }
                                catch (Exception ex)
                                {
                                    Log.Error(ex);
                                }
                                finally
                                {
                                    ServiceRegistration.Get<ISuperLayerManager>().HideBusyScreen();
                                }
                            }
                        }
                        break;
                }
            }
        }

        void OnlineVideosSettingsChanged(object sender, EventArgs e)
        {
            bool rebuildUtils = false;
            bool rebuildList = false;

            var settings = (sender as SettingsChangeWatcher<Configuration.Settings>).Settings;

            // a download dir was now configured or removed
            if ((string.IsNullOrEmpty(OnlineVideoSettings.Instance.DownloadDir) && !string.IsNullOrEmpty(settings.DownloadFolder)) ||
                (!string.IsNullOrEmpty(OnlineVideoSettings.Instance.DownloadDir) && string.IsNullOrEmpty(settings.DownloadFolder)))
            {
                rebuildUtils = true;
                rebuildList = true;
            }
            // usage of age confirmation has changed
            if (settings.UseAgeConfirmation != OnlineVideoSettings.Instance.UseAgeConfirmation)
            {
                rebuildList = true;
            }

            settings.SetValuesToApi();

            if (OnlineVideoSettings.Instance.IsSiteUtilsListBuilt())
            {
                if (rebuildUtils)
                    OnlineVideoSettings.Instance.BuildSiteUtilsList();
                if (rebuildList)
                    RebuildSitesList();
            }
        }
        
        #region IWorkflowModel implementation

        public bool CanEnterState(MediaPortal.UI.Presentation.Workflow.NavigationContext oldContext, MediaPortal.UI.Presentation.Workflow.NavigationContext newContext)
        {
            return !BackgroundTask.Instance.IsExecuting; // only can enter a new state when not doing any background work
        }

        public void ChangeModelContext(MediaPortal.UI.Presentation.Workflow.NavigationContext oldContext, MediaPortal.UI.Presentation.Workflow.NavigationContext newContext, bool push)
        {
            // reload a site when going away from configuring it and settings were changed
            if (oldContext.WorkflowState.StateId == Guids.WorkflowStateSiteSettings && FocusedSite.UserSettingsChanged)
            {
                FocusedSite.RecreateSite();
                // save Site Settings
                (OnlineVideoSettings.Instance.UserStore as Configuration.UserSiteSettingsStore).SaveAll();
            }

            // going to sites view
            if (newContext.WorkflowState.StateId == Guids.WorkflowStateSites)
            {
                SelectedCategory = null;
                CategoriesList = null;
            }
            // going from categories to categories view
            else if (newContext.WorkflowState.StateId == Guids.WorkflowStateCategories && oldContext.WorkflowState.StateId == Guids.WorkflowStateCategories)
            {
                // going up in hierarchy
                if (oldContext.Predecessor == newContext)
                {
                    CategoriesList = new ItemsList();
                    if (SelectedCategory != null && SelectedCategory.Category.ParentCategory != null)
                    {
                        SelectedCategory.Category.ParentCategory.SubCategories.ForEach(c => CategoriesList.Add(new CategoryViewModel(c)));
                        ImageDownloader.GetImages<Category>(SelectedCategory.Category.ParentCategory.SubCategories);
                        SelectedCategory = new CategoryViewModel(SelectedCategory.Category.ParentCategory);
                    }
                    else
                    {
                        foreach (Category c in SelectedSite.Site.Settings.Categories) CategoriesList.Add(new CategoryViewModel(c));
                        ImageDownloader.GetImages<Category>(SelectedSite.Site.Settings.Categories);
                        SelectedCategory = null;
                    }
                }
            }
            // going from videos to categories view
            else if (newContext.WorkflowState.StateId == Guids.WorkflowStateCategories && oldContext.WorkflowState.StateId == Guids.WorkflowStateVideos)
            {
                VideosList = null;
                CategoriesList = new ItemsList();

                if (SelectedCategory != null && SelectedCategory.Category.ParentCategory != null)
                {
                    SelectedCategory.Category.ParentCategory.SubCategories.ForEach(c => CategoriesList.Add(new CategoryViewModel(c)));
                    ImageDownloader.GetImages<Category>(SelectedCategory.Category.ParentCategory.SubCategories);
                }
                else
                {
                    foreach (Category c in SelectedSite.Site.Settings.Categories) CategoriesList.Add(new CategoryViewModel(c));
                    ImageDownloader.GetImages<Category>(SelectedSite.Site.Settings.Categories);
                }

                if (SelectedCategory != null && SelectedCategory.Category.ParentCategory != null)
                    SelectedCategory = new CategoryViewModel(SelectedCategory.Category.ParentCategory);
                else
                    SelectedCategory = null;
            }
            // going from details to videos view
            else if (newContext.WorkflowState.StateId == Guids.WorkflowStateVideos && oldContext.WorkflowState.StateId == Guids.WorkflowStateDetails)
            {
                DetailsVideosList = null;
            }
        }

        public void Deactivate(MediaPortal.UI.Presentation.Workflow.NavigationContext oldContext, MediaPortal.UI.Presentation.Workflow.NavigationContext newContext)
        {
            //
        }

        public void Reactivate(MediaPortal.UI.Presentation.Workflow.NavigationContext oldContext, MediaPortal.UI.Presentation.Workflow.NavigationContext newContext)
        {
            //
        }

        public void EnterModelContext(MediaPortal.UI.Presentation.Workflow.NavigationContext oldContext, MediaPortal.UI.Presentation.Workflow.NavigationContext newContext)
        {
            _messageQueue.Start();
            // when entering OV model context and no siteutils have been loaded yet run automatic update (if configured)
            if (!OnlineVideoSettings.Instance.IsSiteUtilsListBuilt())
            {
                if (_settingsWatcher.Settings.AutomaticUpdate &&
                    _settingsWatcher.Settings.LastAutomaticUpdate.AddHours(_settingsWatcher.Settings.AutomaticUpdateInterval) < DateTime.Now &&
                    OnlineVideos.Sites.Updater.VersionCompatible)
                {
                    IWorkflowManager workflowManager = ServiceRegistration.Get<IWorkflowManager>();
                    workflowManager.NavigatePushAsync(Guids.DialogStateSiteUpdate);
                }
                else
                {
                    // show the busy indicator, because loading site dlls takes some seconds
                    ServiceRegistration.Get<ISuperLayerManager>().ShowBusyScreen();
                    try
                    {
                        OnlineVideoSettings.Instance.BuildSiteUtilsList();
                        RebuildSitesList();
                    }
                    catch (Exception ex)
                    {
                        Log.Error(ex);
                    }
                    finally
                    {
                        ServiceRegistration.Get<ISuperLayerManager>().HideBusyScreen();
                    }
                }
            }
        }

        public void ExitModelContext(MediaPortal.UI.Presentation.Workflow.NavigationContext oldContext, MediaPortal.UI.Presentation.Workflow.NavigationContext newContext)
        {
            _messageQueue.Shutdown();
        }

        public Guid ModelId
        {
            get { return Guids.WorkFlowModelOV; }
        }

        public void UpdateMenuActions(MediaPortal.UI.Presentation.Workflow.NavigationContext context, IDictionary<Guid, MediaPortal.UI.Presentation.Workflow.WorkflowAction> actions)
        {
            //
        }

        public ScreenUpdateMode UpdateScreen(MediaPortal.UI.Presentation.Workflow.NavigationContext context, ref string screen)
        {
            return ScreenUpdateMode.AutoWorkflowManager;
        }

        #endregion
    }

}
