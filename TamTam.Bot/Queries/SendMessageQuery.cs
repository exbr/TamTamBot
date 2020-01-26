using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class SendMessageQuery : TamTamQuery<SendMessageResult>
    {
        private readonly QueryParam<long> _userId;
        private readonly QueryParam<long> _chatId;
        private readonly QueryParam<bool> _disableLinkPreview;

        public SendMessageQuery(TamTamClient client, NewMessageBody newMessageBody)
                : base(client, "/messages", newMessageBody, Method.POST)
        {
            _userId = new QueryParam<long>("user_id", this);
            _chatId = new QueryParam<long>("chat_id", this);
            _disableLinkPreview = new QueryParam<bool>("disable_link_preview", this);
        }

        public long ChatId
        {
            get => _chatId.Value;
            set => _chatId.Value = value;
        }

        public long UserId
        {
            get => _userId.Value;
            set => _userId.Value = value;
        }
        public bool DisableLinkPreview
        {
            get => _disableLinkPreview.Value;
            set => _disableLinkPreview.Value = value;
        }

        public SendMessageQuery SetChatId(long chatId)
        {
            ChatId = chatId;
            return this;
        }

        public SendMessageQuery SetUserId(long userId)
        {
            UserId = userId;
            return this;
        }


    }
}
