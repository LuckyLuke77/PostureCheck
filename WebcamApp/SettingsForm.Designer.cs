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
            this.cameraModeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sizeModeSelector
            // 
            this.sizeModeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sizeModeSelector.FormattingEnabled = true;
            this.sizeModeSelector.Items.AddRange(new object[] {
            "Normal",
            "Stretch Image",
            "Auto Size",
            "Center Image",
            "Zoom"});
            this.sizeModeSelector.Location = new System.Drawing.Point(291, 82);
            this.sizeModeSelector.Name = "sizeModeSelector";
            this.sizeModeSelector.Size = new System.Drawing.Size(228, 28);
            this.sizeModeSelector.TabIndex = 0;
            this.sizeModeSelector.SelectedIndexChanged += new System.EventHandler(this.sizeModeSelector_SelectedIndexChanged);
            // 
            // cameraModeLabel
            // 
            this.cameraModeLabel.AutoSize = true;
            this.cameraModeLabel.Location = new System.Drawing.Point(144, 85);
            this.cameraModeLabel.Name = "cameraModeLabel";
            this.cameraModeLabel.Size = new System.Drawing.Size(141, 20);
            this.cameraModeLabel.TabIndex = 1;
            this.cameraModeLabel.Text = "Camera size mode";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cameraModeLabel);
            this.Controls.Add(this.sizeModeSelector);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox sizeModeSelector;
        private System.Windows.Forms.Label cameraModeLabel;
    }
}