using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace liste_kutusu
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
            int Sayi;
            Sayi = Convert.ToInt16(txtSayi.Text);
            lblBilgi.Text = Sayi + "ların çarpım tablosu";
            for (int a = 1; a <= 10; a++)
            {
                lboxCarpim.Items.Add(Sayi + " x " + a + " = " + Sayi * a);
            }
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            lboxCarpim.Items.Clear();
            for (int irem = 100; irem > 0; irem = irem - 2)
            {
                lboxCarpim.Items.Add(irem);
            }
        }

        private void btnArttır_Click(object sender, EventArgs e)
        {
            lboxCarpim.Items.Clear();
            for (int irem = 25; irem <= 1000; irem = irem + 5)
            {
                lboxCarpim.Items.Add(irem);
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            lbox2.Items.Add(lboxCarpim.SelectedItem.ToString());
        }

        private void btnAktartamami_Click(object sender, EventArgs e)
        {
            for (int a = 9; a >=0; a--)
            {
                lbox2.Items.Add(lboxCarpim.Items[a].ToString());
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbox2.Items.Add("YAZLIMCI OLMAK AYRICALIKTIR");
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

    private void btnA_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
    }
}
