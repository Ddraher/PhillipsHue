using System;
using System.IO;
using System.Json;
using System.Linq;
using Hue.Framework.Model.Response;

namespace Hue.Framework {
    public class JsonParser {
        private JsonObject jsonMessage;

        public JsonParser(string jsonResponse) {
            jsonMessage = JsonValue.Parse(jsonResponse).ToJsonObject();
        }

        public JsonParser(JsonValue message) {
            jsonMessage = message.ToJsonObject();
        }

        public JsonParser(JsonObject message) {
            jsonMessage = message;
        }

        public JsonParser MoveToFirstChild() {
            jsonMessage = jsonMessage.First().Value.ToJsonObject();

            return this;
        }

        public JsonParser FirstChild() {
            JsonObject jsonObject =  jsonMessage.First().Value.ToJsonObject();

            return new JsonParser(jsonObject);
        }

        public TObject ReadAsObject<TObject>() where TObject : IHueReturnableModel, new() {
            TObject targetObject = new TObject();

            targetObject.SetSelf(jsonMessage);

            return targetObject;
        }

        public bool TryReadAsObject<TObject>(ref TObject targetObject) where TObject : IHueReturnableModel, new() {
            try {
                targetObject.SetSelf(jsonMessage);

                return true;
            }
            catch (Exception) {
                return false;
            }
        }

        public string ReadAsString() {
            using (StringWriter writer = new StringWriter()) {
                jsonMessage.Save(writer, JsonSaveOptions.None);

                return writer.ToString();
            }
        }
    }
}
