using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewAndValueConverters
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
