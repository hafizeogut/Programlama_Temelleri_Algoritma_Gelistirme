namespace YAKIT_HESAPLAMA
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
            this.cboxYakit = new System.Windows.Forms.ComboBox();
            this.txtMesafe = new System.Windows.Forms.TextBox();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxYakit
            // 
            this.cboxYakit.FormattingEnabled = true;
            this.cboxYakit.Items.AddRange(new object[] {
            "SEÇİNİZ",
            "LPG",
            "BENZİN",
            "MAZOT"});
            this.cboxYakit.Location = new System.Drawing.Point(169, 24);
            this.cboxYakit.Name = "cboxYakit";
            this.cboxYakit.Size = new System.Drawing.Size(121, 21);
            this.cboxYakit.TabIndex = 0;
            // 
            // txtMesafe
            // 
            this.txtMesafe.Location = new System.Drawing.Point(101, 76);
            this.txtMesafe.Name = "txtMesafe";
            this.txtMesafe.Size = new System.Drawing.Size(100, 20);
            this.txtMesafe.TabIndex = 1;
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(166, 209);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(0, 13);
            this.lblSonuc.TabIndex = 3;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(122, 132);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(110, 29);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "yakıt türünü seçiniz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "mesafe giriniz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtMesafe);
            this.Controls.Add(this.cboxYakit);
            this.Name = "Form1";
            this.Text = "Form1";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxYakit;
        private System.Windows.Forms.TextBox txtMesafe;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

