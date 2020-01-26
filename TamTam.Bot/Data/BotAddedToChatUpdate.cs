using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class BotAddedToChatUpdate : Update
    {
        public override UpdateType UpdateType => UpdateType.BotAdded;

        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        public override string ToString() => $"BotAddedToChatUpdate{{{base.ToString()} chatId='{ChatId}' user='{User}'}}";
    }
}
