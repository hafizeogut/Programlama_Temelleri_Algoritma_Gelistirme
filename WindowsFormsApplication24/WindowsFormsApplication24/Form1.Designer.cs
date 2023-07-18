namespace WindowsFormsApplication24
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
            this.txtYemekAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.dgvYiyecek = new System.Windows.Forms.DataGridView();
            this.pBoxResim = new System.Windows.Forms.PictureBox();
            this.lblTarif = new System.Windows.Forms.Label();
            this.lBoxMalzeme = new System.Windows.Forms.ListBox();
            this.cBoxKisi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYiyecek)).BeginInit();
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
            this.cBoxTur.Location = new System.Drawing.Point(24, 34);
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
            "90",
            "120"});
            this.cBoxZaman.Location = new System.Drawing.Point(180, 34);
            this.cBoxZaman.Name = "cBoxZaman";
            this.cBoxZaman.Size = new System.Drawing.Size(121, 21);
            this.cBoxZaman.TabIndex = 1;
            // 
            // txtYemekAra
            // 
            this.txtYemekAra.Location = new System.Drawing.Point(336, 34);
            this.txtYemekAra.Name = "txtYemekAra";
            this.txtYemekAra.Size = new System.Drawing.Size(100, 20);
            this.txtYemekAra.TabIndex = 2;
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(456, 31);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 3;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            // 
            // dgvYiyecek
            // 
            this.dgvYiyecek.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYiyecek.Location = new System.Drawing.Point(24, 81);
            this.dgvYiyecek.Name = "dgvYiyecek";
            this.dgvYiyecek.Size = new System.Drawing.Size(507, 174);
            this.dgvYiyecek.TabIndex = 4;
            this.dgvYiyecek.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvYiyecek_CellContentClick);
            // 
            // pBoxResim
            // 
            this.pBoxResim.Location = new System.Drawing.Point(538, 31);
            this.pBoxResim.Name = "pBoxResim";
            this.pBoxResim.Size = new System.Drawing.Size(225, 181);
            this.pBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxResim.TabIndex = 5;
            this.pBoxResim.TabStop = false;
            // 
            // lblTarif
            // 
            this.lblTarif.AutoSize = true;
            this.lblTarif.Location = new System.Drawing.Point(537, 226);
            this.lblTarif.Name = "lblTarif";
            this.lblTarif.Size = new System.Drawing.Size(35, 13);
            this.lblTarif.TabIndex = 6;
            this.lblTarif.Text = "label1";
            // 
            // lBoxMalzeme
            // 
            this.lBoxMalzeme.FormattingEnabled = true;
            this.lBoxMalzeme.Location = new System.Drawing.Point(149, 280);
            this.lBoxMalzeme.Name = "lBoxMalzeme";
            this.lBoxMalzeme.Size = new System.Drawing.Size(120, 95);
            this.lBoxMalzeme.TabIndex = 7;
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
            this.cBoxKisi.Location = new System.Drawing.Point(22, 302);
            this.cBoxKisi.Name = "cBoxKisi";
            this.cBoxKisi.Size = new System.Drawing.Size(121, 21);
            this.cBoxKisi.TabIndex = 8;
            this.cBoxKisi.SelectedIndexChanged += new System.EventHandler(this.cBoxKisi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kişi Sayısı";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 443);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cBoxKisi);
            this.Controls.Add(this.lBoxMalzeme);
            this.Controls.Add(this.lblTarif);
            this.Controls.Add(this.pBoxResim);
            this.Controls.Add(this.dgvYiyecek);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtYemekAra);
            this.Controls.Add(this.cBoxZaman);
            this.Controls.Add(this.cBoxTur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYiyecek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxTur;
        private System.Windows.Forms.ComboBox cBoxZaman;
        private System.Windows.Forms.TextBox txtYemekAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.DataGridView dgvYiyecek;
        private System.Windows.Forms.PictureBox pBoxResim;
        private System.Windows.Forms.Label lblTarif;
        private System.Windows.Forms.ListBox lBoxMalzeme;
        private System.Windows.Forms.ComboBox cBoxKisi;
        private System.Windows.Forms.Label label2;
    }
}

