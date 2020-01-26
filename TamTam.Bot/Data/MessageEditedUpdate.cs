using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class MessageEditedUpdate : Update
    {
        [JsonProperty("update_type"), JsonConverter(typeof(EnumMemberConverter))]
        public override UpdateType UpdateType => UpdateType.MessageEdited;

        [JsonProperty("message")]
        public Message Message { get; set; }

        public override string ToString() => $"MessageEditedUpdate{{{base.ToString()} message='{Message}'}}";
    }
}
