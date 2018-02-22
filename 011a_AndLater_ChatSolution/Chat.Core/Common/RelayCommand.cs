using System;
using System.Windows.Input;

namespace Learn.Wpf.Core.Common
{
    public class RelayCommand: ICommand
    {
        /// <summary>
        /// The action to run
        /// </summary>
        private readonly Action _action;
     
        /// <summary>
        /// A relay command can always execute
        /// </summary>
        /// <param name="parameter"></param>
        public bool CanExecute(object parameter) => true;
        

        /// <summary>
        /// Exceutes the commands action
        /// </summary>
        /// <param name="parameter"></param>
        public void Execute(object parameter)
        {
            _action();
        }

        /// <summary>
        /// The event that's fired when the <see cref="CanExecute(object parameter)"/> value has changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public RelayCommand(Action action)
        {
            _action = action;
        }
    }
}
