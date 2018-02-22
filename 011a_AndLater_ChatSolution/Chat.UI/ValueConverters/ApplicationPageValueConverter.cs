using System;
using System.Diagnostics;
using System.Globalization;
using Learn.Wpf.Core.DataModels;

namespace Learn.Wpf.ValueConverters
{
    /// <summary>
    /// Converts the <see cref="ApplicationPage"/> to an actual view/page
    /// </summary>
    public class ApplicationPageValueConverter: BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Fingd the appopiate page
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Login:
                    return  new Pages.LoginPage();
                case ApplicationPage.Register:
                    return new Pages.RegisterPage();
                case ApplicationPage.Chat:
                    return new Pages.ChatPage();

                default:
                    Debugger.Break();
                    return null;
            }
        }
        

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
           throw  new NotImplementedException();
        }
    }
}
