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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainCamera)).BeginInit();
            this.SuspendLayout();
            // 
            // cboCamera
            // 
            this.cboCamera.FormattingEnabled = true;
            this.cboCamera.Location = new System.Drawing.Point(489, 69);
            this.cboCamera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCamera.Name = "cboCamera";
            this.cboCamera.Size = new System.Drawing.Size(457, 28);
            this.cboCamera.TabIndex = 0;
            // 
            // cameraLabel
            // 
            this.cameraLabel.AutoSize = true;
            this.cameraLabel.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.cameraLabel.Location = new System.Drawing.Point(411, 82);
            this.cameraLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cameraLabel.Name = "cameraLabel";
            this.cameraLabel.Size = new System.Drawing.Size(69, 20);
            this.cameraLabel.TabIndex = 1;
            this.cameraLabel.Text = "Camera:";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnStart.Location = new System.Drawing.Point(612, 932);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(189, 35);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start Capturing";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // captureTimer
            // 
            this.captureTimer.Interval = 5000;
            this.captureTimer.Tick += new System.EventHandler(this.captureTimer_Tick);
            // 
            // mainCamera
            // 
            this.mainCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.mainCamera.Location = new System.Drawing.Point(38, 142);
            this.mainCamera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mainCamera.Name = "mainCamera";
            this.mainCamera.Size = new System.Drawing.Size(1350, 782);
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
            this.MomentsPanel.Location = new System.Drawing.Point(1416, 69);
            this.MomentsPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MomentsPanel.Name = "MomentsPanel";
            this.MomentsPanel.RowCount = 2;
            this.MomentsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MomentsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MomentsPanel.Size = new System.Drawing.Size(405, 900);
            this.MomentsPanel.TabIndex = 11;
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(1563, 985);
            this.folderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(109, 20);
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
            this.cameraText.Location = new System.Drawing.Point(38, 400);
            this.cameraText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cameraText.Name = "cameraText";
            this.cameraText.Size = new System.Drawing.Size(1350, 20);
            this.cameraText.TabIndex = 13;
            this.cameraText.Text = "Press the Start button to begin capturing";
            // 
            // initTimer
            // 
            this.initTimer.Interval = 2000;
            this.initTimer.Tick += new System.EventHandler(this.initTimer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(817, 932);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1898, 944);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cameraText);
            this.Controls.Add(this.folderLabel);
            this.Controls.Add(this.MomentsPanel);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cameraLabel);
            this.Controls.Add(this.cboCamera);
            this.Controls.Add(this.mainCamera);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PostureCheck";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
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
        private System.Windows.Forms.Button button1;
    }
}

