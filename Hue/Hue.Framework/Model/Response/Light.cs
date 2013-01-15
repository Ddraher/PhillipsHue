
using Hue.Framework.Extensions.Attributes;
namespace Hue.Framework.Model.Response {
    public class Light : HueReturnableBase {
        private int id;
        private string type;
        private string name;
        private string modelId;
        private string swVersion;
        private LightState state;

        public int Id {
            get {
                return id;
            }
            set {
                id = value;
            }
        }

        [HuePropertyName("type")]
        public string Type {
            get {
                return type;
            }
            set {
                type = value;
            }
        }

        [HuePropertyName("name")]
        public string Name {
            get {
                return name;
            }
            set {
                name = value;
            }
        }

        [HuePropertyName("modelid")]
        public string ModelId {
            get {
                return modelId;
            }
            set {
                modelId = value;
            }
        }

        [HuePropertyName("swversion")]
        public string SwVersion {
            get {
                return swVersion;
            }
            set {
                swVersion = value;
            }
        }

        public LightState State {
            get {
                return state;
            }
            set {
                state = value;
            }
        }

        public Light() { }

        public Light(int id) {
            this.id = id;
        }

        public Light(string id) {
            this.id = int.MinValue;

            int.TryParse(id, out this.id);
        }
    }
}
