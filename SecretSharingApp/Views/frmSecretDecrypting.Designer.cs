
namespace SecretSharingApp.Views
{
    partial class frmSecretDecrypting
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
            this.picDecryptingResult = new System.Windows.Forms.PictureBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.listShares = new System.Windows.Forms.ListView();
            this.columnShareName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDecryptingResult)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(249, 78);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Powrót";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picDecryptingResult
            // 
            this.picDecryptingResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picDecryptingResult.Location = new System.Drawing.Point(727, 126);
            this.picDecryptingResult.Name = "picDecryptingResult";
            this.picDecryptingResult.Size = new System.Drawing.Size(450, 450);
            this.picDecryptingResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDecryptingResult.TabIndex = 20;
            this.picDecryptingResult.TabStop = false;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(312, 916);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(300, 80);
            this.btnAccept.TabIndex = 23;
            this.btnAccept.Text = "Zatwierdź";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(12, 916);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(300, 80);
            this.btnUpload.TabIndex = 24;
            this.btnUpload.Text = "Wczytaj obraz";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // listShares
            // 
            this.listShares.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnShareName});
            this.listShares.HideSelection = false;
            this.listShares.Location = new System.Drawing.Point(12, 111);
            this.listShares.Name = "listShares";
            this.listShares.Size = new System.Drawing.Size(600, 799);
            this.listShares.TabIndex = 25;
            this.listShares.UseCompatibleStateImageBehavior = false;
            this.listShares.View = System.Windows.Forms.View.Details;
            // 
            // columnShareName
            // 
            this.columnShareName.Text = "Nazwa części";
            this.columnShareName.Width = 600;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(727, 582);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(450, 80);
            this.btnDownload.TabIndex = 26;
            this.btnDownload.Text = "Pobierz";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Visible = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // frmSecretDecrypting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 1121);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.listShares);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.picDecryptingResult);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSecretDecrypting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmSecretDecrypting";
            ((System.ComponentModel.ISupportInitialize)(this.picDecryptingResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picDecryptingResult;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.ListView listShares;
        private System.Windows.Forms.ColumnHeader columnShareName;
        private System.Windows.Forms.Button btnDownload;
    }
}