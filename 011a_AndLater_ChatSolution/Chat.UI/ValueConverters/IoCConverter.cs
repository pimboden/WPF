using System;
using System.Diagnostics;
using System.Globalization;
using Learn.Wpf.Core.DataModels;
using Learn.Wpf.Core.IoC;
using Learn.Wpf.Core.ViewModels;
using Ninject;

namespace Learn.Wpf.ValueConverters
{
    /// <summary>
    /// Converts a sring name to a Insance pulled frm the <see cref="IoC"/> contaime
    /// </summary>
    public class IoCConverter : BaseValueConverter<IoCConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            //Fingd the appopiate page
            switch ((string )value)
            {
                case nameof(ApplicationViewModel):
                    return  IoC.Get<ApplicationViewModel>()
                        ;
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
