using System.Windows;
using Learn.Wpf.Core.ViewModels;
using Learn.Wpf.ViewModels;

namespace Learn.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Temporary
        public ApplicationViewModel ApplicationViewModel => new ApplicationViewModel();


        public MainWindow()
        {
            InitializeComponent();
            DataContext = new WindowViewModel(this);
        }
    }
}
