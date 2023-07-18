using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _22222222
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int Tuketim;
            int Sure;
            int Ucret;
            int Sonuc;
            Tuketim = Convert.ToInt16(txtTuketim.Text);
            Sure = Convert.ToInt16(txtSure.Text);
            Ucret = Convert.ToInt16(txtUcret.Text);
            Sonuc = Tuketim * Sure * Ucret;
            lblSonuc.Text = Sonuc.ToString();
        }
    }
}
         



         