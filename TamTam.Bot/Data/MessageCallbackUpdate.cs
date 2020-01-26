using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class MessageCallbackUpdate : Update
    {
        [JsonProperty("update_type"), JsonConverter(typeof(EnumMemberConverter))]
        public override UpdateType UpdateType => UpdateType.MessageCallback;

        [JsonProperty("callback")]
        public Callback Callback { get; set; }

        [JsonProperty("message")]
        public Message Message { get; set; }

        [JsonProperty("user_locale")]
        public string UserLocale { get; set; }

        public override string ToString() => $"MessageCallbackUpdate{{{base.ToString()} callback='{Callback}' message='{Message}' userLocale='{UserLocale}'}}";
    }
}
