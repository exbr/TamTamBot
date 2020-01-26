using System.Collections.Generic;
using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class GetMessagesQuery : TamTamQuery<MessageList>
    {
        private readonly QueryParam<long> _chatId;
        private readonly QueryParam<List<string>> _messageIds;
        private readonly QueryParam<long> _from;
        private readonly QueryParam<long> _to;
        private readonly QueryParam<int> _count;

        public GetMessagesQuery(TamTamClient tamTamClient)
            : base(tamTamClient, "/messages", null, Method.GET)
        {
            _chatId = new QueryParam<long>("chat_id", this);
            _messageIds = new QueryParam<List<string>>("message_ids", this);
            _from = new QueryParam<long>("from", this);
            _to = new QueryParam<long>("to", this);
            _count = new QueryParam<int>("count", this);
        }

        public long ChatId
        {
            get => _chatId.Value;
            set => _chatId.Value = value;
        }
        public List<string> MessageIds
        {
            get => _messageIds.Value;
            set => _messageIds.Value = value;
        }
        public long From
        {
            get => _from.Value;
            set => _from.Value = value;
        }
        public long To
        {
            get => _to.Value;
            set => _to.Value = value;
        }
        public int Count
        {
            get => _count.Value;
            set => _count.Value = value;
        }
    }
}
