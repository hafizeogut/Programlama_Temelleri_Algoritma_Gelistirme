namespace MissingList
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNowNumber = new System.Windows.Forms.TextBox();
            this.txtHowMuch = new System.Windows.Forms.TextBox();
            this.txtMaterial = new System.Windows.Forms.TextBox();
            this.txtWhere = new System.Windows.Forms.TextBox();
            this.dgvShow = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::MissingList.Properties.Resources.e5f7aa742b85257d08adb1918b18d15f;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(371, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 99);
            this.btnDelete.TabIndex = 0;
            this.toolTip1.SetToolTip(this.btnDelete, "DELETE");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::MissingList.Properties.Resources.niXnadr8T;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdd.Location = new System.Drawing.Point(251, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 99);
            this.btnAdd.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btnAdd, "ADD");
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOW NUMBER:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "MATERİAL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "WHERE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "HOW MUCH:";
            // 
            // txtNowNumber
            // 
            this.txtNowNumber.Location = new System.Drawing.Point(127, 6);
            this.txtNowNumber.Name = "txtNowNumber";
            this.txtNowNumber.Size = new System.Drawing.Size(116, 20);
            this.txtNowNumber.TabIndex = 6;
            // 
            // txtHowMuch
            // 
            this.txtHowMuch.Location = new System.Drawing.Point(127, 114);
            this.txtHowMuch.Name = "txtHowMuch";
            this.txtHowMuch.Size = new System.Drawing.Size(116, 20);
            this.txtHowMuch.TabIndex = 7;
            // 
            // txtMaterial
            // 
            this.txtMaterial.Location = new System.Drawing.Point(127, 43);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.Size = new System.Drawing.Size(116, 20);
            this.txtMaterial.TabIndex = 8;
            // 
            // txtWhere
            // 
            this.txtWhere.Location = new System.Drawing.Point(127, 78);
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Size = new System.Drawing.Size(116, 20);
            this.txtWhere.TabIndex = 9;
            // 
            // dgvShow
            // 
            this.dgvShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShow.Location = new System.Drawing.Point(12, 147);
            this.dgvShow.Name = "dgvShow";
            this.dgvShow.Size = new System.Drawing.Size(456, 107);
            this.dgvShow.TabIndex = 10;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(475, 266);
            this.Controls.Add(this.dgvShow);
            this.Controls.Add(this.txtWhere);
            this.Controls.Add(this.txtMaterial);
            this.Controls.Add(this.txtHowMuch);
            this.Controls.Add(this.txtNowNumber);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDelete);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "MİSSİNG LİST";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNowNumber;
        private System.Windows.Forms.TextBox txtHowMuch;
        private System.Windows.Forms.TextBox txtMaterial;
        private System.Windows.Forms.TextBox txtWhere;
        private System.Windows.Forms.DataGridView dgvShow;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

