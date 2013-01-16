namespace Hue.Gui.Experimental {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.IsBridgeActiveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SetAuthenticationButton = new System.Windows.Forms.Button();
            this.GetBridgeConfigurationButton = new System.Windows.Forms.Button();
            this.BridgeStateButton = new System.Windows.Forms.Button();
            this.GetLightButton = new System.Windows.Forms.Button();
            this.LightNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.HueUpDown = new System.Windows.Forms.NumericUpDown();
            this.SaturationUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.BrightnessUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.TargetLightUpDown = new System.Windows.Forms.NumericUpDown();
            this.SetLightButton = new System.Windows.Forms.Button();
            this.SaveBridgeSettingsButton = new System.Windows.Forms.Button();
            this.DeviceHashTextBox = new System.Windows.Forms.TextBox();
            this.IpAddressTextBox = new System.Windows.Forms.TextBox();
            this.DeviceHashLabel = new System.Windows.Forms.Label();
            this.IpAddressLabel = new System.Windows.Forms.Label();
            this.BridgeSettingsPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.LightNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetLightUpDown)).BeginInit();
            this.BridgeSettingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // IsBridgeActiveButton
            // 
            this.IsBridgeActiveButton.BackColor = System.Drawing.SystemColors.Info;
            this.IsBridgeActiveButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsBridgeActiveButton.Location = new System.Drawing.Point(57, 126);
            this.IsBridgeActiveButton.Name = "IsBridgeActiveButton";
            this.IsBridgeActiveButton.Size = new System.Drawing.Size(158, 23);
            this.IsBridgeActiveButton.TabIndex = 6;
            this.IsBridgeActiveButton.Text = "Is Bridge Responsive";
            this.IsBridgeActiveButton.UseVisualStyleBackColor = false;
            this.IsBridgeActiveButton.Click += new System.EventHandler(this.IsBridgeActiveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Bridge Controller Methods";
            // 
            // SetAuthenticationButton
            // 
            this.SetAuthenticationButton.BackColor = System.Drawing.SystemColors.Info;
            this.SetAuthenticationButton.Location = new System.Drawing.Point(57, 170);
            this.SetAuthenticationButton.Name = "SetAuthenticationButton";
            this.SetAuthenticationButton.Size = new System.Drawing.Size(158, 23);
            this.SetAuthenticationButton.TabIndex = 9;
            this.SetAuthenticationButton.Text = "Set Authentication";
            this.SetAuthenticationButton.UseVisualStyleBackColor = false;
            this.SetAuthenticationButton.Click += new System.EventHandler(this.SetAuthenticationButton_Click);
            // 
            // GetBridgeConfigurationButton
            // 
            this.GetBridgeConfigurationButton.BackColor = System.Drawing.SystemColors.Info;
            this.GetBridgeConfigurationButton.Location = new System.Drawing.Point(57, 212);
            this.GetBridgeConfigurationButton.Name = "GetBridgeConfigurationButton";
            this.GetBridgeConfigurationButton.Size = new System.Drawing.Size(158, 23);
            this.GetBridgeConfigurationButton.TabIndex = 10;
            this.GetBridgeConfigurationButton.Text = "Get Bridge Config";
            this.GetBridgeConfigurationButton.UseVisualStyleBackColor = false;
            this.GetBridgeConfigurationButton.Click += new System.EventHandler(this.GetBridgeConfigurationButton_Click);
            // 
            // BridgeStateButton
            // 
            this.BridgeStateButton.BackColor = System.Drawing.SystemColors.Info;
            this.BridgeStateButton.Location = new System.Drawing.Point(57, 257);
            this.BridgeStateButton.Name = "BridgeStateButton";
            this.BridgeStateButton.Size = new System.Drawing.Size(158, 23);
            this.BridgeStateButton.TabIndex = 12;
            this.BridgeStateButton.Text = "Get Bridge State";
            this.BridgeStateButton.UseVisualStyleBackColor = false;
            this.BridgeStateButton.Click += new System.EventHandler(this.BridgeStateButton_Click);
            // 
            // GetLightButton
            // 
            this.GetLightButton.BackColor = System.Drawing.SystemColors.Info;
            this.GetLightButton.Location = new System.Drawing.Point(97, 298);
            this.GetLightButton.Name = "GetLightButton";
            this.GetLightButton.Size = new System.Drawing.Size(118, 23);
            this.GetLightButton.TabIndex = 13;
            this.GetLightButton.Text = "Get Light";
            this.GetLightButton.UseVisualStyleBackColor = false;
            this.GetLightButton.Click += new System.EventHandler(this.GetLightButton_Click);
            // 
            // LightNumUpDown
            // 
            this.LightNumUpDown.Location = new System.Drawing.Point(57, 298);
            this.LightNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.LightNumUpDown.Name = "LightNumUpDown";
            this.LightNumUpDown.Size = new System.Drawing.Size(32, 20);
            this.LightNumUpDown.TabIndex = 14;
            this.LightNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // HueUpDown
            // 
            this.HueUpDown.Location = new System.Drawing.Point(92, 14);
            this.HueUpDown.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.HueUpDown.Name = "HueUpDown";
            this.HueUpDown.Size = new System.Drawing.Size(76, 20);
            this.HueUpDown.TabIndex = 15;
            this.HueUpDown.Value = new decimal(new int[] {
            15331,
            0,
            0,
            0});
            // 
            // SaturationUpDown
            // 
            this.SaturationUpDown.Location = new System.Drawing.Point(92, 40);
            this.SaturationUpDown.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.SaturationUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SaturationUpDown.Name = "SaturationUpDown";
            this.SaturationUpDown.Size = new System.Drawing.Size(76, 20);
            this.SaturationUpDown.TabIndex = 16;
            this.SaturationUpDown.Value = new decimal(new int[] {
            121,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Saturation";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BrightnessUpDown);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TargetLightUpDown);
            this.panel1.Controls.Add(this.SetLightButton);
            this.panel1.Controls.Add(this.HueUpDown);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.SaturationUpDown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(412, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 154);
            this.panel1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Brightness";
            // 
            // BrightnessUpDown
            // 
            this.BrightnessUpDown.Location = new System.Drawing.Point(93, 67);
            this.BrightnessUpDown.Maximum = new decimal(new int[] {
            254,
            0,
            0,
            0});
            this.BrightnessUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.BrightnessUpDown.Name = "BrightnessUpDown";
            this.BrightnessUpDown.Size = new System.Drawing.Size(76, 20);
            this.BrightnessUpDown.TabIndex = 23;
            this.BrightnessUpDown.Value = new decimal(new int[] {
            240,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Target Light";
            // 
            // TargetLightUpDown
            // 
            this.TargetLightUpDown.Location = new System.Drawing.Point(92, 93);
            this.TargetLightUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TargetLightUpDown.Name = "TargetLightUpDown";
            this.TargetLightUpDown.Size = new System.Drawing.Size(32, 20);
            this.TargetLightUpDown.TabIndex = 21;
            this.TargetLightUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // SetLightButton
            // 
            this.SetLightButton.BackColor = System.Drawing.SystemColors.Info;
            this.SetLightButton.Location = new System.Drawing.Point(42, 119);
            this.SetLightButton.Name = "SetLightButton";
            this.SetLightButton.Size = new System.Drawing.Size(118, 23);
            this.SetLightButton.TabIndex = 20;
            this.SetLightButton.Text = "Set Light";
            this.SetLightButton.UseVisualStyleBackColor = false;
            this.SetLightButton.Click += new System.EventHandler(this.SetLightButton_Click);
            // 
            // SaveBridgeSettingsButton
            // 
            this.SaveBridgeSettingsButton.Location = new System.Drawing.Point(484, 17);
            this.SaveBridgeSettingsButton.Name = "SaveBridgeSettingsButton";
            this.SaveBridgeSettingsButton.Size = new System.Drawing.Size(135, 23);
            this.SaveBridgeSettingsButton.TabIndex = 2;
            this.SaveBridgeSettingsButton.Text = "Save Bridge Settings";
            this.SaveBridgeSettingsButton.UseVisualStyleBackColor = true;
            this.SaveBridgeSettingsButton.Click += new System.EventHandler(this.SaveBridgeSettingsButton_Click);
            // 
            // DeviceHashTextBox
            // 
            this.DeviceHashTextBox.Location = new System.Drawing.Point(329, 19);
            this.DeviceHashTextBox.Name = "DeviceHashTextBox";
            this.DeviceHashTextBox.Size = new System.Drawing.Size(100, 20);
            this.DeviceHashTextBox.TabIndex = 1;
            // 
            // IpAddressTextBox
            // 
            this.IpAddressTextBox.Location = new System.Drawing.Point(95, 19);
            this.IpAddressTextBox.Name = "IpAddressTextBox";
            this.IpAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.IpAddressTextBox.TabIndex = 0;
            // 
            // DeviceHashLabel
            // 
            this.DeviceHashLabel.AutoSize = true;
            this.DeviceHashLabel.Location = new System.Drawing.Point(256, 22);
            this.DeviceHashLabel.Name = "DeviceHashLabel";
            this.DeviceHashLabel.Size = new System.Drawing.Size(69, 13);
            this.DeviceHashLabel.TabIndex = 4;
            this.DeviceHashLabel.Text = "Device Hash";
            // 
            // IpAddressLabel
            // 
            this.IpAddressLabel.AutoSize = true;
            this.IpAddressLabel.Location = new System.Drawing.Point(13, 22);
            this.IpAddressLabel.Name = "IpAddressLabel";
            this.IpAddressLabel.Size = new System.Drawing.Size(57, 13);
            this.IpAddressLabel.TabIndex = 3;
            this.IpAddressLabel.Text = "Ip Address";
            // 
            // BridgeSettingsPanel
            // 
            this.BridgeSettingsPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BridgeSettingsPanel.Controls.Add(this.IpAddressLabel);
            this.BridgeSettingsPanel.Controls.Add(this.DeviceHashLabel);
            this.BridgeSettingsPanel.Controls.Add(this.IpAddressTextBox);
            this.BridgeSettingsPanel.Controls.Add(this.DeviceHashTextBox);
            this.BridgeSettingsPanel.Controls.Add(this.SaveBridgeSettingsButton);
            this.BridgeSettingsPanel.Location = new System.Drawing.Point(2, 12);
            this.BridgeSettingsPanel.Name = "BridgeSettingsPanel";
            this.BridgeSettingsPanel.Size = new System.Drawing.Size(1194, 46);
            this.BridgeSettingsPanel.TabIndex = 5;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 659);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LightNumUpDown);
            this.Controls.Add(this.GetLightButton);
            this.Controls.Add(this.BridgeStateButton);
            this.Controls.Add(this.GetBridgeConfigurationButton);
            this.Controls.Add(this.SetAuthenticationButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsBridgeActiveButton);
            this.Controls.Add(this.BridgeSettingsPanel);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LightNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TargetLightUpDown)).EndInit();
            this.BridgeSettingsPanel.ResumeLayout(false);
            this.BridgeSettingsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IsBridgeActiveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SetAuthenticationButton;
        private System.Windows.Forms.Button GetBridgeConfigurationButton;
        private System.Windows.Forms.Button BridgeStateButton;
        private System.Windows.Forms.Button GetLightButton;
        private System.Windows.Forms.NumericUpDown LightNumUpDown;
        private System.Windows.Forms.NumericUpDown HueUpDown;
        private System.Windows.Forms.NumericUpDown SaturationUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown TargetLightUpDown;
        private System.Windows.Forms.Button SetLightButton;
        private System.Windows.Forms.Button SaveBridgeSettingsButton;
        private System.Windows.Forms.TextBox DeviceHashTextBox;
        private System.Windows.Forms.TextBox IpAddressTextBox;
        private System.Windows.Forms.Label DeviceHashLabel;
        private System.Windows.Forms.Label IpAddressLabel;
        private System.Windows.Forms.Panel BridgeSettingsPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown BrightnessUpDown;
    }
}

