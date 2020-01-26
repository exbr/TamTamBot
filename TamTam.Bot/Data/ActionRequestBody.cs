using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class ActionRequestBody
    {
        [JsonProperty("action"), JsonConverter(typeof(EnumMemberConverter))]
        public SenderAction Action { get; set; }

        public override string ToString()
        {
            return $"ActionRequestBody{{ action='{Action}'}}";
        }

    }
}
