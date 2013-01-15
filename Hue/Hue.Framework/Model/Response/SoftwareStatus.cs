using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hue.Framework.Extensions.Attributes;

namespace Hue.Framework.Model.Response {
    [HuePropertyName("description")]
    public class SoftwareStatus : HueReturnableBase {
        private int updateState;
        private string url;
        private string text;
        private bool notify;

        [HuePropertyName("updatestate")]
        public int UpdateState {
            get {
                return updateState;
            }
            set {
                updateState = value;
            }
        }

        [HuePropertyName("url")]
        public string Url {
            get {
                return url;
            }
            set {
                url = value;
            }
        }

        [HuePropertyName("text")]
        public string Text {
            get {
                return text;
            }
            set {
                text = value;
            }
        }

        [HuePropertyName("notify")]
        public bool Notify {
            get {
                return notify;
            }
            set {
                notify = value;
            }
        }
    }
}
