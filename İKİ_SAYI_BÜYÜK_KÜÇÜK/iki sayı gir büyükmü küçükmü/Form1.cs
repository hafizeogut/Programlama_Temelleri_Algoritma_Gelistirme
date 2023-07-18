using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iki_sayı_gir_büyükmü_küçükmü
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int S1, S2, Sonuc1, Sonuc2;
            int Hesapla;
            S1 = Convert.ToInt16(txtSayi1.Text);
            S2 = Convert.ToInt16(txtSayi2.Text);
            Sonuc1 = S1 + S2;
            Sonuc2 = S2 * S2;
            if (Sonuc1 > Sonuc2)
            {
                lblSonuc.Text = "BÜYÜK";
            }
            else if (Sonuc1 < Sonuc2)
            {
                lblSonuc.Text = "KÜÇÜK";
            }
            

        }
    }
}
