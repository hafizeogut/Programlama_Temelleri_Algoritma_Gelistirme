namespace WindowsFormsApplication6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lboxListe = new System.Windows.Forms.ListBox();
            this.btnAktar = new System.Windows.Forms.Button();
            this.txtYazi = new System.Windows.Forms.TextBox();
            this.lbox2 = new System.Windows.Forms.ListBox();
            this.btnSecAktar = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnHepsiniAktar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblZaman = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnDur = new System.Windows.Forms.Button();
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            this.btnTimerCalis = new System.Windows.Forms.Button();
            this.btnTimerDur = new System.Windows.Forms.Button();
            this.pboxResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // lboxListe
            // 
            this.lboxListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lboxListe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lboxListe.FormattingEnabled = true;
            this.lboxListe.ItemHeight = 16;
            this.lboxListe.Location = new System.Drawing.Point(116, 12);
            this.lboxListe.Name = "lboxListe";
            this.lboxListe.Size = new System.Drawing.Size(120, 164);
            this.lboxListe.TabIndex = 0;
            // 
            // btnAktar
            // 
            this.btnAktar.BackColor = System.Drawing.Color.Red;
            this.btnAktar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktar.ForeColor = System.Drawing.Color.White;
            this.btnAktar.Location = new System.Drawing.Point(10, 38);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.Size = new System.Drawing.Size(100, 38);
            this.btnAktar.TabIndex = 2;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.UseVisualStyleBackColor = false;
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // txtYazi
            // 
            this.txtYazi.Location = new System.Drawing.Point(10, 12);
            this.txtYazi.Name = "txtYazi";
            this.txtYazi.Size = new System.Drawing.Size(100, 20);
            this.txtYazi.TabIndex = 3;
            // 
            // lbox2
            // 
            this.lbox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbox2.FormattingEnabled = true;
            this.lbox2.Location = new System.Drawing.Point(476, 12);
            this.lbox2.Name = "lbox2";
            this.lbox2.Size = new System.Drawing.Size(120, 171);
            this.lbox2.TabIndex = 4;
            // 
            // btnSecAktar
            // 
            this.btnSecAktar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecAktar.Location = new System.Drawing.Point(242, 12);
            this.btnSecAktar.Name = "btnSecAktar";
            this.btnSecAktar.Size = new System.Drawing.Size(228, 23);
            this.btnSecAktar.TabIndex = 5;
            this.btnSecAktar.Text = "Seçileni Aktar";
            this.btnSecAktar.UseVisualStyleBackColor = true;
            this.btnSecAktar.Click += new System.EventHandler(this.btnSecAktar_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(10, 167);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(75, 23);
            this.btnKapat.TabIndex = 6;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnHepsiniAktar
            // 
            this.btnHepsiniAktar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHepsiniAktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHepsiniAktar.Location = new System.Drawing.Point(242, 41);
            this.btnHepsiniAktar.Name = "btnHepsiniAktar";
            this.btnHepsiniAktar.Size = new System.Drawing.Size(228, 23);
            this.btnHepsiniAktar.TabIndex = 7;
            this.btnHepsiniAktar.Text = "Hepsini Aktar";
            this.btnHepsiniAktar.UseVisualStyleBackColor = true;
            this.btnHepsiniAktar.Click += new System.EventHandler(this.btnHepsiniAktar_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblZaman
            // 
            this.lblZaman.AutoSize = true;
            this.lblZaman.Location = new System.Drawing.Point(13, 148);
            this.lblZaman.Name = "lblZaman";
            this.lblZaman.Size = new System.Drawing.Size(0, 13);
            this.lblZaman.TabIndex = 8;
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // btnBasla
            // 
            this.btnBasla.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(243, 71);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 23);
            this.btnBasla.TabIndex = 9;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnDur
            // 
            this.btnDur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDur.Location = new System.Drawing.Point(243, 101);
            this.btnDur.Name = "btnDur";
            this.btnDur.Size = new System.Drawing.Size(75, 23);
            this.btnDur.TabIndex = 10;
            this.btnDur.Text = "Dur";
            this.btnDur.UseVisualStyleBackColor = true;
            this.btnDur.Click += new System.EventHandler(this.btnDur_Click);
            // 
            // timer4
            // 
            this.timer4.Interval = 10;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // btnTimerCalis
            // 
            this.btnTimerCalis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTimerCalis.Location = new System.Drawing.Point(243, 131);
            this.btnTimerCalis.Name = "btnTimerCalis";
            this.btnTimerCalis.Size = new System.Drawing.Size(115, 23);
            this.btnTimerCalis.TabIndex = 11;
            this.btnTimerCalis.Text = "son timer çalış";
            this.btnTimerCalis.UseVisualStyleBackColor = true;
            this.btnTimerCalis.Click += new System.EventHandler(this.btnTimerCalis_Click);
            // 
            // btnTimerDur
            // 
            this.btnTimerDur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTimerDur.Location = new System.Drawing.Point(243, 161);
            this.btnTimerDur.Name = "btnTimerDur";
            this.btnTimerDur.Size = new System.Drawing.Size(115, 23);
            this.btnTimerDur.TabIndex = 12;
            this.btnTimerDur.Text = "son timer dur";
            this.btnTimerDur.UseVisualStyleBackColor = true;
            this.btnTimerDur.Click += new System.EventHandler(this.btnTimerDur_Click);
            // 
            // pboxResim
            // 
            this.pboxResim.Image = ((System.Drawing.Image)(resources.GetObject("pboxResim.Image")));
            this.pboxResim.Location = new System.Drawing.Point(243, 190);
            this.pboxResim.Name = "pboxResim";
            this.pboxResim.Size = new System.Drawing.Size(10, 22);
            this.pboxResim.TabIndex = 13;
            this.pboxResim.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 236);
            this.ControlBox = false;
            this.Controls.Add(this.pboxResim);
            this.Controls.Add(this.btnTimerDur);
            this.Controls.Add(this.btnTimerCalis);
            this.Controls.Add(this.btnDur);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblZaman);
            this.Controls.Add(this.btnHepsiniAktar);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnSecAktar);
            this.Controls.Add(this.lbox2);
            this.Controls.Add(this.txtYazi);
            this.Controls.Add(this.btnAktar);
            this.Controls.Add(this.lboxListe);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pboxResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lboxListe;
        private System.Windows.Forms.Button btnAktar;
        private System.Windows.Forms.TextBox txtYazi;
        private System.Windows.Forms.ListBox lbox2;
        private System.Windows.Forms.Button btnSecAktar;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnHepsiniAktar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblZaman;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnDur;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.Button btnTimerCalis;
        private System.Windows.Forms.Button btnTimerDur;
        private System.Windows.Forms.PictureBox pboxResim;
    }
}

