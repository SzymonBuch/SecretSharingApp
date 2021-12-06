
namespace SecretSharingApp.Views
{
    partial class frmShare
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picShare = new System.Windows.Forms.PictureBox();
            this.btnDownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picShare)).BeginInit();
            this.SuspendLayout();
            // 
            // picShare
            // 
            this.picShare.Location = new System.Drawing.Point(132, 57);
            this.picShare.Name = "picShare";
            this.picShare.Size = new System.Drawing.Size(645, 536);
            this.picShare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picShare.TabIndex = 0;
            this.picShare.TabStop = false;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(318, 599);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(267, 95);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Pobierz";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // frmShare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 816);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.picShare);
            this.Name = "frmShare";
            this.Text = "frmShare";
            ((System.ComponentModel.ISupportInitialize)(this.picShare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picShare;
        private System.Windows.Forms.Button btnDownload;
    }
}