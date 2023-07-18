namespace deneme
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
            this.cboxYas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnKontrol = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxYas
            // 
            this.cboxYas.FormattingEnabled = true;
            this.cboxYas.Items.AddRange(new object[] {
            "seçiniz",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cboxYas.Location = new System.Drawing.Point(8, 29);
            this.cboxYas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboxYas.Name = "cboxYas";
            this.cboxYas.Size = new System.Drawing.Size(124, 23);
            this.cboxYas.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "YAŞINIZI SEÇİNİZ";
            // 
            // btnKontrol
            // 
            this.btnKontrol.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnKontrol.Location = new System.Drawing.Point(8, 60);
            this.btnKontrol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnKontrol.Name = "btnKontrol";
            this.btnKontrol.Size = new System.Drawing.Size(125, 27);
            this.btnKontrol.TabIndex = 2;
            this.btnKontrol.Text = "Kontrol";
            this.btnKontrol.UseVisualStyleBackColor = false;
            this.btnKontrol.Click += new System.EventHandler(this.btnKontrol_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(84, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 222);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnKontrol);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxYas);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxYas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKontrol;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
    }
}

