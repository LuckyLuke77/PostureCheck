namespace WebcamApp
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sizeModeSelector = new System.Windows.Forms.ComboBox();
            this.stngPanel = new System.Windows.Forms.Panel();
            this.groupBoxGeneral = new System.Windows.Forms.GroupBox();
            this.txtSeconds = new System.Windows.Forms.Label();
            this.inputCustomValue = new System.Windows.Forms.NumericUpDown();
            this.btnCustomValue = new System.Windows.Forms.CheckBox();
            this.comboBoxTimings = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCamera = new System.Windows.Forms.GroupBox();
            this.txtSizeMode = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtCamera = new System.Windows.Forms.Label();
            this.cboCameras = new System.Windows.Forms.ComboBox();
            this.stngPanel.SuspendLayout();
            this.groupBoxGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputCustomValue)).BeginInit();
            this.groupBoxCamera.SuspendLayout();
            this.SuspendLayout();
            // 
            // sizeModeSelector
            // 
            this.sizeModeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeModeSelector.FormattingEnabled = true;
            this.sizeModeSelector.Items.AddRange(new object[] {
            "Stretch Image",
            "Center Image",
            "Zoom"});
            this.sizeModeSelector.Location = new System.Drawing.Point(317, 126);
            this.sizeModeSelector.Name = "sizeModeSelector";
            this.sizeModeSelector.Size = new System.Drawing.Size(361, 28);
            this.sizeModeSelector.TabIndex = 0;
            this.sizeModeSelector.SelectedIndexChanged += new System.EventHandler(this.sizeModeSelector_SelectedIndexChanged);
            // 
            // stngPanel
            // 
            this.stngPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.stngPanel.Controls.Add(this.groupBoxGeneral);
            this.stngPanel.Controls.Add(this.groupBoxCamera);
            this.stngPanel.Location = new System.Drawing.Point(22, 14);
            this.stngPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stngPanel.Name = "stngPanel";
            this.stngPanel.Size = new System.Drawing.Size(826, 501);
            this.stngPanel.TabIndex = 2;
            // 
            // groupBoxGeneral
            // 
            this.groupBoxGeneral.Controls.Add(this.txtSeconds);
            this.groupBoxGeneral.Controls.Add(this.inputCustomValue);
            this.groupBoxGeneral.Controls.Add(this.btnCustomValue);
            this.groupBoxGeneral.Controls.Add(this.comboBoxTimings);
            this.groupBoxGeneral.Controls.Add(this.label1);
            this.groupBoxGeneral.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.groupBoxGeneral.Location = new System.Drawing.Point(18, 22);
            this.groupBoxGeneral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxGeneral.Size = new System.Drawing.Size(777, 217);
            this.groupBoxGeneral.TabIndex = 10;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "General";
            // 
            // txtSeconds
            // 
            this.txtSeconds.AutoSize = true;
            this.txtSeconds.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSeconds.Location = new System.Drawing.Point(606, 120);
            this.txtSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(72, 20);
            this.txtSeconds.TabIndex = 13;
            this.txtSeconds.Text = "Seconds";
            // 
            // inputCustomValue
            // 
            this.inputCustomValue.Location = new System.Drawing.Point(462, 117);
            this.inputCustomValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputCustomValue.Maximum = new decimal(new int[] {
            86400,
            0,
            0,
            0});
            this.inputCustomValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputCustomValue.Name = "inputCustomValue";
            this.inputCustomValue.Size = new System.Drawing.Size(135, 26);
            this.inputCustomValue.TabIndex = 12;
            this.inputCustomValue.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnCustomValue
            // 
            this.btnCustomValue.AutoSize = true;
            this.btnCustomValue.Location = new System.Drawing.Point(316, 122);
            this.btnCustomValue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCustomValue.Name = "btnCustomValue";
            this.btnCustomValue.Size = new System.Drawing.Size(135, 24);
            this.btnCustomValue.TabIndex = 11;
            this.btnCustomValue.Text = "Custom Value";
            this.btnCustomValue.UseVisualStyleBackColor = true;
            this.btnCustomValue.CheckedChanged += new System.EventHandler(this.btnCustomValue_CheckedChanged_1);
            // 
            // comboBoxTimings
            // 
            this.comboBoxTimings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimings.FormattingEnabled = true;
            this.comboBoxTimings.Items.AddRange(new object[] {
            "5 seconds",
            "30 seconds",
            "60 seconds",
            "5 minutes",
            "10 minutes",
            "30 minutes"});
            this.comboBoxTimings.Location = new System.Drawing.Point(316, 65);
            this.comboBoxTimings.Name = "comboBoxTimings";
            this.comboBoxTimings.Size = new System.Drawing.Size(361, 28);
            this.comboBoxTimings.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(86, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Moment Capture Frequency";
            // 
            // groupBoxCamera
            // 
            this.groupBoxCamera.Controls.Add(this.cboCameras);
            this.groupBoxCamera.Controls.Add(this.txtCamera);
            this.groupBoxCamera.Controls.Add(this.sizeModeSelector);
            this.groupBoxCamera.Controls.Add(this.txtSizeMode);
            this.groupBoxCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCamera.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.groupBoxCamera.Location = new System.Drawing.Point(18, 263);
            this.groupBoxCamera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCamera.Name = "groupBoxCamera";
            this.groupBoxCamera.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBoxCamera.Size = new System.Drawing.Size(777, 204);
            this.groupBoxCamera.TabIndex = 9;
            this.groupBoxCamera.TabStop = false;
            this.groupBoxCamera.Text = "Camera";
            // 
            // txtSizeMode
            // 
            this.txtSizeMode.AutoSize = true;
            this.txtSizeMode.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtSizeMode.Location = new System.Drawing.Point(149, 131);
            this.txtSizeMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtSizeMode.Name = "txtSizeMode";
            this.txtSizeMode.Size = new System.Drawing.Size(152, 20);
            this.txtSizeMode.TabIndex = 7;
            this.txtSizeMode.Text = "Camera Size Mode";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnCancel.Location = new System.Drawing.Point(736, 534);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnOk.Location = new System.Drawing.Point(606, 534);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(112, 35);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.stngButtonOk_Click);
            // 
            // txtCamera
            // 
            this.txtCamera.AutoSize = true;
            this.txtCamera.Location = new System.Drawing.Point(233, 61);
            this.txtCamera.Name = "txtCamera";
            this.txtCamera.Size = new System.Drawing.Size(68, 20);
            this.txtCamera.TabIndex = 8;
            this.txtCamera.Text = "Camera";
            this.txtCamera.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboCameras
            // 
            this.cboCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCameras.FormattingEnabled = true;
            this.cboCameras.Location = new System.Drawing.Point(317, 61);
            this.cboCameras.Name = "cboCameras";
            this.cboCameras.Size = new System.Drawing.Size(361, 28);
            this.cboCameras.TabIndex = 9;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(874, 594);
            this.Controls.Add(this.stngPanel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.MaximumSize = new System.Drawing.Size(896, 650);
            this.MinimumSize = new System.Drawing.Size(896, 650);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.stngPanel.ResumeLayout(false);
            this.groupBoxGeneral.ResumeLayout(false);
            this.groupBoxGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputCustomValue)).EndInit();
            this.groupBoxCamera.ResumeLayout(false);
            this.groupBoxCamera.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox sizeModeSelector;
        private System.Windows.Forms.Panel stngPanel;
        private System.Windows.Forms.ComboBox comboBoxTimings;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label txtSizeMode;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxCamera;
        private System.Windows.Forms.CheckBox btnCustomValue;
        private System.Windows.Forms.NumericUpDown inputCustomValue;
        private System.Windows.Forms.Label txtSeconds;
        private System.Windows.Forms.Label txtCamera;
        private System.Windows.Forms.ComboBox cboCameras;
    }
}