namespace WindowsFormsApplication7
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
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnDurdur = new System.Windows.Forms.Button();
            this.btnSifirla = new System.Windows.Forms.Button();
            this.lblSayi = new System.Windows.Forms.Label();
            this.tmrSayac = new System.Windows.Forms.Timer(this.components);
            this.pbarGosterge = new System.Windows.Forms.ProgressBar();
            this.tbarHiz = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbarHiz)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.Green;
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(13, 66);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(86, 39);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnDurdur
            // 
            this.btnDurdur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDurdur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDurdur.Location = new System.Drawing.Point(105, 66);
            this.btnDurdur.Name = "btnDurdur";
            this.btnDurdur.Size = new System.Drawing.Size(75, 39);
            this.btnDurdur.TabIndex = 1;
            this.btnDurdur.Text = "Durdur";
            this.btnDurdur.UseVisualStyleBackColor = false;
            this.btnDurdur.Click += new System.EventHandler(this.btnDurdur_Click);
            // 
            // btnSifirla
            // 
            this.btnSifirla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSifirla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSifirla.Location = new System.Drawing.Point(13, 111);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(167, 36);
            this.btnSifirla.TabIndex = 2;
            this.btnSifirla.Text = "Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = false;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayi.Location = new System.Drawing.Point(74, 39);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(51, 25);
            this.lblSayi.TabIndex = 3;
            this.lblSayi.Text = "100";
            // 
            // tmrSayac
            // 
            this.tmrSayac.Tick += new System.EventHandler(this.tmrSayac_Tick);
            // 
            // pbarGosterge
            // 
            this.pbarGosterge.Location = new System.Drawing.Point(13, 13);
            this.pbarGosterge.Name = "pbarGosterge";
            this.pbarGosterge.Size = new System.Drawing.Size(167, 23);
            this.pbarGosterge.TabIndex = 4;
            this.pbarGosterge.Value = 100;
            // 
            // tbarHiz
            // 
            this.tbarHiz.Location = new System.Drawing.Point(13, 160);
            this.tbarHiz.Maximum = 3000;
            this.tbarHiz.Minimum = 50;
            this.tbarHiz.Name = "tbarHiz";
            this.tbarHiz.Size = new System.Drawing.Size(167, 45);
            this.tbarHiz.TabIndex = 5;
            this.tbarHiz.Value = 50;
            this.tbarHiz.Scroll += new System.EventHandler(this.tbarHiz_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 217);
            this.Controls.Add(this.tbarHiz);
            this.Controls.Add(this.pbarGosterge);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.btnDurdur);
            this.Controls.Add(this.btnBasla);
            this.Name = "Form1";
            this.Text = "Sayaç";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbarHiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnDurdur;
        private System.Windows.Forms.Button btnSifirla;
        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.Timer tmrSayac;
        private System.Windows.Forms.ProgressBar pbarGosterge;
        private System.Windows.Forms.TrackBar tbarHiz;
    }
}

