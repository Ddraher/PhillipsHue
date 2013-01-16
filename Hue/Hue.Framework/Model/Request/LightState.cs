using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hue.Framework.Exceptions;
using Hue.Framework.Extensions.Attributes;

namespace Hue.Framework.Model.Request {
    public class LightState : HuePostableBase {
        private bool? on;
        private int? brightness;
        private int? hue;
        private int? saturation;
        private int? colorTemperature;
        private string alert;
        private string effect;
        private string colorMode;
        //private XYGamut xyGamut;

        [HuePropertyName("on")]
        public bool? On {
            get {
                return on;
            }
            set {
                on = value;
            }
        }

        [HuePropertyName("bri")]
        public int? Brightness {
            get {
                return brightness;
            }
            set {
                brightness = value;
            }
        }

        [HuePropertyName("hue")]
        public int? Hue {
            get {
                return hue;
            }
            set {
                if (value >= 0 && value <= 65535) {
                    hue = value;
                }
                else {
                    throw new HueDataOutOfRangeException();
                }
            }
        }

        [HuePropertyName("sat")]
        public int? Saturation {
            get {
                return saturation;
            }
            set {
                if (value >= 0 && value <= 254) {
                    saturation = value;
                }
                else {
                    throw new HueDataOutOfRangeException();
                }
            }
        }

        [HuePropertyName("ct")]
        public int? ColorTemperature {
            get {
                return colorTemperature;
            }
            set {
                colorTemperature = value;
            }
        }

        [HuePropertyName("alert")]
        public string Alert {
            get {
                return alert;
            }
            set {
                alert = value;
            }
        }

        [HuePropertyName("effect")]
        public string Effect {
            get {
                return effect;
            }
            set {
                effect = value;
            }
        }

        [HuePropertyName("colormode")]
        public string ColorMode {
            get {
                return colorMode;
            }
            set {
                colorMode = value;
            }
        }

        //public XYGamut XYGamut {
        //    get {
        //        return xyGamut;
        //    }
        //    set {
        //        xyGamut = value;
        //    }
        //}
    }
}
