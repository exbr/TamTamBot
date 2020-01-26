using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class AnswerOnCallbackQuery : TamTamQuery<SimpleQueryResult>
    {
        private readonly QueryParam<string> _callbackId;

        public AnswerOnCallbackQuery(TamTamClient client, CallbackAnswer callbackAnswer, string callbackId)
            : base(client, "/answers", callbackAnswer, Method.POST)
        {
            _callbackId = new QueryParam<string>("callback_id", callbackId, this).Required();

        }

        public string CallbackId
        {
            get => _callbackId.Value;
            set => _callbackId.Value = value;
        }
    }
}