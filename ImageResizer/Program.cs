using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ImageResizer
{
    class Program
    {

        private static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        static void Main(string[] args)
        {
            List<string> graphics = new List<string>();
            List<string> diffs = new List<string>();
            graphics.Add("Graphics\\Series_1\\");
            graphics.Add("Graphics\\Series_2\\");
            graphics.Add("Graphics\\Series_3\\");
            diffs.Add("Diffs\\Series_1\\");
            diffs.Add("Diffs\\Series_2\\");
            diffs.Add("Diffs\\Series_3\\");

            foreach (var g in graphics)
            {
                for (int i = 1; i <= 40; i++)
                {
                    Image img = Image.FromFile(g + i.ToString() + ".jpg");
                    img = ResizeImage(img, 300, 200);
                    img.Save(g + "out\\" + i.ToString() + ".jpg");
                }
            }
            foreach (var g in diffs)
            {
                for (int i = 1; i <= 40; i++)
                {
                    Image img = Image.FromFile(g + i.ToString() + ".jpg");
                    img = ResizeImage(img, 600, 50);
                    img.Save(g + "out\\" + i.ToString() + ".jpg");
                }
            }

        }
    }
}
