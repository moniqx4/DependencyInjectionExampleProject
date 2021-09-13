﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace TestUtilities
{
    public static class ExecutionDirectoryResolver
    {
        private static string _driverExecutablePath = string.Empty;

        public static string GetDriverExecutablePath()
        {
            if (string.IsNullOrEmpty(_driverExecutablePath))
            {
                string assemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                var directoryInfo = new DirectoryInfo(assemblyFolder);
                var parentDirectories = GetAllParentDirectories(directoryInfo);

                if (parentDirectories.Count(x => x.Equals(directoryInfo.Name)) > 1)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        directoryInfo = directoryInfo?.Parent;
                    }
                }

                _driverExecutablePath = directoryInfo?.FullName;
            }

            return _driverExecutablePath;
        }

        private static IEnumerable<string> GetAllParentDirectories(DirectoryInfo directoryToScan)
        {
            var parentFolders = new List<string>();
            GetAllParentDirectories(directoryToScan, parentFolders);
            return parentFolders;
        }

        private static void GetAllParentDirectories(DirectoryInfo directoryToScan, List<string> directories)
        {
            if (directoryToScan == null || directoryToScan.Name == directoryToScan.Root.Name)
            {
                return;
            }

            directories.Add(directoryToScan.Name);
            GetAllParentDirectories(directoryToScan.Parent, directories);
        }
    }
}
