using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebcamApp.Properties;

namespace WebcamApp
{
    public class Camera {
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
