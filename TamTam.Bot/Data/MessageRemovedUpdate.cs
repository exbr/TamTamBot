using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class MessageRemovedUpdate : Update
    {
        [JsonProperty("update_type"), JsonConverter(typeof(EnumMemberConverter))]
        public override UpdateType UpdateType => UpdateType.MessageRemoved;

        [JsonProperty("message_id")]
        public string MessageId { get; set; }

        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

        [JsonProperty("user_id")]
        public long UserId { get; set; }

        public override string ToString() => $"MessageRemovedUpdate{{{base.ToString()} messageId='{MessageId}' chatId='{ChatId}' userId='{UserId}'}}";
    }
}
