using System;
using System.Collections.Generic;
using System.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hue.Framework.Extensions.Attributes;

namespace Hue.Framework.Model.Response {
    [HuePropertyName("lights")]
    public class LightList : HueReturnableBase {
        private List<Light> lights;

        public List<Light> Lights {
            get {
                return lights;
            }
            set {
                lights = value;
            }
        }

        public LightList() {
            lights = new List<Light>();
        }

        public override void SetSelf(JsonObject value) {
            Type type = this.GetType();

            IEnumerable<string> childKeys = value.Keys;

            foreach (string key in childKeys) {
                Light device = new Light(key);
                device.SetSelf(value[key].ToJsonObject());
                Lights.Add(device);
            }
        }
    }
}
