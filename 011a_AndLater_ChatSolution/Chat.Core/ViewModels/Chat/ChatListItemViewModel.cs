namespace Learn.Wpf.Core.ViewModels.Chat
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


        /// <summary>
        /// Indicates if unread messages are available
        /// </summary>
        public bool IsNewContentAvailable { get; set; }

        /// <summary>
        /// True if item is selected
        /// </summary>
        public bool IsSelected { get; set; }
        
    }
}
