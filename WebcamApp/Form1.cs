using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WebcamApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        bool cameraStarted;
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!cameraStarted)
            {
                cameraStarted = true;
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();
                captureTimer.Start();
                cameraText.Visible = false;
                initTimer.Start();
            }

        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (mainCamera.Image != null) mainCamera.Image.Dispose();
            mainCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cameraStarted = false;
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo filterInfo in filterInfoCollection)
                cboCamera.Items.Add(filterInfo.Name);
            cboCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();

            MomentsPanel.AutoScroll = false;
            MomentsPanel.HorizontalScroll.Enabled = false;
            MomentsPanel.HorizontalScroll.Visible = false;
            MomentsPanel.HorizontalScroll.Maximum = 0;
            MomentsPanel.AutoScroll = true;

            cameraText.SelectionAlignment = HorizontalAlignment.Center;

            btnStart.FlatAppearance.BorderSize = 0;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true) {
                videoCaptureDevice.Stop();
            }
            Directory.GetFiles(@"E:\projects\webcam app\WebcamApp\WebcamApp\Moments\").ToList().ForEach(File.Delete);
        }

        private void captureTimer_Tick(object sender, EventArgs e)
        {
            CreateMoment();
        }
        void CreateMoment() {
            Moment.allMoments[Moment.count] = new Moment();
            Moment.allMoments[Moment.count].myPictureBox.Image = (Bitmap)mainCamera.Image.Clone();
            MomentsPanel.Controls.Add(Moment.allMoments[Moment.count].myControls[0]);
            MomentsPanel.Controls.Add(Moment.allMoments[Moment.count].myControls[1]);
       

            //misc
            MomentsPanel.VerticalScroll.Value = MomentsPanel.VerticalScroll.Maximum;
            mainCamera.Image.Save($"E:/projects/webcam app/WebcamApp/WebcamApp/Moments/{Moment.allMoments[Moment.count].myDate.ToString("HH_mm_ss")}.png");

            Moment.count++;
        }

        private void folderLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", @"E:\projects\webcam app\WebcamApp\WebcamApp\Moments\");
        }

        private void initTimer_Tick(object sender, EventArgs e)
        {
            CreateMoment();
            initTimer.Stop();
        }
    }
}
