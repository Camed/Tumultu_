using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tumultu_.Tools
{
    public class Charting
    {
        private double[] entropy;
        public int Length { get; private set; }
        private const int PIXEL_SIZE = 4;

        public Charting(double[] entropy)
        {
            this.entropy = entropy;
            Length = entropy.Length;
        }
        public Charting(List<double> entropy)
        {
            this.entropy = entropy.ToArray();
            Length = entropy.Count();
        }

        public unsafe Bitmap GetBitmap()
        {
            Bitmap bm = new Bitmap(Length, 300, PixelFormat.Format24bppRgb);

            BitmapData bitmapData = bm.LockBits(new Rectangle(0, 0, bm.Width, bm.Height), ImageLockMode.ReadWrite, bm.PixelFormat);
            int bytesPerPixel = Image.GetPixelFormatSize(bm.PixelFormat) / 8;
            int heightInPixels = bitmapData.Height;
            int widthInBytes = bitmapData.Width * bytesPerPixel;
            byte* ptrFirstPixel = (byte*)bitmapData.Scan0;

            for (int y = 0; y < heightInPixels; y++)
            {
                byte* currentLine = ptrFirstPixel + (y * bitmapData.Stride);
                for (int x = 0, z = 0; x < widthInBytes; x = x + bytesPerPixel, z++)
                {
                    int limit = (int)Math.Round(entropy[z] * 300);
                    if(y < limit)
                    {
                        currentLine[x] = (byte)0x00;
                        currentLine[x + 1] = (byte)0x00;
                        currentLine[x + 2] = (byte)0xFF;
                    }
                    else
                    {
                        currentLine[x] = (byte)0xFF;
                        currentLine[x + 1] = (byte)0xFF;
                        currentLine[x + 2] = (byte)0xFF;
                    }
                    
                }
            }
            bm.UnlockBits(bitmapData);
            bm.RotateFlip(RotateFlipType.Rotate180FlipNone);
            return bm;

        }

    }
}

