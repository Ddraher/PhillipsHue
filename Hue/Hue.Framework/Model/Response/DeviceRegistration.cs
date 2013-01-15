using Hue.Framework.Extensions.Attributes;

namespace Hue.Framework.Model.Response {
    [HuePropertyName("success")]
    public class DeviceRegistration : HueReturnableBase {
        private string userName;

        [HuePropertyName("username")]
        public string UserName {
            get {
                return userName;
            }
            set {
                userName = value;
            }
        }
    }
}
