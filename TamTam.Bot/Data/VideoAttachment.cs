using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class VideoAttachment : Attachment
    {
        [JsonConverter(typeof(EnumMemberConverter)), JsonProperty("type")]
        public override AttachmentType Type => AttachmentType.Video;

        [JsonProperty("payload")]
        public MediaAttachmentPayload Payload { get; set; }

        [JsonProperty("thumbnail")]
        public PhotoAttachmentPayload Thumbnail { get; set; }

        [JsonProperty("width")]
        public int? Width { get; set; }

        [JsonProperty("height")]
        public int? Height { get; set; }

        [JsonProperty("duration")]
        public int? Duration { get; set; }

        public override string ToString() => $"VideoAttachment{{{base.ToString()} payload='{Payload}' thumbnail='{Thumbnail}' width='{Width}' "
            + $"height='{Height}' duration='{Duration}'}}";
    }
}
