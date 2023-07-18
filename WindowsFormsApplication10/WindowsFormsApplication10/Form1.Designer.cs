namespace WindowsFormsApplication10
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
            this.lblRed = new System.Windows.Forms.Label();
            this.timerRed = new System.Windows.Forms.Timer(this.components);
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnDurdur2 = new System.Windows.Forms.Button();
            this.btnBasla2 = new System.Windows.Forms.Button();
            this.lblGreen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerGreen = new System.Windows.Forms.Timer(this.components);
            this.btnRenkSec = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.tBarRed = new System.Windows.Forms.TrackBar();
            this.tBarGreen = new System.Windows.Forms.TrackBar();
            this.tBarBlue = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tBarRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Red";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(69, 25);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(13, 13);
            this.lblRed.TabIndex = 1;
            this.lblRed.Text = "0";
            // 
            // timerRed
            // 
            this.timerRed.Tick += new System.EventHandler(this.timerRed_Tick);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(39, 48);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(75, 23);
            this.btnBaslat.TabIndex = 2;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.Location = new System.Drawing.Point(39, 77);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(75, 23);
            this.btnDurdur.TabIndex = 3;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = true;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnDurdur2
            // 
            this.btnDurdur2.Location = new System.Drawing.Point(154, 77);
            this.btnDurdur2.Name = "btnDurdur2";
            this.btnDurdur2.Size = new System.Drawing.Size(75, 23);
            this.btnDurdur2.TabIndex = 7;
            this.btnDurdur2.Text = "Durdur";
            this.btnDurdur2.UseVisualStyleBackColor = true;
            this.btnDurdur2.Click += new System.EventHandler(this.btnDurdur2_Click);
            // 
            // btnBasla2
            // 
            this.btnBasla2.Location = new System.Drawing.Point(154, 48);
            this.btnBasla2.Name = "btnBasla2";
            this.btnBasla2.Size = new System.Drawing.Size(75, 23);
            this.btnBasla2.TabIndex = 6;
            this.btnBasla2.Text = "Başlat";
            this.btnBasla2.UseVisualStyleBackColor = true;
            this.btnBasla2.Click += new System.EventHandler(this.btnBasla2_Click);
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(184, 25);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(13, 13);
            this.lblGreen.TabIndex = 5;
            this.lblGreen.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Green";
            // 
            // timerGreen
            // 
            this.timerGreen.Tick += new System.EventHandler(this.timerGreen_Tick);
            // 
            // btnRenkSec
            // 
            this.btnRenkSec.Location = new System.Drawing.Point(329, 48);
            this.btnRenkSec.Name = "btnRenkSec";
            this.btnRenkSec.Size = new System.Drawing.Size(75, 63);
            this.btnRenkSec.TabIndex = 8;
            this.btnRenkSec.Text = "Renk Seç";
            this.btnRenkSec.UseVisualStyleBackColor = true;
            this.btnRenkSec.Click += new System.EventHandler(this.btnRenkSec_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Blue";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(264, 26);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(13, 13);
            this.lblBlue.TabIndex = 10;
            this.lblBlue.Text = "0";
            // 
            // tBarRed
            // 
            this.tBarRed.Location = new System.Drawing.Point(39, 153);
            this.tBarRed.Maximum = 255;
            this.tBarRed.Name = "tBarRed";
            this.tBarRed.Size = new System.Drawing.Size(297, 45);
            this.tBarRed.TabIndex = 11;
            this.tBarRed.Value = 100;
            this.tBarRed.Scroll += new System.EventHandler(this.tBarRed_Scroll);
            // 
            // tBarGreen
            // 
            this.tBarGreen.Location = new System.Drawing.Point(39, 191);
            this.tBarGreen.Maximum = 255;
            this.tBarGreen.Name = "tBarGreen";
            this.tBarGreen.Size = new System.Drawing.Size(297, 45);
            this.tBarGreen.TabIndex = 12;
            this.tBarGreen.Value = 100;
            this.tBarGreen.Scroll += new System.EventHandler(this.tBarGreen_Scroll);
            // 
            // tBarBlue
            // 
            this.tBarBlue.Location = new System.Drawing.Point(39, 230);
            this.tBarBlue.Maximum = 255;
            this.tBarBlue.Name = "tBarBlue";
            this.tBarBlue.Size = new System.Drawing.Size(297, 45);
            this.tBarBlue.TabIndex = 13;
            this.tBarBlue.Value = 100;
            this.tBarBlue.Scroll += new System.EventHandler(this.tBarBlue_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 277);
            this.Controls.Add(this.tBarBlue);
            this.Controls.Add(this.tBarGreen);
            this.Controls.Add(this.tBarRed);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRenkSec);
            this.Controls.Add(this.btnDurdur2);
            this.Controls.Add(this.btnBasla2);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tBarRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBarBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Timer timerRed;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnDurdur2;
        private System.Windows.Forms.Button btnBasla2;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timerGreen;
        private System.Windows.Forms.Button btnRenkSec;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.TrackBar tBarRed;
        private System.Windows.Forms.TrackBar tBarGreen;
        private System.Windows.Forms.TrackBar tBarBlue;
    }
}

