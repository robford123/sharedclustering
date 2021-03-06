﻿using SharedClustering.Properties;
using System;
using System.IO;

namespace SharedClustering.Models
{
    public static class DirectoryUtils
    {
        public static string GetDefaultDirectory(string defaultFileName)
        {
            if (!string.IsNullOrEmpty(defaultFileName) && Directory.Exists(Path.GetDirectoryName(defaultFileName)))
            {
                return Path.GetDirectoryName(defaultFileName);
            }

            if (!string.IsNullOrEmpty(Settings.Default.LastUsedDirectory) && Directory.Exists(Settings.Default.LastUsedDirectory))
            {
                return Settings.Default.LastUsedDirectory;
            }

            return AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
