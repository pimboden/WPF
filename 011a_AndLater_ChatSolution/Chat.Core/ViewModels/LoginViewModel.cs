using System.Security;
using System.Threading.Tasks;
using System.Windows.Input;
using Learn.Wpf.Core.Common;
using Learn.Wpf.Core.DataModels;
using Learn.Wpf.Core.Security;

namespace Learn.Wpf.Core.ViewModels
{
    /// <summary>
    /// The View Model for a login screen
    /// </summary>
    public class LoginViewModel : BaseViewModel
    {


        #region Public Properties

        /// <summary>
        /// The email of the user
        /// </summary>
        public string Email { get; set; }


        /// <summary>
        /// A flag indicating if the Loging command is running
        /// </summary>
        public bool IsLoginRunning { get; set; }
        #endregion

        #region Commands



        /// <summary>
        /// The command to login
        /// </summary>
        public ICommand LoginCommand { get; set; }

        /// <summary>
        /// The command to register for a new account
        /// </summary>
        public ICommand RegisterCommand { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginViewModel()
        {


            // Create commands
            LoginCommand = new RelayParameterizedCommand(async (parameter) => await Login(parameter));
            RegisterCommand = new RelayCommand(async () => await RegisterAsync());
        }
        /// <summary>
        ///  Takes the user to the register page
        /// </summary>
        /// <returns></returns>
        private async Task RegisterAsync()
        {
            IoC.IoC.Get<ApplicationViewModel>().CurrentPage = ApplicationPage.Register;
            await Task.Delay(1);
        }

        /// <summary>
        /// Attempts to log the user in
        /// </summary>
        /// <param name="parameter">Teh <see cref="SecureString"/> passed in from the users password</param>
        /// <returns></returns>
        public async Task Login(object parameter)
        {

            // ReSharper disable once PossibleNullReferenceException
            await RunCommandAsync(() => IsLoginRunning, async () =>
            {
                await Task.Delay(5000);
                var pass = (parameter as IHavePassword).SecurePassword.Unsecure();
            });
        }

        #endregion

    }
}
