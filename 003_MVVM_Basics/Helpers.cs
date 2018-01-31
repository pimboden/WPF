using System.IO;

namespace Learn.Wpf.MVVM_Basics
{
    public static class StringExtensions
    {

        public static string GetFileFolderName(this string path)
        {
            if (string.IsNullOrEmpty(path))
                return string.Empty;
            var normalizedPath = path.Replace('/',Path.DirectorySeparatorChar);
            var indexOfSeparator = normalizedPath.LastIndexOf(Path.DirectorySeparatorChar);
            return indexOfSeparator <= 0 ? path : normalizedPath.Substring(indexOfSeparator + 1);
        }
    }
}
