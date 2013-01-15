
namespace Hue.Framework.Model.Response {
    public class BridgeState : HueReturnableBase {
        private LightList lights;
        private BridgeConfiguration bridgeConifuration;

        public LightList Lights {
            get {
                return lights;
            }
            set {
                lights = value;
            }
        }

        public BridgeConfiguration BridgeConifuration {
            get {
                return bridgeConifuration;
            }
            set {
                bridgeConifuration = value;
            }
        }
    }
}
