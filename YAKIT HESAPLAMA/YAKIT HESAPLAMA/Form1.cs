using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace YAKIT_HESAPLAMA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (cboxYakit.SelectedIndex == 0 || txtMesafe.Text == "")
            {
                MessageBox.Show("Bilgileri Gir");
            }
            else
            {
                int Mesafe;
                string Yakitturu;
                double Sonuc = 0;
                Mesafe = Convert.ToInt16(txtMesafe.Text);
                Yakitturu = cboxYakit.Text;
                if (Yakitturu == "LPG")
                {
                    Sonuc = 2.40 * Mesafe;
                }
                else if (Yakitturu == "BENZİN")
                {
                    Sonuc = 4.4 * Mesafe;
                }
                else if (Yakitturu == "MAZOT")
                {
                    Sonuc = 3.9 * Mesafe;
                }
                lblSonuc.Text = Sonuc.ToString();
            }




        }
    }
}
