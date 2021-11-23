using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecretSharingApp.Views
{
    public partial class frmSecretEncoding : Form
    {
        public frmSecretEncoding()
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

                int width = inputImage.Width;
                int height = inputImage.Height;

                var firstShare = new Bitmap(width, height);
                var secondShare = new Bitmap(width, height);
                var thirdShare = new Bitmap(width, height);
                var fourthShare = new Bitmap(width, height);

                

                var finalImage = new Bitmap(ofile.FileName);

                this.picInput.Image = inputImage;

                int n = 4;
                int k = 3;
                int recon = n - k + 1;

                int counter = 0;

                var result = Encoding.StepV(inputImage, n, k);

                var imgsArray = Encoding.GenerateSharesPixelsArray(result, n, width, height);


                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        var smh = Encoding.SplitByteString(imgsArray[0, counter]);
                        var pixel = Color.FromArgb(smh[0], smh[1], smh[2], smh[3]);
                        firstShare.SetPixel(i, j, pixel);
                        counter++;
                    }
                }
                counter = 0;
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        var smh = Encoding.SplitByteString(imgsArray[1, counter]);
                        var pixel = Color.FromArgb(smh[0], smh[1], smh[2], smh[3]);
                        secondShare.SetPixel(i, j, pixel);
                        counter++;
                    }
                }
                counter = 0;
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        var smh = Encoding.SplitByteString(imgsArray[2, counter]);
                        var pixel = Color.FromArgb(smh[0], smh[1], smh[2], smh[3]);
                        thirdShare.SetPixel(i, j, pixel);
                        counter++;
                    }
                }
                counter = 0;
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        var smh = Encoding.SplitByteString(imgsArray[3, counter]);
                        var pixel = Color.FromArgb(smh[0], smh[1], smh[2], smh[3]);
                        fourthShare.SetPixel(i, j, pixel);
                        counter++;
                    }
                }

                this.picFirstShare.Image = firstShare;
                this.picSecondShare.Image = secondShare;
                this.picThirdShare.Image = thirdShare;
                this.picFourthShare.Image = fourthShare;

                var share = new string[k, width * height];
                string[] final = Enumerable.Repeat("00000000000000000000000000000000", width * height).ToArray();

                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < width*height; j++)
                    {
                        var finalString = new StringBuilder(final[j]);
                        var imgsArrayString = new StringBuilder(imgsArray[i, j]);
                        for (int l = 0; l < 32; l++)
                        {
                            finalString[l] = Encoding.BoolToChar(Encoding.CharToBool(finalString[l]) || Encoding.CharToBool(imgsArrayString[l]));
                        }
                        final[j] = finalString.ToString();
                    }
                }

                counter = 0;
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        var smh = Encoding.SplitByteString(final[counter]);
                        var pixel = Color.FromArgb(smh[0], smh[1], smh[2], smh[3]);
                        finalImage.SetPixel(i, j, pixel);
                        counter++;
                    }
                }

                this.picReconstructed.Image = finalImage;


            }


        }
    }
}
