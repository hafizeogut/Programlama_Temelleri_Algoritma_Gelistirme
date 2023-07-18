namespace _22222222
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtTuketim = new System.Windows.Forms.TextBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.txtUcret = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elektirik Tüketimi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Çalışma Süresi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Elektirim Ücreti";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.BackColor = System.Drawing.Color.White;
            this.lblSonuc.Location = new System.Drawing.Point(239, 40);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(13, 13);
            this.lblSonuc.TabIndex = 3;
            this.lblSonuc.Text = "0";
            // 
            // txtTuketim
            // 
            this.txtTuketim.BackColor = System.Drawing.Color.White;
            this.txtTuketim.Location = new System.Drawing.Point(93, 6);
            this.txtTuketim.Name = "txtTuketim";
            this.txtTuketim.Size = new System.Drawing.Size(75, 20);
            this.txtTuketim.TabIndex = 4;
            // 
            // txtSure
            // 
            this.txtSure.BackColor = System.Drawing.Color.White;
            this.txtSure.Location = new System.Drawing.Point(93, 40);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(75, 20);
            this.txtSure.TabIndex = 5;
            // 
            // txtUcret
            // 
            this.txtUcret.BackColor = System.Drawing.Color.White;
            this.txtUcret.Location = new System.Drawing.Point(95, 75);
            this.txtUcret.Name = "txtUcret";
            this.txtUcret.Size = new System.Drawing.Size(73, 20);
            this.txtUcret.TabIndex = 6;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.White;
            this.btnHesapla.Location = new System.Drawing.Point(174, 16);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(59, 67);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(263, 110);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtUcret);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.txtTuketim);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ELEKTİRİK TÜKETİMİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtTuketim;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.TextBox txtUcret;
        private System.Windows.Forms.Button btnHesapla;
    }
}

