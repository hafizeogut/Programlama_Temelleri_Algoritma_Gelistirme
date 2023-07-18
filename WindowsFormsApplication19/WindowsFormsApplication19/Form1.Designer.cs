namespace WindowsFormsApplication19
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
            this.lblSoru = new System.Windows.Forms.Label();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.btnCevap = new System.Windows.Forms.Button();
            this.pBarsure = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoru.Location = new System.Drawing.Point(12, 48);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(0, 24);
            this.lblSoru.TabIndex = 0;
            // 
            // txtCevap
            // 
            this.txtCevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCevap.Location = new System.Drawing.Point(132, 45);
            this.txtCevap.Name = "txtCevap";
            this.txtCevap.Size = new System.Drawing.Size(56, 29);
            this.txtCevap.TabIndex = 1;
            // 
            // btnCevap
            // 
            this.btnCevap.Location = new System.Drawing.Point(197, 41);
            this.btnCevap.Name = "btnCevap";
            this.btnCevap.Size = new System.Drawing.Size(75, 33);
            this.btnCevap.TabIndex = 2;
            this.btnCevap.Text = "Cevapla";
            this.btnCevap.UseVisualStyleBackColor = true;
            this.btnCevap.Click += new System.EventHandler(this.btnCevap_Click);
            // 
            // pBarsure
            // 
            this.pBarsure.Location = new System.Drawing.Point(12, 12);
            this.pBarsure.Maximum = 120;
            this.pBarsure.Name = "pBarsure";
            this.pBarsure.Size = new System.Drawing.Size(260, 23);
            this.pBarsure.TabIndex = 3;
            this.pBarsure.Value = 120;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 87);
            this.Controls.Add(this.pBarsure);
            this.Controls.Add(this.btnCevap);
            this.Controls.Add(this.txtCevap);
            this.Controls.Add(this.lblSoru);
            this.Name = "Form1";
            this.Text = "Tahmin Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.Button btnCevap;
        private System.Windows.Forms.ProgressBar pBarsure;
        private System.Windows.Forms.Timer timer1;
    }
}

