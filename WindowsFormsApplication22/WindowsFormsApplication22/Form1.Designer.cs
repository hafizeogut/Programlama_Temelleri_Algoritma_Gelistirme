namespace WindowsFormsApplication22
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
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lBox1 = new System.Windows.Forms.ListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.btnOtoAktar = new System.Windows.Forms.Button();
            this.lBox2 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(12, 12);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(54, 20);
            this.txtAdet.TabIndex = 0;
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(72, 12);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(137, 20);
            this.txtIsim.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(12, 38);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(197, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lBox1
            // 
            this.lBox1.FormattingEnabled = true;
            this.lBox1.Location = new System.Drawing.Point(12, 67);
            this.lBox1.Name = "lBox1";
            this.lBox1.Size = new System.Drawing.Size(197, 147);
            this.lBox1.TabIndex = 3;
            // 
            // btnAktar
            // 
            this.btnAktar.Location = new System.Drawing.Point(215, 67);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(75, 76);
            this.btnAktar.TabIndex = 4;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = true;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // btnOtoAktar
            // 
            this.btnOtoAktar.Location = new System.Drawing.Point(215, 149);
            this.btnOtoAktar.Name = "btnOtoAktar";
            this.btnOtoAktar.Size = new System.Drawing.Size(75, 65);
            this.btnOtoAktar.TabIndex = 5;
            this.btnOtoAktar.Text = "Oto Aktar";
            this.btnOtoAktar.UseVisualStyleBackColor = true;
            this.btnOtoAktar.Click += new System.EventHandler(this.btnOtoAktar_Click);
            // 
            // lBox2
            // 
            this.lBox2.FormattingEnabled = true;
            this.lBox2.Location = new System.Drawing.Point(296, 67);
            this.lBox2.Name = "lBox2";
            this.lBox2.Size = new System.Drawing.Size(188, 147);
            this.lBox2.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 227);
            this.Controls.Add(this.lBox2);
            this.Controls.Add(this.btnOtoAktar);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.lBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.txtAdet);
            this.Name = "Form1";
            this.Text = "ListBox işlemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lBox1;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Button btnOtoAktar;
        private System.Windows.Forms.ListBox lBox2;
        private System.Windows.Forms.Timer timer1;
    }
}

