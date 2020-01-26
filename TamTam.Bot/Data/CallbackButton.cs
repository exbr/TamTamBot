using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class CallbackButton : Button
    {
        [JsonProperty("type"), JsonConverter(typeof(EnumMemberConverter))]
        public override ButtonType Type => ButtonType.Callback;

        [JsonProperty("payload")]
        public string Payload { get; set; }

        [JsonProperty("intent"), JsonConverter(typeof(EnumMemberConverter))]
        public Intent Intent { get; set; }

        public override string ToString() => $"CallbackButton{{{base.ToString()} payload='{Payload}' intent='{Intent}'}}";
    }
}
