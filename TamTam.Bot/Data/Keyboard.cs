using System.Collections.Generic;
using Newtonsoft.Json;

namespace ExLib.TamTam.Bot.Data
{
    public class Keyboard
    {
        [JsonProperty("buttons")]
        public List<List<Button>> Buttons;

        public override string ToString() => $"Keyboard{{ buttons='{Buttons}'}}";
    }
}
