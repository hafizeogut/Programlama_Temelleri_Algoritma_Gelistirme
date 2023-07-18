using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int sayi1;
        double cevap;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            sayi1 = rnd.Next(0, 10);
            cevap = 10 * sayi1;
            if (sayi1 == 0) btnRenk1.BackColor = Color.Black;
            else if (sayi1 == 1) btnRenk1.BackColor = Color.Brown;
            else if (sayi1 == 2) btnRenk1.BackColor = Color.Red;
            else if (sayi1 == 3) btnRenk1.BackColor = Color.Orange;
            else if (sayi1 == 4) btnRenk1.BackColor = Color.Yellow;
            else if (sayi1 == 5) btnRenk1.BackColor = Color.Blue;
            else if (sayi1 == 6) btnRenk1.BackColor = Color.Green;
            else if (sayi1 == 7) btnRenk1.BackColor = Color.Purple;
            else if (sayi1 == 8) btnRenk1.BackColor = Color.Gray;
            else if (sayi1 == 9) btnRenk1.BackColor = Color.White;
            sayi1 = rnd.Next(0, 10);
            cevap = cevap + sayi1;
            if (sayi1 == 0) btnRenk2.BackColor = Color.Black;
            else if (sayi1 == 1) btnRenk2.BackColor = Color.Brown;
            else if (sayi1 == 2) btnRenk2.BackColor = Color.Red;
            else if (sayi1 == 3) btnRenk2.BackColor = Color.Orange;
            else if (sayi1 == 4) btnRenk2.BackColor = Color.Yellow;
            else if (sayi1 == 5) btnRenk2.BackColor = Color.Blue;
            else if (sayi1 == 6) btnRenk2.BackColor = Color.Green;
            else if (sayi1 == 7) btnRenk2.BackColor = Color.Purple;
            else if (sayi1 == 8) btnRenk2.BackColor = Color.Gray;
            else if (sayi1 == 9) btnRenk2.BackColor = Color.White;
            sayi1 = rnd.Next(0, 10);
            int carpim = 1;
            for (int a = 0; a < sayi1; a++)
            {
                carpim = carpim * 10;
            }
            cevap = cevap * carpim;
            if (sayi1 == 0) btnRenk3.BackColor = Color.Black;
            else if (sayi1 == 1) btnRenk3.BackColor = Color.Brown;
            else if (sayi1 == 2) btnRenk3.BackColor = Color.Red;
            else if (sayi1 == 3) btnRenk3.BackColor = Color.Orange;
            else if (sayi1 == 4) btnRenk3.BackColor = Color.Yellow;
            else if (sayi1 == 5) btnRenk3.BackColor = Color.Blue;
            else if (sayi1 == 6) btnRenk3.BackColor = Color.Green;
            else if (sayi1 == 7) btnRenk3.BackColor = Color.Purple;
            else if (sayi1 == 8) btnRenk3.BackColor = Color.Gray;
            else if (sayi1 == 9) btnRenk3.BackColor = Color.White;
            this.Text = cevap.ToString();
        }

        private void btnCEvapla_Click(object sender, EventArgs e)
        {
            if (txtCevap.Text == cevap.ToString())
            {
                lblDogru.Text = (Convert.ToInt16(lblDogru.Text) + 1).ToString();
            }
            else MessageBox.Show("bilemedin dümbelek");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblSure.Text == "0")
            {
                timer1.Enabled = false;
            }
            else
            {

                lblSure.Text = (Convert.ToInt16(lblSure.Text) - 1).ToString();
                progressBar1.Value = progressBar1.Value - 1;
            }
        }
    }
}
