using System.ComponentModel;

namespace Learn.Wpf.MVVM_Basics.ViewModels
{

    /// <summary>
    /// Base viewModel that fires PropertyChanged events as needed
    /// </summary>
    public abstract class BaseViewModel: INotifyPropertyChanged
    {
        /// <summary>
        /// The event that is fired when any child property changes its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
    }
}
