using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class MessageConstructionRequest : Update
    {
        [JsonProperty("update_type"), JsonConverter(typeof(EnumMemberConverter))]
        public override UpdateType UpdateType => UpdateType.MessageConstructionRequest;

        [JsonProperty("user")]
        public UserWithPhoto User { get; set; }

        [JsonProperty("user_locale")]
        public string UserLocale { get; set; }

        [JsonProperty("session_id")]
        public string SessionId { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("input")]
        public ConstructorInput Input { get; set; }

        public override string ToString() => $"MessageConstructionRequest{{{base.ToString()} user='{User}' userLocale='{UserLocale}' "
            + $"sessionId='{SessionId}' data='{Data}' input='{Input}'}}";
    }
}
