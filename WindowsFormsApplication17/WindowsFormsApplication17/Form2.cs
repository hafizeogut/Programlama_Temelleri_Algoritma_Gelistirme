using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnFonk1_Click(object sender, EventArgs e)
        {
            renkdegistir();
        }

        private void renkdegistir()
        {
            lblYazi.ForeColor = Color.Red;
        }

        private void btnFonk2_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(txtFonk2Deger.Text);
            yaziyaz(sayi);
        }

        private void yaziyaz(int a)
        {
            for (int b = 0; b < a; b++)
            {
                lboxYazi.Items.Add("Arel");
            }
        }

        private void btnFonk22_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(txtFonk2Deger.Text);
            yaziyaz2(sayi,txtIsim.Text);
        }


        private void yaziyaz2(int a,string isim)
        {
            for (int b = 0; b < a; b++)
            {
                lboxYazi.Items.Add(isim);
            }
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(txtDeger.Text);
            int sonuc;
            sonuc = hesapyap(sayi);
            txtDeger.Text = sonuc.ToString();

            //txtDeger.Text = hesapyap(Convert.ToInt16(txtDeger.Text)).ToString();

        }

        private int hesapyap(int a)
        {
            a = a * a;
            a = a + 10;
            return a;
        }

    }
}
