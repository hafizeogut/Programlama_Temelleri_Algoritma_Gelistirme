namespace fonksiyon
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
            this.btnAnaEkreneBag = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnaEkreneBag
            // 
            this.btnAnaEkreneBag.Location = new System.Drawing.Point(12, 2);
            this.btnAnaEkreneBag.Name = "btnAnaEkreneBag";
            this.btnAnaEkreneBag.Size = new System.Drawing.Size(154, 23);
            this.btnAnaEkreneBag.TabIndex = 0;
            this.btnAnaEkreneBag.Text = "ANA EKRANA BAĞLAN";
            this.btnAnaEkreneBag.UseVisualStyleBackColor = true;
            this.btnAnaEkreneBag.Click += new System.EventHandler(this.btnAnaEkreneBag_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(12, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(154, 23);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "KAPAT";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(178, 63);
            this.ControlBox = false;
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnAnaEkreneBag);
            this.Name = "Form1";
            this.Text = "GİRİŞ EKRANI";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnaEkreneBag;
        private System.Windows.Forms.Button btnKapat;
    }
}

