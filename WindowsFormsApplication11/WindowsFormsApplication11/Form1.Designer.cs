namespace WindowsFormsApplication11
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnBay = new System.Windows.Forms.RadioButton();
            this.rbtnBayan = new System.Windows.Forms.RadioButton();
            this.rbtnFarketmez = new System.Windows.Forms.RadioButton();
            this.cboxBisiklet = new System.Windows.Forms.CheckBox();
            this.cboxGitar = new System.Windows.Forms.CheckBox();
            this.cboxTelefon = new System.Windows.Forms.CheckBox();
            this.txtYazi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Blue;
            this.groupBox1.Controls.Add(this.rbtnFarketmez);
            this.groupBox1.Controls.Add(this.rbtnBayan);
            this.groupBox1.Controls.Add(this.rbtnBay);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cinsiyet";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Teal;
            this.groupBox2.Controls.Add(this.cboxTelefon);
            this.groupBox2.Controls.Add(this.cboxGitar);
            this.groupBox2.Controls.Add(this.cboxBisiklet);
            this.groupBox2.Location = new System.Drawing.Point(31, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hobiler";
            // 
            // rbtnBay
            // 
            this.rbtnBay.AutoSize = true;
            this.rbtnBay.Checked = true;
            this.rbtnBay.ForeColor = System.Drawing.Color.White;
            this.rbtnBay.Location = new System.Drawing.Point(23, 20);
            this.rbtnBay.Name = "rbtnBay";
            this.rbtnBay.Size = new System.Drawing.Size(43, 17);
            this.rbtnBay.TabIndex = 0;
            this.rbtnBay.TabStop = true;
            this.rbtnBay.Text = "Bay";
            this.rbtnBay.UseVisualStyleBackColor = true;
            this.rbtnBay.CheckedChanged += new System.EventHandler(this.rbtnBay_CheckedChanged);
            // 
            // rbtnBayan
            // 
            this.rbtnBayan.AutoSize = true;
            this.rbtnBayan.ForeColor = System.Drawing.Color.White;
            this.rbtnBayan.Location = new System.Drawing.Point(23, 44);
            this.rbtnBayan.Name = "rbtnBayan";
            this.rbtnBayan.Size = new System.Drawing.Size(55, 17);
            this.rbtnBayan.TabIndex = 1;
            this.rbtnBayan.Text = "Bayan";
            this.rbtnBayan.UseVisualStyleBackColor = true;
            this.rbtnBayan.CheckedChanged += new System.EventHandler(this.rbtnBayan_CheckedChanged);
            // 
            // rbtnFarketmez
            // 
            this.rbtnFarketmez.AutoSize = true;
            this.rbtnFarketmez.ForeColor = System.Drawing.Color.White;
            this.rbtnFarketmez.Location = new System.Drawing.Point(23, 68);
            this.rbtnFarketmez.Name = "rbtnFarketmez";
            this.rbtnFarketmez.Size = new System.Drawing.Size(74, 17);
            this.rbtnFarketmez.TabIndex = 2;
            this.rbtnFarketmez.Text = "Farketmez";
            this.rbtnFarketmez.UseVisualStyleBackColor = true;
            this.rbtnFarketmez.CheckedChanged += new System.EventHandler(this.rbtnFarketmez_CheckedChanged);
            // 
            // cboxBisiklet
            // 
            this.cboxBisiklet.AutoSize = true;
            this.cboxBisiklet.Location = new System.Drawing.Point(23, 20);
            this.cboxBisiklet.Name = "cboxBisiklet";
            this.cboxBisiklet.Size = new System.Drawing.Size(103, 17);
            this.cboxBisiklet.TabIndex = 0;
            this.cboxBisiklet.Text = "Bisiklete Binmek";
            this.cboxBisiklet.UseVisualStyleBackColor = true;
            this.cboxBisiklet.CheckedChanged += new System.EventHandler(this.cboxBisiklet_CheckedChanged);
            // 
            // cboxGitar
            // 
            this.cboxGitar.AutoSize = true;
            this.cboxGitar.Location = new System.Drawing.Point(23, 44);
            this.cboxGitar.Name = "cboxGitar";
            this.cboxGitar.Size = new System.Drawing.Size(86, 17);
            this.cboxGitar.TabIndex = 1;
            this.cboxGitar.Text = "Gitar Çalmak";
            this.cboxGitar.UseVisualStyleBackColor = true;
            // 
            // cboxTelefon
            // 
            this.cboxTelefon.AutoSize = true;
            this.cboxTelefon.Location = new System.Drawing.Point(23, 68);
            this.cboxTelefon.Name = "cboxTelefon";
            this.cboxTelefon.Size = new System.Drawing.Size(110, 17);
            this.cboxTelefon.TabIndex = 2;
            this.cboxTelefon.Text = "Telefon Oynamak";
            this.cboxTelefon.UseVisualStyleBackColor = true;
            // 
            // txtYazi
            // 
            this.txtYazi.Location = new System.Drawing.Point(31, 234);
            this.txtYazi.Name = "txtYazi";
            this.txtYazi.Size = new System.Drawing.Size(397, 20);
            this.txtYazi.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 306);
            this.Controls.Add(this.txtYazi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnFarketmez;
        private System.Windows.Forms.RadioButton rbtnBayan;
        private System.Windows.Forms.RadioButton rbtnBay;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cboxTelefon;
        private System.Windows.Forms.CheckBox cboxGitar;
        private System.Windows.Forms.CheckBox cboxBisiklet;
        private System.Windows.Forms.TextBox txtYazi;
    }
}

