using System.ComponentModel;

namespace Learn.Wpf.CustomWindowsChromeStyles.ViewModels
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


        /// <summary>
        /// Call this to fire <see cref="PropertyChnaged"/> event
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChnaged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name) );
        }
    }
}
