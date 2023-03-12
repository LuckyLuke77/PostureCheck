using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WebcamApp.Properties;

namespace WebcamApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        bool cameraStarted = false;
        bool videoPaused = false;
        //int t = 0;

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (mainCamera.Image != null) mainCamera.Image.Dispose();
            mainCamera.Image = (Bitmap)eventArgs.Frame.Clone();
            //t++;
            //Console.WriteLine($"{t}");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: -add bar at the bottom that has camera/timer interval info (like obs !)
            //       -move camera combo bot to settings form
            //       -move this stuff to the settings/camera classes

            // initialize the list of available cameras
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cboCamera.Items.Add(filterInfo.Name);
            }
            cboCamera.SelectedIndex = 0;

            // initialiaze video capture stuff
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += new NewFrameEventHandler(VideoCaptureDevice_NewFrame);

            // initialize the apprearances of stuff
            btnStart.FlatAppearance.BorderSize = 0;
            btnPause.FlatAppearance.BorderSize = 0;
            btnStop.FlatAppearance.BorderSize = 0;
            MomentsPanel.HorizontalScroll.Maximum = 0;
            MomentsPanel.AutoScroll = true;
            cameraText.SelectionAlignment = HorizontalAlignment.Center;
            mainCamera.Hide();
            Form1_Resize(sender, e);
            Form1_ResizeEnd(sender, e);
            menuStrip1.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());

            //settings
            Camera.SetSizeMode(this);
            captureTimer.Interval = SettingsForm.GetMomentCaptureFrequency();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
            {
                videoCaptureDevice.Stop(); // stop the camera
            }
            Directory.GetFiles(Moment.SaveDirectory()).ToList().ForEach(File.Delete); // delete the contents of the Moments folder
        }

        private void captureTimer_Tick(object sender, EventArgs e)
        {
            Moment newMoment = new Moment();
            newMoment.AddTo(this);
        }

        private void folderLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Moment.SaveDirectory()); // open file explorer inside the Moments folder
        }

        // fancy resizing ratios to make me look smart
        private void Form1_Resize(object sender, EventArgs e)
        {
            int width, height;
            width = Convert.ToInt32(this.Width / 1.5);
            height = Convert.ToInt32(this.Height / 1.5);

            // Resize main camera PictureBox (kinda)
            assistPicBox.Size = new Size(width, height);
            assistPicBox.Left = (this.Width - 800) / 10;
            assistPicBox.Top = (this.Height - 600) / 10 + 70;

            // Resize main camera RichTextBox
            cameraText.Size = new Size(width, 20);
            cameraText.Top = assistPicBox.Top + assistPicBox.Height / 2; // center the camera text at the center of the camera area!
            cameraText.Left = assistPicBox.Left;

            // Reposition buttons
            btnPanel.Left = assistPicBox.Left + assistPicBox.Width / 2 - btnPanel.Width / 2;
            btnPanel.Top = assistPicBox.Top + assistPicBox.Height + 10;

            // Reposition camera select panel
            c_selectPanel.Left = assistPicBox.Left + assistPicBox.Width / 2 - c_selectPanel.Width / 2;
            c_selectPanel.Top = assistPicBox.Top - c_selectPanel.Height - 5;

            // Resize MomentsPanel
            //  position
            MomentsPanel.Top = c_selectPanel.Top;
            MomentsPanel.Left = assistPicBox.Left * 2 + assistPicBox.Width;
            //  size
            MomentsPanel.Width = 250;
            MomentsPanel.Height = btnPanel.Top - c_selectPanel.Top + btnPanel.Height;

            // Reposition show in folder label
            folderLabel.Top = MomentsPanel.Top + MomentsPanel.Height + 5;
            folderLabel.Left = MomentsPanel.Left;

            // Reposition "No moments captured yet" text
            noMomentsText.Top = MomentsPanel.Top + MomentsPanel.Height / 2 - noMomentsText.Height / 2;
            noMomentsText.Left = MomentsPanel.Left + MomentsPanel.Width / 2 - noMomentsText.Width / 2;
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            mainCamera.Hide();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            int width, height;
            width = Convert.ToInt32(this.Width / 1.62); // golden ratio!! :O
            height = Convert.ToInt32(this.Height / 1.62);

            mainCamera.Size = new Size(width, height);
            mainCamera.Left = assistPicBox.Left + (assistPicBox.Width - mainCamera.Width) / 2;
            mainCamera.Top = assistPicBox.Top + (assistPicBox.Height - mainCamera.Height) / 2;
            if (cameraStarted && !videoPaused)
            {
                mainCamera.Show();
            }
        }

        // START CAPTURING button
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!cameraStarted)
            {
                noMomentsText.Hide();
                cameraStarted = true;
                cameraText.Visible = false; // hide the "press start to begin..." text
                videoCaptureDevice.Start(); // start the camera device
                captureTimer.Start();       // start the moments timer
                mainCamera.Show();
            }
        }

        // STOP CAPTURING button
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (cameraStarted)
            {

                if (videoPaused)
                {
                    videoPaused = false;
                    btnPause.Text = "Pause Video";
                }

                cameraText.Text = "Press the \"Start Capturing\" button to begin capturing";
                cameraStarted = false;
                cameraText.Visible = true; // show the "press start to begin..." text
                videoCaptureDevice.Stop(); // stop the camera device
                captureTimer.Stop();       // stop the moments timer
                mainCamera.Hide();
            }
        }
        // PAUSE VIDEO button
        private void btnPause_Click(object sender, EventArgs e)
        {
            if (cameraStarted && !videoPaused)
            {
                videoPaused = true;
                mainCamera.Hide();
                cameraText.Visible = true;
                cameraText.Text = "Video is paused. The camera is still capturing...";
                btnPause.Text = "Resume Video";
            }
            else if (cameraStarted && videoPaused)
            {
                videoPaused = false;
                mainCamera.Show();
                cameraText.Visible = false;
                btnPause.Text = "Pause Video";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cameraText_TextChanged(object sender, EventArgs e)
        {
            cameraText.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void showCaptureFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", Moment.SaveDirectory()); // open file explorer inside the Moments folder
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm mySettings = new SettingsForm(this);
            mySettings.Show();
        }

        // dungeon
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mainCamera_Click(object sender, EventArgs e)
        {

        }
    }
}
