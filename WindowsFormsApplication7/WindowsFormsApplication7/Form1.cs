using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            tmrSayac.Enabled = true;
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            tmrSayac.Enabled = false;
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            tmrSayac.Enabled = false;
            lblSayi.Text = "100";
            pbarGosterge.Value = 100;
        }

        private void tmrSayac_Tick(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt16(lblSayi.Text);
            if (sayi == 0)
            {
                tmrSayac.Enabled = false;
                MessageBox.Show("süre doldu");
            }
            else
            {
                sayi = sayi - 1;
                lblSayi.Text = sayi.ToString();
                pbarGosterge.Value = sayi;
                BackColor = Color.FromArgb(255, 255-(sayi*2), (sayi*2), 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void tbarHiz_Scroll(object sender, EventArgs e)
        {
            tmrSayac.Interval = tbarHiz.Value;
        }

    }
}
