using SecretSharingApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretSharingApp.Views
{
    public partial class frmSecretEncrypting : Form
    {
        List<ImageProperties> sharesImagesPropertiesList = new List<ImageProperties>();
        public frmSecretEncrypting()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            var MainForm = new frmMainSecretSharing();
            MainForm.ShowDialog();
            this.Close();
        }


        private void btnUpload_Click(object sender, EventArgs e)
        {
            var ofile = new OpenFileDialog();
            // ofile.Filter = "Image File (*.bmp)...
            if(DialogResult.OK == ofile.ShowDialog())
            {
                var inputImage = new Bitmap(ofile.FileName);
                this.picInput.Image = inputImage;

                //int width = inputImage.Width;
                //int height = inputImage.Height;

                //var firstShare = new Bitmap(width, height);
                //var secondShare = new Bitmap(width, height);
                //var thirdShare = new Bitmap(width, height);
                //var fourthShare = new Bitmap(width, height);

                

                //var finalImage = new Bitmap(ofile.FileName);


                //int n = 4;
                //int k = 3;
                //int recon = n - k + 1;

                //int counter = 0;

                //var result = Encrypting.StepV(inputImage, n, k);

                //var testArray = new string[4];
                //for (int j = 0; j < 4; j++)
                //{
                //    string test = "";
                //    for (int i = 0; i < 32; i++)
                //    {
                //        test += result[j, 0, i];
                //    }
                //    testArray[j] = test;
                //}


                //var imgsArray = Encrypting.GenerateSharesPixelsArray(result, n, width, height);


                //for (int i = 0; i < width; i++)
                //{
                //    for (int j = 0; j < height; j++)
                //    {
                //        var smh = Encrypting.SplitByteString(imgsArray[0, counter]);
                //        var pixel = Color.FromArgb(smh[0], smh[1], smh[2], smh[3]);
                //        firstShare.SetPixel(i, j, pixel);
                //        var smh1 = Encrypting.SplitByteString(imgsArray[1, counter]);
                //        var pixel1 = Color.FromArgb(smh1[0], smh1[1], smh1[2], smh1[3]);
                //        secondShare.SetPixel(i, j, pixel1);
                //        var smh2 = Encrypting.SplitByteString(imgsArray[2, counter]);
                //        var pixel2 = Color.FromArgb(smh2[0], smh2[1], smh2[2], smh2[3]);
                //        thirdShare.SetPixel(i, j, pixel2);
                //        var smh3 = Encrypting.SplitByteString(imgsArray[3, counter]);
                //        var pixel3 = Color.FromArgb(smh3[0], smh3[1], smh3[2], smh3[3]);
                //        fourthShare.SetPixel(i, j, pixel3);
                //        counter++;
                //    }
                //}

                //this.picFirstShare.Image = firstShare;
                //this.picSecondShare.Image = secondShare;
                //this.picThirdShare.Image = thirdShare;
                //this.picFourthShare.Image = fourthShare;

                //var share = new string[k, width * height];
                //string[] final = Enumerable.Repeat("00000000000000000000000000000000", width * height).ToArray();

                //for (int i = 0; i < k; i++)
                //{
                //    for (int j = 0; j < width*height; j++)
                //    {
                //        var finalString = new StringBuilder(final[j]);
                //        var imgsArrayString = new StringBuilder(imgsArray[i, j]);
                //        for (int l = 0; l < 32; l++)
                //        {
                //            finalString[l] = Encrypting.BoolToChar(Encrypting.CharToBool(finalString[l]) || Encrypting.CharToBool(imgsArrayString[l]));
                //        }
                //        final[j] = finalString.ToString();
                //    }
                //}

                //counter = 0;
                //for (int i = 0; i < width; i++)
                //{
                //    for (int j = 0; j < height; j++)
                //    {
                //        var smh = Encrypting.SplitByteString(final[counter]);
                //        var pixel = Color.FromArgb(smh[0], smh[1], smh[2], smh[3]);
                //        finalImage.SetPixel(i, j, pixel);
                //        counter++;
                //    }
                //}

                //this.picReconstructed.Image = finalImage;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (numMinimalShares.Value > numSharesNumber.Value)
            {
                MessageBox.Show("Wartość k musi być mniejsza lub równa n.", "Błąd");
            }
            else if (numMinimalShares.Value == 0 || numSharesNumber.Value == 0)
            {
                MessageBox.Show("Wartość k oraz n nie mogą wynosić 0.", "Błąd");
            }
            else if (numMinimalShares.Value == 1)
            {
                MessageBox.Show("Wartość k nie może wynosić 1.", "Błąd");
            }
            else if (picInput.Image == null)
            {
                MessageBox.Show("Brak załadowanego zdjęcia.", "Błąd");
            }
            else
            {
                var inputImage = new ImageProperties(new Bitmap(picInput.Image), (int)numSharesNumber.Value, (int)numMinimalShares.Value);

                var sharesPixelsBitsArray = Encrypting.GenerateSharesPixelsBitsArray(inputImage);
                var sharesPixelsArray = Encrypting.GenerateSharesPixelsArray(sharesPixelsBitsArray, inputImage);

                for (int i = 0; i < inputImage.SharesNumber; i++)
                {
                    sharesImagesPropertiesList.Add(new ImageProperties(Encrypting.GenerateBitmap(sharesPixelsArray, inputImage.Width, inputImage.Height, i)));
                }

                listShares.Items.Clear();
                foreach (var share in sharesImagesPropertiesList)
                {
                    listShares.Items.Add(share.Name);
                }

                //    var share = new string[k, width * height];
                //    string[] final = Enumerable.Repeat("00000000000000000000000000000000", width * height).ToArray();

                //    for (int i = 0; i < k; i++)
                //    {
                //        for (int j = 0; j < width * height; j++)
                //        {
                //            var finalString = new StringBuilder(final[j]);
                //            var imgsArrayString = new StringBuilder(imgsArray[i, j]);
                //            for (int l = 0; l < 32; l++)
                //            {
                //                finalString[l] = Encrypting.BoolToChar(Encrypting.CharToBool(finalString[l]) || Encrypting.CharToBool(imgsArrayString[l]));
                //            }
                //            final[j] = finalString.ToString();
                //        }
                //    }

                //    counter = 0;
                //    for (int i = 0; i < width; i++)
                //    {
                //        for (int j = 0; j < height; j++)
                //        {
                //            var smh = Encrypting.SplitByteString(final[counter]);
                //            var pixel = Color.FromArgb(smh[0], smh[1], smh[2], smh[3]);
                //            finalImage.SetPixel(i, j, pixel);
                //            counter++;
                //        }
                //    }

                //    this.picReconstructed.Image = finalImage;
            }
        }
        

        private void listShares_DoubleClick(object sender, EventArgs e)
        {
            var ShareForm = new frmShare(sharesImagesPropertiesList.First(img => img.Name == listShares.SelectedItems[0].Text));
            ShareForm.Show();
        }
    }
}
