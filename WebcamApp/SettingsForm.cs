using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebcamApp.Properties;

namespace WebcamApp
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private MainForm mainForm = null;
        private readonly String[] cameraSizeMode = {"StretchImage", "CenterImage", "Zoom" };
        public SettingsForm(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            string currentSizeMode = mainForm.mainCamera.SizeMode.ToString(); // Gets the active camera SizeMode
            sizeModeSelector.SelectedIndex = Array.IndexOf(cameraSizeMode, currentSizeMode); // Finds the index of the aforementioned camera SizeMode inside the cameraSizeMode array
            //comboBoxTimings.SelectedIndex = 0;

            // Moment Capture Frequency button shenanigans
            btnCustomValue.Checked = (bool)Settings.Default["CustomValueButton"];
            inputCustomValue.Enabled = (bool)Settings.Default["CustomValueButton"];
            comboBoxTimings.Enabled = !(bool)Settings.Default["CustomValueButton"];
            inputCustomValue.Value = (int)Settings.Default["CustomMomentCaptureFrequency"];
            comboBoxTimings.SelectedIndex = (int)Settings.Default["MomentCaptureFrequencyIndex"];

            // selected camera stuff
            Camera.InitSettings(cboCameras);

            //button apearance
            btnCancel.FlatAppearance.BorderSize = 0;
            btnOk.FlatAppearance.BorderSize = 0;
        }

        // change the SizeMode of the mainCamera to the once selected
        // disgusting code, but its the only way I could make it kinda work
        private void sizeModeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sizeModeSelected = cameraSizeMode[sizeModeSelector.SelectedIndex];
            if (sizeModeSelected == "StretchImage") {
                this.mainForm.mainCamera.SizeMode = PictureBoxSizeMode.StretchImage;
            } else if (sizeModeSelected == "CenterImage") {
                this.mainForm.mainCamera.SizeMode = PictureBoxSizeMode.CenterImage;
            } else if (sizeModeSelected == "Zoom") {
                this.mainForm.mainCamera.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void stngButtonOk_Click(object sender, EventArgs e)
        {
            Settings.Default["CameraSizeMode"] = sizeModeSelector.SelectedItem.ToString(); // save the camera size mode
            Settings.Default["CustomMomentCaptureFrequency"] = (int)inputCustomValue.Value; // save the custom moment capture frequency
            Settings.Default["CustomValueButton"] = btnCustomValue.Checked; // save the custom moment capture frequency button state
            Settings.Default["MomentCaptureFrequencyIndex"] = comboBoxTimings.SelectedIndex;
            Settings.Default.Save();
            mainForm.captureTimer.Interval = GetMomentCaptureFrequency();
            this.Close();
        }
        public static int GetMomentCaptureFrequency()
        {
            if ((bool)Settings.Default["CustomValueButton"])
            {
                return (int)Settings.Default["CustomMomentCaptureFrequency"] * 1000; // interval is in milliseconds, and the input is in seconds, so i mutluply by 1000
            }
            else
            {
                if ((int)Settings.Default["MomentCaptureFrequencyIndex"] == 0) { // 5 seconds
                    return 5000;
                } else if ((int)Settings.Default["MomentCaptureFrequencyIndex"] == 1) { // 30 seconds
                    return 30000;
                } else if ((int)Settings.Default["MomentCaptureFrequencyIndex"] == 2) { // 60 seconds
                    return 60000;
                } else if ((int)Settings.Default["MomentCaptureFrequencyIndex"] == 3) { // 5 min
                    return 300000;
                } else if ((int)Settings.Default["MomentCaptureFrequencyIndex"] == 4) { // 10 min
                    return 600000;
                } else { // 30 min
                    return 1800000;
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCustomValue_CheckedChanged_1(object sender, EventArgs e)
        {
            inputCustomValue.Enabled = !inputCustomValue.Enabled;
            comboBoxTimings.Enabled = !comboBoxTimings.Enabled;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}