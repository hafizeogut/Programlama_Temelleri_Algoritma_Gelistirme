namespace WindowsFormsApplication16
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
            this.dgvPc = new System.Windows.Forms.DataGridView();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.txtIslemci = new System.Windows.Forms.TextBox();
            this.txtAnakart = new System.Windows.Forms.TextBox();
            this.btnAraIslemci = new System.Windows.Forms.Button();
            this.btnAraAnakart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtMainboard = new System.Windows.Forms.TextBox();
            this.txtCPU = new System.Windows.Forms.TextBox();
            this.txtRAM = new System.Windows.Forms.TextBox();
            this.txtHDD = new System.Windows.Forms.TextBox();
            this.dgvTamir = new System.Windows.Forms.DataGridView();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPc)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamir)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPc
            // 
            this.dgvPc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPc.Location = new System.Drawing.Point(12, 12);
            this.dgvPc.Name = "dgvPc";
            this.dgvPc.Size = new System.Drawing.Size(601, 150);
            this.dgvPc.TabIndex = 0;
            this.dgvPc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPc_CellContentClick);
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(620, 13);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(59, 149);
            this.btnBaglan.TabIndex = 1;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // txtIslemci
            // 
            this.txtIslemci.Location = new System.Drawing.Point(6, 19);
            this.txtIslemci.Name = "txtIslemci";
            this.txtIslemci.Size = new System.Drawing.Size(100, 20);
            this.txtIslemci.TabIndex = 2;
            // 
            // txtAnakart
            // 
            this.txtAnakart.Location = new System.Drawing.Point(113, 19);
            this.txtAnakart.Name = "txtAnakart";
            this.txtAnakart.Size = new System.Drawing.Size(100, 20);
            this.txtAnakart.TabIndex = 3;
            // 
            // btnAraIslemci
            // 
            this.btnAraIslemci.Location = new System.Drawing.Point(6, 46);
            this.btnAraIslemci.Name = "btnAraIslemci";
            this.btnAraIslemci.Size = new System.Drawing.Size(100, 23);
            this.btnAraIslemci.TabIndex = 4;
            this.btnAraIslemci.Text = "Ara İşlemci";
            this.btnAraIslemci.UseVisualStyleBackColor = true;
            this.btnAraIslemci.Click += new System.EventHandler(this.btnAraIslemci_Click);
            // 
            // btnAraAnakart
            // 
            this.btnAraAnakart.Location = new System.Drawing.Point(113, 45);
            this.btnAraAnakart.Name = "btnAraAnakart";
            this.btnAraAnakart.Size = new System.Drawing.Size(100, 23);
            this.btnAraAnakart.TabIndex = 5;
            this.btnAraAnakart.Text = "Ara Anakart";
            this.btnAraAnakart.UseVisualStyleBackColor = true;
            this.btnAraAnakart.Click += new System.EventHandler(this.btnAraAnakart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.btnAraIslemci);
            this.groupBox1.Controls.Add(this.btnAraAnakart);
            this.groupBox1.Controls.Add(this.txtIslemci);
            this.groupBox1.Controls.Add(this.txtAnakart);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 86);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(282, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Anakart:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "İşemci:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "RAM:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "HardDisk:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(309, 168);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 12;
            // 
            // txtMainboard
            // 
            this.txtMainboard.Location = new System.Drawing.Point(335, 187);
            this.txtMainboard.Name = "txtMainboard";
            this.txtMainboard.Size = new System.Drawing.Size(100, 20);
            this.txtMainboard.TabIndex = 13;
            // 
            // txtCPU
            // 
            this.txtCPU.Location = new System.Drawing.Point(336, 213);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(100, 20);
            this.txtCPU.TabIndex = 14;
            // 
            // txtRAM
            // 
            this.txtRAM.Location = new System.Drawing.Point(336, 242);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(100, 20);
            this.txtRAM.TabIndex = 15;
            // 
            // txtHDD
            // 
            this.txtHDD.Location = new System.Drawing.Point(335, 269);
            this.txtHDD.Name = "txtHDD";
            this.txtHDD.Size = new System.Drawing.Size(100, 20);
            this.txtHDD.TabIndex = 16;
            // 
            // dgvTamir
            // 
            this.dgvTamir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTamir.Location = new System.Drawing.Point(12, 334);
            this.dgvTamir.Name = "dgvTamir";
            this.dgvTamir.Size = new System.Drawing.Size(601, 118);
            this.dgvTamir.TabIndex = 17;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(517, 189);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(148, 39);
            this.btnSil.TabIndex = 18;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(517, 234);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(148, 33);
            this.btnEkle.TabIndex = 19;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(517, 273);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(146, 37);
            this.btnGuncelle.TabIndex = 20;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 464);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.dgvTamir);
            this.Controls.Add(this.txtHDD);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.txtMainboard);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBaglan);
            this.Controls.Add(this.dgvPc);
            this.Name = "Form1";
            this.Text = "Veri tabanı işlemleri";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPc)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPc;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.TextBox txtIslemci;
        private System.Windows.Forms.TextBox txtAnakart;
        private System.Windows.Forms.Button btnAraIslemci;
        private System.Windows.Forms.Button btnAraAnakart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtMainboard;
        private System.Windows.Forms.TextBox txtCPU;
        private System.Windows.Forms.TextBox txtRAM;
        private System.Windows.Forms.TextBox txtHDD;
        private System.Windows.Forms.DataGridView dgvTamir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

