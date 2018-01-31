using System.Collections.Generic;
using System.IO;
using System.Linq;
using Learn.Wpf.MVVM_Basics.Common.Enums;
using Learn.Wpf.MVVM_Basics.Data;

namespace Learn.Wpf.MVVM_Basics.Directory
{
    /// <summary>
    /// Helper class o query information about directories
    /// </summary>
    public static class DirectoryStructure
    {
        /// <summary>
        /// Find the file or folder name from a full path
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string GetFileFolderName(this string path)
        {
            if (string.IsNullOrEmpty(path))
                return string.Empty;
            var normalizedPath = path.Replace('/', Path.DirectorySeparatorChar);
            var indexOfSeparator = normalizedPath.LastIndexOf(Path.DirectorySeparatorChar);
            return indexOfSeparator <= 0 ? path : normalizedPath.Substring(indexOfSeparator + 1);
        }

        /// <summary>
        /// Gets all logical drives on the computer
        /// </summary>
        /// <returns></returns>
        public static List<DirectoryItem> GetLogicalDrives()
        {
            return System.IO.Directory.GetLogicalDrives().Select(logicalDrive =>
                new DirectoryItem {Type = DirectoryItemType.Drive, FullPath = logicalDrive}).ToList();
        }

        /// <summary>
        /// Gets all the child files and folders
        /// </summary>
        /// <param name="fullPath">Full path of the parrent directory </param>
        /// <returns></returns>
        public static List<DirectoryItem> GetDirectoryContents( string fullPath)
        {
            var childItems = new List<DirectoryItem>();
            try
            {
                var dirs = System.IO.Directory.GetDirectories(fullPath);
                if (dirs.Length > 0)
                {
                    childItems.AddRange(dirs.Select(directory => new DirectoryItem {Type = DirectoryItemType.Folder, FullPath = directory}));
                }
            }
            catch
            {
                // ignored
            }
            try
            {
                var files = System.IO.Directory.GetFiles(fullPath);
                if (files.Length > 0)
                {
                    childItems.AddRange(files.Select(file => new DirectoryItem { Type = DirectoryItemType.File, FullPath = file }));
                }

            }
            catch
            {
                // ignored
            }
            return childItems;
        }
    }
}
