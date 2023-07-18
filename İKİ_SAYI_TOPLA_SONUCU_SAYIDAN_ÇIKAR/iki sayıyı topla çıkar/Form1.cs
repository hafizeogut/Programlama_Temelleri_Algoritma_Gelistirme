using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iki_sayıyı_topla_çıkar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int S1, S2, S3, Hesapla;
            S1 =  Convert.ToInt16(txtSayi1.Text);
            S2 =  Convert.ToInt16(txtSayi2.Text);
            S3 = Convert.ToInt16(txtSayi3.Text);
            Hesapla = (S1 + S2) - S3;
            lblSonuc.Text = Hesapla.ToString();
        }
    }
}
