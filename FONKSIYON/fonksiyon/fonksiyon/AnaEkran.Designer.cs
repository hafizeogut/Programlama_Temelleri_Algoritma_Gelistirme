namespace fonksiyon
{
    partial class AnaEkran
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
            this.tcIslemler = new System.Windows.Forms.TabControl();
            this.f1 = new System.Windows.Forms.TabPage();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.lblYaz = new System.Windows.Forms.Label();
            this.f2 = new System.Windows.Forms.TabPage();
            this.btnYaziyiAktar = new System.Windows.Forms.Button();
            this.lboxYazi = new System.Windows.Forms.ListBox();
            this.txtF2Isim = new System.Windows.Forms.TextBox();
            this.txtF2Sayi = new System.Windows.Forms.TextBox();
            this.f3 = new System.Windows.Forms.TabPage();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtF3Sayi = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tcIslemler.SuspendLayout();
            this.f1.SuspendLayout();
            this.f2.SuspendLayout();
            this.f3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcIslemler
            // 
            this.tcIslemler.Controls.Add(this.f1);
            this.tcIslemler.Controls.Add(this.f2);
            this.tcIslemler.Controls.Add(this.f3);
            this.tcIslemler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcIslemler.Location = new System.Drawing.Point(0, 0);
            this.tcIslemler.Name = "tcIslemler";
            this.tcIslemler.SelectedIndex = 0;
            this.tcIslemler.Size = new System.Drawing.Size(445, 203);
            this.tcIslemler.TabIndex = 0;
            // 
            // f1
            // 
            this.f1.Controls.Add(this.btnYazdir);
            this.f1.Controls.Add(this.lblYaz);
            this.f1.Location = new System.Drawing.Point(4, 24);
            this.f1.Name = "f1";
            this.f1.Padding = new System.Windows.Forms.Padding(3);
            this.f1.Size = new System.Drawing.Size(437, 175);
            this.f1.TabIndex = 0;
            this.f1.Text = "FONKSİYON 1";
            this.f1.UseVisualStyleBackColor = true;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(8, 15);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(75, 27);
            this.btnYazdir.TabIndex = 1;
            this.btnYazdir.Text = "RENK";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // lblYaz
            // 
            this.lblYaz.AutoSize = true;
            this.lblYaz.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYaz.Location = new System.Drawing.Point(98, 21);
            this.lblYaz.Name = "lblYaz";
            this.lblYaz.Size = new System.Drawing.Size(309, 21);
            this.lblYaz.TabIndex = 0;
            this.lblYaz.Text = "YAZILIMCI OLMAK AYRICALIKTIR";
            // 
            // f2
            // 
            this.f2.Controls.Add(this.btnYaziyiAktar);
            this.f2.Controls.Add(this.lboxYazi);
            this.f2.Controls.Add(this.txtF2Isim);
            this.f2.Controls.Add(this.txtF2Sayi);
            this.f2.Location = new System.Drawing.Point(4, 24);
            this.f2.Name = "f2";
            this.f2.Padding = new System.Windows.Forms.Padding(3);
            this.f2.Size = new System.Drawing.Size(437, 175);
            this.f2.TabIndex = 1;
            this.f2.Text = "FONKSİYON 2";
            this.f2.UseVisualStyleBackColor = true;
            // 
            // btnYaziyiAktar
            // 
            this.btnYaziyiAktar.Location = new System.Drawing.Point(46, 13);
            this.btnYaziyiAktar.Name = "btnYaziyiAktar";
            this.btnYaziyiAktar.Size = new System.Drawing.Size(252, 29);
            this.btnYaziyiAktar.TabIndex = 3;
            this.btnYaziyiAktar.Text = "AKTAR";
            this.btnYaziyiAktar.UseVisualStyleBackColor = true;
            this.btnYaziyiAktar.Click += new System.EventHandler(this.btnYaziyiAktar_Click);
            // 
            // lboxYazi
            // 
            this.lboxYazi.FormattingEnabled = true;
            this.lboxYazi.ItemHeight = 15;
            this.lboxYazi.Location = new System.Drawing.Point(304, 13);
            this.lboxYazi.Name = "lboxYazi";
            this.lboxYazi.Size = new System.Drawing.Size(120, 154);
            this.lboxYazi.TabIndex = 2;
            // 
            // txtF2Isim
            // 
            this.txtF2Isim.Location = new System.Drawing.Point(6, 55);
            this.txtF2Isim.Name = "txtF2Isim";
            this.txtF2Isim.Size = new System.Drawing.Size(115, 21);
            this.txtF2Isim.TabIndex = 1;
            // 
            // txtF2Sayi
            // 
            this.txtF2Sayi.Location = new System.Drawing.Point(8, 16);
            this.txtF2Sayi.Name = "txtF2Sayi";
            this.txtF2Sayi.Size = new System.Drawing.Size(32, 21);
            this.txtF2Sayi.TabIndex = 0;
            // 
            // f3
            // 
            this.f3.Controls.Add(this.label1);
            this.f3.Controls.Add(this.lblSonuc);
            this.f3.Controls.Add(this.txtF3Sayi);
            this.f3.Controls.Add(this.btnHesapla);
            this.f3.Location = new System.Drawing.Point(4, 24);
            this.f3.Name = "f3";
            this.f3.Padding = new System.Windows.Forms.Padding(3);
            this.f3.Size = new System.Drawing.Size(437, 175);
            this.f3.TabIndex = 2;
            this.f3.Text = "FONKSİYON 3";
            this.f3.UseVisualStyleBackColor = true;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(326, 20);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(21, 23);
            this.lblSonuc.TabIndex = 2;
            this.lblSonuc.Text = "0";
            // 
            // txtF3Sayi
            // 
            this.txtF3Sayi.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtF3Sayi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtF3Sayi.Location = new System.Drawing.Point(8, 20);
            this.txtF3Sayi.Multiline = true;
            this.txtF3Sayi.Name = "txtF3Sayi";
            this.txtF3Sayi.Size = new System.Drawing.Size(31, 31);
            this.txtF3Sayi.TabIndex = 1;
            this.txtF3Sayi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(58, 6);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(77, 55);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(136, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "(SAYI * SAYI) + 45) / 2)*5  \r\n   İŞLEMİNİZ SONUCU\r\n";
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 203);
            this.Controls.Add(this.tcIslemler);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "AnaEkran";
            this.Text = "AnaEkran";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.tcIslemler.ResumeLayout(false);
            this.f1.ResumeLayout(false);
            this.f1.PerformLayout();
            this.f2.ResumeLayout(false);
            this.f2.PerformLayout();
            this.f3.ResumeLayout(false);
            this.f3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcIslemler;
        private System.Windows.Forms.TabPage f1;
        private System.Windows.Forms.TabPage f2;
        private System.Windows.Forms.TabPage f3;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Label lblYaz;
        private System.Windows.Forms.Button btnYaziyiAktar;
        private System.Windows.Forms.ListBox lboxYazi;
        private System.Windows.Forms.TextBox txtF2Isim;
        private System.Windows.Forms.TextBox txtF2Sayi;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtF3Sayi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label1;
    }
}