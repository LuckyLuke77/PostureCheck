﻿using System;
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
        private void btnStart_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
            //enable timer
            captureTimer.Start();
            cameraText.Visible = false;

        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            mainCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
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

            MomentsDir();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true) {
                videoCaptureDevice.Stop();
            }
            Directory.GetFiles(MomentsDir()).ToList().ForEach(File.Delete);
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
            mainCamera.Image.Save(MomentsDir() + $"{Moment.allMoments[Moment.count].myDate.ToString("HH_mm_ss")}.png");

            Moment.count++;
        }

        private void folderLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe", MomentsDir());
        }

        // Get the path of the "Moments" folder
        private String MomentsDir()
        {
            String localDir; 
            localDir = AppContext.BaseDirectory; // gets the path, inluding \bin\debug\
            int dirLen = localDir.Length;
            localDir = localDir.Substring(0, dirLen - 10); // remove \bin\debug\ from the path
            localDir += @"Moments\"; // add Moments\ to the path
            return localDir;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int width, height;
            width = Convert.ToInt32(this.Width / 1.62); // the golden ratio :O
            height = Convert.ToInt32(this.Height / 1.62);
            mainCamera.Size = new Size(width, height);
            cameraText.Size = new Size(width, 20);
            cameraText.Top = mainCamera.Top + mainCamera.Height /2; // center the camera text at the center of the camera area!

            MomentsPanel.Left = mainCamera.Left * 2 + mainCamera.Width;
            //cameraText.Text = this.Width.ToString();
        }

        private void cameraText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
