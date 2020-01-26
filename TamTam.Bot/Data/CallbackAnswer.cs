using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class CallbackAnswer
    {
        [JsonProperty("message")]
        public NewMessageBody Message { get; set; }

        [JsonProperty("notification")]
        public string Notification { get; set; }

        public override string ToString() => $"CallbackAnswer{{ message='{Message}' notification='{Notification}'}}";
    }
}
