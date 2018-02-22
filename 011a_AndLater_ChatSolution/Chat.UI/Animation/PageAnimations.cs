using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Learn.Wpf.Animation
{
    /// <summary>
    /// Helpers to animate pages in specific ways
    /// </summary>
    public static class PageAnimations
    {
        public static async Task SlideAndFadeInFromRight(this Page page, float seconds)
        {
            var storyBoard = new Storyboard();
            storyBoard.AddSlideFromRight(seconds, page.WindowWidth);
            storyBoard.AddFadeIn(seconds);
            storyBoard.Begin(page);
            page.Visibility = Visibility.Visible;
            await Task.Delay((int)seconds * 1000);
        }
        public static async Task SlideAndFadeOutToLeft(this Page page, float seconds)
        {
            var storyBoard = new Storyboard();
            storyBoard.AddSlideToLeft(seconds, page.WindowWidth);
            storyBoard.AddFadeOut(seconds);
            storyBoard.Begin(page);
            await Task.Delay((int) seconds * 1000);   
        }
    }
}