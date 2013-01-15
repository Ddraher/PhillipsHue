using System.Json;

namespace Hue.Framework.Model.Response {
    public interface IHueReturnableModel {
        void SetSelf(JsonObject value);
    }
}
