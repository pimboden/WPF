using System.Windows;
using Learn.Wpf.MVVM_Basics.ViewModels;

namespace Learn.Wpf.MVVM_Basics
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext  =  new DirectoryStructureViewModel();
        }

    }
}
