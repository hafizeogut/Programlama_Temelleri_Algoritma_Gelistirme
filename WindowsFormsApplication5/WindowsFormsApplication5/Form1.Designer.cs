namespace WindowsFormsApplication5
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lboxCarpim = new System.Windows.Forms.ListBox();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnAktar = new System.Windows.Forms.Button();
            this.lbox2 = new System.Windows.Forms.ListBox();
            this.btnAktarTamami = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCalis = new System.Windows.Forms.Button();
            this.btnDur = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblSaat = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnTimer3 = new System.Windows.Forms.Button();
            this.pboxResim = new System.Windows.Forms.PictureBox();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pboxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxCarpim
            // 
            this.lboxCarpim.FormattingEnabled = true;
            this.lboxCarpim.Location = new System.Drawing.Point(118, 36);
            this.lboxCarpim.Name = "lboxCarpim";
            this.lboxCarpim.Size = new System.Drawing.Size(114, 134);
            this.lboxCarpim.TabIndex = 0;
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(12, 36);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sayı Gir";
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Location = new System.Drawing.Point(115, 17);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(80, 13);
            this.lblBilgi.TabIndex = 3;
            this.lblBilgi.Text = "Çarpım Tablosu";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(12, 63);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 23);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(239, 32);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(143, 23);
            this.btnAktar.TabIndex = 5;
            this.btnAktar.Text = "SEÇİLENİ AKTAR";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // lbox2
            // 
            this.lbox2.FormattingEnabled = true;
            this.lbox2.Location = new System.Drawing.Point(388, 36);
            this.lbox2.Name = "lbox2";
            this.lbox2.Size = new System.Drawing.Size(120, 134);
            this.lbox2.TabIndex = 6;
            // 
            // btnAktarTamami
            // 
            this.btnAktarTamami.Location = new System.Drawing.Point(239, 62);
            this.btnAktarTamami.Name = "btnAktarTamami";
            this.btnAktarTamami.Size = new System.Drawing.Size(143, 23);
            this.btnAktarTamami.TabIndex = 7;
            this.btnAktarTamami.Text = "Tamamını AKTAR";
            this.btnAktarTamami.UseVisualStyleBackColor = true;
            this.btnAktarTamami.Click += new System.EventHandler(this.btnAktarTamami_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnCalis
            // 
            this.btnCalis.Location = new System.Drawing.Point(239, 92);
            this.btnCalis.Name = "btnCalis";
            this.btnCalis.Size = new System.Drawing.Size(143, 23);
            this.btnCalis.TabIndex = 8;
            this.btnCalis.Text = "Timer Çalış";
            this.btnCalis.UseVisualStyleBackColor = true;
            this.btnCalis.Click += new System.EventHandler(this.btnCalis_Click);
            // 
            // btnDur
            // 
            this.btnDur.Location = new System.Drawing.Point(239, 122);
            this.btnDur.Name = "btnDur";
            this.btnDur.Size = new System.Drawing.Size(143, 23);
            this.btnDur.TabIndex = 9;
            this.btnDur.Text = "Timer Dur";
            this.btnDur.UseVisualStyleBackColor = true;
            this.btnDur.Click += new System.EventHandler(this.btnDur_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(456, 13);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(0, 13);
            this.lblSaat.TabIndex = 10;
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btnTimer3
            // 
            this.btnTimer3.Location = new System.Drawing.Point(239, 152);
            this.btnTimer3.Name = "btnTimer3";
            this.btnTimer3.Size = new System.Drawing.Size(143, 23);
            this.btnTimer3.TabIndex = 11;
            this.btnTimer3.Text = "timer3 Çalış";
            this.btnTimer3.UseVisualStyleBackColor = true;
            this.btnTimer3.Click += new System.EventHandler(this.btnTimer3_Click);
            // 
            // pboxResim
            // 
            this.pboxResim.Image = ((System.Drawing.Image)(resources.GetObject("pboxResim.Image")));
            this.pboxResim.Location = new System.Drawing.Point(524, 36);
            this.pboxResim.Name = "pboxResim";
            this.pboxResim.Size = new System.Drawing.Size(245, 20);
            this.pboxResim.TabIndex = 12;
            this.pboxResim.TabStop = false;
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 50;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 188);
            this.Controls.Add(this.pboxResim);
            this.Controls.Add(this.btnTimer3);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.btnDur);
            this.Controls.Add(this.btnCalis);
            this.Controls.Add(this.btnAktarTamami);
            this.Controls.Add(this.lbox2);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.lboxCarpim);
            this.Name = "Form1";
            this.Text = "List Box Nesnesi Ör1";
            ((System.ComponentModel.ISupportInitialize)(this.pboxResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxCarpim;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.ListBox lbox2;
        private System.Windows.Forms.Button btnAktarTamami;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCalis;
        private System.Windows.Forms.Button btnDur;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btnTimer3;
        private System.Windows.Forms.PictureBox pboxResim;
        private System.Windows.Forms.Timer timer4;
    }
}

