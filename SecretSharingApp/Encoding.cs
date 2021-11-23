using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSharingApp
{
    public static class Encoding
    {
        public static int[,,] StepV(Bitmap image, int n, int k)
        {
            var w = image.Width;
            var h = image.Height;
            int recons = n - k + 1;
            int counter = 0;
            var imgShare = new int[n, w * h, 32];


            for (int width = 0; width < w; width++)
            {
                for (int height = 0; height < h; height++)
                {
                    var pixel = image.GetPixel(width, height);
                    string PIX = ARGBToString
                        (ColorToString(Convert.ToString(pixel.A, 2)),
                        ColorToString(Convert.ToString(pixel.R, 2)),
                        ColorToString(Convert.ToString(pixel.G, 2)),
                        ColorToString(Convert.ToString(pixel.B, 2)));
                    for (int i = 0; i < 32; i++)
                    {
                        if (PIX[i] == '1')
                        {
                            var rand = RandomPlace(n, recons);
                            for (int j = 0; j < recons; j++)
                            {
                                imgShare[rand[j], counter, i] = 1;
                            }
                        }
                    }
                    counter++;
                }
            }
            return imgShare;
        }

        public static string[,] GenerateSharesPixelsArray(int [,,] imgShare, int n, int w, int h)
        {

            var output = new string[n, w * h];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < w * h; j++)
                {
                    string value = "";
                    for (int k = 0; k < 32; k++)
                    {
                        value += imgShare[i, j, k].ToString();
                    }
                    output[i, j] = value;
                }
            }
            return output;
        }

        public static int[] RandomPlace(int n, int recons)
        {
            var random = new Random();
            var rand = new int[recons];
            for (int i = 0; i < recons; i++)
            {
                var randomInt = random.Next(0, n);
                if (!rand.Any(item => item == randomInt))
                {
                    rand[i] = randomInt;
                }
            }
            return rand;
        }

        private static string ColorToString(string colorValue) 
        {
            while (colorValue.Length<8)
            {
                colorValue = '0' + colorValue;
            }
            return colorValue;
        }

        private static string ARGBToString(string A, string R, string G, string B)
        {
            return A + R + G + B;
        }

        public static IList<int> SplitByteString(string colors)
        {
            return Enumerable.Range(0, colors.Length / 8)
                .Select(i => Convert.ToInt32(colors.Substring(i * 8, 8), 2)).ToList();
        }

        public static bool CharToBool(char bit)
        {
            if (bit == '0')
                return false;
            else
                return true;
        }

        public static char BoolToChar(bool orResult)
        {
            if (orResult)
                return '1';
            else
                return '0';
        }
    }
}
