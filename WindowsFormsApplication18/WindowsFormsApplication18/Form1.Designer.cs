namespace WindowsFormsApplication18
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
            this.btnForm2Open = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnForm2Open
            // 
            this.btnForm2Open.Location = new System.Drawing.Point(124, 67);
            this.btnForm2Open.Name = "btnForm2Open";
            this.btnForm2Open.Size = new System.Drawing.Size(75, 23);
            this.btnForm2Open.TabIndex = 0;
            this.btnForm2Open.Text = "Form2\'ye git";
            this.btnForm2Open.UseVisualStyleBackColor = true;
            this.btnForm2Open.Click += new System.EventHandler(this.btnForm2Open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 170);
            this.Controls.Add(this.btnForm2Open);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnForm2Open;


    }
}

