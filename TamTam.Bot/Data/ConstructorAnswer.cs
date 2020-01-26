using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class ConstructorAnswer
    {
        [JsonProperty("messages")]
        public List<NewMessageBody> Messages { get; set; }

        [JsonProperty("allow_user_input")]
        public bool AllowUserInput { get; set; }

        [JsonProperty("hint")]
        public string Hint { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("keyboard")]
        public Keyboard Keyboard { get; set; }

        [JsonProperty("placeholder")]
        public string Placeholder { get; set; }

        public override string ToString() => $"ConstructorAnswer{{ messages='{Messages}' allowUserInput='{AllowUserInput}' hint='{Hint}' "
            + $"data='{Data}' keyboard='{Keyboard}' placeholder='{Placeholder}'}}";
    }
}
