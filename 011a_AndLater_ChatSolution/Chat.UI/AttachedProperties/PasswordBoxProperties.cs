using System.Windows;
using System.Windows.Controls;

namespace Learn.Wpf.AttachedProperties
{

    /// <summary>
    /// The MonitorPassword attached property for the <see cref="PasswordBox"/>
    /// </summary>
    public class MonitorPasswordProperty : BaseAttachedProperty<MonitorPasswordProperty, bool>
    {
        public override void OnValuePropertyChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            //Get the calles

            if(!(sender is PasswordBox passwordBox))
                return;

            //Remove prevoius event
            passwordBox.PasswordChanged -= PasswordBox_PasswordChanged;

            //Start listening if MonitorPassword is set to true
            if ((bool) e.NewValue)
            {
                //Set default value 
                HasTextProperty.SetValue(passwordBox);
                passwordBox.PasswordChanged += PasswordBox_PasswordChanged;
            }

        }

        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            HasTextProperty.SetValue((PasswordBox)sender);
        }
    }


    /// <summary>
    /// The HasText attached property for the <see cref="PasswordBox"/>
    /// </summary>
    public class HasTextProperty : BaseAttachedProperty<HasTextProperty, bool>
    {
        public  static  void SetValue(DependencyObject sender)
        {
            SetValue(sender, ((PasswordBox)sender).SecurePassword.Length > 0);
        }
    }
}
