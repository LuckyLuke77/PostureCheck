using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebcamApp
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private MainForm mainForm = null;
        private readonly String[] imageSizeMode = {"StretchImage", "CenterImage", "Zoom" };
        public SettingsForm(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            string currentSizeMode = this.mainForm.mainCamera.SizeMode.ToString();
            sizeModeSelector.SelectedIndex = Array.IndexOf(imageSizeMode, currentSizeMode);
            comboBoxTimings.SelectedIndex = 0;
        }

        // change the SizeMode of the mainCamera to the once selected
        // disgusting code, but its the only way I could make it kinda work
        private void sizeModeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sizeModeSelected = imageSizeMode[sizeModeSelector.SelectedIndex];
            if (sizeModeSelected == "StretchImage") {
                this.mainForm.mainCamera.SizeMode = PictureBoxSizeMode.StretchImage;
            } else if (sizeModeSelected == "CenterImage") {
                this.mainForm.mainCamera.SizeMode = PictureBoxSizeMode.CenterImage;
            } else if (sizeModeSelected == "Zoom") {
                this.mainForm.mainCamera.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
        private void comboBoxTimings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTimings.SelectedIndex == 0) // 5 seconds
            {
                this.mainForm.captureTimer.Interval = 5000;
            } else if (comboBoxTimings.SelectedIndex == 1) // 30 seconds
            {
                this.mainForm.captureTimer.Interval = 30000;
            }
        }

        private void stngButtonOk_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        // the dungeon
        private void SettingsForm_Resize(object sender, EventArgs e)
        {

        }

        private void stngTimerLabel_Click(object sender, EventArgs e)
        {

        }
        private void cameraModeLabel_Click(object sender, EventArgs e)
        {

        }

        private void stngTitleName_Click(object sender, EventArgs e)
        {

        }
    }
}