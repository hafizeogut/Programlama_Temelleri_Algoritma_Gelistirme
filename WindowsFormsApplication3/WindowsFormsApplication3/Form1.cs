using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            int yas;
            yas = Convert.ToInt16(cboxYas.Text);
            if (yas < 15)
            {
                MessageBox.Show("büyüde gel","yaşınız ufak",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Buyrun");
            }
        }
    }
}
