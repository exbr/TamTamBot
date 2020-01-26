using ExLib.TamTam.Bot.Client;
using ExLib.TamTam.Bot.Data;

namespace ExLib.TamTam.Bot.Queries
{
    public class ConstructQuery : TamTamQuery<SimpleQueryResult>
    {
        private readonly QueryParam<string> _sessionId;
        public ConstructQuery(TamTamClient client, ConstructorAnswer constructorAnswer, string sessionId)
            : base(client, "/answers/constructor", constructorAnswer, Method.POST)
        {
            _sessionId = new QueryParam<string>("message_id", sessionId, this).Required();
        }

        public string SessionId
        {
            get => _sessionId.Value;
            set => _sessionId.Value = value;
        }
    }
}
