using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication18
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            renk();
        }

        private void renk()
        {
            int r,g,b;
            Random rnd = new Random();
            r=rnd.Next(0, 250);
            g = rnd.Next(0, 250);
            b = rnd.Next(0, 250);
            lblYazi.ForeColor = Color.FromArgb(r,g,b);
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(txtSayi.Text);
            string isim = txtIsim.Text;
            yaz(sayi,isim);
        }

        private void yaz(int a,string isim)
        {
            lboxYazi.Items.Clear();

            for (int b = 0; b < a; b++)
            {
                lboxYazi.Items.Add(isim);
            }
        }

        private void btnHesap_Click(object sender, EventArgs e)
        {
            /*
            int a = Convert.ToInt16(txtVeri.Text);
            int sonuc = hesap(a);
            lblSonuc.Text = sonuc.ToString();
            */

            lblSonuc.Text = hesap(txtVeri.Text);

        }

        private string hesap(string sayi)
        {
            int sayiiii = Convert.ToInt16(sayi);
            sayiiii = (((sayiiii * sayiiii)+10)/2)+3;
            return sayiiii.ToString();
        }

    }
}
