using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace büyük_küçük
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            int Sayi;
            Sayi = Convert.ToInt16(txtSayi.Text);
            if (Sayi > 100)
            {
                lblSonuc.Text = "Büyük";
            }
            if (Sayi < 100)
            {
                lblSonuc.Text = "Küçük";
            }

        }
    }
}
