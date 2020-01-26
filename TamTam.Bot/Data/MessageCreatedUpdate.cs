using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class MessageCreatedUpdate : Update
    {
        [JsonProperty("update_type"), JsonConverter(typeof(EnumMemberConverter))]

        public override UpdateType UpdateType => UpdateType.MessageCreated;

        [JsonProperty("message")]
        public Message Message { get; set; }

        public override string ToString() => $"MessageCreatedUpdate{{{base.ToString()} message='{Message}'}}";
    }
}
