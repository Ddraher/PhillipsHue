using System;
using System.Net.Http;
using System.Threading.Tasks;
using Hue.Framework.Exceptions;
using Hue.Framework.Model;

namespace Hue.Framework {
    public class BridgeController {
        private Bridge targetBridge;

        public BridgeController(Bridge bridge) {
            targetBridge = bridge;
        }

        public async Task<bool> IsBridgeResponsiveAsync() {
            try {
                string result = await HttpHelper.GetAsync(targetBridge.ApiUri).ConfigureAwait(false);

                return true;
            }
            catch (HueUnresponsiveException) {
                return false;
            }
        }

        public async Task<Model.Response.DeviceRegistration> SetDeviceRegistration() {
            Model.Request.DeviceRegistration registrationRequest = new Model.Request.DeviceRegistration {
                DeviceType = targetBridge.DeviceType,
                UserName = targetBridge.DeviceUserName,
            };

            JsonParser requestParser = new JsonParser(registrationRequest.CreateJsonObject());

            string result = await HttpHelper.PostAsync(targetBridge.ApiUri, requestParser.ReadAsString()).ConfigureAwait(false);
            JsonParser responseParser = new JsonParser(result).MoveToFirstChild();

            Model.Response.Error error = responseParser.ReadAsObject<Model.Response.Error>();
            if (error.HasDataSet()) {
                throw new HueErrorRecievedException(error);
            }
            else {
                Model.Response.DeviceRegistration registrationResponse = responseParser.ReadAsObject<Model.Response.DeviceRegistration>();

                return registrationResponse;
            }
        }

        public async Task<Model.Response.BridgeConfiguration> GetBridgeConfiguration() {
            Uri requestUri = new Uri(targetBridge.FullUri + "/config");

            string result = await HttpHelper.GetAsync(requestUri).ConfigureAwait(false);
            JsonParser responseParser = new JsonParser(result);

            Model.Response.Error error = responseParser.ReadAsObject<Model.Response.Error>();
            if (error.HasDataSet()) {
                throw new HueErrorRecievedException(error);
            }
            else {
                Model.Response.BridgeConfiguration configuration = responseParser.ReadAsObject<Model.Response.BridgeConfiguration>();

                return configuration;
            }
        }

        public async Task<Model.Response.BridgeState> GetBridgeState() {
            string result = await HttpHelper.GetAsync(targetBridge.FullUri).ConfigureAwait(false);
            JsonParser responseParser = new JsonParser(result);

            Model.Response.Error error = responseParser.ReadAsObject<Model.Response.Error>();
            if (error.HasDataSet()) {
                throw new HueErrorRecievedException(error);
            }
            else {
                Model.Response.BridgeState state = responseParser.ReadAsObject<Model.Response.BridgeState>();

                return state;
            }
        }

        public async Task<Model.Response.Light> GetLightState(int lightId) {
            Uri requestUri = new Uri(targetBridge.FullUri + "/lights/" + lightId.ToString());

            string result = await HttpHelper.GetAsync(requestUri).ConfigureAwait(false);
            JsonParser responseParser = new JsonParser(result);

            Model.Response.Error error = responseParser.FirstChild().ReadAsObject<Model.Response.Error>();
            if (error.HasDataSet()) {
                throw new HueErrorRecievedException(error);
            }
            else {
                Model.Response.Light light = responseParser.ReadAsObject<Model.Response.Light>();
                light.Id = lightId;

                return light;
            }
        }
    }
}
