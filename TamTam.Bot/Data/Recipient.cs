using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class Recipient
    {
        [JsonProperty("chat_id")]
        public long? ChatId { get; set; }

        [JsonProperty("chat_type"), JsonConverter(typeof(EnumMemberConverter))]
        public ChatType ChatType { get; set; }

        [JsonProperty("user_id")]
        public long? UserId { get; set; }

        public override string ToString() => $"Recipient{{ chatId='{ChatId}' chatType='{ChatType}' userId='{UserId}'}}";
    }
}
