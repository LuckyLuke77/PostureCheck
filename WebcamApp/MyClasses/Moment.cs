using System;
using System.Windows.Forms;
using System.Drawing;

namespace WebcamApp
{
    public class Moment {

    // private: 

        static int momentCount = 0;
        PictureBox myPictureBox = new PictureBox();
        Label myLabel = new Label();
        Control[] myControls = new Control[2];
        DateTime myDate = DateTime.Now;
        void InitControls() {
            // Initialize this Moment's pictureBox
            myPictureBox.Size = new Size(220, 160);
            myPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            myControls[0] = myPictureBox;

            // Initialize this Moment's label
            myLabel.AutoSize = true;
            myLabel.Text = $"Moment: {momentCount + 1}" +
                           "                               " + // heheheha
                           $"Time: {myDate.ToString("HH:mm:ss")}";
            myControls[1] = myLabel;
        }

    // public:

        public Moment() // constructor!
        {
            InitControls();
        }

        // add this Moment to the Moments panel!
        public void AddTo(MainForm callingForm) {
            myPictureBox.Image = (Bitmap)callingForm.mainCamera.Image.Clone(); // save the current camera frame to the object
            callingForm.MomentsPanel.Controls.Add(myControls[0]); // add the image to the Moments panel
            callingForm.MomentsPanel.Controls.Add(myControls[1]); // add the label to the Moments panel
            callingForm.MomentsPanel.VerticalScroll.Value = callingForm.MomentsPanel.VerticalScroll.Maximum; // scroll to the bottom of the moments panel
            callingForm.mainCamera.Image.Save(SaveDirectory() + $"{myDate.ToString("HH_mm_ss")}.png"); // save the image inside the moments folder
            momentCount++;
        }

        // Get the path of the "Moments" folder
        public static String SaveDirectory() {
            String localDir;
            localDir = AppContext.BaseDirectory; // gets the path, inluding \bin\debug\
            int dirLen = localDir.Length;
            localDir = localDir.Substring(0, dirLen - 10); // remove \bin\debug\ from the path
            localDir += @"Moments\"; // add Moments\ to the path
            return localDir;
        }
    }
}
