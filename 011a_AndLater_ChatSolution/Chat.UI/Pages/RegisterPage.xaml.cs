using System.Security;
using Learn.Wpf.Core.Common;
using Learn.Wpf.Core.ViewModels;

namespace Learn.Wpf.Pages
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class RegisterPage : BasePage<LoginViewModel>, IHavePassword
    {
        public RegisterPage()
        {
            InitializeComponent();
        }


        /// <summary>
        /// The scure password for this login page
        /// </summary>
        public SecureString SecurePassword => PasswordText.SecurePassword;
    }
}
