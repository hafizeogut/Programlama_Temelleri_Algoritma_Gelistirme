using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace not_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int Y1, Y2, P1, P2, Ort;
            Y1 = Convert.ToInt16(txtSayi1.Text);
            Y2 = Convert.ToInt16(txtSayi2.Text);
            P1 = Convert.ToInt16(txtSayi3.Text);
            P2 = Convert.ToInt16(txtSayi4.Text);
            Ort=(Y1+Y2+P1+P2) / 4;
            lblSonuc.Text= Ort.ToString();
            if (Ort > 50)
            {
                lblDurum.Text = "Geçti";
            }
            if (Ort < 50)
            {
                lblDurum.Text = "Kaldı";
            }
        }
    }
}
