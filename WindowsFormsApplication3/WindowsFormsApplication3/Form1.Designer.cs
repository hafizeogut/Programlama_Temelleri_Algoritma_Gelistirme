namespace WindowsFormsApplication3
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxYas
            // 
            this.cboxYas.FormattingEnabled = true;
            this.cboxYas.Items.AddRange(new object[] {
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19"});
            this.cboxYas.Location = new System.Drawing.Point(77, 29);
            this.cboxYas.Name = "cboxYas";
            this.cboxYas.Size = new System.Drawing.Size(121, 21);
            this.cboxYas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Yaşınızı Seçiniz";
            // 
            // btnKontrol
            // 
            this.btnKontrol.Location = new System.Drawing.Point(80, 80);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(118, 32);
            this.btnKontrol.TabIndex = 2;
            this.btnKontrol.Text = "Kontrol Et";
            this.btnKontrol.UseVisualStyleBackColor = true;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxYas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxYas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKontrol;
    }
}

