using System;
using System.Collections.Generic;
using System.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hue.Framework.Extensions;
using Hue.Framework.Extensions.Attributes;

namespace Hue.Framework.Model.Response {
    [HuePropertyName("whitelist")]
    public class DeviceList : HueReturnableBase {
        private List<Device> registeredDevices;

        public List<Device> RegisteredDevices {
            get {
                return registeredDevices;
            }
            set {
                registeredDevices = value;
            }
        }

        public DeviceList() {
            registeredDevices = new List<Device>();
        }

        public override void SetSelf(JsonObject value) {
            Type type = this.GetType();

            IEnumerable<string> childKeys = value.Keys;

            foreach (string key in childKeys) {
                Device device = new Device(key);
                device.SetSelf(value[key].ToJsonObject());
                RegisteredDevices.Add(device);
            }
        }
    }
}
