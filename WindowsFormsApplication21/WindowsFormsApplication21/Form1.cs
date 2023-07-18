using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lbox1.Items.Add(txtIsim.Text);
            txtIsim.Text = "";
            txtIsim.Focus();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            int kacadet = lbox1.Items.Count;
            for (int a = kacadet-1;  a>=0 ; a--) //for(int a=0;a<kacadet;a++)
            {
                lbox2.Items.Add(lbox1.Items[a].ToString());
            }
            lbox1.Items.Clear();
        }

        private void btnZamanAktar_Click(object sender, EventArgs e)
        {
            nekadar = lbox1.Items.Count;
            sayac = 1;
            timer1.Enabled = true;
        }

        int nekadar;
        int sayac = 1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nekadar == sayac) timer1.Enabled = false;
            lbox2.Items.Add(lbox1.Items[0].ToString());
            lbox1.Items.Remove(lbox1.Items[0]);
            sayac++;
        }
    }
}
