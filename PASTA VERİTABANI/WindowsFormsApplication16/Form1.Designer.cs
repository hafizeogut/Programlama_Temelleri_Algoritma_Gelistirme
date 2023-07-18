namespace WindowsFormsApplication16
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
            this.dgvPc = new System.Windows.Forms.DataGridView();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtPadi = new System.Windows.Forms.TextBox();
            this.txtPboyut = new System.Windows.Forms.TextBox();
            this.txtPtur = new System.Windows.Forms.TextBox();
            this.dgvİcerik = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMalzeme = new System.Windows.Forms.TextBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtBirim = new System.Windows.Forms.TextBox();
            this.btnİsil = new System.Windows.Forms.Button();
            this.btnİekle = new System.Windows.Forms.Button();
            this.btnİgüncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvİcerik)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPc
            // 
            this.dgvPc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPc.Location = new System.Drawing.Point(12, 12);
            this.dgvPc.Name = "dgvPc";
            this.dgvPc.Size = new System.Drawing.Size(601, 150);
            this.dgvPc.TabIndex = 0;
            this.dgvPc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPc_CellContentClick);
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(620, 13);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(59, 149);
            this.btnBaglan.TabIndex = 1;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(10, 204);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(52, 13);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = "Pasta Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Pasta boyutu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Pasta türü";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(52, 185);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 12;
            // 
            // txtPadi
            // 
            this.txtPadi.Location = new System.Drawing.Point(78, 204);
            this.txtPadi.Name = "txtPadi";
            this.txtPadi.Size = new System.Drawing.Size(100, 20);
            this.txtPadi.TabIndex = 13;
            // 
            // txtPboyut
            // 
            this.txtPboyut.Location = new System.Drawing.Point(79, 230);
            this.txtPboyut.Name = "txtPboyut";
            this.txtPboyut.Size = new System.Drawing.Size(100, 20);
            this.txtPboyut.TabIndex = 14;
            // 
            // txtPtur
            // 
            this.txtPtur.Location = new System.Drawing.Point(79, 259);
            this.txtPtur.Name = "txtPtur";
            this.txtPtur.Size = new System.Drawing.Size(100, 20);
            this.txtPtur.TabIndex = 15;
            // 
            // dgvİcerik
            // 
            this.dgvİcerik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvİcerik.Location = new System.Drawing.Point(12, 288);
            this.dgvİcerik.Name = "dgvİcerik";
            this.dgvİcerik.Size = new System.Drawing.Size(601, 118);
            this.dgvİcerik.TabIndex = 17;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(208, 169);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(130, 28);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(208, 204);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(130, 32);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(208, 245);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(130, 37);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(638, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Malzeme :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(641, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Miktar :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(641, 436);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Birim :";
            // 
            // txtMalzeme
            // 
            this.txtMalzeme.Location = new System.Drawing.Point(705, 374);
            this.txtMalzeme.Name = "txtMalzeme";
            this.txtMalzeme.Size = new System.Drawing.Size(100, 20);
            this.txtMalzeme.TabIndex = 24;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(705, 408);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtMiktar.TabIndex = 25;
            // 
            // txtBirim
            // 
            this.txtBirim.Location = new System.Drawing.Point(705, 436);
            this.txtBirim.Name = "txtBirim";
            this.txtBirim.Size = new System.Drawing.Size(100, 20);
            this.txtBirim.TabIndex = 26;
            // 
            // btnİsil
            // 
            this.btnİsil.Location = new System.Drawing.Point(423, 415);
            this.btnİsil.Name = "btnİsil";
            this.btnİsil.Size = new System.Drawing.Size(75, 41);
            this.btnİsil.TabIndex = 27;
            this.btnİsil.Text = "Sil";
            this.btnİsil.UseVisualStyleBackColor = true;
            this.btnİsil.Click += new System.EventHandler(this.btnİsil_Click);
            // 
            // btnİekle
            // 
            this.btnİekle.Location = new System.Drawing.Point(327, 415);
            this.btnİekle.Name = "btnİekle";
            this.btnİekle.Size = new System.Drawing.Size(75, 41);
            this.btnİekle.TabIndex = 28;
            this.btnİekle.Text = "Ekle";
            this.btnİekle.UseVisualStyleBackColor = true;
            this.btnİekle.Click += new System.EventHandler(this.btnİekle_Click);
            // 
            // btnİgüncelle
            // 
            this.btnİgüncelle.Location = new System.Drawing.Point(223, 415);
            this.btnİgüncelle.Name = "btnİgüncelle";
            this.btnİgüncelle.Size = new System.Drawing.Size(75, 41);
            this.btnİgüncelle.TabIndex = 29;
            this.btnİgüncelle.Text = "Güncelle";
            this.btnİgüncelle.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 463);
            this.Controls.Add(this.btnİgüncelle);
            this.Controls.Add(this.btnİekle);
            this.Controls.Add(this.btnİsil);
            this.Controls.Add(this.txtBirim);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.txtMalzeme);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvİcerik);
            this.Controls.Add(this.txtPtur);
            this.Controls.Add(this.txtPboyut);
            this.Controls.Add(this.txtPadi);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.dgvPc);
            this.Name = "Form1";
            this.Text = "Veri tabanı işlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvİcerik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPc;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtPadi;
        private System.Windows.Forms.TextBox txtPboyut;
        private System.Windows.Forms.TextBox txtPtur;
        private System.Windows.Forms.DataGridView dgvİcerik;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMalzeme;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtBirim;
        private System.Windows.Forms.Button btnİsil;
        private System.Windows.Forms.Button btnİekle;
        private System.Windows.Forms.Button btnİgüncelle;
    }
}

