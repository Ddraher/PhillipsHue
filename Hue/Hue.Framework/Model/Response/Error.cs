using Hue.Framework.Extensions.Attributes;

namespace Hue.Framework.Model.Response {
    [HuePropertyName("error")]
    public class Error : HueReturnableBase {
        private int type;
        private string address;
        private string description;
        
        [HuePropertyName("type")]
        public int Type {
            get {
                return type;
            }
            set {
                type = value;
            }
        }

        [HuePropertyName("address")]
        public string Address {
            get {
                return address;
            }
            set {
                address = value;
            }
        }

        [HuePropertyName("description")]
        public string Description {
            get {
                return description;
            }
            set {
                description = value;
            }
        }

        public bool HasDataSet() {
            if (!string.IsNullOrWhiteSpace(Address) || !string.IsNullOrWhiteSpace(Description)) {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
