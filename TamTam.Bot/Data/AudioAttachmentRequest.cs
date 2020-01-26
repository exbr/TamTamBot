using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class AudioAttachmentRequest : AttachmentRequest
    {
        public override AttachmentType Type => AttachmentType.Audio;

        [JsonProperty("payload")]
        public UploadedInfo Payload { get; set; }

        public override string ToString()
        {
            return $"AudioAttachmentRequest{{{base.ToString()} payload='{Payload}'}}";
        }
    }
}
