using System.Windows;
using System.Windows.Input;
using Learn.Wpf.Common;
using Learn.Wpf.DataModels;

namespace Learn.Wpf.ViewModels
{
    /// <summary>
    /// The ViewModel for the flat window 
    /// </summary>
    public class WindowViewModel : BaseViewModel
    {
        /// <summary>
        /// The window this Viewmodel Controls
        /// </summary>
        private Window _window;

        private int _outerMarginSize = 10;
        private int _windowRadius = 10;

        /// <summary>
        /// The Height of the title basr /caption of the window
        /// </summary>
        public int TitleHeight { get; set; } = 42;

        /// <summary>
        /// The Height of the title basr /caption of the window
        /// </summary>
        public GridLength TileHeightGridLength => new GridLength(TitleHeight + ResizeBorder);

        /// <summary>
        /// The size of the border around the window
        /// </summary>
        public int ResizeBorder { get; set; } = 6;

        /// <summary>
        /// The size of the resize border around the window
        /// </summary>
        public Thickness ResizeBorderThickness => new Thickness(ResizeBorder + OuterMargingSize);


        /// <summary>
        /// The padding of the inner content od the main window
        /// </summary>
        public Thickness InnerContentPadding { get; set; } = new Thickness(0);


        /// <summary>
        /// The smallest window with
        /// </summary>
        public double WindowMinimumWidth { get; set; } = 200;

        /// <summary>
        /// The smallest window height
        /// </summary>
        public double WindowMinimumHeight { get; set; } = 200;
        
        
        
        /// <summary>
        /// The margin around the window to allow for a drop shadow
        /// </summary>
        public int OuterMargingSize
        {
            get => _window.WindowState == WindowState.Maximized ? 0 : _outerMarginSize;
            set => _outerMarginSize = value;
        }


        /// <summary>
        /// The margin Thikness around the window to allow for a drop shadow
        /// </summary>
        public Thickness OuterMargingSizeThikness => new Thickness(OuterMargingSize);


        /// <summary>
        /// The radius of the edges of the window
        /// </summary>
        public int WindowRadius
        {
            get => _window.WindowState == WindowState.Maximized ? 0 : _windowRadius;
            set => _windowRadius = value;
        }

        /// <summary>
        /// The radius of the edges of the window
        /// </summary>
        public CornerRadius WindowCornerRadius => new CornerRadius(WindowRadius);


        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.LoginPage;
    
        public WindowViewModel(Window window)
        {
            _window = window;
            //Listen for window resizing
            _window.StateChanged += (sender, e) =>
            {
                // Fire events for all properties that are affecte ba a resize
                OnPropertyChnaged(nameof(ResizeBorderThickness));
                OnPropertyChnaged(nameof(OuterMargingSize));
                OnPropertyChnaged(nameof(OuterMargingSizeThikness));
                OnPropertyChnaged(nameof(ResizeBorder));
                OnPropertyChnaged(nameof(WindowRadius));
                OnPropertyChnaged(nameof(WindowCornerRadius));

            };

            MinimizeCommand = new RelayCommand(() => _window.WindowState = WindowState.Minimized);
            MaximizeCommand = new RelayCommand(() => _window.WindowState = _window.WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized);
            CloseCommand = new RelayCommand(() => _window.Close());
            MenuCommand = new RelayCommand(() => SystemCommands.ShowSystemMenu(_window, _window.PointToScreen(Mouse.GetPosition(_window))));

            //Fix window resize issue
            // ReSharper disable once UnusedVariable
            var resizer = new WindowResizer(_window);
        }

        public ICommand MinimizeCommand { get; set; }
        public ICommand MaximizeCommand { get; set; }
        public ICommand CloseCommand { get; set; }
        public ICommand MenuCommand { get; set; }
    }
}
