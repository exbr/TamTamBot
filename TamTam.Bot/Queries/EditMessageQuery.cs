using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class EditMessageQuery : TamTamQuery<SimpleQueryResult>
    {
        private readonly QueryParam<string> _messageId;

        public EditMessageQuery(TamTamClient client, NewMessageBody newMessageBody, string messageId)
            : base(client, "/messages", newMessageBody, Method.PUT)
        {
            _messageId = new QueryParam<string>("message_id", messageId, this).Required();
        }


        public string MessageId
        {
            get => _messageId.Value;
            set => _messageId.Value = value;
        }
    }
}
