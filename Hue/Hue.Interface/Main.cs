﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Hue.Framework;
using Hue.Framework.Exceptions;
using Hue.Framework.Model;
using Hue.Generators;
using Hue.Interface.Properties;

namespace Hue.Gui.Experimental {
    public partial class Main : Form {
        private BridgeController bridgeController;

        protected string bridgeIpAddress {
            get {
                return IpAddressTextBox.Text;
            }
            set {
                IpAddressTextBox.Text = value;
            }
        }

        protected string deviceHash {
            get {
                return DeviceHashTextBox.Text;
            }
            set {
                DeviceHashTextBox.Text = value;
            }
        }

        public Main() {
            InitializeComponent();

            if (string.IsNullOrWhiteSpace(Settings.Default.IpAddress)) {
                throw new Exception("IpAddress setting not found.");
            }
            else {
                bridgeIpAddress = Settings.Default.IpAddress;
            }

            deviceHash = Settings.Default.DeviceHashKey;
            if (string.IsNullOrWhiteSpace(deviceHash)) {
                deviceHash = new UserNameGenerator().GenerateUserName();

                Settings.Default.DeviceHashKey = deviceHash;
                Settings.Default.Save();
            }

            SetBridgeController();
        }

        private void Main_Load(object sender, EventArgs e) { }

        private void SaveBridgeSettingsButton_Click(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(bridgeIpAddress)) {
                Settings.Default.IpAddress = bridgeIpAddress;
            }

            if (!string.IsNullOrWhiteSpace(deviceHash)) {
                Settings.Default.DeviceHashKey = deviceHash;
            }

            Settings.Default.Save();

            SetBridgeController();
        }

        private async void IsBridgeActiveButton_Click(object sender, EventArgs e) {
            bool active = await bridgeController.IsBridgeResponsiveAsync();

            if (active) {
                IsBridgeActiveButton.BackColor = Color.GreenYellow;
            }
            else {
                IsBridgeActiveButton.BackColor = Color.OrangeRed;
            }
        }

        private async void SetAuthenticationButton_Click(object sender, EventArgs e) {
            try {
                Hue.Framework.Model.Response.DeviceRegistration registration = await bridgeController.SetDeviceRegistrationAsync();

                SetAuthenticationButton.BackColor = Color.GreenYellow;
            }
            catch (HueErrorRecievedException ex) {
                //Press the link button.
                if (ex.Error.Type == 101) {
                    SetAuthenticationButton.BackColor = Color.MediumPurple;
                }
            }
        }

        private async void GetBridgeConfigurationButton_Click(object sender, EventArgs e) {
            try {
                Hue.Framework.Model.Response.BridgeConfiguration configuration = await bridgeController.GetBridgeConfigurationAsync();

                GetBridgeConfigurationButton.BackColor = Color.GreenYellow;
            }
            catch (HueErrorRecievedException) {
                GetBridgeConfigurationButton.BackColor = Color.OrangeRed;
            }
        }

        private async void BridgeStateButton_Click(object sender, EventArgs e) {
            try {
                Hue.Framework.Model.Response.BridgeState state = await bridgeController.GetBridgeStateAsync();

                BridgeStateButton.BackColor = Color.GreenYellow;
            }
            catch (HueErrorRecievedException) {
                BridgeStateButton.BackColor = Color.OrangeRed;
            }

        }

        private async void GetLightButton_Click(object sender, EventArgs e) {
            int index = (int)LightNumUpDown.Value;

            try {
                Hue.Framework.Model.Response.Light state = await bridgeController.GetLightStateAsync(index);

                GetLightButton.BackColor = Color.GreenYellow;
            }
            catch (HueErrorRecievedException) {
                GetLightButton.BackColor = Color.OrangeRed;
            }
        }

        private void SetLightButton_Click(object sender, EventArgs e) {
            int index = (int)TargetLightUpDown.Value;

            Hue.Framework.Model.Request.LightState state = new Framework.Model.Request.LightState {
                Hue = (int)HueUpDown.Value,
                Saturation = (int)SaturationUpDown.Value,
                Brightness = (int)BrightnessUpDown.Value,
            };

            try {
                bridgeController.SetLightState(index, state);

                SetLightButton.BackColor = Color.GreenYellow;
            }
            catch (HueErrorRecievedException) {
                SetLightButton.BackColor = Color.OrangeRed;
            }
        }

        private void SetBridgeController() {
            string bridgeUrlBase = "http://" + bridgeIpAddress;

            Bridge bridge = new Bridge(bridgeUrlBase, deviceHash);

            bridgeController = new BridgeController(bridge);
        }
    }
}
