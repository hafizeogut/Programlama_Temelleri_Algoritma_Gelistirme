namespace WindowsFormsApplication8
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
            this.lblSayac = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbarDeger = new System.Windows.Forms.ProgressBar();
            this.tbarHiz = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.tbarHiz)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSayac.Location = new System.Drawing.Point(102, 9);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(51, 25);
            this.lblSayac.TabIndex = 0;
            this.lblSayac.Text = "100";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pbarDeger
            // 
            this.pbarDeger.Location = new System.Drawing.Point(12, 35);
            this.pbarDeger.Name = "pbarDeger";
            this.pbarDeger.Size = new System.Drawing.Size(230, 23);
            this.pbarDeger.TabIndex = 1;
            this.pbarDeger.Value = 100;
            // 
            // tbarHiz
            // 
            this.tbarHiz.Location = new System.Drawing.Point(12, 84);
            this.tbarHiz.Maximum = 2000;
            this.tbarHiz.Minimum = 100;
            this.tbarHiz.Name = "tbarHiz";
            this.tbarHiz.Size = new System.Drawing.Size(230, 45);
            this.tbarHiz.TabIndex = 2;
            this.tbarHiz.Value = 100;
            this.tbarHiz.Scroll += new System.EventHandler(this.tbarHiz_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 152);
            this.Controls.Add(this.tbarHiz);
            this.Controls.Add(this.pbarDeger);
            this.Controls.Add(this.lblSayac);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbarHiz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar pbarDeger;
        private System.Windows.Forms.TrackBar tbarHiz;
    }
}

