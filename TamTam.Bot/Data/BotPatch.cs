using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class BotPatch
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("commands")]
        public List<BotCommand> Commands { get; set; }

        [JsonProperty("photo")]
        public PhotoAttachmentRequestPayload Photo { get; set; }

        public override string ToString()
            => $"BotPatch{{ name='{Name}' username='{Username}' description='{Description}' commands='{Commands}{'"'} photo='{Photo}'}}";
    }
}
