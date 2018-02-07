using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Markup;

namespace Learn.Wpf.ValueConverters
{
    /// <summary>
    /// A Base Value Converter that allows direct XAML usage
    /// </summary>
    /// <typeparam name="T">The type of this value converter</typeparam>
    public abstract class BaseValueConverter<T>: MarkupExtension, IValueConverter where T : class, new()
    {
        public abstract object Convert(object value, Type targetType, object parameter, CultureInfo culture);

        public abstract object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture);

        /// <summary>
        /// A single static Instance of this value converter
        /// </summary>
        private static T _converter ;

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return _converter ?? (_converter = new T());
        }
    }
}
