using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Artı_eksi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAzalt_Click(object sender, EventArgs e)
        {
            int Sayi;
            Sayi = Convert.ToInt16(lblSonuc.Text);
            Sayi = Sayi - 5;
            lblSonuc.Text = Sayi.ToString();
        }

        private void btnCogalt_Click(object sender, EventArgs e)
        {
            int Sayi;
            Sayi = Convert.ToInt16(lblSonuc.Text);
            Sayi = Sayi + 5;
            lblSonuc.Text = Sayi.ToString();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = txtSayi.Text;
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            lblSonuc.Text = "0";
        }
    }
}
