using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class ShareAttachment : Attachment
    {
        [JsonConverter(typeof(EnumMemberConverter)), JsonProperty("type")]
        public override AttachmentType Type => AttachmentType.Share;

        [JsonProperty("payload")]
        public ShareAttachmentPayload Payload { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        public override string ToString() => $"{"ShareAttachment{" + base.ToString() + " payload='" + Payload}' title='{Title}' "
            + $"description='{Description}' imageUrl='{ImageUrl}'}}";
    }
}
