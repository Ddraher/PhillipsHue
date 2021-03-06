﻿using Hue.Framework.Extensions.Attributes;

namespace Hue.Framework.Model.Response {
    [HuePropertyName("state")]
    public class LightState : HueReturnableBase {
        private bool on;
        private bool reachable;
        private int brightness;
        private int hue;
        private int saturation;
        private int colorTemperature;
        private string alert;
        private string effect;
        private string colorMode;
        private XYGamut xyGamut;

        [HuePropertyName("on")]
        public bool On {
            get {
                return on;
            }
            set {
                on = value;
            }
        }

        [HuePropertyName("reachable")]
        public bool Reachable {
            get {
                return reachable;
            }
            set {
                reachable = value;
            }
        }

        [HuePropertyName("bri")]
        public int Brightness {
            get {
                return brightness;
            }
            set {
                brightness = value;
            }
        }

        [HuePropertyName("hue")]
        public int Hue {
            get {
                return hue;
            }
            set {
                hue = value;
            }
        }

        [HuePropertyName("sat")]
        public int Saturation {
            get {
                return saturation;
            }
            set {
                saturation = value;
            }
        }

        [HuePropertyName("ct")]
        public int ColorTemperature {
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

        [HuePropertyName("colorcode")]
        public string ColorMode {
            get {
                return colorMode;
            }
            set {
                colorMode = value;
            }
        }

        public XYGamut XYGamut{
            get {
                return xyGamut;
            }
            set {
                xyGamut = value;
            }
        }
    }
}
