using SecretSharingApp.Helpers;
using SecretSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretSharingApp
{
    public static class Encrypting
    {
        public static int[,,] GenerateSharesPixelsBitsArray(ImageProperties imageProperties)
        {
            var random = new Random();
            int counter = 0;
            var sharesPixelsBitsArray = new int[imageProperties.SharesNumber, imageProperties.Width * imageProperties.Height, 32];

            for (int width = 0; width < imageProperties.Width; width++)
            {
                for (int height = 0; height < imageProperties.Height; height++)
                {
                    var pixel = imageProperties.Image.GetPixel(width, height);
                    string PIX = HelpFunctions.ARGBToString
                        (HelpFunctions.ColorToString(Convert.ToString(pixel.A, 2)),
                        HelpFunctions.ColorToString(Convert.ToString(pixel.R, 2)),
                        HelpFunctions.ColorToString(Convert.ToString(pixel.G, 2)),
                        HelpFunctions.ColorToString(Convert.ToString(pixel.B, 2)));
                    for (int i = 0; i < 32; i++)
                    {
                        if (PIX[i] == '1')
                        {
                            var rand = RandomPlace(random, imageProperties.SharesNumber, imageProperties.Recons);
                            for (int j = 0; j < imageProperties.Recons; j++)
                            {
                                sharesPixelsBitsArray[rand[j], counter, i] = 1;
                            }
                        }
                    }
                    counter++;
                }
            }
            return sharesPixelsBitsArray;
        }

        public static string[,] GenerateSharesPixelsArray(int [,,] sharesArray, ImageProperties imageProperties)
        {
            var sharesPixelsArray = new string[imageProperties.SharesNumber, imageProperties.Width * imageProperties.Height];
            for (int i = 0; i < imageProperties.SharesNumber; i++)
            {
                for (int j = 0; j < imageProperties.Width * imageProperties.Height; j++)
                {
                    string value = "";
                    for (int k = 0; k < 32; k++)
                    {
                        value += sharesArray[i, j, k].ToString();
                    }
                    sharesPixelsArray[i, j] = value;
                }
            }
            return sharesPixelsArray;
        }

        public static int[] RandomPlace(Random random, int sharesNumber, int recons)
        {
            var rand = new int[recons];
            for (int i = 0; i < recons; i++)
            {
                var randomInt = random.Next(0, sharesNumber);
                if (!rand.Any(item => item == randomInt))
                {
                    rand[i] = randomInt;
                }
            }
            return rand;
        }

        public static Bitmap GenerateBitmap(string[,] sharesPixelsArray, int width, int height, int share)
        {
            int counter = 0;
            var shareImage = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    var ARGBValueList = HelpFunctions.SplitBitsString(sharesPixelsArray[share, counter]);
                    var pixel = Color.FromArgb(ARGBValueList[0], ARGBValueList[1], ARGBValueList[2], ARGBValueList[3]);
                    shareImage.SetPixel(i, j, pixel);
                    counter++;
                }
            }
            return shareImage;
        }
    }
}
