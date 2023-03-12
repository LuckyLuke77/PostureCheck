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
            this.stngButtonOk = new System.Windows.Forms.Button();
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
            this.sizeModeSelector.Location = new System.Drawing.Point(211, 39);
            this.sizeModeSelector.Margin = new System.Windows.Forms.Padding(2);
            this.sizeModeSelector.Name = "sizeModeSelector";
            this.sizeModeSelector.Size = new System.Drawing.Size(242, 21);
            this.sizeModeSelector.TabIndex = 0;
            this.sizeModeSelector.SelectedIndexChanged += new System.EventHandler(this.sizeModeSelector_SelectedIndexChanged);
            // 
            // stngPanel
            // 
            this.stngPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.stngPanel.Controls.Add(this.groupBoxGeneral);
            this.stngPanel.Controls.Add(this.groupBoxCamera);
            this.stngPanel.Controls.Add(this.btnCancel);
            this.stngPanel.Controls.Add(this.stngButtonOk);
            this.stngPanel.Location = new System.Drawing.Point(21, 22);
            this.stngPanel.Name = "stngPanel";
            this.stngPanel.Size = new System.Drawing.Size(551, 336);
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
            this.groupBoxGeneral.Location = new System.Drawing.Point(12, 14);
            this.groupBoxGeneral.Name = "groupBoxGeneral";
            this.groupBoxGeneral.Size = new System.Drawing.Size(518, 141);
            this.groupBoxGeneral.TabIndex = 10;
            this.groupBoxGeneral.TabStop = false;
            this.groupBoxGeneral.Text = "General";
            // 
            // txtSeconds
            // 
            this.txtSeconds.AutoSize = true;
            this.txtSeconds.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSeconds.Location = new System.Drawing.Point(404, 78);
            this.txtSeconds.Name = "txtSeconds";
            this.txtSeconds.Size = new System.Drawing.Size(49, 13);
            this.txtSeconds.TabIndex = 13;
            this.txtSeconds.Text = "Seconds";
            // 
            // inputCustomValue
            // 
            this.inputCustomValue.Location = new System.Drawing.Point(308, 76);
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
            this.inputCustomValue.Size = new System.Drawing.Size(90, 20);
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
            this.btnCustomValue.Location = new System.Drawing.Point(211, 79);
            this.btnCustomValue.Name = "btnCustomValue";
            this.btnCustomValue.Size = new System.Drawing.Size(91, 17);
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
            this.comboBoxTimings.Location = new System.Drawing.Point(211, 42);
            this.comboBoxTimings.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTimings.Name = "comboBoxTimings";
            this.comboBoxTimings.Size = new System.Drawing.Size(242, 21);
            this.comboBoxTimings.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Location = new System.Drawing.Point(57, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Moment Capture Frequency";
            // 
            // groupBoxCamera
            // 
            this.groupBoxCamera.Controls.Add(this.sizeModeSelector);
            this.groupBoxCamera.Controls.Add(this.txtSizeMode);
            this.groupBoxCamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxCamera.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.groupBoxCamera.Location = new System.Drawing.Point(12, 171);
            this.groupBoxCamera.Name = "groupBoxCamera";
            this.groupBoxCamera.Size = new System.Drawing.Size(518, 100);
            this.groupBoxCamera.TabIndex = 9;
            this.groupBoxCamera.TabStop = false;
            this.groupBoxCamera.Text = "Camera";
            // 
            // txtSizeMode
            // 
            this.txtSizeMode.AutoSize = true;
            this.txtSizeMode.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.txtSizeMode.Location = new System.Drawing.Point(99, 42);
            this.txtSizeMode.Name = "txtSizeMode";
            this.txtSizeMode.Size = new System.Drawing.Size(96, 13);
            this.txtSizeMode.TabIndex = 7;
            this.txtSizeMode.Text = "Camera Size Mode";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(440, 291);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // stngButtonOk
            // 
            this.stngButtonOk.Location = new System.Drawing.Point(359, 291);
            this.stngButtonOk.Name = "stngButtonOk";
            this.stngButtonOk.Size = new System.Drawing.Size(75, 23);
            this.stngButtonOk.TabIndex = 5;
            this.stngButtonOk.Text = "OK";
            this.stngButtonOk.UseVisualStyleBackColor = true;
            this.stngButtonOk.Click += new System.EventHandler(this.stngButtonOk_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(589, 382);
            this.Controls.Add(this.stngPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(605, 421);
            this.MinimumSize = new System.Drawing.Size(605, 421);
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
        private System.Windows.Forms.Button stngButtonOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label txtSizeMode;
        private System.Windows.Forms.GroupBox groupBoxGeneral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxCamera;
        private System.Windows.Forms.CheckBox btnCustomValue;
        private System.Windows.Forms.NumericUpDown inputCustomValue;
        private System.Windows.Forms.Label txtSeconds;
    }
}