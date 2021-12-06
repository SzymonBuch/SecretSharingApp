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
    public partial class frmShare : Form
    {
        public ImageProperties ImageProperties { get; }
        public frmShare(ImageProperties imageProperties)
        {
            InitializeComponent();
            ImageProperties = imageProperties;
            picShare.Image = imageProperties.Image;
            this.Text = imageProperties.Name;
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.DefaultExt = ".png";
            sf.Filter = "PNG Image (.png)|*.png";
            sf.FileName = ImageProperties.Name;

            if (sf.ShowDialog() == DialogResult.OK)
            {
                picShare.Image.Save(sf.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }
    }
}
