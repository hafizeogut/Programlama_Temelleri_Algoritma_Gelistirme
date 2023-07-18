namespace WindowsFormsApplication9
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.btnBaslaRed = new System.Windows.Forms.Button();
            this.btnDurdurRed = new System.Windows.Forms.Button();
            this.btnBaslaGreen = new System.Windows.Forms.Button();
            this.btnDurdurGreen = new System.Windows.Forms.Button();
            this.btnBaslaBlue = new System.Windows.Forms.Button();
            this.btnDurdurBlue = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.timerRed = new System.Windows.Forms.Timer(this.components);
            this.timerGreen = new System.Windows.Forms.Timer(this.components);
            this.timerBlue = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Blue";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(36, 30);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(13, 13);
            this.lblRed.TabIndex = 3;
            this.lblRed.Text = "0";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(123, 30);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(13, 13);
            this.lblGreen.TabIndex = 4;
            this.lblGreen.Text = "0";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(202, 30);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(13, 13);
            this.lblBlue.TabIndex = 5;
            this.lblBlue.Text = "0";
            // 
            // btnBaslaRed
            // 
            this.btnBaslaRed.Location = new System.Drawing.Point(12, 62);
            this.btnBaslaRed.Name = "btnBaslaRed";
            this.btnBaslaRed.Size = new System.Drawing.Size(75, 23);
            this.btnBaslaRed.TabIndex = 6;
            this.btnBaslaRed.Text = "Başlat";
            this.btnBaslaRed.UseVisualStyleBackColor = true;
            this.btnBaslaRed.Click += new System.EventHandler(this.btnBaslaRed_Click);
            // 
            // btnDurdurRed
            // 
            this.btnDurdurRed.Location = new System.Drawing.Point(12, 91);
            this.btnDurdurRed.Name = "btnDurdurRed";
            this.btnDurdurRed.Size = new System.Drawing.Size(75, 23);
            this.btnDurdurRed.TabIndex = 7;
            this.btnDurdurRed.Text = "Durdur";
            this.btnDurdurRed.UseVisualStyleBackColor = true;
            this.btnDurdurRed.Click += new System.EventHandler(this.btnDurdurRed_Click);
            // 
            // btnBaslaGreen
            // 
            this.btnBaslaGreen.Location = new System.Drawing.Point(93, 62);
            this.btnBaslaGreen.Name = "btnBaslaGreen";
            this.btnBaslaGreen.Size = new System.Drawing.Size(75, 23);
            this.btnBaslaGreen.TabIndex = 8;
            this.btnBaslaGreen.Text = "Başlat";
            this.btnBaslaGreen.UseVisualStyleBackColor = true;
            this.btnBaslaGreen.Click += new System.EventHandler(this.btnBaslaGreen_Click);
            // 
            // btnDurdurGreen
            // 
            this.btnDurdurGreen.Location = new System.Drawing.Point(93, 91);
            this.btnDurdurGreen.Name = "btnDurdurGreen";
            this.btnDurdurGreen.Size = new System.Drawing.Size(75, 23);
            this.btnDurdurGreen.TabIndex = 9;
            this.btnDurdurGreen.Text = "Durdur";
            this.btnDurdurGreen.UseVisualStyleBackColor = true;
            this.btnDurdurGreen.Click += new System.EventHandler(this.btnDurdurGreen_Click);
            // 
            // btnBaslaBlue
            // 
            this.btnBaslaBlue.Location = new System.Drawing.Point(174, 62);
            this.btnBaslaBlue.Name = "btnBaslaBlue";
            this.btnBaslaBlue.Size = new System.Drawing.Size(75, 23);
            this.btnBaslaBlue.TabIndex = 10;
            this.btnBaslaBlue.Text = "Başlat";
            this.btnBaslaBlue.UseVisualStyleBackColor = true;
            this.btnBaslaBlue.Click += new System.EventHandler(this.btnBaslaBlue_Click);
            // 
            // btnDurdurBlue
            // 
            this.btnDurdurBlue.Location = new System.Drawing.Point(174, 91);
            this.btnDurdurBlue.Name = "btnDurdurBlue";
            this.btnDurdurBlue.Size = new System.Drawing.Size(75, 23);
            this.btnDurdurBlue.TabIndex = 11;
            this.btnDurdurBlue.Text = "Durdur";
            this.btnDurdurBlue.UseVisualStyleBackColor = true;
            this.btnDurdurBlue.Click += new System.EventHandler(this.btnDurdurBlue_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(255, 13);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(75, 101);
            this.btnSifirla.TabIndex = 12;
            this.btnSifirla.Text = "Sıfırlar";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // timerRed
            // 
            this.timerRed.Tick += new System.EventHandler(this.timerRed_Tick);
            // 
            // timerGreen
            // 
            this.timerGreen.Tick += new System.EventHandler(this.timerGreen_Tick);
            // 
            // timerBlue
            // 
            this.timerBlue.Tick += new System.EventHandler(this.timerBlue_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 126);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnDurdurBlue);
            this.Controls.Add(this.btnBaslaBlue);
            this.Controls.Add(this.btnDurdurGreen);
            this.Controls.Add(this.btnBaslaGreen);
            this.Controls.Add(this.btnDurdurRed);
            this.Controls.Add(this.btnBaslaRed);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Button btnBaslaRed;
        private System.Windows.Forms.Button btnDurdurRed;
        private System.Windows.Forms.Button btnBaslaGreen;
        private System.Windows.Forms.Button btnDurdurGreen;
        private System.Windows.Forms.Button btnBaslaBlue;
        private System.Windows.Forms.Button btnDurdurBlue;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Timer timerRed;
        private System.Windows.Forms.Timer timerGreen;
        private System.Windows.Forms.Timer timerBlue;
    }
}

