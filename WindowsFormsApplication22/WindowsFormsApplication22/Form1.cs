using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt16(txtAdet.Text);
            for (int a = 0; a < sayi; a++)
            {
                lBox1.Items.Add(txtIsim.Text);
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            lBox2.Items.Add(lBox1.SelectedItem.ToString());
        }

        int kackayit;
        int sayac = 1;
        private void btnOtoAktar_Click(object sender, EventArgs e)
        {
            kackayit = lBox1.Items.Count;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (kackayit == sayac) timer1.Enabled = false;
            lBox2.Items.Add(lBox1.Items[kackayit-sayac].ToString());
            sayac++;
        }

    }
}
