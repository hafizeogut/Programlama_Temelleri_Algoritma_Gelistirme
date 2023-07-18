namespace HENTBOL
{
    partial class Form1
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
            this.lblOzellik1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblHareketAd = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pboxRes = new System.Windows.Forms.PictureBox();
            this.cboxHentbol = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxRes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOzellik1
            // 
            this.lblOzellik1.AutoSize = true;
            this.lblOzellik1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOzellik1.Location = new System.Drawing.Point(488, 68);
            this.lblOzellik1.Name = "lblOzellik1";
            this.lblOzellik1.Size = new System.Drawing.Size(16, 17);
            this.lblOzellik1.TabIndex = 17;
            this.lblOzellik1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(426, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Özellik :";
            // 
            // lblHareketAd
            // 
            this.lblHareketAd.AutoSize = true;
            this.lblHareketAd.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHareketAd.Location = new System.Drawing.Point(534, 10);
            this.lblHareketAd.Name = "lblHareketAd";
            this.lblHareketAd.Size = new System.Drawing.Size(16, 17);
            this.lblHareketAd.TabIndex = 15;
            this.lblHareketAd.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(426, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Hareketin Adı:";
            // 
            // pboxRes
            // 
            this.pboxRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pboxRes.Location = new System.Drawing.Point(12, 34);
            this.pboxRes.Name = "pboxRes";
            this.pboxRes.Size = new System.Drawing.Size(400, 273);
            this.pboxRes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxRes.TabIndex = 13;
            this.pboxRes.TabStop = false;
            // 
            // cboxHentbol
            // 
            this.cboxHentbol.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboxHentbol.FormattingEnabled = true;
            this.cboxHentbol.Items.AddRange(new object[] {
            "SEÇİNİZ",
            "1) Devre Oluşumu",
            "2) Ceza Sahası",
            "3) Amaç",
            "4)Saha",
            "5)Oyuncu Değişikliği",
            "6) Oyuncu Şekli",
            "7) Oyun Süresi",
            "8) Hakem ",
            "9) Kale",
            "10) Top Tutabilme",
            "11) Şampiyonluk",
            "12) Yere Olan Uzaklık",
            "13) Topun Çapı",
            "14)  Topun Ağırlığı",
            "15) Defans",
            "16)Savunma",
            "17) Faul",
            "18)Kaleye Olan Uzaklık "});
            this.cboxHentbol.Location = new System.Drawing.Point(12, 2);
            this.cboxHentbol.Name = "cboxHentbol";
            this.cboxHentbol.Size = new System.Drawing.Size(400, 26);
            this.cboxHentbol.TabIndex = 12;
            this.cboxHentbol.SelectedIndexChanged += new System.EventHandler(this.cboxHentbol_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 313);
            this.Controls.Add(this.lblOzellik1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHareketAd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pboxRes);
            this.Controls.Add(this.cboxHentbol);
            this.Name = "Form1";
            this.Text = "HENTBOL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxRes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOzellik1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblHareketAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboxRes;
        private System.Windows.Forms.ComboBox cboxHentbol;
    }
}

