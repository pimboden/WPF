using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Wpf.ViewModels.Chat.Design
{

    /// <summary>
    /// design time data for a ChatListDesignModel
    /// </summary>
    public class ChatListDesignModel : ChatListViewModel
    {
        private static ChatListDesignModel _instance;

        public static ChatListDesignModel Instance => _instance ?? (_instance = new ChatListDesignModel());

        public ChatListDesignModel()
        {
            Items = new List<ChatListItemViewModel>
            {
                new ChatListItemViewModel{Initials = "AA", Message = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam", Name = "Andres Amstein", ProfilePictureRGB = "ccdd66"},
                new ChatListItemViewModel{Initials = "BB", Message = "Stet clita kasd gubergren, no sea takimata sanctus est", Name = "Bo Broww", ProfilePictureRGB = "ffdd33"},
                new ChatListItemViewModel{Initials = "CC", Message = "Duis autem vel eum iriure dolor in hendrerit in vulputate", Name = "Carl Camambert", ProfilePictureRGB = "4578d3"},
                new ChatListItemViewModel{Initials = "DD", Message = "am liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer", Name = "Dagonert Duck", ProfilePictureRGB = "ddee33"},
            };
        }
    }
}
