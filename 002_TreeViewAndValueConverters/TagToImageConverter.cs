using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace TreeViewAndValueConverters
{
    [ValueConversion(typeof(string), typeof(BitmapImage))]
    public class TagToImageConverter :IValueConverter
    {

        public static TagToImageConverter Instace = new TagToImageConverter();

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var fullPath = (string) value;
            if (string.IsNullOrEmpty(fullPath))
            {
                return null;
            }
            var image = "/images/drive.png";
            if (!fullPath.EndsWith(":\\"))
            {
                FileAttributes attr = File.GetAttributes(fullPath);

                if ((attr & FileAttributes.Directory) == FileAttributes.Directory)
                    image = "/images/folder-closed.png";
                else
                    image = "/images/file.png";
            }
           

            return new BitmapImage(new Uri($"pack://application:,,,{image}"));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
