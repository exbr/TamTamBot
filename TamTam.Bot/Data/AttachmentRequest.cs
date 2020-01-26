using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class AttachmentRequest
    {
        [JsonProperty("type"), JsonConverter(typeof(EnumMemberConverter))]
        public virtual AttachmentType Type { get; set; }

        public override string ToString()
        {
            return "AttachmentRequest {}";
        }
    }
}
