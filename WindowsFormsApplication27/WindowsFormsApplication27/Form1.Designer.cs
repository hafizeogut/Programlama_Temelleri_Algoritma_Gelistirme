namespace WindowsFormsApplication27
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
            this.lblHangiSoru = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnBitir = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rbtnA = new System.Windows.Forms.RadioButton();
            this.rbtnB = new System.Windows.Forms.RadioButton();
            this.rbtnC = new System.Windows.Forms.RadioButton();
            this.rbtnD = new System.Windows.Forms.RadioButton();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblD = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSoru = new System.Windows.Forms.Label();
            this.btnCevapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDogru = new System.Windows.Forms.Label();
            this.lblSure = new System.Windows.Forms.Label();
            this.timerSure = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblHangiSoru
            // 
            this.lblHangiSoru.AutoSize = true;
            this.lblHangiSoru.Location = new System.Drawing.Point(27, 53);
            this.lblHangiSoru.Name = "lblHangiSoru";
            this.lblHangiSoru.Size = new System.Drawing.Size(35, 13);
            this.lblHangiSoru.TabIndex = 0;
            this.lblHangiSoru.Text = "label1";
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(22, 96);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 23);
            this.btnBasla.TabIndex = 1;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnBitir
            // 
            this.btnBitir.Location = new System.Drawing.Point(103, 96);
            this.btnBitir.Name = "btnBitir";
            this.btnBitir.Size = new System.Drawing.Size(75, 23);
            this.btnBitir.TabIndex = 2;
            this.btnBitir.Text = "BİTİR";
            this.btnBitir.UseVisualStyleBackColor = true;
            this.btnBitir.Click += new System.EventHandler(this.btnBitir_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rbtnA
            // 
            this.rbtnA.AutoSize = true;
            this.rbtnA.Location = new System.Drawing.Point(22, 173);
            this.rbtnA.Name = "rbtnA";
            this.rbtnA.Size = new System.Drawing.Size(35, 17);
            this.rbtnA.TabIndex = 3;
            this.rbtnA.TabStop = true;
            this.rbtnA.Text = "A)";
            this.rbtnA.UseVisualStyleBackColor = true;
            // 
            // rbtnB
            // 
            this.rbtnB.AutoSize = true;
            this.rbtnB.Location = new System.Drawing.Point(22, 197);
            this.rbtnB.Name = "rbtnB";
            this.rbtnB.Size = new System.Drawing.Size(35, 17);
            this.rbtnB.TabIndex = 4;
            this.rbtnB.TabStop = true;
            this.rbtnB.Text = "B)";
            this.rbtnB.UseVisualStyleBackColor = true;
            // 
            // rbtnC
            // 
            this.rbtnC.AutoSize = true;
            this.rbtnC.Location = new System.Drawing.Point(21, 221);
            this.rbtnC.Name = "rbtnC";
            this.rbtnC.Size = new System.Drawing.Size(35, 17);
            this.rbtnC.TabIndex = 5;
            this.rbtnC.TabStop = true;
            this.rbtnC.Text = "C)";
            this.rbtnC.UseVisualStyleBackColor = true;
            // 
            // rbtnD
            // 
            this.rbtnD.AutoSize = true;
            this.rbtnD.Location = new System.Drawing.Point(22, 245);
            this.rbtnD.Name = "rbtnD";
            this.rbtnD.Size = new System.Drawing.Size(36, 17);
            this.rbtnD.TabIndex = 6;
            this.rbtnD.TabStop = true;
            this.rbtnD.Text = "D)";
            this.rbtnD.UseVisualStyleBackColor = true;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(55, 175);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(35, 13);
            this.lblA.TabIndex = 7;
            this.lblA.Text = "label1";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(55, 199);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(35, 13);
            this.lblB.TabIndex = 8;
            this.lblB.Text = "label2";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(55, 223);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(35, 13);
            this.lblC.TabIndex = 9;
            this.lblC.Text = "label3";
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Location = new System.Drawing.Point(55, 249);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(35, 13);
            this.lblD.TabIndex = 10;
            this.lblD.Text = "label4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "SORU:";
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Location = new System.Drawing.Point(23, 146);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(35, 13);
            this.lblSoru.TabIndex = 12;
            this.lblSoru.Text = "label2";
            // 
            // btnCevapla
            // 
            this.btnCevapla.Location = new System.Drawing.Point(21, 279);
            this.btnCevapla.Name = "btnCevapla";
            this.btnCevapla.Size = new System.Drawing.Size(157, 23);
            this.btnCevapla.TabIndex = 13;
            this.btnCevapla.Text = "CEVAPLA";
            this.btnCevapla.UseVisualStyleBackColor = true;
            this.btnCevapla.Click += new System.EventHandler(this.btnCevapla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Doğru Sayısı";
            // 
            // lblDogru
            // 
            this.lblDogru.AutoSize = true;
            this.lblDogru.Location = new System.Drawing.Point(133, 70);
            this.lblDogru.Name = "lblDogru";
            this.lblDogru.Size = new System.Drawing.Size(13, 13);
            this.lblDogru.TabIndex = 15;
            this.lblDogru.Text = "0";
            // 
            // lblSure
            // 
            this.lblSure.AutoSize = true;
            this.lblSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSure.Location = new System.Drawing.Point(38, 9);
            this.lblSure.Name = "lblSure";
            this.lblSure.Size = new System.Drawing.Size(92, 31);
            this.lblSure.TabIndex = 16;
            this.lblSure.Text = "label3";
            // 
            // timerSure
            // 
            this.timerSure.Interval = 1000;
            this.timerSure.Tick += new System.EventHandler(this.timerSure_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 371);
            this.Controls.Add(this.lblSure);
            this.Controls.Add(this.lblDogru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCevapla);
            this.Controls.Add(this.lblSoru);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.rbtnD);
            this.Controls.Add(this.rbtnC);
            this.Controls.Add(this.rbtnB);
            this.Controls.Add(this.rbtnA);
            this.Controls.Add(this.btnBitir);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.lblHangiSoru);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHangiSoru;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnBitir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton rbtnA;
        private System.Windows.Forms.RadioButton rbtnB;
        private System.Windows.Forms.RadioButton rbtnC;
        private System.Windows.Forms.RadioButton rbtnD;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Button btnCevapla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDogru;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.Timer timerSure;
    }
}

