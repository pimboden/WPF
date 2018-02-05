﻿using System.ComponentModel;

namespace Learn.Wpf.ViewModels
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
    }
}
