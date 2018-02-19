using System;
using System.Globalization;
using System.Windows;

namespace Learn.Wpf.ValueConverters
{
    /// <summary>
    /// Changes the   <see cref="Visibility"/> dependant on the boolean value
    /// </summary>
    public class BooleanToVisibilityConverter : BaseValueConverter<BooleanToVisibilityConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool) value ? Visibility.Hidden : Visibility.Visible;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
