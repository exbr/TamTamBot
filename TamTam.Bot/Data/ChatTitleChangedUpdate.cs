using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class ChatTitleChangedUpdate : Update
    {
        [JsonProperty("update_type"), JsonConverter(typeof(EnumMemberConverter))]
        public override UpdateType UpdateType => UpdateType.ChatTitleChanged;

        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

        [JsonProperty("user")]
        public User User { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        public override string ToString() => $"ChatTitleChangedUpdate{{{base.ToString()} chatId='{ChatId}' user='{User}' title='{Title}'}}";
    }
}
