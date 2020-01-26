using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class DeleteMessageQuery : TamTamQuery<SimpleQueryResult>
    {
        private readonly QueryParam<string> _messageId;

        public DeleteMessageQuery(TamTamClient client, string messageId)
         : base(client, "/messages", null, Method.DELETE)
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
