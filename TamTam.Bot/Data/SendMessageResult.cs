using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class SendMessageResult
    {
        [JsonProperty("message")]
        public Message Message { get; }

        public override string ToString() => $"SendMessageResult{{ message='{Message}'}}";
    }
}
