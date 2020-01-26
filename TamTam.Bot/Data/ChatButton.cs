using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class ChatButton : Button
    {
        [JsonProperty("type"), JsonConverter(typeof(EnumMemberConverter))]
        public override ButtonType Type => ButtonType.Chat;

        [JsonProperty("chat_title")]
        public string ChatTitle { get; set; }

        [JsonProperty("chat_description")]
        public string ChatDescription { get; set; }

        [JsonProperty("start_payload")]
        public string StartPayload { get; set; }

        [JsonProperty("uuid")]
        public int Uuid { get; set; }

        public override string ToString() => $"ChatButton{{{base.ToString()} chatTitle='{ChatTitle}' chatDescription='{ChatDescription}' "
            + $"startPayload='{StartPayload}' uuid='{Uuid}'}}";
    }
}
