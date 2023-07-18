namespace WindowsFormsApplication18
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblYazi = new System.Windows.Forms.Label();
            this.btnRenk = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.lboxYazi = new System.Windows.Forms.ListBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.btnHesap = new System.Windows.Forms.Button();
            this.txtVeri = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(413, 318);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblYazi);
            this.tabPage1.Controls.Add(this.btnRenk);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(405, 292);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fonksiyon1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblYazi
            // 
            this.lblYazi.AutoSize = true;
            this.lblYazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazi.Location = new System.Drawing.Point(194, 103);
            this.lblYazi.Name = "lblYazi";
            this.lblYazi.Size = new System.Drawing.Size(71, 25);
            this.lblYazi.TabIndex = 1;
            this.lblYazi.Text = "AREL";
            // 
            // btnRenk
            // 
            this.btnRenk.Location = new System.Drawing.Point(31, 107);
            this.btnRenk.Name = "btnRenk";
            this.btnRenk.Size = new System.Drawing.Size(142, 23);
            this.btnRenk.TabIndex = 0;
            this.btnRenk.Text = "Renk Değiştir";
            this.btnRenk.UseVisualStyleBackColor = true;
            this.btnRenk.Click += new System.EventHandler(this.btnRenk_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtIsim);
            this.tabPage2.Controls.Add(this.lboxYazi);
            this.tabPage2.Controls.Add(this.txtSayi);
            this.tabPage2.Controls.Add(this.btnYazdir);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(405, 292);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Fonksiyon2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblSonuc);
            this.tabPage3.Controls.Add(this.txtVeri);
            this.tabPage3.Controls.Add(this.btnHesap);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(405, 292);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fonksiyon3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(53, 6);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(218, 23);
            this.btnYazdir.TabIndex = 0;
            this.btnYazdir.Text = "Adımı yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(8, 8);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(39, 20);
            this.txtSayi.TabIndex = 1;
            // 
            // lboxYazi
            // 
            this.lboxYazi.FormattingEnabled = true;
            this.lboxYazi.Location = new System.Drawing.Point(277, 6);
            this.lboxYazi.Name = "lboxYazi";
            this.lboxYazi.Size = new System.Drawing.Size(120, 238);
            this.lboxYazi.TabIndex = 2;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(9, 35);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(100, 20);
            this.txtIsim.TabIndex = 3;
            // 
            // btnHesap
            // 
            this.btnHesap.Location = new System.Drawing.Point(73, 32);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(75, 23);
            this.btnHesap.TabIndex = 0;
            this.btnHesap.Text = "Hesapla";
            this.btnHesap.UseVisualStyleBackColor = true;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // txtVeri
            // 
            this.txtVeri.Location = new System.Drawing.Point(22, 34);
            this.txtVeri.Name = "txtVeri";
            this.txtVeri.Size = new System.Drawing.Size(45, 20);
            this.txtVeri.TabIndex = 1;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(154, 37);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 13);
            this.lblSonuc.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 318);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblYazi;
        private System.Windows.Forms.Button btnRenk;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lboxYazi;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtVeri;
        private System.Windows.Forms.Button btnHesap;
    }
}