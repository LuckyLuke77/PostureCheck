using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebcamApp.Properties;

namespace WebcamApp
{
    public class Camera {
        static FilterInfoCollection filterInfoCollection;
        static VideoCaptureDevice videoCaptureDevice;
        static private MainForm mainForm;
        static public Bitmap newFrame;
        static public bool initialized;

        static public void InitCameras(MainForm caller)
        {
            mainForm = caller;
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            try {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
                videoCaptureDevice.NewFrame += new NewFrameEventHandler(VideoCaptureDevice_NewFrame);
                mainForm.cameraText.Text =  "Press the \"Start Capturing\" button to begin capturing";
                initialized = true;
            } catch {
                mainForm.cameraText.Text = "Error: Could not find a web camera";
                initialized = false;
            }
        }

        static private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            if (mainForm.mainCamera.Image != null) mainForm.mainCamera.Image.Dispose();
            newFrame = (Bitmap)eventArgs.Frame.Clone();
            mainForm.mainCamera.Image = newFrame;
            //mainForm.mainCamera.Image = (Bitmap)eventArgs.Frame.Clone();
            // (Bitmap)eventArgs.Frame.Clone();
            //t++;
            //Console.WriteLine($"{t}");
        }
        static public void Start()
        {
            if (initialized) {
                videoCaptureDevice.Start(); 
            }
        }

        static public void Stop()
        {
            if (initialized) {
                videoCaptureDevice.Stop(); 
            }
        }

        static public bool IsRunning()
        {
            if (initialized)
            {
                return videoCaptureDevice.IsRunning;
            }
            return false;
        }

        // Called when the settings form is loaded
        // fills the available camera combo box and selects the saved index
        static public void InitSettings(ComboBox cbo) 
        {
            if (initialized) {
                foreach (FilterInfo filterInfo in filterInfoCollection)
                {
                    cbo.Items.Add(filterInfo.Name);
                }
                cbo.SelectedIndex = (int)Settings.Default["SelectedCameraIndex"];
            }         
        }
        static public void SetSizeMode(MainForm mainForm) {
            string savedSizeMode = Settings.Default["CameraSizeMode"].ToString();
            if (savedSizeMode == "Stretch Image")
            {
                mainForm.mainCamera.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else if (savedSizeMode == "Center Image")
            {
                mainForm.mainCamera.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else if (savedSizeMode == "Zoom")
            {
                mainForm.mainCamera.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}
