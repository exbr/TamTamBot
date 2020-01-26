using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class MessageConstructedUpdate : Update
    {
        [JsonProperty("update_type"), JsonConverter(typeof(EnumMemberConverter))]
        public override UpdateType UpdateType => UpdateType.MessageConstructed;

        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        [JsonProperty("message")]
        public ConstructedMessage Message { get; set; }

        public override string ToString() => $"MessageConstructedUpdate{{{base.ToString()} sessionId='{SessionId}' message='{Message}'}}";
    }
}
