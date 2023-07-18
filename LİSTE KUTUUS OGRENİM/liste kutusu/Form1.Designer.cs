namespace liste_kutusu
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
            this.lboxCarpim = new System.Windows.Forms.ListBox();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnAzalt = new System.Windows.Forms.Button();
            this.btnArttır = new System.Windows.Forms.Button();
            this.btnAktar = new System.Windows.Forms.Button();
            this.lbox2 = new System.Windows.Forms.ListBox();
            this.btnAktartamami = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblSaat = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lboxCarpim
            // 
            this.lboxCarpim.FormattingEnabled = true;
            this.lboxCarpim.Location = new System.Drawing.Point(107, 16);
            this.lboxCarpim.Name = "lboxCarpim";
            this.lboxCarpim.Size = new System.Drawing.Size(120, 147);
            this.lboxCarpim.TabIndex = 0;
            // 
            // lblBilgi
            // 
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Location = new System.Drawing.Point(104, 0);
            this.lblBilgi.Name = "lblBilgi";
            this.lblBilgi.Size = new System.Drawing.Size(39, 13);
            this.lblBilgi.TabIndex = 1;
            this.lblBilgi.Text = "Çarpım";
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(1, 16);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sayı Gir";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(1, 42);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 50);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnAzalt
            // 
            this.btnAzalt.Location = new System.Drawing.Point(4, 98);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(97, 23);
            this.btnAzalt.TabIndex = 5;
            this.btnAzalt.Text = "2 azalt";
            this.btnAzalt.UseVisualStyleBackColor = true;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // btnArttır
            // 
            this.btnArttır.Location = new System.Drawing.Point(4, 127);
            this.btnArttır.Name = "btnArttır";
            this.btnArttır.Size = new System.Drawing.Size(97, 23);
            this.btnArttır.TabIndex = 6;
            this.btnArttır.Text = "5 arttır";
            this.btnArttır.UseVisualStyleBackColor = true;
            this.btnArttır.Click += new System.EventHandler(this.btnArttır_Click);
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(233, 20);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(131, 23);
            this.btnAktar.TabIndex = 7;
            this.btnAktar.Text = "Seçileni Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // lbox2
            // 
            this.lbox2.FormattingEnabled = true;
            this.lbox2.Location = new System.Drawing.Point(369, 16);
            this.lbox2.Name = "lbox2";
            this.lbox2.Size = new System.Drawing.Size(126, 147);
            this.lbox2.TabIndex = 8;
            // 
            // btnAktartamami
            // 
            this.btnAktartamami.Location = new System.Drawing.Point(233, 49);
            this.btnAktartamami.Name = "btnAktartamami";
            this.btnAktartamami.Size = new System.Drawing.Size(130, 23);
            this.btnAktartamami.TabIndex = 9;
            this.btnAktartamami.Text = "Tamamını Aktar";
            this.btnAktartamami.UseVisualStyleBackColor = true;
            this.btnAktartamami.Click += new System.EventHandler(this.btnAktartamami_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.lblSaat.Location = new System.Drawing.Point(275, 4);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(0, 13);
            this.lblSaat.TabIndex = 10;
            // 
            // timer3
            // 
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(233, 78);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(130, 23);
            this.btnA.TabIndex = 11;
            this.btnA.Text = "Sürekli Aktar";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 177);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.btnAktartamami);
            this.Controls.Add(this.lbox2);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.btnArttır);
            this.Controls.Add(this.btnAzalt);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.lblBilgi);
            this.Controls.Add(this.lboxCarpim);
            this.Name = "Form1";
            this.Text = "listbox";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxCarpim;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnAzalt;
        private System.Windows.Forms.Button btnArttır;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.ListBox lbox2;
        private System.Windows.Forms.Button btnAktartamami;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btnA;
    }
}

