﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecretSharingApp.Views;

namespace SecretSharingApp
{
    public partial class frmMainSecretSharing : Form
    {
        public frmMainSecretSharing()
        {
            InitializeComponent();
        }

        private void btnEncoding_Click(object sender, EventArgs e)
        {
            this.Hide();
            var EncryptingForm = new frmSecretEncrypting();
            EncryptingForm.ShowDialog();
            this.Close();
        }

        private void btnDecoding_Click(object sender, EventArgs e)
        {
            this.Hide();
            var DecryptingForm = new frmSecretDecrypting();
            DecryptingForm.ShowDialog();
            this.Close();
        }
    }
}
