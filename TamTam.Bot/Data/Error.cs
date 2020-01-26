using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class Error
    {
        [JsonProperty("error")]
        public string ErrorName { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        public override string ToString() => $"Error{{ error='{ErrorName}' code='{Code}' message='{Message}'}}";
    }
}
