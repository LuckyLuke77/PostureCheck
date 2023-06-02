using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebcamApp
{
    public class MyColorTable : System.Windows.Forms.ProfessionalColorTable // Tooltrip coloring stuff
    {
        public override Color MenuItemPressedGradientBegin
        {
            get
            {
                return Color.Blue;
            }
        }

        public override Color MenuItemPressedGradientEnd
        {
            get
            {
                return Color.Blue;
            }
        }

        public override Color MenuItemBorder
        {
            get
            {
                return Color.Blue;
            }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get
            {
                return Color.Blue;
            }
        }

        public override Color MenuItemSelectedGradientEnd
        {
            get
            {
                return Color.Blue;
            }
        }

        public override Color MenuItemSelected
        {
            get
            {
                return Color.Blue;
            }
        }

        public override Color ToolStripDropDownBackground
        {
            get
            {
                return Color.FromArgb(76, 76, 76);
            }
        }

        public override Color ImageMarginGradientBegin
        {
            get
            {
                return Color.FromArgb(76, 76, 76);
            }
        }
        public override Color ImageMarginGradientEnd
        {
            get
            {
                return Color.FromArgb(76, 76, 76);
            }
        }
        public override Color ImageMarginGradientMiddle
        {
            get
            {
                return Color.FromArgb(76, 76, 76);
            }
        }
    }
}
