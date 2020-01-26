using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class BotRemovedFromChatUpdate : Update
    {
        public override UpdateType UpdateType => UpdateType.BotRemoved;


        [JsonProperty("chat_id")]
        public long ChatId { get; set; }


        [JsonProperty("user")]
        public User User { get; set; }

        public override string ToString() => $"BotRemovedFromChatUpdate{{{base.ToString()} chatId='{ChatId}' user='{User}'}}";
    }
}
