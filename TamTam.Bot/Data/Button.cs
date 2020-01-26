using System;
using ExLib.TamTam.Bot.Tools;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ExLib.TamTam.Bot.Data
{
    [JsonConverter(typeof(ButtonConverter))]
    public class Button //: IEnumerable
    {
        [JsonProperty("type"), JsonConverter(typeof(EnumMemberConverter))]
        public virtual ButtonType Type { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        public override string ToString() => $"Button{{ text='{Text}'}}";

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    foreach (var prop in GetType().GetProperties())
        //    {
        //        if (prop.CanRead)
        //        {
        //            var propVal = prop.GetValue(this, null);
        //            if (propVal != null)
        //            {
        //                var attr = prop.GetCustomAttribute<JsonPropertyAttribute>();
        //                //writer.WritePropertyName(attr?.PropertyName ?? prop.Name);
        //                //writer.WriteValue(propVal);
        //                yield return $@"""{attr?.PropertyName ?? prop.Name}""=""{propVal}""";
        //            }
        //        }
        //    }
        //}
    }

    public class ButtonConverter : JsonConverter
    {
        public override bool CanWrite => false;
        public override bool CanRead => true;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
            //writer.WriteStartArray();
            //foreach (var prop in value.GetType().GetProperties())
            //{
            //    if (prop.CanRead)
            //    {
            //        var propVal = prop.GetValue(value, null);
            //        if (propVal != null)
            //        {
            //            var attr = prop.GetCustomAttribute<JsonPropertyAttribute>();
            //            writer.WritePropertyName(attr?.PropertyName ?? prop.Name);
            //            writer.WriteValue(propVal);
            //        }
            //    }
            //}
            //writer.WriteEndArray();

            var jo = new JObject();



            foreach (var prop in value.GetType().GetProperties())
            {
                if (prop.CanRead)
                {
                    var propVal = prop.GetValue(value, null);
                    if (propVal != null)
                    {
                        jo.Add(prop.Name, JToken.FromObject(propVal, serializer));
                    }
                }
            }

            jo.WriteTo(writer);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);


            //Enum.TryParse<ButtonType>(jObject.GetValue("type").Value<string>(), out var attachmentType);

            var button = new Button();
            serializer.Populate(jObject.CreateReader(), button);

            switch (button.Type)
            {
                case ButtonType.Callback:
                    button = new CallbackButton();
                    break;
                case ButtonType.Link:
                    button = new LinkButton();
                    break;
                case ButtonType.RequestGeoLocation:
                    button = new RequestGeoLocationButton();
                    break;
                case ButtonType.RequestContact:
                    button = new RequestContactButton();
                    break;
                case ButtonType.Chat:
                    button = new ChatButton();
                    break;
                default:
                    button = new Button();
                    break;
            }


            // Create target object based on JObject
            //T target = Create(objectType, jObject);

            // Populate the object properties
            serializer.Populate(jObject.CreateReader(), button);

            return button;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}
