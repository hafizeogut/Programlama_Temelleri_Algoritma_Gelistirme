namespace pasta
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
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.dgvPasta = new System.Windows.Forms.DataGridView();
            this.dgvMalzeme = new System.Windows.Forms.DataGridView();
            this.txtPadi = new System.Windows.Forms.TextBox();
            this.txtPboy = new System.Windows.Forms.TextBox();
            this.txtPtur = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.LABEL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGuncellee = new System.Windows.Forms.Button();
            this.btnSill = new System.Windows.Forms.Button();
            this.btnEklee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIDD = new System.Windows.Forms.Label();
            this.txtPastaTuru = new System.Windows.Forms.TextBox();
            this.txtPastaBoy = new System.Windows.Forms.TextBox();
            this.txtPastaAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMalzeme)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(596, 28);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(596, 57);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(596, 86);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(344, 174);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(75, 81);
            this.btnBaglan.TabIndex = 3;
            this.btnBaglan.Text = "BAĞLAN";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // dgvPasta
            // 
            this.dgvPasta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPasta.Location = new System.Drawing.Point(12, 12);
            this.dgvPasta.Name = "dgvPasta";
            this.dgvPasta.Size = new System.Drawing.Size(326, 193);
            this.dgvPasta.TabIndex = 5;
            this.dgvPasta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPasta_CellContentClick);
            // 
            // dgvMalzeme
            // 
            this.dgvMalzeme.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMalzeme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMalzeme.Location = new System.Drawing.Point(12, 210);
            this.dgvMalzeme.Name = "dgvMalzeme";
            this.dgvMalzeme.Size = new System.Drawing.Size(326, 193);
            this.dgvMalzeme.TabIndex = 6;
            this.dgvMalzeme.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMalzeme_CellContentClick);
            // 
            // txtPadi
            // 
            this.txtPadi.Location = new System.Drawing.Point(473, 33);
            this.txtPadi.Name = "txtPadi";
            this.txtPadi.Size = new System.Drawing.Size(100, 20);
            this.txtPadi.TabIndex = 7;
            // 
            // txtPboy
            // 
            this.txtPboy.Location = new System.Drawing.Point(473, 62);
            this.txtPboy.Name = "txtPboy";
            this.txtPboy.Size = new System.Drawing.Size(100, 20);
            this.txtPboy.TabIndex = 8;
            // 
            // txtPtur
            // 
            this.txtPtur.Location = new System.Drawing.Point(473, 91);
            this.txtPtur.Name = "txtPtur";
            this.txtPtur.Size = new System.Drawing.Size(100, 20);
            this.txtPtur.TabIndex = 9;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(470, 12);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(13, 13);
            this.lblID.TabIndex = 10;
            this.lblID.Text = "0";
            // 
            // LABEL
            // 
            this.LABEL.AutoSize = true;
            this.LABEL.Location = new System.Drawing.Point(368, 12);
            this.LABEL.Name = "LABEL";
            this.LABEL.Size = new System.Drawing.Size(18, 13);
            this.LABEL.TabIndex = 11;
            this.LABEL.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Pasta Adi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Pasta Boyutu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Pasta Türü";
            // 
            // btnGuncellee
            // 
            this.btnGuncellee.Location = new System.Drawing.Point(596, 357);
            this.btnGuncellee.Name = "btnGuncellee";
            this.btnGuncellee.Size = new System.Drawing.Size(75, 23);
            this.btnGuncellee.TabIndex = 17;
            this.btnGuncellee.Text = "GÜNCELLE";
            this.btnGuncellee.UseVisualStyleBackColor = true;
            this.btnGuncellee.Click += new System.EventHandler(this.btnGuncellee_Click);
            // 
            // btnSill
            // 
            this.btnSill.Location = new System.Drawing.Point(596, 328);
            this.btnSill.Name = "btnSill";
            this.btnSill.Size = new System.Drawing.Size(75, 23);
            this.btnSill.TabIndex = 16;
            this.btnSill.Text = "SİL";
            this.btnSill.UseVisualStyleBackColor = true;
            this.btnSill.Click += new System.EventHandler(this.btnSill_Click);
            // 
            // btnEklee
            // 
            this.btnEklee.Location = new System.Drawing.Point(596, 299);
            this.btnEklee.Name = "btnEklee";
            this.btnEklee.Size = new System.Drawing.Size(75, 23);
            this.btnEklee.TabIndex = 15;
            this.btnEklee.Text = "EKLE";
            this.btnEklee.UseVisualStyleBackColor = true;
            this.btnEklee.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Pasta Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Pasta Boyutu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Pasta Adi";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(359, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "ID";
            // 
            // lblIDD
            // 
            this.lblIDD.AutoSize = true;
            this.lblIDD.Location = new System.Drawing.Point(480, 278);
            this.lblIDD.Name = "lblIDD";
            this.lblIDD.Size = new System.Drawing.Size(13, 13);
            this.lblIDD.TabIndex = 21;
            this.lblIDD.Text = "0";
            // 
            // txtPastaTuru
            // 
            this.txtPastaTuru.Location = new System.Drawing.Point(464, 362);
            this.txtPastaTuru.Name = "txtPastaTuru";
            this.txtPastaTuru.Size = new System.Drawing.Size(100, 20);
            this.txtPastaTuru.TabIndex = 20;
            // 
            // txtPastaBoy
            // 
            this.txtPastaBoy.Location = new System.Drawing.Point(464, 333);
            this.txtPastaBoy.Name = "txtPastaBoy";
            this.txtPastaBoy.Size = new System.Drawing.Size(100, 20);
            this.txtPastaBoy.TabIndex = 19;
            // 
            // txtPastaAdi
            // 
            this.txtPastaAdi.Location = new System.Drawing.Point(464, 304);
            this.txtPastaAdi.Name = "txtPastaAdi";
            this.txtPastaAdi.Size = new System.Drawing.Size(100, 20);
            this.txtPastaAdi.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 406);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblIDD);
            this.Controls.Add(this.txtPastaTuru);
            this.Controls.Add(this.txtPastaBoy);
            this.Controls.Add(this.txtPastaAdi);
            this.Controls.Add(this.btnGuncellee);
            this.Controls.Add(this.btnSill);
            this.Controls.Add(this.btnEklee);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LABEL);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtPtur);
            this.Controls.Add(this.txtPboy);
            this.Controls.Add(this.txtPadi);
            this.Controls.Add(this.dgvMalzeme);
            this.Controls.Add(this.dgvPasta);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMalzeme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.DataGridView dgvPasta;
        private System.Windows.Forms.DataGridView dgvMalzeme;
        private System.Windows.Forms.TextBox txtPadi;
        private System.Windows.Forms.TextBox txtPboy;
        private System.Windows.Forms.TextBox txtPtur;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label LABEL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuncellee;
        private System.Windows.Forms.Button btnSill;
        private System.Windows.Forms.Button btnEklee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblIDD;
        private System.Windows.Forms.TextBox txtPastaTuru;
        private System.Windows.Forms.TextBox txtPastaBoy;
        private System.Windows.Forms.TextBox txtPastaAdi;
    }
}

