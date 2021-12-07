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
            this.Size = new System.Drawing.Size(600, 550);
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
            //ofile.Filter = "Image File (*.bmp)...
            if (DialogResult.OK == ofile.ShowDialog())
            {
                var inputImage = new Bitmap(ofile.FileName);
                this.picInput.Image = inputImage;
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
            }
        }
       
        private void listShares_DoubleClick(object sender, EventArgs e)
        {
            var ShareForm = new frmShare(sharesImagesPropertiesList.First(img => img.Name == listShares.SelectedItems[0].Text));
            ShareForm.Show();
        }
    }
}
