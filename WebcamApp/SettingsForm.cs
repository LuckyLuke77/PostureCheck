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

        private Form1 mainForm = null;
        private readonly String[] imageSizeMode = { "Normal", "StretchImage", "AutoSize", "CenterImage", "Zoom" };
        public SettingsForm(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
        }
        private void SettingsForm_Load(object sender, EventArgs e)
        {
            string currentSizeMode = this.mainForm.mainCamera.SizeMode.ToString();
            sizeModeSelector.SelectedIndex = Array.IndexOf(imageSizeMode, currentSizeMode);
        }

        // change the SizeMode of the mainCamera to the once selected
        // disgusting code, but its the only way I could make it kinda work
        private void sizeModeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sizeModeSelected = imageSizeMode[sizeModeSelector.SelectedIndex];
            if (sizeModeSelected == "Nomral") {
                this.mainForm.mainCamera.SizeMode = PictureBoxSizeMode.Normal;
            } else if (sizeModeSelected == "StretchImage") {
                this.mainForm.mainCamera.SizeMode = PictureBoxSizeMode.StretchImage;
            } else if (sizeModeSelected == "AutoSize") {
                this.mainForm.mainCamera.SizeMode = PictureBoxSizeMode.AutoSize;
            } else if (sizeModeSelected == "CenterImage") {
                this.mainForm.mainCamera.SizeMode = PictureBoxSizeMode.CenterImage;
            } else if (sizeModeSelected == "Zoom") {
                this.mainForm.mainCamera.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }
    }
}