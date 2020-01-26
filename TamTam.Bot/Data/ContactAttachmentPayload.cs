using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class ContactAttachmentPayload
    {
        [JsonProperty("vcfInfo")]
        public string VcfInfo { get; set; }

        [JsonProperty("tamInfo")]
        public User TamInfo { get; set; }

        public override string ToString() => $"ContactAttachmentPayload{{ vcfInfo='{VcfInfo}' tamInfo='{TamInfo}'}}";
    }
}
