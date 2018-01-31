using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Learn.Wpf.MVVM_Basics.Common;
using Learn.Wpf.MVVM_Basics.Common.Enums;
using Learn.Wpf.MVVM_Basics.Directory;

namespace Learn.Wpf.MVVM_Basics.ViewModels
{
    /// <summary>
    /// A viewmodel for a directory item
    /// </summary>
    public class DirectoryItemViewModel : BaseViewModel
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
        public string Name => Type == DirectoryItemType.Drive ? FullPath : FullPath.GetFileFolderName();

        public ObservableCollection<DirectoryItemViewModel> Children { get; set; }

        public bool CanExpand => Type != DirectoryItemType.File;

        public bool IsExpanded
        {
            get { return Children?.Count(f => f != null) > 0; }
            set
            {
                if (value)
                {
                    //UI want to expand
                    Expand();
                }
                else
                {
                    Collapse();
                }
            }
        }


        public ICommand ExpandCommand { get; set; }

        public DirectoryItemViewModel(string fullPath, DirectoryItemType type)
        {
            ExpandCommand = new RelayCommand(Expand);
            FullPath = fullPath;
            Type = type;
            Collapse();
        }

        /// <summary>
        /// Collapse the childs
        /// </summary>
        private void Collapse()
        {
            ClearChildren();
        }

        /// <summary>
        /// expands this directory and finds all children
        /// </summary>
        private void Expand()
        {
            if (Type == DirectoryItemType.File)
                return;
            Children = new ObservableCollection<DirectoryItemViewModel>(DirectoryStructure.GetDirectoryContents(FullPath)
                .Select(content => new DirectoryItemViewModel(content.FullPath, content.Type)));
        }


        /// <summary>
        /// Removes all children form the list add a dummy to show the expand Icon if required
        /// </summary>
        private void ClearChildren()
        {
            Children = new ObservableCollection<DirectoryItemViewModel>();
            if (Type != DirectoryItemType.File)
            {
                Children.Add(null);
            }
        }
    }
}