namespace WindowsFormsApplication23
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
            this.btnAra = new System.Windows.Forms.Button();
            this.txtAra = new System.Windows.Forms.TextBox();
            this.lboxNesneler = new System.Windows.Forms.ListBox();
            this.pboxResim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(12, 34);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(100, 23);
            this.btnAra.TabIndex = 0;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtAra
            // 
            this.txtAra.Location = new System.Drawing.Point(12, 8);
            this.txtAra.Name = "txtAra";
            this.txtAra.Size = new System.Drawing.Size(100, 20);
            this.txtAra.TabIndex = 1;
            // 
            // lboxNesneler
            // 
            this.lboxNesneler.FormattingEnabled = true;
            this.lboxNesneler.Location = new System.Drawing.Point(12, 63);
            this.lboxNesneler.Name = "lboxNesneler";
            this.lboxNesneler.Size = new System.Drawing.Size(100, 173);
            this.lboxNesneler.TabIndex = 2;
            this.lboxNesneler.SelectedIndexChanged += new System.EventHandler(this.lboxNesneler_SelectedIndexChanged);
            // 
            // pboxResim
            // 
            this.pboxResim.Location = new System.Drawing.Point(118, 8);
            this.pboxResim.Name = "pboxResim";
            this.pboxResim.Size = new System.Drawing.Size(254, 228);
            this.pboxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxResim.TabIndex = 3;
            this.pboxResim.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 244);
            this.Controls.Add(this.pboxResim);
            this.Controls.Add(this.lboxNesneler);
            this.Controls.Add(this.txtAra);
            this.Controls.Add(this.btnAra);
            this.Name = "Form1";
            this.Text = "Veri tabanlı nesne resimleri";
            ((System.ComponentModel.ISupportInitialize)(this.pboxResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtAra;
        private System.Windows.Forms.ListBox lboxNesneler;
        private System.Windows.Forms.PictureBox pboxResim;
    }
}

