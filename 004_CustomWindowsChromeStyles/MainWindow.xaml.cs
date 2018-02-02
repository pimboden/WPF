using System.Windows;
using Learn.Wpf.CustomWindowsChromeStyles.ViewModels;

namespace Learn.Wpf.CustomWindowsChromeStyles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new WindowViewModel(this);
        }
    }
}
