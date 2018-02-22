namespace Learn.Wpf.Core.ViewModels.Chat.Design
{

    /// <summary>
    /// design time data for a ChatListItemViewModel
    /// </summary>
    public class ChatListItemDesignModel : ChatListItemViewModel
    {
        private static ChatListItemDesignModel _instance;

        public static ChatListItemDesignModel Instance => _instance ?? (_instance = new ChatListItemDesignModel());

        public ChatListItemDesignModel()
        {
            Initials = "LM";
            Name = "Luke";
            Message = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam";
            ProfilePictureRGB = "3099c5";
            IsNewContentAvailable = true;
        }
    }
}
