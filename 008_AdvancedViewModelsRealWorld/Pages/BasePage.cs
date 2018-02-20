using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Learn.Wpf.Animation;
using Learn.Wpf.ViewModels;

namespace Learn.Wpf.Pages
{
    public class BasePage<TVm> : Page where TVm: BaseViewModel, new()
    {
    /// <summary>
    /// The ViewModel associated with this page
    /// </summary>
    private TVm _viewModel;


    /// <summary>
    /// The animation to play when page is loaded
    /// </summary>
    public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

    /// <summary>
    /// The animation to play when page is unloaded
    /// </summary>
    public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

    /// <summary>
    /// The time any slide animation should take to complete
    /// </summary>
    public float SlideSeconds { get; set; } = 0.8f;

    /// <summary>
    /// The ViewModel associated with this page
    /// </summary>
    public TVm ViewModel
    {
        get => _viewModel;
        set
        {
            if (Equals(_viewModel, value))
                return;
            _viewModel = value;
            DataContext = ViewModel;
        }
    }

    public BasePage()
    {
        if (PageLoadAnimation != PageAnimation.None)
        {
            Visibility = Visibility.Collapsed;
        }

        Loaded += BasePage_Loaded;
        ViewModel = new TVm();
    }

    /// <summary>
    /// Once page is loaded perform any required animation
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void BasePage_Loaded(object sender, RoutedEventArgs e)
    {
        await AnimateIn();
    }

    public async Task AnimateIn()
    {
        if (PageLoadAnimation == PageAnimation.None)
            return;
        switch (PageLoadAnimation)
        {
            case PageAnimation.SlideAndFadeInFromRight:
                await this.SlideAndFadeInFromRight(SlideSeconds);
                break;
        }
    }

    public async Task AnimateOut()
    {
        if (PageUnloadAnimation == PageAnimation.None)
            return;
        switch (PageUnloadAnimation)
        {
            case PageAnimation.SlideAndFadeOutToLeft:
                await this.SlideAndFadeOutToLeft(SlideSeconds);
                break;
        }
    }
    }

}
