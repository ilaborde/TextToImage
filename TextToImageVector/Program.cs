using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextToImageVector
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitmapimage = new Bitmap(1000, 1000);
            Graphics bitmapGraphics = Graphics.FromImage(bitmapimage);
            bitmapGraphics.Clear(Color.CadetBlue);
            bitmapGraphics.DrawString("ILaborde", new Font("Arial", 200,GraphicsUnit.Pixel), Brushes.Black, new RectangleF(10, 30,1000,1000));
            bitmapimage.Save("Image.png", System.Drawing.Imaging.ImageFormat.Png);

        }
    }
}
