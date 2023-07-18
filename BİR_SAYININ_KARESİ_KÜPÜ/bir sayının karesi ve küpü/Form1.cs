using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bir_sayının_karesi_ve_küpü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int Sayi;
            int SonucKare;
            int SonucKup;
            Sayi = Convert.ToInt16(txtSayi.Text);
            SonucKare = Sayi * Sayi;
            SonucKup = Sayi * Sayi * Sayi;
            lblKare.Text = SonucKare.ToString();
            lblKup.Text = SonucKup.ToString();
                
        }
    }
}
