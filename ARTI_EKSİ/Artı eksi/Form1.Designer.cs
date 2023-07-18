namespace Artı_eksi
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
            this.btnAzalt = new System.Windows.Forms.Button();
            this.btnCogalt = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAzalt
            // 
            this.btnAzalt.BackColor = System.Drawing.Color.Red;
            this.btnAzalt.Location = new System.Drawing.Point(5, 7);
            this.btnAzalt.Name = "btnAzalt";
            this.btnAzalt.Size = new System.Drawing.Size(37, 28);
            this.btnAzalt.TabIndex = 0;
            this.btnAzalt.Text = "-";
            this.btnAzalt.UseVisualStyleBackColor = false;
            this.btnAzalt.Click += new System.EventHandler(this.btnAzalt_Click);
            // 
            // btnCogalt
            // 
            this.btnCogalt.BackColor = System.Drawing.Color.Yellow;
            this.btnCogalt.Location = new System.Drawing.Point(86, 7);
            this.btnCogalt.Name = "btnCogalt";
            this.btnCogalt.Size = new System.Drawing.Size(40, 28);
            this.btnCogalt.TabIndex = 1;
            this.btnCogalt.Text = "+";
            this.btnCogalt.UseVisualStyleBackColor = false;
            this.btnCogalt.Click += new System.EventHandler(this.btnCogalt_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(55, 15);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(25, 13);
            this.lblSonuc.TabIndex = 2;
            this.lblSonuc.Text = "100";
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(132, 12);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(100, 20);
            this.txtSayi.TabIndex = 3;
            // 
            // btnAktar
            // 
            this.btnAktar.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnAktar.Location = new System.Drawing.Point(5, 41);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(114, 24);
            this.btnAktar.TabIndex = 4;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = false;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSifirla.Location = new System.Drawing.Point(132, 41);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(100, 24);
            this.btnSifirla.TabIndex = 5;
            this.btnSifirla.Text = "sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 73);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnCogalt);
            this.Controls.Add(this.btnAzalt);
            this.Name = "Form1";
            this.Text = "ARTI-EKSİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAzalt;
        private System.Windows.Forms.Button btnCogalt;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.Button btnSifirla;
    }
}

