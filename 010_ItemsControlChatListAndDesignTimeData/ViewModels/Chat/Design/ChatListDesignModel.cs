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
                new ChatListItemViewModel{Initials = "DD", Message = "am liber tempor cum soluta nobis eleifend option congue nihil imperdiet doming id quod mazim placerat facer", Name = "Dagobert Duck", ProfilePictureRGB = "3099c5"},
                new ChatListItemViewModel{Initials = "EE", Message = "Duis autem vel eum iriure dolor in hendrerit in vulputate", Name = "Emil Evergreen", ProfilePictureRGB = "aa00d3"},
                new ChatListItemViewModel{Initials = "FF", Message = "Duis autem vel eum iriure dolor in hendrerit in vulputate", Name = "Franz Fouler", ProfilePictureRGB = "44ee32"},
                new ChatListItemViewModel{Initials = "GG", Message = "Duis autem vel eum iriure dolor in hendrerit in vulputate", Name = "Gregory Gut", ProfilePictureRGB = "4578d3"},
                new ChatListItemViewModel{Initials = "HH", Message = "Duis autem vel eum iriure dolor in hendrerit in vulputate", Name = "Heinz Hiller", ProfilePictureRGB = "ccdd66"},
                new ChatListItemViewModel{Initials = "II", Message = "Duis autem vel eum iriure dolor in hendrerit in vulputate", Name = "Ivan Imboden", ProfilePictureRGB = "55ee99"},
                new ChatListItemViewModel{Initials = "JJ", Message = "Duis autem vel eum iriure dolor in hendrerit in vulputate", Name = "Joseph Joller", ProfilePictureRGB = "123456"},
                new ChatListItemViewModel{Initials = "PI", Message = "Duis autem vel eum iriure dolor in hendrerit in vulputate", Name = "Patrick Imboden", ProfilePictureRGB = "abcdef"},
                new ChatListItemViewModel{Initials = "MI", Message = "Duis autem vel eum iriure dolor in hendrerit in vulputate", Name = "Matthias Imboden", ProfilePictureRGB = "fedcba"},
                new ChatListItemViewModel{Initials = "PI", Message = "Duis autem vel eum iriure dolor in hendrerit in vulputate", Name = "Philipp Imboden", ProfilePictureRGB = "99aabb"},
            };
        }
    }
}
