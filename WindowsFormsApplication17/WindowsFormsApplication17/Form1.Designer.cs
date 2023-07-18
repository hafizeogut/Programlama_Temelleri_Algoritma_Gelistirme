namespace WindowsFormsApplication17
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
            this.dgvPasta = new System.Windows.Forms.DataGridView();
            this.dgvIcerik = new System.Windows.Forms.DataGridView();
            this.bntEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle2 = new System.Windows.Forms.Button();
            this.btnSil2 = new System.Windows.Forms.Button();
            this.btnGuncelle2 = new System.Windows.Forms.Button();
            this.txtPadi = new System.Windows.Forms.TextBox();
            this.txtPboyut = new System.Windows.Forms.TextBox();
            this.txtPtur = new System.Windows.Forms.TextBox();
            this.txtMalzeme = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnAyarlar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIcerik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPasta
            // 
            this.dgvPasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasta.Location = new System.Drawing.Point(12, 3);
            this.dgvPasta.Name = "dgvPasta";
            this.dgvPasta.Size = new System.Drawing.Size(564, 128);
            this.dgvPasta.TabIndex = 0;
            this.dgvPasta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasta_CellContentClick);
            // 
            // dgvIcerik
            // 
            this.dgvIcerik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIcerik.Location = new System.Drawing.Point(12, 137);
            this.dgvIcerik.Name = "dgvIcerik";
            this.dgvIcerik.Size = new System.Drawing.Size(564, 150);
            this.dgvIcerik.TabIndex = 1;
            // 
            // bntEkle
            // 
            this.bntEkle.Location = new System.Drawing.Point(697, 50);
            this.bntEkle.Name = "bntEkle";
            this.bntEkle.Size = new System.Drawing.Size(75, 23);
            this.bntEkle.TabIndex = 2;
            this.bntEkle.Text = "Ekle";
            this.bntEkle.UseVisualStyleBackColor = true;
            this.bntEkle.Click += new System.EventHandler(this.bntEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(697, 79);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(697, 108);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle2
            // 
            this.btnEkle2.Location = new System.Drawing.Point(697, 206);
            this.btnEkle2.Name = "btnEkle2";
            this.btnEkle2.Size = new System.Drawing.Size(75, 23);
            this.btnEkle2.TabIndex = 5;
            this.btnEkle2.Text = "Ekle";
            this.btnEkle2.UseVisualStyleBackColor = true;
            this.btnEkle2.Click += new System.EventHandler(this.btnEkle2_Click);
            // 
            // btnSil2
            // 
            this.btnSil2.Location = new System.Drawing.Point(697, 235);
            this.btnSil2.Name = "btnSil2";
            this.btnSil2.Size = new System.Drawing.Size(75, 23);
            this.btnSil2.TabIndex = 6;
            this.btnSil2.Text = "Sil";
            this.btnSil2.UseVisualStyleBackColor = true;
            // 
            // btnGuncelle2
            // 
            this.btnGuncelle2.Location = new System.Drawing.Point(697, 264);
            this.btnGuncelle2.Name = "btnGuncelle2";
            this.btnGuncelle2.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle2.TabIndex = 7;
            this.btnGuncelle2.Text = "Güncelle";
            this.btnGuncelle2.UseVisualStyleBackColor = true;
            // 
            // txtPadi
            // 
            this.txtPadi.Location = new System.Drawing.Point(582, 54);
            this.txtPadi.Name = "txtPadi";
            this.txtPadi.Size = new System.Drawing.Size(100, 20);
            this.txtPadi.TabIndex = 8;
            // 
            // txtPboyut
            // 
            this.txtPboyut.Location = new System.Drawing.Point(582, 81);
            this.txtPboyut.Name = "txtPboyut";
            this.txtPboyut.Size = new System.Drawing.Size(100, 20);
            this.txtPboyut.TabIndex = 9;
            // 
            // txtPtur
            // 
            this.txtPtur.Location = new System.Drawing.Point(582, 108);
            this.txtPtur.Name = "txtPtur";
            this.txtPtur.Size = new System.Drawing.Size(100, 20);
            this.txtPtur.TabIndex = 10;
            // 
            // txtMalzeme
            // 
            this.txtMalzeme.Location = new System.Drawing.Point(582, 208);
            this.txtMalzeme.Name = "txtMalzeme";
            this.txtMalzeme.Size = new System.Drawing.Size(100, 20);
            this.txtMalzeme.TabIndex = 11;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(582, 238);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtMiktar.TabIndex = 12;
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(582, 267);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(100, 20);
            this.txtBirim.TabIndex = 13;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(583, 35);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 14;
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Location = new System.Drawing.Point(697, 13);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(75, 23);
            this.btnAyarlar.TabIndex = 15;
            this.btnAyarlar.Text = "Ayarlar";
            this.btnAyarlar.UseVisualStyleBackColor = true;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 296);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtBirim);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtMalzeme);
            this.Controls.Add(this.txtPtur);
            this.Controls.Add(this.txtPboyut);
            this.Controls.Add(this.txtPadi);
            this.Controls.Add(this.btnGuncelle2);
            this.Controls.Add(this.btnSil2);
            this.Controls.Add(this.btnEkle2);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.bntEkle);
            this.Controls.Add(this.dgvIcerik);
            this.Controls.Add(this.dgvPasta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.txtPadi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIcerik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPasta;
        private System.Windows.Forms.DataGridView dgvIcerik;
        private System.Windows.Forms.Button bntEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle2;
        private System.Windows.Forms.Button btnSil2;
        private System.Windows.Forms.Button btnGuncelle2;
        private System.Windows.Forms.TextBox txtPadi;
        private System.Windows.Forms.TextBox txtPboyut;
        private System.Windows.Forms.TextBox txtPtur;
        private System.Windows.Forms.TextBox txtMalzeme;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnAyarlar;
    }
}

