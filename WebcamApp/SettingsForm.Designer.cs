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
            this.stngCameraModeLabel = new System.Windows.Forms.Label();
            this.stngPanel = new System.Windows.Forms.Panel();
            this.stngTitleName = new System.Windows.Forms.Label();
            this.stngTimerLabel = new System.Windows.Forms.Label();
            this.comboBoxTimings = new System.Windows.Forms.ComboBox();
            this.stngButtonOk = new System.Windows.Forms.Button();
            this.stngPanel.SuspendLayout();
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
            this.sizeModeSelector.Location = new System.Drawing.Point(202, 44);
            this.sizeModeSelector.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sizeModeSelector.Name = "sizeModeSelector";
            this.sizeModeSelector.Size = new System.Drawing.Size(187, 21);
            this.sizeModeSelector.TabIndex = 0;
            this.sizeModeSelector.SelectedIndexChanged += new System.EventHandler(this.sizeModeSelector_SelectedIndexChanged);
            // 
            // stngCameraModeLabel
            // 
            this.stngCameraModeLabel.AutoSize = true;
            this.stngCameraModeLabel.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.stngCameraModeLabel.Location = new System.Drawing.Point(89, 47);
            this.stngCameraModeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stngCameraModeLabel.Name = "stngCameraModeLabel";
            this.stngCameraModeLabel.Size = new System.Drawing.Size(93, 13);
            this.stngCameraModeLabel.TabIndex = 1;
            this.stngCameraModeLabel.Text = "Camera size mode";
            this.stngCameraModeLabel.Click += new System.EventHandler(this.cameraModeLabel_Click);
            // 
            // stngPanel
            // 
            this.stngPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.stngPanel.Controls.Add(this.stngButtonOk);
            this.stngPanel.Controls.Add(this.stngTitleName);
            this.stngPanel.Controls.Add(this.comboBoxTimings);
            this.stngPanel.Controls.Add(this.stngTimerLabel);
            this.stngPanel.Controls.Add(this.stngCameraModeLabel);
            this.stngPanel.Controls.Add(this.sizeModeSelector);
            this.stngPanel.Location = new System.Drawing.Point(40, 30);
            this.stngPanel.Name = "stngPanel";
            this.stngPanel.Size = new System.Drawing.Size(400, 400);
            this.stngPanel.TabIndex = 2;
            // 
            // stngTitleName
            // 
            this.stngTitleName.AutoSize = true;
            this.stngTitleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stngTitleName.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.stngTitleName.Location = new System.Drawing.Point(150, 0);
            this.stngTitleName.Name = "stngTitleName";
            this.stngTitleName.Size = new System.Drawing.Size(113, 31);
            this.stngTitleName.TabIndex = 2;
            this.stngTitleName.Text = "Settings";
            this.stngTitleName.Click += new System.EventHandler(this.stngTitleName_Click);
            // 
            // stngTimerLabel
            // 
            this.stngTimerLabel.AutoSize = true;
            this.stngTimerLabel.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.stngTimerLabel.Location = new System.Drawing.Point(48, 95);
            this.stngTimerLabel.Name = "stngTimerLabel";
            this.stngTimerLabel.Size = new System.Drawing.Size(134, 13);
            this.stngTimerLabel.TabIndex = 3;
            this.stngTimerLabel.Text = "Moment capture frequency";
            this.stngTimerLabel.Click += new System.EventHandler(this.stngTimerLabel_Click);
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
            "30 minutes",
            "1 hour"});
            this.comboBoxTimings.Location = new System.Drawing.Point(202, 92);
            this.comboBoxTimings.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTimings.Name = "comboBoxTimings";
            this.comboBoxTimings.Size = new System.Drawing.Size(187, 21);
            this.comboBoxTimings.TabIndex = 4;
            this.comboBoxTimings.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimings_SelectedIndexChanged);
            // 
            // stngButtonOk
            // 
            this.stngButtonOk.Location = new System.Drawing.Point(165, 364);
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
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.stngPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.Resize += new System.EventHandler(this.SettingsForm_Resize);
            this.stngPanel.ResumeLayout(false);
            this.stngPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox sizeModeSelector;
        private System.Windows.Forms.Label stngCameraModeLabel;
        private System.Windows.Forms.Panel stngPanel;
        private System.Windows.Forms.Label stngTitleName;
        private System.Windows.Forms.Label stngTimerLabel;
        private System.Windows.Forms.ComboBox comboBoxTimings;
        private System.Windows.Forms.Button stngButtonOk;
    }
}