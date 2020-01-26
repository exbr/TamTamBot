using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class BotStartedUpdate : Update
    {
        [JsonProperty("update_type"), JsonConverter(typeof(EnumMemberConverter))]
        public override UpdateType UpdateType => UpdateType.BotStarted;

        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("payload")]
        public string Payload { get; set; }

        [JsonProperty("user_locale")]
        public string UserLocale { get; set; }

        public override string ToString()
            => $"BotStartedUpdate{{{base.ToString()} chatId='{ChatId}' user='{User}' payload='{Payload}' userLocale='{UserLocale}'}}";
    }
}
