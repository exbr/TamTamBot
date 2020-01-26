using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class PhotoAttachmentRequestPayload
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }


        [JsonProperty("photos")]
        public Dictionary<string, PhotoToken> Photos { get; set; }

        public override string ToString() => $"PhotoAttachmentRequestPayload{{ url='{Url}' token='{Token}' photos='{Photos}'}}";
    }
}
