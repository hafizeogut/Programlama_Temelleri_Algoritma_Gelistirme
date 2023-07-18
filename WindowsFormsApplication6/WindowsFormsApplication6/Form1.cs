using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            lboxListe.Items.Clear();//her başlamada listeyi siler
            int sayi;
            sayi = Convert.ToInt16(txtYazi.Text);
            for (int a = 1; a <= 10; a++)
            {
                lboxListe.Items.Add(sayi+" X "+a+" = "+sayi*a);//  4X1=4   4X2=8   4X3=12   4X4=16  4X10=40 
            }

        }

        private void btnSecAktar_Click(object sender, EventArgs e)
        {
            lbox2.Items.Add(lboxListe.SelectedItem.ToString());
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHepsiniAktar_Click(object sender, EventArgs e)
        {
            for(int dondu=0;dondu<10;dondu++)
            {
                lbox2.Items.Add(lboxListe.Items[dondu].ToString());
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbox2.Items.Add("Çağıl SÖYLER");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            lblZaman.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer3.Enabled = true;
        }

        private void btnDur_Click(object sender, EventArgs e)
        {
            timer3.Enabled = false;
        }

        int sayac = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            lbox2.Items.Add(lboxListe.Items[sayac].ToString());
            sayac = sayac + 1;
        }

        int sayac2 = 10;
        private void timer4_Tick(object sender, EventArgs e)
        {
            pboxResim.Size = new Size(sayac2, 22);
            sayac2 = sayac2 + 1;
        }

        private void btnTimerCalis_Click(object sender, EventArgs e)
        {
            timer4.Enabled = true;
        }

        private void btnTimerDur_Click(object sender, EventArgs e)
        {
            timer4.Enabled = false;
        }
    }
}
