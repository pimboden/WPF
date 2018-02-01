using System.Collections.ObjectModel;
using System.Linq;
using Learn.Wpf.MVVM_Basics.Directory;

namespace Learn.Wpf.MVVM_Basics.ViewModels
{
    /// <summary>
    /// The viewmodel for the applications main directory view
    /// </summary>
    public class DirectoryStructureViewModel : BaseViewModel
    {
        public ObservableCollection<DirectoryItemViewModel> Items { get; set; }

        public DirectoryStructureViewModel()
        {
            Items = new ObservableCollection<DirectoryItemViewModel>(DirectoryStructure.GetLogicalDrives().Select(drive => new DirectoryItemViewModel(drive.FullPath, drive.Type)));

        }
    }
}