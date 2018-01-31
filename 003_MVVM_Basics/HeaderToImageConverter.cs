using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;
using Learn.Wpf.MVVM_Basics.Common.Enums;

namespace Learn.Wpf.MVVM_Basics
{
    [ValueConversion(typeof(DirectoryItemType), typeof(BitmapImage))]
    public class HeaderToImageConverter :IValueConverter
    {

        public static HeaderToImageConverter Instace = new HeaderToImageConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {

            string image;
            switch ((DirectoryItemType)value)
            {
                case DirectoryItemType.Drive:
                    image = "/images/drive.png";
                    break;

                case DirectoryItemType.File:
                    image = "/images/file.png";
                    break;
                case DirectoryItemType.Folder:
                    image = "/images/folder-closed.png";
                    break;
                default:
                    image = "/images/file.png";
                    break;
            }


            return new BitmapImage(new Uri($"pack://application:,,,{image}"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
