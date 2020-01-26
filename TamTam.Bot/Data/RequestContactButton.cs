using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class RequestContactButton : Button
    {
        [JsonProperty("type")]
        public override ButtonType Type => ButtonType.RequestContact;

        public override string ToString() => $"RequestContactButton{{{base.ToString()}}}";
    }
}
