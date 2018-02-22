using Learn.Wpf.Core.IoC;
using Learn.Wpf.Core.ViewModels;

namespace Learn.Wpf.ViewModels
{

    /// <summary>
    /// Locates View models form the IoC for use in binding in Xaml files
    /// </summary>
    public class ViewModelLocator
    {
        private static ViewModelLocator _instance;

        public static ViewModelLocator Instance => _instance ?? (_instance = new ViewModelLocator());


        public static ApplicationViewModel ApplicationViewModel => IoC.Get<ApplicationViewModel>();
    }
}
