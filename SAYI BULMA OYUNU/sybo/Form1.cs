using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sybo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int Tutulansayi;
        private void btnBasla_Click(object sender, EventArgs e)
        {
            btnTahmin.Visible = true;
            if (txtSayi.Text == "") lblDurum.Text = ("ÖNCELİKLE BİR SAYİ GİRİNİZ");
            else
            {
                Skor = 0;
                timer1.Start();
                Tutulansayi = Convert.ToInt16(txtSayi.Text);
                txtSayi.Text = "";//TEXT KUTUSUNU BOŞULTTIM
                btnBasla.Enabled = false;
                btnTahmin.Enabled = true;
            }
        }
        int Skor = 0;
        private void btnTahmin_Click(object sender, EventArgs e)
        {
            if (txtSayi.Text == "") lblDurum.Text = "ÖNCELİKLE BİR SAYİ TAHİNİNDE BULUNUNUZ";
            else
            {
                int Tahmin;//değiken tanımladım
                Skor++;
                Tahmin = Convert.ToInt16(txtSayi.Text);
                if (Tutulansayi > Tahmin) lblDurum.Text = "DAHA BÜYÜK BİR SAYİ GİRİNİZ";
                if (Tutulansayi < Tahmin) lblDurum.Text = "DAHA KÜÇÜK BİR SAYİ GİRİNİZ";
                if (Tutulansayi == Tahmin)
                {
                    lblDurum.Text = "tebrikler kazandınız!!!" + Skor + ".denemede buldun" + Sayac + " SN kala buldunuz";
                    timer1.Stop();
                    btnTahmin.Enabled = false;
                    btnBasla.Enabled = true;
                    Sayac = 120;
                    lblSonuc.Text = "";
                    txtSayi.Text = null;

                }
            }
        }
        int Sayac = 120;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Sayac--;
            lblSonuc.Text = Sayac.ToString() + " SANİYE";
            if (Sayac == 0)
            {
                timer1.Stop();
                btnTahmin.Enabled = false;
                btnBasla.Enabled = true;

                pbBar.Value = pbBar.Value + 1;
                if (pbBar.Value == 100)
                {
                    timer1.Enabled = false;
                    MessageBox.Show("TAME OUT", "BASLIK", MessageBoxButtons.YesNo);
                }
            }


        }

        private void pbBar_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
        }

  
 