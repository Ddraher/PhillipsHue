
using Hue.Framework.Extensions.Attributes;
namespace Hue.Framework.Model.Response {
    [HuePropertyName("xy")]
    public class XYGamut : HueReturnableBase {
        private double x;
        private double y;

        public override void SetSelf(System.Json.JsonObject value) {
            x = value["0"].ReadAs<double>();
            y = value["1"].ReadAs<double>();
        }
    }
}
