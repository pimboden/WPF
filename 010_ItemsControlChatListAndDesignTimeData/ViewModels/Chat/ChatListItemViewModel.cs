using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Wpf.ViewModels.Chat
{
    /// <summary>
    /// A viewmodel for a ChatListItem
    /// </summary>
    public class ChatListItemViewModel:BaseViewModel
    {
        /// <summary>
        /// Display name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The latest message
        /// </summary>
        public string Message { get; set; }


        /// <summary>
        /// Initials for the profile picture
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// The RGB background color of the profile picture in hex
        /// </summary>
        public string ProfilePictureRGB { get; set; }


    }
}
