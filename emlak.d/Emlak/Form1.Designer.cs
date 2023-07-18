namespace Emlak
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
            this.dgvGoster = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.pboxResim = new System.Windows.Forms.PictureBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtBina = new System.Windows.Forms.TextBox();
            this.txtOdaSayisi = new System.Windows.Forms.TextBox();
            this.txtAlan = new System.Windows.Forms.TextBox();
            this.txtIsitma = new System.Windows.Forms.TextBox();
            this.txtDaire = new System.Windows.Forms.TextBox();
            this.txtBulunduguYer = new System.Windows.Forms.TextBox();
            this.txtKatSayisi = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtIlce = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGoster
            // 
            this.dgvGoster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoster.Location = new System.Drawing.Point(239, 243);
            this.dgvGoster.Name = "dgvGoster";
            this.dgvGoster.Size = new System.Drawing.Size(442, 203);
            this.dgvGoster.TabIndex = 64;
            this.dgvGoster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoster_CellContentClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.White;
            this.btnGuncelle.Location = new System.Drawing.Point(234, 180);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(94, 35);
            this.btnGuncelle.TabIndex = 62;
            this.btnGuncelle.Text = "KAYIT GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.Location = new System.Drawing.Point(234, 38);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(94, 35);
            this.btnEkle.TabIndex = 61;
            this.btnEkle.Text = "KAYIT EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(233, 128);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(94, 35);
            this.btnAra.TabIndex = 60;
            this.btnAra.Text = "KAYIT ARAMA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.Location = new System.Drawing.Point(234, 83);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 35);
            this.btnSil.TabIndex = 59;
            this.btnSil.Text = "KAYIT SİL";
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(86, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 58;
            this.label12.Text = "FİYAT";
            // 
            // pboxResim
            // 
            this.pboxResim.BackColor = System.Drawing.Color.White;
            this.pboxResim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxResim.Location = new System.Drawing.Point(339, 38);
            this.pboxResim.Name = "pboxResim";
            this.pboxResim.Size = new System.Drawing.Size(342, 199);
            this.pboxResim.TabIndex = 57;
            this.pboxResim.TabStop = false;
            // 
            // txtFiyat
            // 
            this.txtFiyat.BackColor = System.Drawing.Color.White;
            this.txtFiyat.Location = new System.Drawing.Point(134, 424);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 20);
            this.txtFiyat.TabIndex = 56;
            // 
            // txtBina
            // 
            this.txtBina.BackColor = System.Drawing.Color.White;
            this.txtBina.Location = new System.Drawing.Point(134, 381);
            this.txtBina.Name = "txtBina";
            this.txtBina.Size = new System.Drawing.Size(100, 20);
            this.txtBina.TabIndex = 55;
            // 
            // txtOdaSayisi
            // 
            this.txtOdaSayisi.BackColor = System.Drawing.Color.White;
            this.txtOdaSayisi.Location = new System.Drawing.Point(130, 342);
            this.txtOdaSayisi.Name = "txtOdaSayisi";
            this.txtOdaSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtOdaSayisi.TabIndex = 54;
            // 
            // txtAlan
            // 
            this.txtAlan.BackColor = System.Drawing.Color.White;
            this.txtAlan.Location = new System.Drawing.Point(130, 302);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Size = new System.Drawing.Size(100, 20);
            this.txtAlan.TabIndex = 53;
            // 
            // txtIsitma
            // 
            this.txtIsitma.BackColor = System.Drawing.Color.White;
            this.txtIsitma.Location = new System.Drawing.Point(130, 259);
            this.txtIsitma.Name = "txtIsitma";
            this.txtIsitma.Size = new System.Drawing.Size(100, 20);
            this.txtIsitma.TabIndex = 52;
            // 
            // txtDaire
            // 
            this.txtDaire.BackColor = System.Drawing.Color.White;
            this.txtDaire.Location = new System.Drawing.Point(130, 217);
            this.txtDaire.Name = "txtDaire";
            this.txtDaire.Size = new System.Drawing.Size(100, 20);
            this.txtDaire.TabIndex = 51;
            // 
            // txtBulunduguYer
            // 
            this.txtBulunduguYer.BackColor = System.Drawing.Color.White;
            this.txtBulunduguYer.Location = new System.Drawing.Point(130, 168);
            this.txtBulunduguYer.Name = "txtBulunduguYer";
            this.txtBulunduguYer.Size = new System.Drawing.Size(100, 20);
            this.txtBulunduguYer.TabIndex = 50;
            // 
            // txtKatSayisi
            // 
            this.txtKatSayisi.BackColor = System.Drawing.Color.White;
            this.txtKatSayisi.Location = new System.Drawing.Point(127, 128);
            this.txtKatSayisi.Name = "txtKatSayisi";
            this.txtKatSayisi.Size = new System.Drawing.Size(100, 20);
            this.txtKatSayisi.TabIndex = 49;
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.Color.White;
            this.txtAdres.Location = new System.Drawing.Point(127, 83);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 20);
            this.txtAdres.TabIndex = 48;
            // 
            // txtIlce
            // 
            this.txtIlce.BackColor = System.Drawing.Color.White;
            this.txtIlce.Location = new System.Drawing.Point(128, 38);
            this.txtIlce.Name = "txtIlce";
            this.txtIlce.Size = new System.Drawing.Size(100, 20);
            this.txtIlce.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(58, 383);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 45;
            this.label10.Text = "BİNA YAŞI ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(48, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 15);
            this.label9.TabIndex = 44;
            this.label9.Text = "ODA SAYISI";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(76, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 43;
            this.label8.Text = "ALANI ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(73, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 42;
            this.label7.Text = "ISITMA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(55, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 15);
            this.label6.TabIndex = 41;
            this.label6.Text = "DAİRE NO";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(6, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 15);
            this.label5.TabIndex = 40;
            this.label5.Text = "BULUNDUĞU KAT ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(48, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 39;
            this.label4.Text = "KAT SAYISI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(68, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 38;
            this.label3.Text = "ADRES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(62, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "İL / İLÇE ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 29);
            this.label1.TabIndex = 36;
            this.label1.Text = "SARGIN EMLAK PROGRAMI ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 458);
            this.Controls.Add(this.dgvGoster);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pboxResim);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.txtBina);
            this.Controls.Add(this.txtOdaSayisi);
            this.Controls.Add(this.txtAlan);
            this.Controls.Add(this.txtIsitma);
            this.Controls.Add(this.txtDaire);
            this.Controls.Add(this.txtBulunduguYer);
            this.Controls.Add(this.txtKatSayisi);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtIlce);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "EMLAK İŞLEMLERİ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGoster;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pboxResim;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtBina;
        private System.Windows.Forms.TextBox txtOdaSayisi;
        private System.Windows.Forms.TextBox txtAlan;
        private System.Windows.Forms.TextBox txtIsitma;
        private System.Windows.Forms.TextBox txtDaire;
        private System.Windows.Forms.TextBox txtBulunduguYer;
        private System.Windows.Forms.TextBox txtKatSayisi;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtIlce;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

