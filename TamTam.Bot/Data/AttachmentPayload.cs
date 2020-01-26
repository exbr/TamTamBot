using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class AttachmentPayload
    {
        [JsonProperty("url")] public string Url { get; set; }

        public override string ToString()
        {
            return $"AttachmentPayload{{ url='{Url}'}}";
        }
    }
}
