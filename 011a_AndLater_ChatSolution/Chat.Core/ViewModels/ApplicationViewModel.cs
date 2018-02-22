using Learn.Wpf.Core.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Wpf.Core.ViewModels
{
    /// <summary>
    /// The application state as a ViewModel
    /// </summary>
    public class ApplicationViewModel: BaseViewModel
    {

        //The current page of the application
        public ApplicationPage CurrentPage { get; set; } = ApplicationPage.Login;


    }
}
