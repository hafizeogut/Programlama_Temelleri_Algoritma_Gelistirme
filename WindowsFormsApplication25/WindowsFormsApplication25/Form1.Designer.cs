namespace WindowsFormsApplication25
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
            this.cBoxTur = new System.Windows.Forms.ComboBox();
            this.cBoxZaman = new System.Windows.Forms.ComboBox();
            this.txtYemek = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.dgvYemekler = new System.Windows.Forms.DataGridView();
            this.pBoxResim = new System.Windows.Forms.PictureBox();
            this.lblTarif = new System.Windows.Forms.Label();
            this.cBoxKisi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lBoxMalzemeler = new System.Windows.Forms.ListBox();
            this.txtBonusAra = new System.Windows.Forms.TextBox();
            this.btnBonusAra = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // cBoxTur
            // 
            this.cBoxTur.FormattingEnabled = true;
            this.cBoxTur.Items.AddRange(new object[] {
            "Seçiniz",
            "yemek",
            "çorba",
            "tatlı"});
            this.cBoxTur.Location = new System.Drawing.Point(13, 13);
            this.cBoxTur.Name = "cBoxTur";
            this.cBoxTur.Size = new System.Drawing.Size(121, 21);
            this.cBoxTur.TabIndex = 0;
            this.cBoxTur.SelectedIndexChanged += new System.EventHandler(this.cBoxTur_SelectedIndexChanged);
            // 
            // cBoxZaman
            // 
            this.cBoxZaman.FormattingEnabled = true;
            this.cBoxZaman.Items.AddRange(new object[] {
            "Seçiniz",
            "15",
            "30",
            "45",
            "60",
            "75",
            "90"});
            this.cBoxZaman.Location = new System.Drawing.Point(140, 11);
            this.cBoxZaman.Name = "cBoxZaman";
            this.cBoxZaman.Size = new System.Drawing.Size(121, 21);
            this.cBoxZaman.TabIndex = 1;
            // 
            // txtYemek
            // 
            this.txtYemek.Location = new System.Drawing.Point(277, 13);
            this.txtYemek.Name = "txtYemek";
            this.txtYemek.Size = new System.Drawing.Size(100, 20);
            this.txtYemek.TabIndex = 2;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(383, 12);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // dgvYemekler
            // 
            this.dgvYemekler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYemekler.Location = new System.Drawing.Point(13, 52);
            this.dgvYemekler.Name = "dgvYemekler";
            this.dgvYemekler.Size = new System.Drawing.Size(445, 103);
            this.dgvYemekler.TabIndex = 4;
            this.dgvYemekler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYemekler_CellContentClick);
            // 
            // pBoxResim
            // 
            this.pBoxResim.Location = new System.Drawing.Point(12, 161);
            this.pBoxResim.Name = "pBoxResim";
            this.pBoxResim.Size = new System.Drawing.Size(225, 132);
            this.pBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxResim.TabIndex = 5;
            this.pBoxResim.TabStop = false;
            // 
            // lblTarif
            // 
            this.lblTarif.AutoSize = true;
            this.lblTarif.Location = new System.Drawing.Point(243, 161);
            this.lblTarif.Name = "lblTarif";
            this.lblTarif.Size = new System.Drawing.Size(35, 13);
            this.lblTarif.TabIndex = 6;
            this.lblTarif.Text = "label1";
            // 
            // cBoxKisi
            // 
            this.cBoxKisi.FormattingEnabled = true;
            this.cBoxKisi.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cBoxKisi.Location = new System.Drawing.Point(484, 68);
            this.cBoxKisi.Name = "cBoxKisi";
            this.cBoxKisi.Size = new System.Drawing.Size(59, 21);
            this.cBoxKisi.TabIndex = 7;
            this.cBoxKisi.SelectedIndexChanged += new System.EventHandler(this.cBoxKisi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(481, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kişi Sayısı";
            // 
            // lBoxMalzemeler
            // 
            this.lBoxMalzemeler.FormattingEnabled = true;
            this.lBoxMalzemeler.Location = new System.Drawing.Point(565, 52);
            this.lBoxMalzemeler.Name = "lBoxMalzemeler";
            this.lBoxMalzemeler.Size = new System.Drawing.Size(124, 108);
            this.lBoxMalzemeler.TabIndex = 9;
            // 
            // txtBonusAra
            // 
            this.txtBonusAra.Location = new System.Drawing.Point(472, 235);
            this.txtBonusAra.Name = "txtBonusAra";
            this.txtBonusAra.Size = new System.Drawing.Size(100, 20);
            this.txtBonusAra.TabIndex = 10;
            // 
            // btnBonusAra
            // 
            this.btnBonusAra.Location = new System.Drawing.Point(578, 232);
            this.btnBonusAra.Name = "btnBonusAra";
            this.btnBonusAra.Size = new System.Drawing.Size(75, 23);
            this.btnBonusAra.TabIndex = 11;
            this.btnBonusAra.Text = "ARA";
            this.btnBonusAra.UseVisualStyleBackColor = true;
            this.btnBonusAra.Click += new System.EventHandler(this.btnBonusAra_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 306);
            this.Controls.Add(this.btnBonusAra);
            this.Controls.Add(this.txtBonusAra);
            this.Controls.Add(this.lBoxMalzemeler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxKisi);
            this.Controls.Add(this.lblTarif);
            this.Controls.Add(this.pBoxResim);
            this.Controls.Add(this.dgvYemekler);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtYemek);
            this.Controls.Add(this.cBoxZaman);
            this.Controls.Add(this.cBoxTur);
            this.Name = "Form1";
            this.Text = "Yemeklerimiz ve biz";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYemekler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxTur;
        private System.Windows.Forms.ComboBox cBoxZaman;
        private System.Windows.Forms.TextBox txtYemek;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dgvYemekler;
        private System.Windows.Forms.PictureBox pBoxResim;
        private System.Windows.Forms.Label lblTarif;
        private System.Windows.Forms.ComboBox cBoxKisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBoxMalzemeler;
        private System.Windows.Forms.TextBox txtBonusAra;
        private System.Windows.Forms.Button btnBonusAra;
    }
}

