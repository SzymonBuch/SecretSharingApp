using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SecretSharingApp.Models
{
    public class ImageProperties
    {
        static int counter = 0;

        public string Name { get; }
        public Bitmap Image { get; set; }
        public int Width { get; }
        public int Height { get; }
        public int SharesNumber { get; set; }
        public int MinimalShares { get; set; }
        public int Recons { get; }

        public ImageProperties(Bitmap bitmap, int sharesNumber, int minimalShares)
        {
            Name = "Input Image";
            Image = bitmap;
            SharesNumber = sharesNumber;
            MinimalShares = minimalShares;
            Recons = SharesNumber - MinimalShares + 1;
            Width = Image.Width;
            Height = Image.Height;
        }

        public ImageProperties(Bitmap bitmap)
        {
            Interlocked.Increment(ref counter);
            Name = "Share" + counter;
            Image = bitmap;
        }
    }
}
