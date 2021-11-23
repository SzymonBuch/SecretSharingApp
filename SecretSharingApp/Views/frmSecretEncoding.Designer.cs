
namespace SecretSharingApp.Views
{
    partial class frmSecretEncoding
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
            this.btnBack = new System.Windows.Forms.Button();
            this.picInput = new System.Windows.Forms.PictureBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.picFirstShare = new System.Windows.Forms.PictureBox();
            this.picSecondShare = new System.Windows.Forms.PictureBox();
            this.picFourthShare = new System.Windows.Forms.PictureBox();
            this.picThirdShare = new System.Windows.Forms.PictureBox();
            this.picReconstructed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirstShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecondShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFourthShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThirdShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReconstructed)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(249, 78);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Powrót";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picInput
            // 
            this.picInput.Location = new System.Drawing.Point(95, 162);
            this.picInput.Name = "picInput";
            this.picInput.Size = new System.Drawing.Size(324, 327);
            this.picInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInput.TabIndex = 1;
            this.picInput.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(139, 555);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(226, 80);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Wczytaj obraz";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // picFirstShare
            // 
            this.picFirstShare.Location = new System.Drawing.Point(893, 162);
            this.picFirstShare.Name = "picFirstShare";
            this.picFirstShare.Size = new System.Drawing.Size(324, 327);
            this.picFirstShare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFirstShare.TabIndex = 3;
            this.picFirstShare.TabStop = false;
            // 
            // picSecondShare
            // 
            this.picSecondShare.Location = new System.Drawing.Point(893, 576);
            this.picSecondShare.Name = "picSecondShare";
            this.picSecondShare.Size = new System.Drawing.Size(324, 327);
            this.picSecondShare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSecondShare.TabIndex = 4;
            this.picSecondShare.TabStop = false;
            // 
            // picFourthShare
            // 
            this.picFourthShare.Location = new System.Drawing.Point(1361, 576);
            this.picFourthShare.Name = "picFourthShare";
            this.picFourthShare.Size = new System.Drawing.Size(324, 327);
            this.picFourthShare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFourthShare.TabIndex = 6;
            this.picFourthShare.TabStop = false;
            // 
            // picThirdShare
            // 
            this.picThirdShare.Location = new System.Drawing.Point(1361, 162);
            this.picThirdShare.Name = "picThirdShare";
            this.picThirdShare.Size = new System.Drawing.Size(324, 327);
            this.picThirdShare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThirdShare.TabIndex = 5;
            this.picThirdShare.TabStop = false;
            // 
            // picReconstructed
            // 
            this.picReconstructed.Location = new System.Drawing.Point(95, 686);
            this.picReconstructed.Name = "picReconstructed";
            this.picReconstructed.Size = new System.Drawing.Size(324, 327);
            this.picReconstructed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picReconstructed.TabIndex = 7;
            this.picReconstructed.TabStop = false;
            // 
            // frmSecretEncoding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1917, 1114);
            this.Controls.Add(this.picReconstructed);
            this.Controls.Add(this.picFourthShare);
            this.Controls.Add(this.picThirdShare);
            this.Controls.Add(this.picSecondShare);
            this.Controls.Add(this.picFirstShare);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.picInput);
            this.Controls.Add(this.btnBack);
            this.Name = "frmSecretEncoding";
            this.Text = "Szyfrowanie";
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFirstShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSecondShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFourthShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThirdShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picReconstructed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picInput;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox picFirstShare;
        private System.Windows.Forms.PictureBox picSecondShare;
        private System.Windows.Forms.PictureBox picFourthShare;
        private System.Windows.Forms.PictureBox picThirdShare;
        private System.Windows.Forms.PictureBox picReconstructed;
    }
}