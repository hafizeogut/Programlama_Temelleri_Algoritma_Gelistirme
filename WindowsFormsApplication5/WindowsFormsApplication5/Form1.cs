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
            lboxCarpim.Items.Clear();
            int sayi;
            sayi = Convert.ToInt16(txtSayi.Text);
            lblBilgi.Text = sayi + "ların Çarpım Tablosu";
            for (int a = 1; a <= 10; a++)
            { 
                lboxCarpim.Items.Add(sayi + " X " + a + " = " + sayi * a);//   2X1=2    2X2=4   2x3=6  2x10=20
            }
            
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            lbox2.Items.Add(lboxCarpim.SelectedItem.ToString());//seçileni aktarır
        }

        private void btnAktarTamami_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < 10; a++)
            {
                lbox2.Items.Add(lboxCarpim.Items[9-a].ToString());
            }            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbox2.Items.Add("Çağıl SÖYLER");
        }

        private void btnCalis_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToLongTimeString();
        }
        int sayac = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            lbox2.Items.Add(lboxCarpim.Items[sayac].ToString());
            sayac = sayac + 1;
        }

        private void btnTimer3_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;

        }
        int sayac2 = 0;
        private void timer4_Tick(object sender, EventArgs e)
        {
            pboxResim.Size = new Size(sayac2, 20);
            sayac2 = sayac2 + 1;
        }
    }
}
