using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class UploadEndpoint
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        public override string ToString() => $"{nameof(UploadEndpoint)}{{ {nameof(Url)}='{Url}'}}";
    }
}
