using Learn.Wpf.MVVM_Basics.Common.Enums;
using Learn.Wpf.MVVM_Basics.Directory;

namespace Learn.Wpf.MVVM_Basics.Data
{

    /// <summary>
    /// Information about abstract directory Item such as a drive, a file or a folder
    /// </summary>
    public class DirectoryItem
    {
        /// <summary>
        /// The type of item 
        /// </summary>
        public DirectoryItemType Type { get; set; }
       
        /// <summary>
        /// The absoulte path to this item
        /// </summary>
        public string FullPath { get; set; }


        /// <summary>
        /// The name of the Item
        /// </summary>
        public string Name => Type == DirectoryItemType.Drive ? FullPath: FullPath.GetFileFolderName();
    }
}
