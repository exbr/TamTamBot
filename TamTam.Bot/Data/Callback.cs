using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class Callback
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("callback_id")]
        public string CallbackId { get; set; }

        [JsonProperty("payload")]
        public string Payload { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        public override string ToString()
            => $"Callback{{ timestamp='{Timestamp}' callbackId='{CallbackId}' payload='{Payload}' user='{User}'}}";
    }
}
