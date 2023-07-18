using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace koşucu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int S1;
            int S2;
            int S3;
            int Hesapla;
            S1 = Convert.ToInt16(txtKilo.Text);
            S2 = Convert.ToInt16(txtBoy.Text);
            S3 = Convert.ToInt16(txtSure.Text);
            Hesapla = S1 / S2 * S3;
            lblSonuc.Text = Hesapla.ToString();

        }
    }
}
