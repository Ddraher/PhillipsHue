using System;
using Hue.Framework.Extensions.Attributes;

namespace Hue.Framework.Model.Request {
    public class DeviceRegistration : HuePostableBase {
        private string userName;
        private string deviceType;

        [HuePropertyName("username")]
        public string UserName {
            get {
                return userName;
            }
            set {
                userName = value;
            }
        }

        [HuePropertyName("devicetype")]
        public string DeviceType {
            get {
                return deviceType;
            }
            set {
                if (value.Length < 10) {
                    throw new Exception("Device Type must be atleast 10 characters.");
                }
                deviceType = value;
            }
        }

        public DeviceRegistration() {
            userName = string.Empty;
            deviceType = string.Empty;
        }

        public DeviceRegistration(string userName, string deviceType) {
            this.userName = userName;
            this.deviceType = deviceType;
        }
    }
}
