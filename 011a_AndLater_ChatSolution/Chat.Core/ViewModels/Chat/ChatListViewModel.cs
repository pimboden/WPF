using System.Collections.Generic;

namespace Learn.Wpf.Core.ViewModels.Chat
{
    /// <summary>
    /// A viewmodel for the overview Chatlist
    /// </summary>
    public class ChatListViewModel:BaseViewModel
    {
        /// <summary>
        /// The list of chat items
        /// </summary>
        public List<ChatListItemViewModel> Items { get; set; }

    }
}
