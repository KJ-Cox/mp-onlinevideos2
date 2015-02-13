﻿using System.IO;
using System.Text;

namespace OnlineVideos.Helpers
{
    public static class EncryptionUtils
    {
        public static string CalculateCRC32(string strLine)
        {
            if (string.IsNullOrEmpty(strLine)) return string.Empty;
            Ionic.Zlib.CRC32 crc = new Ionic.Zlib.CRC32();
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };
            writer.Write(strLine);
            stream.Position = 0;
            return string.Format("{0}", crc.GetCrc32(stream));
        }

        public static string GetMD5Hash(string input)
        {
            System.Security.Cryptography.MD5 md5Hasher;
            byte[] data;
            int count;
            StringBuilder result;

            md5Hasher = System.Security.Cryptography.MD5.Create();
            data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Loop through each byte of the hashed data and format each one as a hexadecimal string.
            result = new StringBuilder();
            for (count = 0; count < data.Length; count++)
            {
                result.Append(data[count].ToString("x2", System.Globalization.CultureInfo.InvariantCulture));
            }

            return result.ToString();
        }
    }
}