using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Learn.Wpf.Core.Security
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
