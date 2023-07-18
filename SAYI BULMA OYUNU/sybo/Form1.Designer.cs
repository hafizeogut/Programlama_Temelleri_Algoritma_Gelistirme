namespace sybo
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
            this.lblDurum = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSonuc = new System.Windows.Forms.Label();
            this.pbBar = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(22, 9);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(10, 13);
            this.lblDurum.TabIndex = 0;
            this.lblDurum.Text = " ";
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(12, 59);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 57);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.Text = "OYUNU BUŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnTahmin
            // 
            this.btnTahmin.Location = new System.Drawing.Point(103, 59);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(75, 57);
            this.btnTahmin.TabIndex = 2;
            this.btnTahmin.Text = "TAHMİN ET";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Visible = false;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(53, 33);
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(75, 20);
            this.txtSayi.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(75, 133);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(13, 13);
            this.lblSonuc.TabIndex = 4;
            this.lblSonuc.Text = "0";
            // 
            // pbBar
            // 
            this.pbBar.Location = new System.Drawing.Point(125, 149);
            this.pbBar.Name = "pbBar";
            this.pbBar.Size = new System.Drawing.Size(100, 23);
            this.pbBar.TabIndex = 5;
            this.pbBar.Click += new System.EventHandler(this.pbBar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "BAŞLA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 219);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbBar);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblDurum);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.ProgressBar pbBar;
        private System.Windows.Forms.Button button1;
    }
}

