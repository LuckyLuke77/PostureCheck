namespace WebcamApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.cboCamera = new System.Windows.Forms.ComboBox();
            this.cameraLabel = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.captureTimer = new System.Windows.Forms.Timer(this.components);
            this.mainCamera = new System.Windows.Forms.PictureBox();
            this.serviceController1 = new System.ServiceProcess.ServiceController();
            this.MomentsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.folderLabel = new System.Windows.Forms.LinkLabel();
            this.cameraText = new System.Windows.Forms.RichTextBox();
            this.initTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCamera
            // 
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(326, 45);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(306, 21);
            this.cboCamera.TabIndex = 0;
            // 
            // cameraLabel
            // 
            this.cameraLabel.AutoSize = true;
            this.cameraLabel.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.cameraLabel.Location = new System.Drawing.Point(274, 53);
            this.cameraLabel.Name = "cameraLabel";
            this.cameraLabel.Size = new System.Drawing.Size(46, 13);
            this.cameraLabel.TabIndex = 1;
            this.cameraLabel.Text = "Camera:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnStart.Location = new System.Drawing.Point(408, 606);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(126, 23);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Capturing";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // captureTimer
            // 
            this.captureTimer.Interval = 2000;
            this.captureTimer.Tick += new System.EventHandler(this.captureTimer_Tick);
            // 
            // mainCamera
            // 
            this.mainCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.mainCamera.Location = new System.Drawing.Point(25, 92);
            this.mainCamera.Name = "mainCamera";
            this.mainCamera.Size = new System.Drawing.Size(900, 508);
            this.mainCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainCamera.TabIndex = 2;
            this.mainCamera.TabStop = false;
            // 
            // MomentsPanel
            // 
            this.MomentsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.MomentsPanel.ColumnCount = 1;
            this.MomentsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MomentsPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.MomentsPanel.Location = new System.Drawing.Point(944, 45);
            this.MomentsPanel.Name = "MomentsPanel";
            this.MomentsPanel.RowCount = 2;
            this.MomentsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MomentsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MomentsPanel.Size = new System.Drawing.Size(270, 628);
            this.MomentsPanel.TabIndex = 11;
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(1048, 676);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(74, 13);
            this.folderLabel.TabIndex = 12;
            this.folderLabel.TabStop = true;
            this.folderLabel.Text = "Show in folder";
            this.folderLabel.VisitedLinkColor = System.Drawing.Color.Blue;
            this.folderLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.folderLabel_LinkClicked);
            // 
            // cameraText
            // 
            this.cameraText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.cameraText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cameraText.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.cameraText.Location = new System.Drawing.Point(25, 344);
            this.cameraText.Name = "cameraText";
            this.cameraText.Size = new System.Drawing.Size(900, 256);
            this.cameraText.TabIndex = 13;
            this.cameraText.Text = "Press the Start button to begin capturing";
            // 
            // initTimer
            // 
            this.initTimer.Interval = 2000;
            this.initTimer.Tick += new System.EventHandler(this.initTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1237, 792);
            this.Controls.Add(this.cameraText);
            this.Controls.Add(this.folderLabel);
            this.Controls.Add(this.MomentsPanel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cameraLabel);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.mainCamera);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostureCheck";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainCamera)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboCamera;
        private System.Windows.Forms.Label cameraLabel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer captureTimer;
        private System.Windows.Forms.PictureBox mainCamera;
        private System.ServiceProcess.ServiceController serviceController1;
        private System.Windows.Forms.TableLayoutPanel MomentsPanel;
        private System.Windows.Forms.LinkLabel folderLabel;
        private System.Windows.Forms.RichTextBox cameraText;
        private System.Windows.Forms.Timer initTimer;
    }
}

