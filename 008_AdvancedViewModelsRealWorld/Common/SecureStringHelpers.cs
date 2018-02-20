using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Wpf.Common
{

    /// <summary>
    /// helpers for the <see cref="SecureString"/> class
    /// </summary>
    public static class SecureStringHelpers
    {

        /// <summary>
        /// Show the plain string of the sceure sting
        /// </summary>
        /// <param name="secureString">The sceure string</param>
        /// <returns></returns>
        public static string Unsecure(this SecureString secureString)
        {
            if (secureString == null)
                return string.Empty;
            var unmanagedString = IntPtr.Zero;
            try
            {
                unmanagedString = Marshal.SecureStringToGlobalAllocUnicode(secureString);
                return Marshal.PtrToStringUni(unmanagedString);
            }
            finally
            {
                Marshal.ZeroFreeGlobalAllocUnicode(unmanagedString);
            }
        }
    }
}
