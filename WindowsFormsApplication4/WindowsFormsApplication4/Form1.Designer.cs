namespace WindowsFormsApplication4
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
            this.cboxYas = new System.Windows.Forms.ComboBox();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboxYas
            // 
            this.cboxYas.FormattingEnabled = true;
            this.cboxYas.Items.AddRange(new object[] {
            "Seçiniz",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.cboxYas.Location = new System.Drawing.Point(19, 40);
            this.cboxYas.Name = "cboxYas";
            this.cboxYas.Size = new System.Drawing.Size(121, 21);
            this.cboxYas.TabIndex = 0;
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(22, 67);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(118, 23);
            this.btnKontrol.TabIndex = 1;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Yaşınızı Seçiniz:";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(61, 107);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(0, 13);
            this.lblDurum.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 141);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.cboxYas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxYas;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDurum;
    }
}

