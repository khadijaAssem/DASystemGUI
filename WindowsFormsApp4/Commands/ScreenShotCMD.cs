using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4.Commands
{
    class ScreenShotCMD
    {
        private static int scshot = 0;
        public static void Capture()
        {
            try
            {
                string image = "img" + scshot.ToString() + ".jpg";
                Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                Graphics graphics = Graphics.FromImage(bitmap as Image);
                graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
                bitmap.Save(image);
                scshot++;
            }
            catch(Exception e)
            {
                throw e;
            }
        }
    }
}
