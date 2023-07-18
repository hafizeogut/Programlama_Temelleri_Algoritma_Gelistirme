using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int sayi1,sayi2,sayi3;
        double cevap;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private Color renkler(int renksayi)
        {
            Color renk = Color.Black;
            if (renksayi == 0) renk = Color.Black;
            else if (renksayi == 1) renk = Color.Brown;
            else if (renksayi == 2) renk = Color.Red;
            else if (renksayi == 3) renk = Color.Orange;
            else if (renksayi == 4) renk = Color.Yellow;
            else if (renksayi == 5) renk = Color.Green;
            else if (renksayi == 6) renk = Color.Blue;
            else if (renksayi == 7) renk = Color.Purple;
            else if (renksayi == 8) renk = Color.Gray;
            else if (renksayi == 9) renk = Color.White;
            return renk;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lblSure.Text == "0") oyunbitti();
            else
            {
                pBar.Value = pBar.Value - 1;
                lblSure.Text = (Convert.ToInt16(lblSure.Text) - 1).ToString();
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            direncgetir();
        }

        private void direncgetir()
        {
            sayi1 = rnd.Next(0, 10);
            btnRenk1.BackColor = renkler(sayi1);
            sayi2 = rnd.Next(0, 10);
            btnRenk2.BackColor = renkler(sayi2);
            sayi3 = rnd.Next(0, 10);
            btnRenk3.BackColor = renkler(sayi3);
            timer1.Enabled = true;
            cevap = ((sayi1 * 10) + sayi2) * (Math.Pow(10, sayi3));
            this.Text = cevap.ToString();
            txtCevap.Text = "";
        }

        private void oyunbitti()
        {
            timer1.Enabled=false;
            lblSure.Text="60";
            pBar.Value=60;
            MessageBox.Show("oyun bitti");
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (cevap == Convert.ToDouble(txtCevap.Text))
            {
                lblDogru.Text = (Convert.ToInt16(lblDogru.Text) + 1).ToString();
                direncgetir();
            }
            else oyunbitti();
        }
    }
}
