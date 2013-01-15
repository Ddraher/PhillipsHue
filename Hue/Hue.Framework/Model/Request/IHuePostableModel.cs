using System.Json;

namespace Hue.Framework.Model.Request {
    public interface IHuePostableModel {
        JsonObject CreateJsonObject();
    }
}
