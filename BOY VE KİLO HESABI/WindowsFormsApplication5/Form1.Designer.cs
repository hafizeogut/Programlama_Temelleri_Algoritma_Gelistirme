namespace WindowsFormsApplication5
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.cboxBoy = new System.Windows.Forms.ComboBox();
            this.cboxKilo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(194, 1);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 46);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "KİLO(kg)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "BOY(cm)";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(275, 1);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(79, 13);
            this.lblDurum.TabIndex = 3;
            this.lblDurum.Text = "DURUMUNUZ";
            this.lblDurum.Click += new System.EventHandler(this.lblDurum_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(307, 29);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(13, 13);
            this.lblSonuc.TabIndex = 4;
            this.lblSonuc.Text = "0";
            // 
            // cboxBoy
            // 
            this.cboxBoy.FormattingEnabled = true;
            this.cboxBoy.Location = new System.Drawing.Point(67, 1);
            this.cboxBoy.Name = "cboxBoy";
            this.cboxBoy.Size = new System.Drawing.Size(121, 21);
            this.cboxBoy.TabIndex = 5;
            // 
            // cboxKilo
            // 
            this.cboxKilo.FormattingEnabled = true;
            this.cboxKilo.Location = new System.Drawing.Point(67, 26);
            this.cboxKilo.Name = "cboxKilo";
            this.cboxKilo.Size = new System.Drawing.Size(121, 21);
            this.cboxKilo.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(362, 60);
            this.Controls.Add(this.cboxKilo);
            this.Controls.Add(this.cboxBoy);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "BOY VE KİLO HESABI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.ComboBox cboxBoy;
        private System.Windows.Forms.ComboBox cboxKilo;
    }
}

