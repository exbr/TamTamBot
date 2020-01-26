using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class ContactAttachmentRequestPayload
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("contactId")]
        public long ContactId { get; set; }

        [JsonProperty("vcfInfo")]
        public string VcfInfo { get; set; }

        [JsonProperty("vcfPhone")]
        public string VcfPhone { get; set; }

        public override string ToString() => $"ContactAttachmentRequestPayload{{ name='{Name}' contactId='{ContactId}' vcfInfo='{VcfInfo}' vcfPhone='{VcfPhone}'}}";
    }
}
