using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fonksiyon
{
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }
        private void RENK()
        {
            int r, g, b;
            Random renk = new Random();
            r = renk.Next(0, 250);
            g = renk.Next(0, 250);
            b = renk.Next(0, 250);
            lblYaz.ForeColor = Color.FromArgb(r, g, b);
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            RENK();

        }
        private void YAZ(int S, string ISIM)
        {
            lboxYazi.Items.Clear();
            for (int b = 0; b < S; b++)
            {
                lboxYazi.Items.Add(ISIM);
            }
        }
        private void btnYaziyiAktar_Click(object sender, EventArgs e) 
        { 

            int sayi = Convert.ToInt16(txtF2Sayi.Text);
            string isim = txtF2Isim.Text;
            YAZ(sayi, isim);
        }
        int SAYI,SONUC; 
        private void btnHesapla_Click(object sender, EventArgs e)
        { 
                SAYI = Convert.ToInt16(txtF3Sayi.Text);
                SONUC = ((((SAYI * SAYI) + 45) / 2)*5);
                lblSonuc.Text = SONUC.ToString();
             
        }
         
        private void AnaEkran_Load(object sender, EventArgs e)
        {
             
        }
    }
}