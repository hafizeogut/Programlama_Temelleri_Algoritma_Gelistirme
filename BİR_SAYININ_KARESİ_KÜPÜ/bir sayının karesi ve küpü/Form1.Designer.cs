namespace bir_sayının_karesi_ve_küpü
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
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblKare = new System.Windows.Forms.Label();
            this.lblKup = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(14, 12);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(73, 20);
            this.txtSayi.TabIndex = 0;
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHesapla.Location = new System.Drawing.Point(7, 38);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(117, 27);
            this.btnHesapla.TabIndex = 1;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblKare
            // 
            this.lblKare.AutoSize = true;
            this.lblKare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKare.Location = new System.Drawing.Point(11, 86);
            this.lblKare.Name = "lblKare";
            this.lblKare.Size = new System.Drawing.Size(41, 13);
            this.lblKare.TabIndex = 2;
            this.lblKare.Text = "karesi";
            // 
            // lblKup
            // 
            this.lblKup.AutoSize = true;
            this.lblKup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKup.Location = new System.Drawing.Point(89, 85);
            this.lblKup.Name = "lblKup";
            this.lblKup.Size = new System.Drawing.Size(35, 13);
            this.lblKup.TabIndex = 3;
            this.lblKup.Text = "küpü";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(136, 108);
            this.Controls.Add(this.lblKup);
            this.Controls.Add(this.lblKare);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtSayi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblKare;
        private System.Windows.Forms.Label lblKup;
    }
}

