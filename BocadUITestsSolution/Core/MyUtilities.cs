using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BocadAPITestsSolution.Core
{
    public class MyUtilities
    {
        public static void DelayFor(int milliSec)
        {

            Thread.Sleep(milliSec);

        }

        public static void WaitTime(int milliseconds)
        {
            Task.Delay(milliseconds).Wait();
        }

        public static void CaptureScreen(String fileName)
        {

            Bitmap printscreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(printscreen as System.Drawing.Image);
            graphics.CopyFromScreen(0, 0, 0, 0, printscreen.Size);
            FileInfo fInfo = new FileInfo(fileName);
            Directory.CreateDirectory(fInfo.DirectoryName);
            printscreen.Save(fInfo.FullName);
        }

    }
}
