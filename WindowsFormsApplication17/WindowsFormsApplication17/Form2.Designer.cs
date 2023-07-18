namespace WindowsFormsApplication17
{
    partial class Form2
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
            this.btnFonk1 = new System.Windows.Forms.Button();
            this.lblYazi = new System.Windows.Forms.Label();
            this.btnFonk2 = new System.Windows.Forms.Button();
            this.txtFonk2Deger = new System.Windows.Forms.TextBox();
            this.lboxYazi = new System.Windows.Forms.ListBox();
            this.btnFonk22 = new System.Windows.Forms.Button();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtDeger = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFonk1
            // 
            this.btnFonk1.Location = new System.Drawing.Point(13, 13);
            this.btnFonk1.Name = "btnFonk1";
            this.btnFonk1.Size = new System.Drawing.Size(90, 23);
            this.btnFonk1.TabIndex = 0;
            this.btnFonk1.Text = "Renk Değiştir";
            this.btnFonk1.UseVisualStyleBackColor = true;
            this.btnFonk1.Click += new System.EventHandler(this.btnFonk1_Click);
            // 
            // lblYazi
            // 
            this.lblYazi.AutoSize = true;
            this.lblYazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYazi.Location = new System.Drawing.Point(119, 13);
            this.lblYazi.Name = "lblYazi";
            this.lblYazi.Size = new System.Drawing.Size(141, 25);
            this.lblYazi.TabIndex = 1;
            this.lblYazi.Text = "Selam Millet";
            // 
            // btnFonk2
            // 
            this.btnFonk2.Location = new System.Drawing.Point(13, 63);
            this.btnFonk2.Name = "btnFonk2";
            this.btnFonk2.Size = new System.Drawing.Size(90, 23);
            this.btnFonk2.TabIndex = 2;
            this.btnFonk2.Text = "Listeye yaz";
            this.btnFonk2.UseVisualStyleBackColor = true;
            this.btnFonk2.Click += new System.EventHandler(this.btnFonk2_Click);
            // 
            // txtFonk2Deger
            // 
            this.txtFonk2Deger.Location = new System.Drawing.Point(110, 65);
            this.txtFonk2Deger.Name = "txtFonk2Deger";
            this.txtFonk2Deger.Size = new System.Drawing.Size(100, 20);
            this.txtFonk2Deger.TabIndex = 3;
            // 
            // lboxYazi
            // 
            this.lboxYazi.FormattingEnabled = true;
            this.lboxYazi.Location = new System.Drawing.Point(226, 65);
            this.lboxYazi.Name = "lboxYazi";
            this.lboxYazi.Size = new System.Drawing.Size(120, 95);
            this.lboxYazi.TabIndex = 4;
            // 
            // btnFonk22
            // 
            this.btnFonk22.Location = new System.Drawing.Point(13, 204);
            this.btnFonk22.Name = "btnFonk22";
            this.btnFonk22.Size = new System.Drawing.Size(90, 23);
            this.btnFonk22.TabIndex = 5;
            this.btnFonk22.Text = "Listeye yaz2";
            this.btnFonk22.UseVisualStyleBackColor = true;
            this.btnFonk22.Click += new System.EventHandler(this.btnFonk22_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(110, 207);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(100, 20);
            this.txtIsim.TabIndex = 6;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(13, 246);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(90, 23);
            this.btnHesapla.TabIndex = 7;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtDeger
            // 
            this.txtDeger.Location = new System.Drawing.Point(110, 248);
            this.txtDeger.Name = "txtDeger";
            this.txtDeger.Size = new System.Drawing.Size(100, 20);
            this.txtDeger.TabIndex = 8;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 350);
            this.Controls.Add(this.txtDeger);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.btnFonk22);
            this.Controls.Add(this.lboxYazi);
            this.Controls.Add(this.txtFonk2Deger);
            this.Controls.Add(this.btnFonk2);
            this.Controls.Add(this.lblYazi);
            this.Controls.Add(this.btnFonk1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFonk1;
        private System.Windows.Forms.Label lblYazi;
        private System.Windows.Forms.Button btnFonk2;
        private System.Windows.Forms.TextBox txtFonk2Deger;
        private System.Windows.Forms.ListBox lboxYazi;
        private System.Windows.Forms.Button btnFonk22;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtDeger;
    }
}