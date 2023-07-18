namespace IlacDenet
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblYanEtki = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKullanim = new System.Windows.Forms.Label();
            this.pboxResim = new System.Windows.Forms.PictureBox();
            this.dgvGoster = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoster)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblYanEtki);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(605, 172);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YAN ETKİLERİ";
            // 
            // lblYanEtki
            // 
            this.lblYanEtki.AutoSize = true;
            this.lblYanEtki.Location = new System.Drawing.Point(6, 18);
            this.lblYanEtki.Name = "lblYanEtki";
            this.lblYanEtki.Size = new System.Drawing.Size(14, 15);
            this.lblYanEtki.TabIndex = 5;
            this.lblYanEtki.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblKullanim);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(605, 180);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KULLUNIM ŞEKİLLERİ";
            // 
            // lblKullanim
            // 
            this.lblKullanim.AutoSize = true;
            this.lblKullanim.Location = new System.Drawing.Point(6, 18);
            this.lblKullanim.Name = "lblKullanim";
            this.lblKullanim.Size = new System.Drawing.Size(14, 15);
            this.lblKullanim.TabIndex = 3;
            this.lblKullanim.Text = "0";
            // 
            // pboxResim
            // 
            this.pboxResim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxResim.Location = new System.Drawing.Point(623, 12);
            this.pboxResim.Name = "pboxResim";
            this.pboxResim.Size = new System.Drawing.Size(367, 180);
            this.pboxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxResim.TabIndex = 7;
            this.pboxResim.TabStop = false;
            // 
            // dgvGoster
            // 
            this.dgvGoster.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGoster.Location = new System.Drawing.Point(623, 223);
            this.dgvGoster.Name = "dgvGoster";
            this.dgvGoster.Size = new System.Drawing.Size(369, 224);
            this.dgvGoster.TabIndex = 11;
            this.dgvGoster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGoster_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 459);
            this.Controls.Add(this.dgvGoster);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pboxResim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGoster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblYanEtki;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKullanim;
        private System.Windows.Forms.PictureBox pboxResim;
        private System.Windows.Forms.DataGridView dgvGoster;
    }
}

