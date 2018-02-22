using System;
using System.Windows;

namespace Learn.Wpf.AttachedProperties
{
    /// <summary>
    /// a base attached property to replace the vanilla attached property
    /// </summary>
    public abstract class BaseAttachedProperty<TParent, TProperty> where TParent: BaseAttachedProperty<TParent, TProperty>, new()
    {
        /// <summary>
        /// A singleton instance
        /// </summary>
        public static  TParent Instance { get; private set; } = new TParent();

        /// <summary>
        /// The attached Property for this class
        /// </summary>
        public static readonly DependencyProperty ValueProperty = DependencyProperty.RegisterAttached("Value", typeof(TProperty), typeof(BaseAttachedProperty<TParent, TProperty>), new PropertyMetadata(new PropertyChangedCallback(OnValuePropertyChange)));

        public event Action<DependencyObject, DependencyPropertyChangedEventArgs> ValueChanged = (sender, e) => { };

        /// <summary>
        /// The method that is called when any attached property of this type changes
        /// </summary>
        /// <param name="sender">The ui element that had it's property changed</param>
        /// <param name="e">The arguments for the event</param>
        public virtual void OnValuePropertyChanged(DependencyObject sender,DependencyPropertyChangedEventArgs e)
        {

        }

        /// <summary>
        /// Callback event when the value porperty is changed
        /// </summary>
        /// <param name="sender">The ui element that had it's property changed</param>
        /// <param name="e">The arguments for the event</param>
        private static void OnValuePropertyChange(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            //Call the parent function
            Instance.OnValuePropertyChanged(sender, e);
            
            //call event listeners
            Instance.ValueChanged(sender, e);
        }

        /// <summary>
        /// Sets the attached property
        /// </summary>
        /// <param name="dependencyObject">The element to set the property to</param>
        /// <param name="value">The value to set to</param>
        public static void SetValue(DependencyObject dependencyObject, TProperty value)
        {
            dependencyObject.SetValue(ValueProperty, value);
        }

        /// <summary>
        /// Gets the attached property
        /// </summary>
        /// <param name="dependencyObject">The element to get the property from</param>
        /// <returns></returns>
        public static TProperty GetValue(DependencyObject dependencyObject) => (TProperty)dependencyObject.GetValue(ValueProperty);
    }
}
