﻿/*
 * Created by SharpDevelop.
 * User: GZamor1
 * Date: 7/24/2007
 * Time: 9:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace OnlineVideos
{
	partial class Configuration
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Configuration));
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTrailerSize = new System.Windows.Forms.ComboBox();
            this.txtDownloadDir = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RssLinkList = new System.Windows.Forms.ListBox();
            this.bindingSourceRssLink = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceSiteSettings = new System.Windows.Forms.BindingSource(this.components);
            this.txtRssUrl = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtRssName = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.toolStripContainer3 = new System.Windows.Forms.ToolStripContainer();
            this.siteList = new System.Windows.Forms.ListBox();
            this.toolStripSiteUpDown = new System.Windows.Forms.ToolStrip();
            this.btnSiteUp = new System.Windows.Forms.ToolStripButton();
            this.btnSiteDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSites = new System.Windows.Forms.ToolStrip();
            this.btnImportSite = new System.Windows.Forms.ToolStripButton();
            this.btnAddSite = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteSite = new System.Windows.Forms.ToolStripButton();
            this.label18 = new System.Windows.Forms.Label();
            this.cbLanguages = new System.Windows.Forms.ComboBox();
            this.cbSiteUtil = new System.Windows.Forms.ComboBox();
            this.tbxSearchUrl = new System.Windows.Forms.TextBox();
            this.lblSearchUrl = new System.Windows.Forms.Label();
            this.chkAgeConfirm = new System.Windows.Forms.CheckBox();
            this.txtSiteName = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.chkEnabled = new System.Windows.Forms.CheckBox();
            this.txtFilters = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtThumbLoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.chkUseAgeConfirmation = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnYahooConfig = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageRssLinks = new System.Windows.Forms.TabPage();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripRss = new System.Windows.Forms.ToolStrip();
            this.btnAddRss = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteRss = new System.Windows.Forms.ToolStripButton();
            this.txtRssThumb = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabChannels = new System.Windows.Forms.TabPage();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.tvGroups = new System.Windows.Forms.TreeView();
            this.toolStripChannels = new System.Windows.Forms.ToolStrip();
            this.btnAddGroup = new System.Windows.Forms.ToolStripButton();
            this.btnAddChannel = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteChannel = new System.Windows.Forms.ToolStripButton();
            this.tbxChannelThumb = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbxStreamThumb = new System.Windows.Forms.TextBox();
            this.btnSaveChannel = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxStreamUrl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxStreamName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxChannelName = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.tbxPin = new System.Windows.Forms.TextBox();
            this.tbxScreenName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBrowseForDlFolder = new System.Windows.Forms.Button();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.tabGeneral = new System.Windows.Forms.TabPage();
            this.label21 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.cmbDasErsteQuality = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbYoutubeQuality = new System.Windows.Forms.ComboBox();
            this.tabSites = new System.Windows.Forms.TabPage();
            this.tabPageCodecs = new System.Windows.Forms.TabPage();
            this.groupBoxSplitter = new System.Windows.Forms.GroupBox();
            this.tbxWMVSplitter = new System.Windows.Forms.TextBox();
            this.tbxAVISplitter = new System.Windows.Forms.TextBox();
            this.tbxMP4Splitter = new System.Windows.Forms.TextBox();
            this.tbxFLVSplitter = new System.Windows.Forms.TextBox();
            this.chkWMVSplitterInstalled = new System.Windows.Forms.CheckBox();
            this.chkAVISplitterInstalled = new System.Windows.Forms.CheckBox();
            this.chkMP4SplitterInstalled = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chkFLVSplitterInstalled = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRssLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSiteSettings)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStripContainer3.ContentPanel.SuspendLayout();
            this.toolStripContainer3.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer3.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer3.SuspendLayout();
            this.toolStripSiteUpDown.SuspendLayout();
            this.toolStripSites.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageRssLinks.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripRss.SuspendLayout();
            this.tabChannels.SuspendLayout();
            this.toolStripContainer2.ContentPanel.SuspendLayout();
            this.toolStripContainer2.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.toolStripChannels.SuspendLayout();
            this.mainTabControl.SuspendLayout();
            this.tabGeneral.SuspendLayout();
            this.tabSites.SuspendLayout();
            this.tabPageCodecs.SuspendLayout();
            this.groupBoxSplitter.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 136);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "AppleTrailers Max Quality";
            // 
            // cmbTrailerSize
            // 
            this.cmbTrailerSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTrailerSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrailerSize.FormattingEnabled = true;
            this.cmbTrailerSize.Location = new System.Drawing.Point(225, 135);
            this.cmbTrailerSize.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTrailerSize.Name = "cmbTrailerSize";
            this.cmbTrailerSize.Size = new System.Drawing.Size(242, 21);
            this.cmbTrailerSize.TabIndex = 21;
            // 
            // txtDownloadDir
            // 
            this.txtDownloadDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDownloadDir.Location = new System.Drawing.Point(225, 58);
            this.txtDownloadDir.Name = "txtDownloadDir";
            this.txtDownloadDir.Size = new System.Drawing.Size(212, 20);
            this.txtDownloadDir.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Download Folder:";
            // 
            // RssLinkList
            // 
            this.RssLinkList.DataSource = this.bindingSourceRssLink;
            this.RssLinkList.DisplayMember = "Name";
            this.RssLinkList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RssLinkList.FormattingEnabled = true;
            this.RssLinkList.Location = new System.Drawing.Point(0, 0);
            this.RssLinkList.Name = "RssLinkList";
            this.RssLinkList.Size = new System.Drawing.Size(148, 186);
            this.RssLinkList.TabIndex = 6;
            this.RssLinkList.SelectedIndexChanged += new System.EventHandler(this.RssLinkListSelectedIndexChanged);
            // 
            // bindingSourceRssLink
            // 
            this.bindingSourceRssLink.DataSource = typeof(OnlineVideos.RssLink);
            // 
            // bindingSourceSiteSettings
            // 
            this.bindingSourceSiteSettings.DataSource = typeof(OnlineVideos.SiteSettings);
            // 
            // txtRssUrl
            // 
            this.txtRssUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRssUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceRssLink, "Url", true));
            this.txtRssUrl.Enabled = false;
            this.txtRssUrl.Location = new System.Drawing.Point(244, 50);
            this.txtRssUrl.Name = "txtRssUrl";
            this.txtRssUrl.Size = new System.Drawing.Size(218, 20);
            this.txtRssUrl.TabIndex = 16;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(160, 30);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(60, 13);
            this.label26.TabIndex = 9;
            this.label26.Text = "RSS Name";
            // 
            // txtRssName
            // 
            this.txtRssName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRssName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceRssLink, "Name", true));
            this.txtRssName.Enabled = false;
            this.txtRssName.Location = new System.Drawing.Point(244, 28);
            this.txtRssName.Name = "txtRssName";
            this.txtRssName.Size = new System.Drawing.Size(218, 20);
            this.txtRssName.TabIndex = 15;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(160, 53);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(45, 13);
            this.label25.TabIndex = 10;
            this.label25.Text = "RSS Url";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.descriptionTextBox);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.btnAdvanced);
            this.groupBox1.Controls.Add(this.toolStripContainer3);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.cbLanguages);
            this.groupBox1.Controls.Add(this.cbSiteUtil);
            this.groupBox1.Controls.Add(this.tbxSearchUrl);
            this.groupBox1.Controls.Add(this.lblSearchUrl);
            this.groupBox1.Controls.Add(this.chkAgeConfirm);
            this.groupBox1.Controls.Add(this.txtSiteName);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.chkEnabled);
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 235);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sites";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 83F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label29, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label30, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtUserId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(161, 137);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(312, 23);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Location = new System.Drawing.Point(3, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(77, 23);
            this.label29.TabIndex = 14;
            this.label29.Text = "UserId";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Location = new System.Drawing.Point(170, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(54, 23);
            this.label30.TabIndex = 15;
            this.label30.Text = "Password";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserId
            // 
            this.txtUserId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUserId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSiteSettings, "Username", true));
            this.txtUserId.Location = new System.Drawing.Point(86, 3);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(78, 20);
            this.txtUserId.TabIndex = 17;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSiteSettings, "Password", true));
            this.txtPassword.Location = new System.Drawing.Point(230, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(79, 20);
            this.txtPassword.TabIndex = 18;
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdvanced.Location = new System.Drawing.Point(394, 37);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(75, 23);
            this.btnAdvanced.TabIndex = 25;
            this.btnAdvanced.Text = "Advanced";
            this.btnAdvanced.UseVisualStyleBackColor = true;
            this.btnAdvanced.Click += new System.EventHandler(this.btnAdvanced_Click);
            // 
            // toolStripContainer3
            // 
            this.toolStripContainer3.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer3.ContentPanel
            // 
            this.toolStripContainer3.ContentPanel.Controls.Add(this.siteList);
            this.toolStripContainer3.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer3.ContentPanel.Size = new System.Drawing.Size(127, 172);
            // 
            // toolStripContainer3.LeftToolStripPanel
            // 
            this.toolStripContainer3.LeftToolStripPanel.Controls.Add(this.toolStripSiteUpDown);
            this.toolStripContainer3.Location = new System.Drawing.Point(5, 18);
            this.toolStripContainer3.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer3.Name = "toolStripContainer3";
            this.toolStripContainer3.RightToolStripPanelVisible = false;
            this.toolStripContainer3.Size = new System.Drawing.Size(151, 197);
            this.toolStripContainer3.TabIndex = 24;
            this.toolStripContainer3.Text = "toolStripContainer3";
            // 
            // toolStripContainer3.TopToolStripPanel
            // 
            this.toolStripContainer3.TopToolStripPanel.Controls.Add(this.toolStripSites);
            // 
            // siteList
            // 
            this.siteList.DataSource = this.bindingSourceSiteSettings;
            this.siteList.DisplayMember = "Name";
            this.siteList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.siteList.FormattingEnabled = true;
            this.siteList.Location = new System.Drawing.Point(0, 0);
            this.siteList.Name = "siteList";
            this.siteList.Size = new System.Drawing.Size(127, 160);
            this.siteList.TabIndex = 5;
            this.siteList.SelectedIndexChanged += new System.EventHandler(this.SiteListSelectedIndexChanged);
            // 
            // toolStripSiteUpDown
            // 
            this.toolStripSiteUpDown.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripSiteUpDown.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripSiteUpDown.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSiteUp,
            this.btnSiteDown});
            this.toolStripSiteUpDown.Location = new System.Drawing.Point(0, 0);
            this.toolStripSiteUpDown.Name = "toolStripSiteUpDown";
            this.toolStripSiteUpDown.Size = new System.Drawing.Size(24, 172);
            this.toolStripSiteUpDown.Stretch = true;
            this.toolStripSiteUpDown.TabIndex = 0;
            // 
            // btnSiteUp
            // 
            this.btnSiteUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSiteUp.Enabled = false;
            this.btnSiteUp.Image = global::OnlineVideos.Properties.Resources.Up;
            this.btnSiteUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSiteUp.Name = "btnSiteUp";
            this.btnSiteUp.Size = new System.Drawing.Size(22, 20);
            this.btnSiteUp.Text = "Up";
            this.btnSiteUp.Click += new System.EventHandler(this.btnSiteUp_Click);
            // 
            // btnSiteDown
            // 
            this.btnSiteDown.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSiteDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSiteDown.Enabled = false;
            this.btnSiteDown.Image = global::OnlineVideos.Properties.Resources.Down;
            this.btnSiteDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSiteDown.Name = "btnSiteDown";
            this.btnSiteDown.Size = new System.Drawing.Size(22, 20);
            this.btnSiteDown.Text = "Down";
            this.btnSiteDown.Click += new System.EventHandler(this.btnSiteDown_Click);
            // 
            // toolStripSites
            // 
            this.toolStripSites.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripSites.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripSites.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnImportSite,
            this.btnAddSite,
            this.btnDeleteSite});
            this.toolStripSites.Location = new System.Drawing.Point(3, 0);
            this.toolStripSites.Name = "toolStripSites";
            this.toolStripSites.Size = new System.Drawing.Size(72, 25);
            this.toolStripSites.TabIndex = 0;
            // 
            // btnImportSite
            // 
            this.btnImportSite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImportSite.Image = global::OnlineVideos.Properties.Resources.ImportXml;
            this.btnImportSite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImportSite.Name = "btnImportSite";
            this.btnImportSite.Size = new System.Drawing.Size(23, 22);
            this.btnImportSite.Text = "Import";
            this.btnImportSite.Click += new System.EventHandler(this.btnImportSite_Click);
            // 
            // btnAddSite
            // 
            this.btnAddSite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddSite.Image = global::OnlineVideos.Properties.Resources.Add;
            this.btnAddSite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSite.Name = "btnAddSite";
            this.btnAddSite.Size = new System.Drawing.Size(23, 22);
            this.btnAddSite.Text = "Add";
            this.btnAddSite.Click += new System.EventHandler(this.btnAddSite_Click);
            // 
            // btnDeleteSite
            // 
            this.btnDeleteSite.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteSite.Enabled = false;
            this.btnDeleteSite.Image = global::OnlineVideos.Properties.Resources.delete;
            this.btnDeleteSite.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteSite.Name = "btnDeleteSite";
            this.btnDeleteSite.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteSite.Text = "Delete";
            this.btnDeleteSite.Click += new System.EventHandler(this.btnDeleteSite_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(164, 192);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Language";
            // 
            // cbLanguages
            // 
            this.cbLanguages.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSourceSiteSettings, "Language", true));
            this.cbLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguages.FormattingEnabled = true;
            this.cbLanguages.Location = new System.Drawing.Point(247, 189);
            this.cbLanguages.Margin = new System.Windows.Forms.Padding(2);
            this.cbLanguages.Name = "cbLanguages";
            this.cbLanguages.Size = new System.Drawing.Size(53, 21);
            this.cbLanguages.TabIndex = 22;
            // 
            // cbSiteUtil
            // 
            this.cbSiteUtil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSiteUtil.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bindingSourceSiteSettings, "UtilName", true));
            this.cbSiteUtil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSiteUtil.FormattingEnabled = true;
            this.cbSiteUtil.Location = new System.Drawing.Point(247, 86);
            this.cbSiteUtil.Margin = new System.Windows.Forms.Padding(2);
            this.cbSiteUtil.Name = "cbSiteUtil";
            this.cbSiteUtil.Size = new System.Drawing.Size(223, 21);
            this.cbSiteUtil.TabIndex = 21;
            // 
            // tbxSearchUrl
            // 
            this.tbxSearchUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxSearchUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSiteSettings, "SearchUrl", true));
            this.tbxSearchUrl.Location = new System.Drawing.Point(247, 166);
            this.tbxSearchUrl.Name = "tbxSearchUrl";
            this.tbxSearchUrl.Size = new System.Drawing.Size(223, 20);
            this.tbxSearchUrl.TabIndex = 20;
            // 
            // lblSearchUrl
            // 
            this.lblSearchUrl.AutoSize = true;
            this.lblSearchUrl.Location = new System.Drawing.Point(164, 168);
            this.lblSearchUrl.Name = "lblSearchUrl";
            this.lblSearchUrl.Size = new System.Drawing.Size(57, 13);
            this.lblSearchUrl.TabIndex = 19;
            this.lblSearchUrl.Text = "Search Url";
            // 
            // chkAgeConfirm
            // 
            this.chkAgeConfirm.AutoSize = true;
            this.chkAgeConfirm.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceSiteSettings, "ConfirmAge", true));
            this.chkAgeConfirm.Location = new System.Drawing.Point(247, 41);
            this.chkAgeConfirm.Name = "chkAgeConfirm";
            this.chkAgeConfirm.Size = new System.Drawing.Size(83, 17);
            this.chkAgeConfirm.TabIndex = 16;
            this.chkAgeConfirm.Text = "Confirm Age";
            this.chkAgeConfirm.UseVisualStyleBackColor = true;
            // 
            // txtSiteName
            // 
            this.txtSiteName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSiteName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSiteSettings, "Name", true));
            this.txtSiteName.Location = new System.Drawing.Point(247, 63);
            this.txtSiteName.Name = "txtSiteName";
            this.txtSiteName.Size = new System.Drawing.Size(223, 20);
            this.txtSiteName.TabIndex = 11;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(164, 89);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(43, 13);
            this.label28.TabIndex = 10;
            this.label28.Text = "Site Util";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(164, 66);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(56, 13);
            this.label27.TabIndex = 9;
            this.label27.Text = "Site Name";
            // 
            // chkEnabled
            // 
            this.chkEnabled.AutoSize = true;
            this.chkEnabled.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bindingSourceSiteSettings, "IsEnabled", true));
            this.chkEnabled.Location = new System.Drawing.Point(164, 41);
            this.chkEnabled.Name = "chkEnabled";
            this.chkEnabled.Size = new System.Drawing.Size(65, 17);
            this.chkEnabled.TabIndex = 8;
            this.chkEnabled.Text = "Enabled";
            this.chkEnabled.UseVisualStyleBackColor = true;
            // 
            // txtFilters
            // 
            this.txtFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilters.Location = new System.Drawing.Point(225, 110);
            this.txtFilters.Name = "txtFilters";
            this.txtFilters.Size = new System.Drawing.Size(242, 20);
            this.txtFilters.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtFilters, "Comma seperated list of words that will be used to filter out videos.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filter out videos with these tags";
            // 
            // txtThumbLoc
            // 
            this.txtThumbLoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtThumbLoc.Location = new System.Drawing.Point(225, 84);
            this.txtThumbLoc.Name = "txtThumbLoc";
            this.txtThumbLoc.Size = new System.Drawing.Size(242, 20);
            this.txtThumbLoc.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thumbnail Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Use Age Confirmation";
            // 
            // chkUseAgeConfirmation
            // 
            this.chkUseAgeConfirmation.AutoSize = true;
            this.chkUseAgeConfirmation.Location = new System.Drawing.Point(225, 35);
            this.chkUseAgeConfirmation.Name = "chkUseAgeConfirmation";
            this.chkUseAgeConfirmation.Size = new System.Drawing.Size(15, 14);
            this.chkUseAgeConfirmation.TabIndex = 24;
            this.chkUseAgeConfirmation.UseVisualStyleBackColor = true;
            this.chkUseAgeConfirmation.CheckedChanged += new System.EventHandler(this.chkUseAgeConfirmation_CheckedChanged);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Image = global::OnlineVideos.Properties.Resources.Save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(290, 440);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnSave.Size = new System.Drawing.Size(90, 25);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnYahooConfig
            // 
            this.btnYahooConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYahooConfig.Location = new System.Drawing.Point(341, 212);
            this.btnYahooConfig.Name = "btnYahooConfig";
            this.btnYahooConfig.Size = new System.Drawing.Size(125, 23);
            this.btnYahooConfig.TabIndex = 26;
            this.btnYahooConfig.Text = "Yahoo Configuration";
            this.btnYahooConfig.UseVisualStyleBackColor = true;
            this.btnYahooConfig.Click += new System.EventHandler(this.btnYahooConfig_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageRssLinks);
            this.tabControl1.Controls.Add(this.tabChannels);
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.Location = new System.Drawing.Point(5, 225);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(471, 254);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPageRssLinks
            // 
            this.tabPageRssLinks.Controls.Add(this.toolStripContainer1);
            this.tabPageRssLinks.Controls.Add(this.txtRssThumb);
            this.tabPageRssLinks.Controls.Add(this.label19);
            this.tabPageRssLinks.Controls.Add(this.txtRssUrl);
            this.tabPageRssLinks.Controls.Add(this.label26);
            this.tabPageRssLinks.Controls.Add(this.txtRssName);
            this.tabPageRssLinks.Controls.Add(this.label25);
            this.tabPageRssLinks.ImageIndex = 0;
            this.tabPageRssLinks.Location = new System.Drawing.Point(4, 23);
            this.tabPageRssLinks.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageRssLinks.Name = "tabPageRssLinks";
            this.tabPageRssLinks.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageRssLinks.Size = new System.Drawing.Size(463, 227);
            this.tabPageRssLinks.TabIndex = 0;
            this.tabPageRssLinks.Text = "RssLinks";
            this.tabPageRssLinks.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.RssLinkList);
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(148, 196);
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(4, 7);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(148, 221);
            this.toolStripContainer1.TabIndex = 34;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripRss);
            // 
            // toolStripRss
            // 
            this.toolStripRss.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripRss.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripRss.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddRss,
            this.btnDeleteRss});
            this.toolStripRss.Location = new System.Drawing.Point(3, 0);
            this.toolStripRss.Name = "toolStripRss";
            this.toolStripRss.Size = new System.Drawing.Size(49, 25);
            this.toolStripRss.TabIndex = 0;
            // 
            // btnAddRss
            // 
            this.btnAddRss.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddRss.Enabled = false;
            this.btnAddRss.Image = global::OnlineVideos.Properties.Resources.Add;
            this.btnAddRss.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddRss.Name = "btnAddRss";
            this.btnAddRss.Size = new System.Drawing.Size(23, 22);
            this.btnAddRss.Text = "Add";
            this.btnAddRss.Click += new System.EventHandler(this.BtnAddRssClick);
            // 
            // btnDeleteRss
            // 
            this.btnDeleteRss.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteRss.Enabled = false;
            this.btnDeleteRss.Image = global::OnlineVideos.Properties.Resources.delete;
            this.btnDeleteRss.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteRss.Name = "btnDeleteRss";
            this.btnDeleteRss.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteRss.Text = "Delete";
            this.btnDeleteRss.Click += new System.EventHandler(this.BtnDeleteRssClick);
            // 
            // txtRssThumb
            // 
            this.txtRssThumb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRssThumb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceRssLink, "Thumb", true));
            this.txtRssThumb.Enabled = false;
            this.txtRssThumb.Location = new System.Drawing.Point(244, 75);
            this.txtRssThumb.Name = "txtRssThumb";
            this.txtRssThumb.Size = new System.Drawing.Size(218, 20);
            this.txtRssThumb.TabIndex = 19;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(160, 77);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(56, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Thumb Url";
            // 
            // tabChannels
            // 
            this.tabChannels.Controls.Add(this.toolStripContainer2);
            this.tabChannels.Controls.Add(this.tbxChannelThumb);
            this.tabChannels.Controls.Add(this.label20);
            this.tabChannels.Controls.Add(this.label17);
            this.tabChannels.Controls.Add(this.tbxStreamThumb);
            this.tabChannels.Controls.Add(this.btnSaveChannel);
            this.tabChannels.Controls.Add(this.label10);
            this.tabChannels.Controls.Add(this.tbxStreamUrl);
            this.tabChannels.Controls.Add(this.label9);
            this.tabChannels.Controls.Add(this.tbxStreamName);
            this.tabChannels.Controls.Add(this.label8);
            this.tabChannels.Controls.Add(this.tbxChannelName);
            this.tabChannels.ImageIndex = 1;
            this.tabChannels.Location = new System.Drawing.Point(4, 23);
            this.tabChannels.Margin = new System.Windows.Forms.Padding(2);
            this.tabChannels.Name = "tabChannels";
            this.tabChannels.Padding = new System.Windows.Forms.Padding(2);
            this.tabChannels.Size = new System.Drawing.Size(463, 227);
            this.tabChannels.TabIndex = 1;
            this.tabChannels.Text = "Channels";
            this.tabChannels.UseVisualStyleBackColor = true;
            // 
            // toolStripContainer2
            // 
            this.toolStripContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Controls.Add(this.tvGroups);
            this.toolStripContainer2.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(148, 198);
            this.toolStripContainer2.Location = new System.Drawing.Point(4, 5);
            this.toolStripContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(148, 223);
            this.toolStripContainer2.TabIndex = 30;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // toolStripContainer2.TopToolStripPanel
            // 
            this.toolStripContainer2.TopToolStripPanel.Controls.Add(this.toolStripChannels);
            // 
            // tvGroups
            // 
            this.tvGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvGroups.Location = new System.Drawing.Point(0, 0);
            this.tvGroups.Margin = new System.Windows.Forms.Padding(2);
            this.tvGroups.Name = "tvGroups";
            this.tvGroups.Size = new System.Drawing.Size(148, 198);
            this.tvGroups.TabIndex = 0;
            this.tvGroups.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvGroups_AfterSelect);
            // 
            // toolStripChannels
            // 
            this.toolStripChannels.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripChannels.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripChannels.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddGroup,
            this.btnAddChannel,
            this.btnDeleteChannel});
            this.toolStripChannels.Location = new System.Drawing.Point(3, 0);
            this.toolStripChannels.Name = "toolStripChannels";
            this.toolStripChannels.Size = new System.Drawing.Size(72, 25);
            this.toolStripChannels.TabIndex = 0;
            // 
            // btnAddGroup
            // 
            this.btnAddGroup.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddGroup.Enabled = false;
            this.btnAddGroup.Image = global::OnlineVideos.Properties.Resources.NewFolderHS;
            this.btnAddGroup.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddGroup.Name = "btnAddGroup";
            this.btnAddGroup.Size = new System.Drawing.Size(23, 22);
            this.btnAddGroup.Text = "Add Group";
            this.btnAddGroup.Click += new System.EventHandler(this.btnAddGroup_Click);
            // 
            // btnAddChannel
            // 
            this.btnAddChannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddChannel.Enabled = false;
            this.btnAddChannel.Image = global::OnlineVideos.Properties.Resources.Add;
            this.btnAddChannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddChannel.Name = "btnAddChannel";
            this.btnAddChannel.Size = new System.Drawing.Size(23, 22);
            this.btnAddChannel.Text = "Add Stream";
            this.btnAddChannel.Click += new System.EventHandler(this.btnAddChannel_Click);
            // 
            // btnDeleteChannel
            // 
            this.btnDeleteChannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteChannel.Enabled = false;
            this.btnDeleteChannel.Image = global::OnlineVideos.Properties.Resources.delete;
            this.btnDeleteChannel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteChannel.Name = "btnDeleteChannel";
            this.btnDeleteChannel.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteChannel.Text = "Delete";
            this.btnDeleteChannel.Click += new System.EventHandler(this.btnDeleteChannel_Click);
            // 
            // tbxChannelThumb
            // 
            this.tbxChannelThumb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxChannelThumb.Enabled = false;
            this.tbxChannelThumb.Location = new System.Drawing.Point(244, 50);
            this.tbxChannelThumb.Name = "tbxChannelThumb";
            this.tbxChannelThumb.Size = new System.Drawing.Size(217, 20);
            this.tbxChannelThumb.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(158, 52);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(56, 13);
            this.label20.TabIndex = 28;
            this.label20.Text = "Thumb Url";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(158, 141);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Thumb Url";
            // 
            // tbxStreamThumb
            // 
            this.tbxStreamThumb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxStreamThumb.Enabled = false;
            this.tbxStreamThumb.Location = new System.Drawing.Point(244, 138);
            this.tbxStreamThumb.Name = "tbxStreamThumb";
            this.tbxStreamThumb.Size = new System.Drawing.Size(217, 20);
            this.tbxStreamThumb.TabIndex = 27;
            // 
            // btnSaveChannel
            // 
            this.btnSaveChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveChannel.Enabled = false;
            this.btnSaveChannel.Image = global::OnlineVideos.Properties.Resources.Save;
            this.btnSaveChannel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveChannel.Location = new System.Drawing.Point(364, 162);
            this.btnSaveChannel.Name = "btnSaveChannel";
            this.btnSaveChannel.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.btnSaveChannel.Size = new System.Drawing.Size(95, 23);
            this.btnSaveChannel.TabIndex = 22;
            this.btnSaveChannel.Text = "Save";
            this.btnSaveChannel.UseVisualStyleBackColor = true;
            this.btnSaveChannel.Click += new System.EventHandler(this.btnSaveChannel_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Stream Url";
            // 
            // tbxStreamUrl
            // 
            this.tbxStreamUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxStreamUrl.Enabled = false;
            this.tbxStreamUrl.Location = new System.Drawing.Point(244, 114);
            this.tbxStreamUrl.Name = "tbxStreamUrl";
            this.tbxStreamUrl.Size = new System.Drawing.Size(217, 20);
            this.tbxStreamUrl.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Stream Name";
            // 
            // tbxStreamName
            // 
            this.tbxStreamName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxStreamName.Enabled = false;
            this.tbxStreamName.Location = new System.Drawing.Point(244, 89);
            this.tbxStreamName.Name = "tbxStreamName";
            this.tbxStreamName.Size = new System.Drawing.Size(217, 20);
            this.tbxStreamName.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(158, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Channel Name";
            // 
            // tbxChannelName
            // 
            this.tbxChannelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxChannelName.Enabled = false;
            this.tbxChannelName.Location = new System.Drawing.Point(244, 25);
            this.tbxChannelName.Name = "tbxChannelName";
            this.tbxChannelName.Size = new System.Drawing.Size(217, 20);
            this.tbxChannelName.TabIndex = 17;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Rss.png");
            this.imageList1.Images.SetKeyName(1, "Tv.png");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 185);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Pin";
            // 
            // tbxPin
            // 
            this.tbxPin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPin.Enabled = false;
            this.tbxPin.Location = new System.Drawing.Point(271, 33);
            this.tbxPin.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPin.Name = "tbxPin";
            this.tbxPin.PasswordChar = '*';
            this.tbxPin.Size = new System.Drawing.Size(197, 20);
            this.tbxPin.TabIndex = 29;
            // 
            // tbxScreenName
            // 
            this.tbxScreenName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxScreenName.Location = new System.Drawing.Point(225, 9);
            this.tbxScreenName.Name = "tbxScreenName";
            this.tbxScreenName.Size = new System.Drawing.Size(242, 20);
            this.tbxScreenName.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "BasicHome Screen Name:";
            // 
            // btnBrowseForDlFolder
            // 
            this.btnBrowseForDlFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseForDlFolder.AutoSize = true;
            this.btnBrowseForDlFolder.Location = new System.Drawing.Point(441, 57);
            this.btnBrowseForDlFolder.Margin = new System.Windows.Forms.Padding(2);
            this.btnBrowseForDlFolder.Name = "btnBrowseForDlFolder";
            this.btnBrowseForDlFolder.Size = new System.Drawing.Size(26, 23);
            this.btnBrowseForDlFolder.TabIndex = 32;
            this.btnBrowseForDlFolder.Text = "...";
            this.btnBrowseForDlFolder.UseVisualStyleBackColor = true;
            this.btnBrowseForDlFolder.Click += new System.EventHandler(this.btnBrowseForDlFolder_Click);
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.tabGeneral);
            this.mainTabControl.Controls.Add(this.tabSites);
            this.mainTabControl.Controls.Add(this.tabPageCodecs);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(488, 508);
            this.mainTabControl.TabIndex = 33;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.label21);
            this.tabGeneral.Controls.Add(this.btnCancel);
            this.tabGeneral.Controls.Add(this.lblVersion);
            this.tabGeneral.Controls.Add(this.cmbDasErsteQuality);
            this.tabGeneral.Controls.Add(this.label16);
            this.tabGeneral.Controls.Add(this.label15);
            this.tabGeneral.Controls.Add(this.cmbYoutubeQuality);
            this.tabGeneral.Controls.Add(this.label1);
            this.tabGeneral.Controls.Add(this.btnBrowseForDlFolder);
            this.tabGeneral.Controls.Add(this.btnYahooConfig);
            this.tabGeneral.Controls.Add(this.txtThumbLoc);
            this.tabGeneral.Controls.Add(this.btnSave);
            this.tabGeneral.Controls.Add(this.tbxScreenName);
            this.tabGeneral.Controls.Add(this.label2);
            this.tabGeneral.Controls.Add(this.label7);
            this.tabGeneral.Controls.Add(this.txtFilters);
            this.tabGeneral.Controls.Add(this.tbxPin);
            this.tabGeneral.Controls.Add(this.label3);
            this.tabGeneral.Controls.Add(this.label6);
            this.tabGeneral.Controls.Add(this.txtDownloadDir);
            this.tabGeneral.Controls.Add(this.cmbTrailerSize);
            this.tabGeneral.Controls.Add(this.label4);
            this.tabGeneral.Controls.Add(this.label5);
            this.tabGeneral.Controls.Add(this.chkUseAgeConfirmation);
            this.tabGeneral.Location = new System.Drawing.Point(4, 22);
            this.tabGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.Padding = new System.Windows.Forms.Padding(2);
            this.tabGeneral.Size = new System.Drawing.Size(480, 482);
            this.tabGeneral.TabIndex = 0;
            this.tabGeneral.Text = "General";
            this.tabGeneral.UseVisualStyleBackColor = true;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(244, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(22, 13);
            this.label21.TabIndex = 39;
            this.label21.Text = "Pin";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(386, 440);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 25);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblVersion
            // 
            this.lblVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblVersion.Location = new System.Drawing.Point(2, 466);
            this.lblVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(476, 14);
            this.lblVersion.TabIndex = 37;
            this.lblVersion.Text = "Version";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmbDasErsteQuality
            // 
            this.cmbDasErsteQuality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDasErsteQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDasErsteQuality.FormattingEnabled = true;
            this.cmbDasErsteQuality.Items.AddRange(new object[] {
            "Low",
            "High"});
            this.cmbDasErsteQuality.Location = new System.Drawing.Point(225, 187);
            this.cmbDasErsteQuality.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDasErsteQuality.Name = "cmbDasErsteQuality";
            this.cmbDasErsteQuality.Size = new System.Drawing.Size(242, 21);
            this.cmbDasErsteQuality.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 189);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Das Erste Quality";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 163);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "YouTube Max Quality";
            // 
            // cmbYoutubeQuality
            // 
            this.cmbYoutubeQuality.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbYoutubeQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYoutubeQuality.FormattingEnabled = true;
            this.cmbYoutubeQuality.Items.AddRange(new object[] {
            "Normal",
            "High",
            "HD"});
            this.cmbYoutubeQuality.Location = new System.Drawing.Point(225, 161);
            this.cmbYoutubeQuality.Name = "cmbYoutubeQuality";
            this.cmbYoutubeQuality.Size = new System.Drawing.Size(242, 21);
            this.cmbYoutubeQuality.TabIndex = 33;
            // 
            // tabSites
            // 
            this.tabSites.AutoScroll = true;
            this.tabSites.Controls.Add(this.groupBox1);
            this.tabSites.Controls.Add(this.tabControl1);
            this.tabSites.Location = new System.Drawing.Point(4, 22);
            this.tabSites.Margin = new System.Windows.Forms.Padding(2);
            this.tabSites.Name = "tabSites";
            this.tabSites.Padding = new System.Windows.Forms.Padding(2);
            this.tabSites.Size = new System.Drawing.Size(480, 482);
            this.tabSites.TabIndex = 1;
            this.tabSites.Text = "Sites";
            this.tabSites.UseVisualStyleBackColor = true;
            // 
            // tabPageCodecs
            // 
            this.tabPageCodecs.Controls.Add(this.groupBoxSplitter);
            this.tabPageCodecs.Location = new System.Drawing.Point(4, 22);
            this.tabPageCodecs.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageCodecs.Name = "tabPageCodecs";
            this.tabPageCodecs.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageCodecs.Size = new System.Drawing.Size(480, 482);
            this.tabPageCodecs.TabIndex = 2;
            this.tabPageCodecs.Text = "Codecs";
            this.tabPageCodecs.UseVisualStyleBackColor = true;
            // 
            // groupBoxSplitter
            // 
            this.groupBoxSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSplitter.Controls.Add(this.tbxWMVSplitter);
            this.groupBoxSplitter.Controls.Add(this.tbxAVISplitter);
            this.groupBoxSplitter.Controls.Add(this.tbxMP4Splitter);
            this.groupBoxSplitter.Controls.Add(this.tbxFLVSplitter);
            this.groupBoxSplitter.Controls.Add(this.chkWMVSplitterInstalled);
            this.groupBoxSplitter.Controls.Add(this.chkAVISplitterInstalled);
            this.groupBoxSplitter.Controls.Add(this.chkMP4SplitterInstalled);
            this.groupBoxSplitter.Controls.Add(this.label14);
            this.groupBoxSplitter.Controls.Add(this.label13);
            this.groupBoxSplitter.Controls.Add(this.label12);
            this.groupBoxSplitter.Controls.Add(this.chkFLVSplitterInstalled);
            this.groupBoxSplitter.Controls.Add(this.label11);
            this.groupBoxSplitter.Location = new System.Drawing.Point(6, 5);
            this.groupBoxSplitter.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSplitter.Name = "groupBoxSplitter";
            this.groupBoxSplitter.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxSplitter.Size = new System.Drawing.Size(470, 109);
            this.groupBoxSplitter.TabIndex = 1;
            this.groupBoxSplitter.TabStop = false;
            this.groupBoxSplitter.Text = "Splitter";
            // 
            // tbxWMVSplitter
            // 
            this.tbxWMVSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxWMVSplitter.Location = new System.Drawing.Point(118, 84);
            this.tbxWMVSplitter.Margin = new System.Windows.Forms.Padding(2);
            this.tbxWMVSplitter.Name = "tbxWMVSplitter";
            this.tbxWMVSplitter.ReadOnly = true;
            this.tbxWMVSplitter.Size = new System.Drawing.Size(349, 20);
            this.tbxWMVSplitter.TabIndex = 11;
            // 
            // tbxAVISplitter
            // 
            this.tbxAVISplitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxAVISplitter.Location = new System.Drawing.Point(118, 62);
            this.tbxAVISplitter.Margin = new System.Windows.Forms.Padding(2);
            this.tbxAVISplitter.Name = "tbxAVISplitter";
            this.tbxAVISplitter.ReadOnly = true;
            this.tbxAVISplitter.Size = new System.Drawing.Size(349, 20);
            this.tbxAVISplitter.TabIndex = 10;
            // 
            // tbxMP4Splitter
            // 
            this.tbxMP4Splitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxMP4Splitter.Location = new System.Drawing.Point(118, 39);
            this.tbxMP4Splitter.Margin = new System.Windows.Forms.Padding(2);
            this.tbxMP4Splitter.Name = "tbxMP4Splitter";
            this.tbxMP4Splitter.ReadOnly = true;
            this.tbxMP4Splitter.Size = new System.Drawing.Size(349, 20);
            this.tbxMP4Splitter.TabIndex = 9;
            // 
            // tbxFLVSplitter
            // 
            this.tbxFLVSplitter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxFLVSplitter.Location = new System.Drawing.Point(118, 16);
            this.tbxFLVSplitter.Margin = new System.Windows.Forms.Padding(2);
            this.tbxFLVSplitter.Name = "tbxFLVSplitter";
            this.tbxFLVSplitter.ReadOnly = true;
            this.tbxFLVSplitter.Size = new System.Drawing.Size(349, 20);
            this.tbxFLVSplitter.TabIndex = 8;
            // 
            // chkWMVSplitterInstalled
            // 
            this.chkWMVSplitterInstalled.AutoSize = true;
            this.chkWMVSplitterInstalled.Enabled = false;
            this.chkWMVSplitterInstalled.Location = new System.Drawing.Point(100, 88);
            this.chkWMVSplitterInstalled.Margin = new System.Windows.Forms.Padding(2);
            this.chkWMVSplitterInstalled.Name = "chkWMVSplitterInstalled";
            this.chkWMVSplitterInstalled.Size = new System.Drawing.Size(15, 14);
            this.chkWMVSplitterInstalled.TabIndex = 7;
            this.chkWMVSplitterInstalled.UseVisualStyleBackColor = true;
            // 
            // chkAVISplitterInstalled
            // 
            this.chkAVISplitterInstalled.AutoSize = true;
            this.chkAVISplitterInstalled.Enabled = false;
            this.chkAVISplitterInstalled.Location = new System.Drawing.Point(100, 65);
            this.chkAVISplitterInstalled.Margin = new System.Windows.Forms.Padding(2);
            this.chkAVISplitterInstalled.Name = "chkAVISplitterInstalled";
            this.chkAVISplitterInstalled.Size = new System.Drawing.Size(15, 14);
            this.chkAVISplitterInstalled.TabIndex = 6;
            this.chkAVISplitterInstalled.UseVisualStyleBackColor = true;
            // 
            // chkMP4SplitterInstalled
            // 
            this.chkMP4SplitterInstalled.AutoSize = true;
            this.chkMP4SplitterInstalled.Enabled = false;
            this.chkMP4SplitterInstalled.Location = new System.Drawing.Point(100, 42);
            this.chkMP4SplitterInstalled.Margin = new System.Windows.Forms.Padding(2);
            this.chkMP4SplitterInstalled.Name = "chkMP4SplitterInstalled";
            this.chkMP4SplitterInstalled.Size = new System.Drawing.Size(15, 14);
            this.chkMP4SplitterInstalled.TabIndex = 5;
            this.chkMP4SplitterInstalled.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 87);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "wmv | asf";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 64);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(21, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "avi";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 41);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "mp4 | m4v | mov";
            // 
            // chkFLVSplitterInstalled
            // 
            this.chkFLVSplitterInstalled.AutoSize = true;
            this.chkFLVSplitterInstalled.Enabled = false;
            this.chkFLVSplitterInstalled.Location = new System.Drawing.Point(100, 20);
            this.chkFLVSplitterInstalled.Margin = new System.Windows.Forms.Padding(2);
            this.chkFLVSplitterInstalled.Name = "chkFLVSplitterInstalled";
            this.chkFLVSplitterInstalled.Size = new System.Drawing.Size(15, 14);
            this.chkFLVSplitterInstalled.TabIndex = 1;
            this.chkFLVSplitterInstalled.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 19);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "flv";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(164, 115);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 13);
            this.label22.TabIndex = 27;
            this.label22.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceSiteSettings, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(247, 112);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(223, 20);
            this.descriptionTextBox.TabIndex = 28;
            // 
            // Configuration
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(488, 508);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Configuration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Online Videos Configuration";
            this.Load += new System.EventHandler(this.Configuration_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConfigurationFormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceRssLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceSiteSettings)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStripContainer3.ContentPanel.ResumeLayout(false);
            this.toolStripContainer3.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer3.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer3.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer3.TopToolStripPanel.PerformLayout();
            this.toolStripContainer3.ResumeLayout(false);
            this.toolStripContainer3.PerformLayout();
            this.toolStripSiteUpDown.ResumeLayout(false);
            this.toolStripSiteUpDown.PerformLayout();
            this.toolStripSites.ResumeLayout(false);
            this.toolStripSites.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageRssLinks.ResumeLayout(false);
            this.tabPageRssLinks.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripRss.ResumeLayout(false);
            this.toolStripRss.PerformLayout();
            this.tabChannels.ResumeLayout(false);
            this.tabChannels.PerformLayout();
            this.toolStripContainer2.ContentPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer2.TopToolStripPanel.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.toolStripChannels.ResumeLayout(false);
            this.toolStripChannels.PerformLayout();
            this.mainTabControl.ResumeLayout(false);
            this.tabGeneral.ResumeLayout(false);
            this.tabGeneral.PerformLayout();
            this.tabSites.ResumeLayout(false);
            this.tabPageCodecs.ResumeLayout(false);
            this.groupBoxSplitter.ResumeLayout(false);
            this.groupBoxSplitter.PerformLayout();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.ComboBox cmbTrailerSize;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtDownloadDir;
		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtRssUrl;
		private System.Windows.Forms.TextBox txtRssName;
		private System.Windows.Forms.ListBox RssLinkList;
		private System.Windows.Forms.ListBox siteList;
		private System.Windows.Forms.CheckBox chkEnabled;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtSiteName;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.CheckBox chkAgeConfirm;
		private System.Windows.Forms.TextBox txtUserId;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
		private System.Windows.Forms.TextBox txtFilters;
		private System.Windows.Forms.TextBox txtThumbLoc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		//private System.Windows.Forms.TabPage General_Tab;
		//private System.Windows.Forms.TabControl tabControl1;
		
		void CheckBox1CheckedChanged(object sender, System.EventArgs e)
		{
			
		}

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkUseAgeConfirmation;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnYahooConfig;
        private System.Windows.Forms.TextBox tbxSearchUrl;
        private System.Windows.Forms.Label lblSearchUrl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageRssLinks;
        private System.Windows.Forms.TabPage tabChannels;
        private System.Windows.Forms.TreeView tvGroups;
        private System.Windows.Forms.ComboBox cbSiteUtil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxPin;
        private System.Windows.Forms.TextBox tbxScreenName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxChannelName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxStreamUrl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxStreamName;
        private System.Windows.Forms.Button btnSaveChannel;
        private System.Windows.Forms.Button btnBrowseForDlFolder;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage tabGeneral;
        private System.Windows.Forms.TabPage tabSites;
        private System.Windows.Forms.TabPage tabPageCodecs;
        private System.Windows.Forms.GroupBox groupBoxSplitter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox chkFLVSplitterInstalled;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkWMVSplitterInstalled;
        private System.Windows.Forms.CheckBox chkAVISplitterInstalled;
        private System.Windows.Forms.CheckBox chkMP4SplitterInstalled;
        private System.Windows.Forms.TextBox tbxFLVSplitter;
        private System.Windows.Forms.TextBox tbxWMVSplitter;
        private System.Windows.Forms.TextBox tbxAVISplitter;
        private System.Windows.Forms.TextBox tbxMP4Splitter;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbYoutubeQuality;
        private System.Windows.Forms.ComboBox cmbDasErsteQuality;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbxStreamThumb;
        private System.Windows.Forms.ComboBox cbLanguages;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtRssThumb;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbxChannelThumb;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.BindingSource bindingSourceSiteSettings;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStripRss;
        private System.Windows.Forms.ToolStripButton btnDeleteRss;
        private System.Windows.Forms.ToolStripButton btnAddRss;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        private System.Windows.Forms.ToolStrip toolStripChannels;
        private System.Windows.Forms.ToolStripButton btnAddChannel;
        private System.Windows.Forms.ToolStripButton btnAddGroup;
        private System.Windows.Forms.ToolStripButton btnDeleteChannel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer3;
        private System.Windows.Forms.ToolStrip toolStripSites;
        private System.Windows.Forms.ToolStripButton btnAddSite;
        private System.Windows.Forms.ToolStripButton btnDeleteSite;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStrip toolStripSiteUpDown;
        private System.Windows.Forms.ToolStripButton btnSiteUp;
        private System.Windows.Forms.ToolStripButton btnSiteDown;
        private System.Windows.Forms.ToolStripButton btnImportSite;
        private System.Windows.Forms.BindingSource bindingSourceRssLink;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox descriptionTextBox;
	}
}
