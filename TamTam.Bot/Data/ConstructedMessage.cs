using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class ConstructedMessage
    {
        [JsonProperty("sender")]
        public User Sender { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("link")]
        public LinkedMessage Link { get; set; }

        [JsonProperty("body")]
        public MessageBody Body { get; set; }

        public override string ToString() => $"ConstructedMessage{{ sender='{Sender}' timestamp='{Timestamp}' link='{Link}' body='{Body}'}}";
    }
}
