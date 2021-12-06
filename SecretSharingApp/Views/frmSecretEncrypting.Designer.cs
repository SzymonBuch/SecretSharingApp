
namespace SecretSharingApp.Views
{
    partial class frmSecretEncrypting
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
            this.lblSharesNumber = new System.Windows.Forms.Label();
            this.lblMinimalShares = new System.Windows.Forms.Label();
            this.btnAccept = new System.Windows.Forms.Button();
            this.numSharesNumber = new System.Windows.Forms.NumericUpDown();
            this.numMinimalShares = new System.Windows.Forms.NumericUpDown();
            this.listShares = new System.Windows.Forms.ListView();
            this.columnShare = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSharesNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimalShares)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(236, 84);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Powrót";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picInput
            // 
            this.picInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picInput.Location = new System.Drawing.Point(100, 102);
            this.picInput.Name = "picInput";
            this.picInput.Size = new System.Drawing.Size(442, 428);
            this.picInput.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInput.TabIndex = 1;
            this.picInput.TabStop = false;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(100, 536);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(442, 80);
            this.btnUpload.TabIndex = 2;
            this.btnUpload.Text = "Wczytaj obraz";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblSharesNumber
            // 
            this.lblSharesNumber.AutoSize = true;
            this.lblSharesNumber.Location = new System.Drawing.Point(95, 648);
            this.lblSharesNumber.Name = "lblSharesNumber";
            this.lblSharesNumber.Size = new System.Drawing.Size(180, 29);
            this.lblSharesNumber.TabIndex = 13;
            this.lblSharesNumber.Text = "Liczba części n:";
            // 
            // lblMinimalShares
            // 
            this.lblMinimalShares.AutoSize = true;
            this.lblMinimalShares.Location = new System.Drawing.Point(95, 782);
            this.lblMinimalShares.Name = "lblMinimalShares";
            this.lblMinimalShares.Size = new System.Drawing.Size(456, 29);
            this.lblMinimalShares.TabIndex = 14;
            this.lblMinimalShares.Text = "Wymagana ilość części do odtworzenia k:";
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(95, 933);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(447, 80);
            this.btnAccept.TabIndex = 15;
            this.btnAccept.Text = "Zatwierdź";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // numSharesNumber
            // 
            this.numSharesNumber.Location = new System.Drawing.Point(95, 702);
            this.numSharesNumber.Name = "numSharesNumber";
            this.numSharesNumber.Size = new System.Drawing.Size(447, 35);
            this.numSharesNumber.TabIndex = 16;
            // 
            // numMinimalShares
            // 
            this.numMinimalShares.Location = new System.Drawing.Point(95, 829);
            this.numMinimalShares.Name = "numMinimalShares";
            this.numMinimalShares.Size = new System.Drawing.Size(447, 35);
            this.numMinimalShares.TabIndex = 17;
            // 
            // listShares
            // 
            this.listShares.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listShares.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnShare});
            this.listShares.HideSelection = false;
            this.listShares.Location = new System.Drawing.Point(637, 106);
            this.listShares.Name = "listShares";
            this.listShares.Size = new System.Drawing.Size(591, 906);
            this.listShares.TabIndex = 18;
            this.listShares.UseCompatibleStateImageBehavior = false;
            this.listShares.View = System.Windows.Forms.View.Details;
            this.listShares.DoubleClick += new System.EventHandler(this.listShares_DoubleClick);
            // 
            // columnShare
            // 
            this.columnShare.Text = "Nazwa części";
            this.columnShare.Width = 584;
            // 
            // frmSecretEncrypting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 1121);
            this.Controls.Add(this.listShares);
            this.Controls.Add(this.numMinimalShares);
            this.Controls.Add(this.numSharesNumber);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblMinimalShares);
            this.Controls.Add(this.lblSharesNumber);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.picInput);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmSecretEncrypting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Szyfrowanie";
            ((System.ComponentModel.ISupportInitialize)(this.picInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSharesNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinimalShares)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox picInput;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblSharesNumber;
        private System.Windows.Forms.Label lblMinimalShares;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.NumericUpDown numSharesNumber;
        private System.Windows.Forms.NumericUpDown numMinimalShares;
        private System.Windows.Forms.ListView listShares;
        private System.Windows.Forms.ColumnHeader columnShare;
    }
}