using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WebcamApp
{
    public class Moment {
        public static int count = 0;
        public static Moment[] allMoments = new Moment[1000];
        public Label myLabel = new Label();
        public PictureBox myPictureBox = new PictureBox();
        public Control[] myControls = new Control[2];
        public DateTime myDate = DateTime.Now;
        public Moment() {
            InitControls();
        }
        void InitControls() {
            InitPictureBox();
            InitLabels();
        }
        void InitPictureBox()
        {
            myPictureBox.Size = new System.Drawing.Size(220, 160);
            myPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            myControls[0] = myPictureBox;
        }
        void InitLabels() {
            myLabel.AutoSize = true;
            myLabel.Text = $"Moment: {count + 1}" +
                           "                               " + // heheheha
                           $"Time: {myDate.ToString("HH:mm:ss")}";
            myControls[1] = myLabel;
        }
    }
}
