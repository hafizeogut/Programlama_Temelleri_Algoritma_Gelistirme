using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double BOY, KİLO, SONUC;
            BOY = Convert.ToDouble(cboxBoy.Text);
            KİLO = Convert.ToDouble(cboxKilo.Text);
            SONUC = KİLO / BOY*BOY;
            lblSonuc.Text = SONUC.ToString();
            if (SONUC <= 18.4)
            {
                lblDurum.Text = "zayıf";
            }
            if (SONUC >= 18.5)
            {
                lblDurum.Text = "Normal";
            }
            if (SONUC >= 25)
            {
                lblDurum.Text = "fazla kilolu";
            }
            if (SONUC >= 30)
            {
                lblDurum.Text = "obozite";
            }
        }

        private void lblDurum_Click(object sender, EventArgs e)
        {

        }
    }
}