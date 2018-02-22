using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Learn.Wpf.Core.Expressions;

namespace Learn.Wpf.Core.ViewModels
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
        /// Call this to fire <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="name"></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name) );
        }

        #region Command Helpers
        #endregion

        /// <summary>
        /// Runs a command if the updating flag is not set.<Br/>
        /// If the flag is true (the function is running) the action is not run <br/>
        /// If the flag is false, the action is run
        /// </summary>
        /// <param name="updatingFlag">the boolean property flag</param>
        /// <param name="action">the action to run</param>
        /// <returns></returns>
        protected async Task RunCommandAsync(Expression<Func<bool>> updatingFlag, Func<Task> action)
        {


            if (updatingFlag.GetPropertyValue())
            {
                return;
            }

            updatingFlag.SetPropertyValue(true);
            try
            {
                await action();
            }
            finally
            {
                updatingFlag.SetPropertyValue(false);
            }
        }
    }
}
