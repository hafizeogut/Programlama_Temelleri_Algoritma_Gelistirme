namespace WindowsFormsApplication29
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
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnRenk2 = new System.Windows.Forms.Button();
            this.btnRenk3 = new System.Windows.Forms.Button();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.btnCEvapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnRenk1
            // 
            this.btnRenk1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenk1.Location = new System.Drawing.Point(36, 113);
            this.btnRenk1.Name = "btnRenk1";
            this.btnRenk1.Size = new System.Drawing.Size(52, 133);
            this.btnRenk1.TabIndex = 0;
            this.btnRenk1.UseVisualStyleBackColor = true;
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(13, 71);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 23);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnRenk2
            // 
            this.btnRenk2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenk2.Location = new System.Drawing.Point(94, 113);
            this.btnRenk2.Name = "btnRenk2";
            this.btnRenk2.Size = new System.Drawing.Size(53, 133);
            this.btnRenk2.TabIndex = 2;
            this.btnRenk2.UseVisualStyleBackColor = true;
            // 
            // btnRenk3
            // 
            this.btnRenk3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenk3.Location = new System.Drawing.Point(153, 113);
            this.btnRenk3.Name = "btnRenk3";
            this.btnRenk3.Size = new System.Drawing.Size(52, 133);
            this.btnRenk3.TabIndex = 3;
            this.btnRenk3.UseVisualStyleBackColor = true;
            // 
            // txtCevap
            // 
            this.txtCevap.Location = new System.Drawing.Point(27, 282);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(100, 20);
            this.txtCevap.TabIndex = 4;
            // 
            // btnCEvapla
            // 
            this.btnCEvapla.Location = new System.Drawing.Point(27, 309);
            this.btnCEvapla.Name = "btnCEvapla";
            this.btnCEvapla.Size = new System.Drawing.Size(100, 23);
            this.btnCEvapla.TabIndex = 5;
            this.btnCEvapla.Text = "CEvapla";
            this.btnCEvapla.UseVisualStyleBackColor = true;
            this.btnCEvapla.Click += new System.EventHandler(this.btnCEvapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Doğru Sayısı";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Location = new System.Drawing.Point(369, 113);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(13, 13);
            this.lblDogru.TabIndex = 7;
            this.lblDogru.Text = "0";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(321, 14);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(19, 13);
            this.lblSure.TabIndex = 8;
            this.lblSure.Text = "60";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 30);
            this.progressBar1.Maximum = 60;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(685, 23);
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Value = 60;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 395);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCEvapla);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.btnRenk3);
            this.Controls.Add(this.btnRenk2);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.btnRenk1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRenk1;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnRenk2;
        private System.Windows.Forms.Button btnRenk3;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Button btnCEvapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}

