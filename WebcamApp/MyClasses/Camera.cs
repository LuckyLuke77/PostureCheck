using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[0].MonikerString);
            videoCaptureDevice.NewFrame += new NewFrameEventHandler(VideoCaptureDevice_NewFrame);

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
            if (Found()) {
                videoCaptureDevice.Start(); 
            }
        }

        static public void Stop()
        {
            if (Found()) {
                videoCaptureDevice.Stop(); 
            }
        }

        static public bool IsRunning()
        {
            if (Found())
            {
                return videoCaptureDevice.IsRunning;
            }
            return false;
        }

        // Called when the settings form is loaded
        // fills the available camera combo box and selects the saved index
        static public void InitSettings(ComboBox cbo) 
        {
            if (Found()) {
                foreach (FilterInfo filterInfo in filterInfoCollection)
                {
                    cbo.Items.Add(filterInfo.Name);
                }
                cbo.SelectedIndex = (int)Settings.Default["SelectedCameraIndex"];
            }         
        }

        static public String getActiveCamera() {
            List<String> allCameras = new List<String>();
            if (Found())
            {
                foreach (FilterInfo filterInfo in filterInfoCollection)
                {
                    allCameras.Add(filterInfo.Name);
                }           
                return allCameras[(int)Settings.Default["SelectedCameraIndex"]];
            }
            return null;
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
        static public bool Found() {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (filterInfoCollection.Count == 0) {
                return false;
            }
            return true;
        }
    }
}
