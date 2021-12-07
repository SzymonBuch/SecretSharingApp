using SecretSharingApp.Models;
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
    public partial class frmSecretDecrypting : Form
    {
        List<ImageProperties> sharesImagesPropertiesList = new List<ImageProperties>();
        public frmSecretDecrypting()
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
            if (DialogResult.OK == ofile.ShowDialog())
            {
                var shareImage = new Bitmap(ofile.FileName);
                var shareProperties = new ImageProperties(shareImage);
                sharesImagesPropertiesList.Add(shareProperties);
                listShares.Items.Add(ofile.SafeFileName);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (sharesImagesPropertiesList.Count < 2)
            {
                MessageBox.Show("Liczba części powinna wynosić conajmniej 2.", "Błąd");
            }
            else
            {
                var sharesPixelsArray = Decrypting.ListToSharesPixelsArray(sharesImagesPropertiesList);
                var decryptedImagePixelsArray = Decrypting.GenerateDecryptedImagePixelsArray(sharesPixelsArray, sharesImagesPropertiesList[0].Width, sharesImagesPropertiesList[0].Height);
                var decryptedImage = Decrypting.GenerateDecryptedImage(decryptedImagePixelsArray, sharesImagesPropertiesList[0].Width, sharesImagesPropertiesList[0].Height);
                this.picDecryptingResult.Image = decryptedImage;
                btnDownload.Visible = true;

            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.DefaultExt = ".png";
            sf.Filter = "PNG Image (.png)|*.png";
            sf.FileName = "result";

            if (sf.ShowDialog() == DialogResult.OK)
            {
                picDecryptingResult.Image.Save(sf.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
