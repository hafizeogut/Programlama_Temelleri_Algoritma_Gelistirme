namespace WindowsFormsApplication28
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
            this.btnRenk1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRenk3 = new System.Windows.Forms.Button();
            this.btnRenk2 = new System.Windows.Forms.Button();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.btnBasla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRenk1
            // 
            this.btnRenk1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenk1.Location = new System.Drawing.Point(12, 63);
            this.btnRenk1.Name = "btnRenk1";
            this.btnRenk1.Size = new System.Drawing.Size(75, 134);
            this.btnRenk1.TabIndex = 0;
            this.btnRenk1.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRenk3
            // 
            this.btnRenk3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenk3.Location = new System.Drawing.Point(174, 63);
            this.btnRenk3.Name = "btnRenk3";
            this.btnRenk3.Size = new System.Drawing.Size(75, 134);
            this.btnRenk3.TabIndex = 1;
            this.btnRenk3.UseVisualStyleBackColor = true;
            // 
            // btnRenk2
            // 
            this.btnRenk2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenk2.Location = new System.Drawing.Point(93, 63);
            this.btnRenk2.Name = "btnRenk2";
            this.btnRenk2.Size = new System.Drawing.Size(75, 134);
            this.btnRenk2.TabIndex = 2;
            this.btnRenk2.UseVisualStyleBackColor = true;
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(255, 147);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(122, 20);
            this.txtCevap.TabIndex = 3;
            // 
            // btnTahmin
            // 
            this.btnTahmin.Location = new System.Drawing.Point(255, 174);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(122, 23);
            this.btnTahmin.TabIndex = 4;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Doğru Sayısı";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Location = new System.Drawing.Point(328, 63);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(13, 13);
            this.lblDogru.TabIndex = 6;
            this.lblDogru.Text = "0";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Mistral", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.ForeColor = System.Drawing.Color.Green;
            this.lblSure.Location = new System.Drawing.Point(169, 5);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(31, 26);
            this.lblSure.TabIndex = 7;
            this.lblSure.Text = "60";
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(12, 34);
            this.pBar.Maximum = 60;
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(365, 23);
            this.pBar.TabIndex = 8;
            this.pBar.Value = 60;
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBasla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasla.ForeColor = System.Drawing.Color.Maroon;
            this.btnBasla.Location = new System.Drawing.Point(0, 1);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(43, 23);
            this.btnBasla.TabIndex = 9;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(389, 207);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.btnRenk2);
            this.Controls.Add(this.btnRenk3);
            this.Controls.Add(this.btnRenk1);
            this.ForeColor = System.Drawing.Color.Maroon;
            this.Name = "Form1";
            this.Text = "Direnç Tahmin Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenk1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRenk3;
        private System.Windows.Forms.Button btnRenk2;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Button btnBasla;
    }
}

