using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ExLib.TamTam.Bot.Data
{

    [JsonConverter(typeof(UpdateConverter))]
    public class Update
    {
        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("update_type")]
        public virtual UpdateType UpdateType { get; set; }

        public override string ToString() => $"Update{{ timestamp='{Timestamp}'}}";
    }

    public class UpdateConverter : JsonConverter
    {
        public override bool CanRead => true;
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var jObject = JObject.Load(reader);
            //var attachmentType = jObject.GetValue("type").Value<string>();
            var update = new Update();
            serializer.Populate(jObject.CreateReader(), update);

            switch (update.UpdateType)
            {
                case UpdateType.MessageCreated:
                    update = new MessageCreatedUpdate();
                    break;
                case UpdateType.BotAdded:
                    update = new BotAddedToChatUpdate();
                    break;
                case UpdateType.BotRemoved:
                    update = new BotRemovedFromChatUpdate();
                    break;
                case UpdateType.BotStarted:
                    update = new BotStartedUpdate();
                    break;
                case UpdateType.ChatTitleChanged:
                    update = new ChatTitleChangedUpdate();
                    break;
                case UpdateType.MessageCallback:
                    update = new MessageCallbackUpdate();
                    break;
                case UpdateType.MessageEdited:
                    update = new MessageEditedUpdate();
                    break;
                case UpdateType.MessageRemoved:
                    update = new MessageRemovedUpdate();
                    break;
                case UpdateType.UserAdded:
                    update = new UserAddedToChatUpdate();
                    break;
                case UpdateType.UserRemoved:
                    update = new UserRemovedFromChatUpdate();
                    break;
                case UpdateType.MessageConstructionRequest:
                    update = new MessageConstructionRequest();
                    break;
                case UpdateType.MessageConstructed:
                    update = new MessageConstructedUpdate();
                    break;
                case UpdateType.MessageChatCreated:
                    update = new MessageChatCreatedUpdate();
                    break;
            }

            serializer.Populate(jObject.CreateReader(), update);

            return update;
        }

        public override bool CanConvert(Type objectType)
        {
            return true;
        }


    }
}
