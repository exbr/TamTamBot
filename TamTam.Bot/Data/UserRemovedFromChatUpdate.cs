using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class UserRemovedFromChatUpdate : Update
    {
        [JsonProperty("update_type"), JsonConverter(typeof(EnumMemberConverter))]
        public override UpdateType UpdateType => UpdateType.UserRemoved;

        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

        [JsonProperty("user")]
        public long User { get; set; }

        [JsonProperty("admin_id")]
        public long AdminId { get; set; }

        public override string ToString() => $"UserRemovedFromChatUpdate{{{base.ToString()} chatId='{ChatId}' user='{User}' adminId='{AdminId}'}}";
    }
}
