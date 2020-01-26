using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class NewMessageLink
    {
        [JsonProperty("type"), JsonConverter(typeof(EnumMemberConverter))]
        public MessageLinkType Type { get; set; }

        [JsonProperty("mid")]
        public string Mid { get; set; }

        public override string ToString() => $"NewMessageLink{{ type='{Type}' mid='{Mid}'}}";
    }
}
