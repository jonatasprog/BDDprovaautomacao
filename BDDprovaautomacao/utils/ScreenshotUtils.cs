using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace BDDprovaautomacao.utils
{   
    public static class ScreenshotUtils
        {
            private static int count = 1;

            public static String Capture()
            {
                String screenshotName = "Evidence_" + DateUtils.DateWithoutSlashes() + count++ + ".png";
                var bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format32bppArgb);
                var gfxScreenshot = Graphics.FromImage(bmpScreenshot);

                gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);
                bmpScreenshot.Save(Report.screenshotsPath + screenshotName, ImageFormat.Png);
                return "./Screenshots/" + screenshotName;
            }
        }
}