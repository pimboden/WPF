using System;
using System.Windows.Input;

namespace Learn.Wpf.Core.Common
{
    public class RelayParameterizedCommand : ICommand
    {
        /// <summary>
        /// The action to run
        /// </summary>
        private Action<object> _action;

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
            _action(parameter);
        }

        /// <summary>
        /// The event that's fired when the <see cref="CanExecute(object parameter)"/> value has changed
        /// </summary>
        public event EventHandler CanExecuteChanged = (sender, e) => { };

        public RelayParameterizedCommand(Action<object> action)
        {
            _action = action;
        }
    }
}