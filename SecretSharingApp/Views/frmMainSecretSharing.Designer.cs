
namespace SecretSharingApp
{
    partial class frmMainSecretSharing
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
            this.btnEncoding = new System.Windows.Forms.Button();
            this.btnDecoding = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnEncoding
            // 
            this.btnEncoding.Location = new System.Drawing.Point(235, 470);
            this.btnEncoding.Name = "btnEncoding";
            this.btnEncoding.Size = new System.Drawing.Size(281, 158);
            this.btnEncoding.TabIndex = 0;
            this.btnEncoding.Text = "Szyfrowanie";
            this.btnEncoding.UseVisualStyleBackColor = true;
            this.btnEncoding.Click += new System.EventHandler(this.btnEncoding_Click);
            // 
            // btnDecoding
            // 
            this.btnDecoding.Location = new System.Drawing.Point(959, 482);
            this.btnDecoding.Name = "btnDecoding";
            this.btnDecoding.Size = new System.Drawing.Size(300, 146);
            this.btnDecoding.TabIndex = 1;
            this.btnDecoding.Text = "Deszyfryzacja";
            this.btnDecoding.UseVisualStyleBackColor = true;
            this.btnDecoding.Click += new System.EventHandler(this.btnDecoding_Click);
            // 
            // frmMainSecretSharing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1572, 821);
            this.Controls.Add(this.btnDecoding);
            this.Controls.Add(this.btnEncoding);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMainSecretSharing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dzielenie sekretu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEncoding;
        private System.Windows.Forms.Button btnDecoding;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

