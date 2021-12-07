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
    public static class Decrypting
    {   
        public static string[,] ListToSharesPixelsArray(List<ImageProperties> imagePropertiesList)
        {
            var sharesPixelsArray = new string[imagePropertiesList.Count, imagePropertiesList[0].Width * imagePropertiesList[0].Height];
            for (int i = 0; i < imagePropertiesList.Count; i++)
            {
                int counter = 0;
                for (int width = 0; width < imagePropertiesList[i].Width; width++)
                {
                    for (int height = 0; height < imagePropertiesList[i].Height; height++)
                    {
                        var pixel = imagePropertiesList[i].Image.GetPixel(width, height);
                        string PIX = HelpFunctions.ARGBToString
                            (HelpFunctions.ColorToString(Convert.ToString(pixel.A, 2)),
                            HelpFunctions.ColorToString(Convert.ToString(pixel.R, 2)),
                            HelpFunctions.ColorToString(Convert.ToString(pixel.G, 2)),
                            HelpFunctions.ColorToString(Convert.ToString(pixel.B, 2)));
                        sharesPixelsArray[i, counter] = PIX;
                        counter++;
                    }
                }
            }
            return sharesPixelsArray;
        }

        public static string[] GenerateDecryptedImagePixelsArray(string[,] sharesPixelsArray, int width, int height)
        {
            string[] decryptedImagePixelsArray = Enumerable.Repeat("00000000000000000000000000000000", width * height).ToArray();
            for (int i = 0; i < sharesPixelsArray.GetLength(0); i++)
            {
                for (int j = 0; j < width * height; j++)
                {
                    var finalString = new StringBuilder(decryptedImagePixelsArray[j]);
                    var imgsArrayString = new StringBuilder(sharesPixelsArray[i, j]);
                    for (int l = 0; l < 32; l++)
                    {
                        finalString[l] = BoolToChar(CharToBool(finalString[l]) || CharToBool(imgsArrayString[l]));
                    }
                    decryptedImagePixelsArray[j] = finalString.ToString();
                }
            }
            return decryptedImagePixelsArray;
        }

        public static Bitmap GenerateDecryptedImage(string[] decryptedImagePixelsArray, int width, int height)
        {
            var counter = 0;
            var decryptedImage = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    var pixelString = HelpFunctions.SplitBitsString(decryptedImagePixelsArray[counter]);
                    var pixel = Color.FromArgb(pixelString[0], pixelString[1], pixelString[2], pixelString[3]);
                    decryptedImage.SetPixel(i, j, pixel);
                    counter++;
                }
            }
            return decryptedImage;
        }

        private static bool CharToBool(char bit)
        {
            if (bit == '0')
                return false;
            else
                return true;
        }

        private static char BoolToChar(bool orResult)
        {
            if (orResult)
                return '1';
            else
                return '0';
        }
    }
}
