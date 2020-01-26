using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class Message
    {
        [JsonProperty("sender")]
        public User Sender { get; set; }

        [JsonProperty("recipient")]
        public Recipient Recipient { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("link")]
        public LinkedMessage Link { get; set; }

        [JsonProperty("body")]
        public MessageBody Body { get; set; }

        [JsonProperty("stat")]
        public MessageStat Stat { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("constructor")]
        public User Constructor { get; set; }

        public override string ToString() => $"Message{{ sender='{Sender}' recipient='{Recipient}' timestamp='{Timestamp}' link='{Link}' "
            + $"body='{Body}' stat='{Stat}' url='{Url}' constructor='{Constructor}'}}";
    }
}
