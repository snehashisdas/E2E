using RelevantCodes.ExtentReports;
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace BocadUITestsSolution.Core
{
    public class AIValLibrary
    {
        public static void CaptureBitmapwithFlip(int xStart, int yStart, int width, int bredth, string sBitmapName)
        {
            //Rectangle rect = new Rectangle(386, 4, 280, 21);
            string strBitmapPath;
            //strBitmapPath = @"c:\Test\JPG\" + sBitmapName + ".jpg";
            strBitmapPath = @"D:\Test\BMP\" + sBitmapName + ".bmp";
            Rectangle rect = new Rectangle(xStart, yStart, width, bredth);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            //Thread.Sleep(iMediumwait);
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
            bmp.Save(strBitmapPath, ImageFormat.Jpeg);
            //Thread.Sleep(iMediumwait);
            
        }


        public void CaptureBitmap(int xStart, int yStart, int width, int bredth, string sBitmapName)
        {
            //Rectangle rect = new Rectangle(386, 4, 280, 21);
            string strBitmapPath;
            //strBitmapPath = @"c:\Test\JPG\" + sBitmapName + ".jpg";
            strBitmapPath = @"D:\Test\BMP\ActualImages\" + sBitmapName + ".bmp";
            Rectangle rect = new Rectangle(xStart, yStart, width, bredth);
            Bitmap bmp = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(rect.Left, rect.Top, 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
           // Thread.Sleep(iMediumwait);
            bmp.Save(strBitmapPath, ImageFormat.Jpeg);
           // Thread.Sleep(iMediumwait);
        }


        static float f_CompareBitmaps(string[] args)
        {
            Image DefferenceresultImage;
            float colorPresent = 0;
            float colorNotPresent = 0;
            float percentage;
            string path;



            Bitmap bm1 = (Bitmap)Image.FromFile(args[0]);
            Bitmap bm2 = (Bitmap)Image.FromFile(args[1]);
            path = args[2];




            // Make a difference image.
            int wid = Math.Min(bm1.Width, bm2.Width);
            int hgt = Math.Min(bm1.Height, bm2.Height);
            Bitmap bm3 = new Bitmap(wid, hgt);

            // Create the difference image.
            bool are_identical = true;
            Color eq_color = Color.White;
            Color ne_color = Color.Red;


            for (int x = 0; x < wid; x++)
            {
                for (int y = 0; y < hgt; y++)
                {
                    if (bm1.GetPixel(x, y).Equals(bm2.GetPixel(x, y)))
                    {
                        bm3.SetPixel(x, y, eq_color);
                        colorPresent++;
                    }

                    else
                    {
                        bm3.SetPixel(x, y, ne_color);
                        are_identical = false;
                        colorNotPresent++;
                    }
                }
            }
            percentage = ((colorPresent / (colorPresent + colorNotPresent)) * 100);
            DefferenceresultImage = bm3;
            return percentage;



        }

        public double CompareIMG(string[] args)
        {


            float colorPresent = 0;
            float colorNotPresent = 0;
            float percentage;
            percentage = 0;

            string path;

            Color bm1_color;
            Color bm2_color;

            //Bitmap bm1 = (Bitmap)Image.FromFile(@"C:\TDPN_3_1\BitMaps\TestBitmaps\ActualBitmap_POC3.jpg");
            //Bitmap bm2 = (Bitmap)Image.FromFile(@"C:\TDPN_3_1\BitMaps\TestBitmaps\ExpectedBitmap_POC3.jpg");

            Bitmap bm1 = (Bitmap)Image.FromFile(args[0]);
            Bitmap bm2 = (Bitmap)Image.FromFile(args[1]);



            // Make a difference image.
            int wid = Math.Min(bm1.Width, bm2.Width);
            int hgt = Math.Min(bm1.Height, bm2.Height);
            Bitmap bm4 = new Bitmap(3 * wid + 10, hgt);

            // Create the difference image.
            bool are_identical = true;
            Color eq_color = Color.White;
            Color ne_color = Color.Red;
            Color black_color = Color.Black;
            for (int x = 0; x < wid; x++)
            {
                for (int y = 0; y < hgt; y++)
                {
                    bm1_color = bm1.GetPixel(x, y);
                    bm2_color = bm2.GetPixel(x, y);

                    if (bm1_color.Equals(bm2_color))
                    {
                        bm4.SetPixel(x, y, bm1_color);
                        bm4.SetPixel(x + wid + 5, y, bm2_color);
                        bm4.SetPixel(x + wid + wid + 5, y, eq_color);


                        colorPresent++;
                    }

                    else
                    {
                        bm4.SetPixel(x, y, bm1_color);
                        bm4.SetPixel(x + wid + 5, y, bm2_color);
                        bm4.SetPixel(x + wid + wid + 5, y, ne_color);


                        are_identical = false;
                        colorNotPresent++;
                    }
                }
            }

            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    for (int z = 0; z < hgt; z++)
                    {
                        if (x == 0)
                        {
                            bm4.SetPixel(wid + y, z, black_color);
                        }
                        else
                        {
                            bm4.SetPixel(2 * wid + y, z, black_color);
                        }

                    }
                }
            }
            percentage = ((colorPresent / (colorPresent + colorNotPresent)) * 100);



            //bm4.Save(@"C:\TDPN_3_1\BitMaps\CombinedImage4.bmp");
            bm4.Save(args[2]);







            if (percentage >= 98)
            {
                //Reporting.test.Log(LogStatus.Pass, "Bitmap validation", "Bitmap validation has passedwith " + percentage + "%");
                Reporting.test.Log(LogStatus.Pass, "Bitmaps Referrance", "Bitmap validation has passedwith " + percentage + "%" + Reporting.test.AddScreenCapture(args[2]));

            }
            else
            {
                //Reporting.test.Log(LogStatus.Fail, "Bitmap validation", "Bitmap validation has failed with " + percentage + "%");
                Reporting.test.Log(LogStatus.Fail, "Bitmaps DIfference", "Bitmap validation has failed with " + percentage + "%" + Reporting.test.AddScreenCapture(args[2]));
            }

            return percentage;

        }






    }
}
