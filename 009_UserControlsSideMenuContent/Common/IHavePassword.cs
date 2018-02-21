using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Wpf.Common
{

    /// <summary>
    /// An interface for a class that can provide a secure password
    /// </summary>
    public interface IHavePassword
    {
        SecureString SecurePassword { get;}
    }
}
