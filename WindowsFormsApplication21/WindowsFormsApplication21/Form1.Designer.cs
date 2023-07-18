namespace WindowsFormsApplication21
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
            this.lbox1 = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.btnZamanAktar = new System.Windows.Forms.Button();
            this.lbox2 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbox1
            // 
            this.lbox1.FormattingEnabled = true;
            this.lbox1.Location = new System.Drawing.Point(13, 78);
            this.lbox1.Name = "lbox1";
            this.lbox1.Size = new System.Drawing.Size(120, 186);
            this.lbox1.TabIndex = 5;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(13, 39);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(120, 34);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(13, 13);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(120, 20);
            this.txtIsim.TabIndex = 4;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(139, 13);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(109, 119);
            this.btnAktar.TabIndex = 2;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // btnZamanAktar
            // 
            this.btnZamanAktar.Location = new System.Drawing.Point(140, 139);
            this.btnZamanAktar.Name = "btnZamanAktar";
            this.btnZamanAktar.Size = new System.Drawing.Size(108, 125);
            this.btnZamanAktar.TabIndex = 3;
            this.btnZamanAktar.Text = "Zamanlı Aktar";
            this.btnZamanAktar.UseVisualStyleBackColor = true;
            this.btnZamanAktar.Click += new System.EventHandler(this.btnZamanAktar_Click);
            // 
            // lbox2
            // 
            this.lbox2.FormattingEnabled = true;
            this.lbox2.Location = new System.Drawing.Point(255, 13);
            this.lbox2.Name = "lbox2";
            this.lbox2.Size = new System.Drawing.Size(120, 251);
            this.lbox2.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 278);
            this.Controls.Add(this.lbox2);
            this.Controls.Add(this.btnZamanAktar);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lbox1);
            this.Name = "Form1";
            this.Text = "Listbox işlemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbox1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Button btnZamanAktar;
        private System.Windows.Forms.ListBox lbox2;
        private System.Windows.Forms.Timer timer1;
    }
}

