using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Wpf.ViewModels.Chat
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
