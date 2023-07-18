using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timerRed.Enabled = true;
        }

        private void btnDurdur_Click(object sender, EventArgs e)
        {
            timerRed.Enabled = false;
        }

        int kirmizi;
        private void timerRed_Tick(object sender, EventArgs e)
        {
            yesil = Convert.ToInt16(lblGreen.Text);
            kirmizi = Convert.ToInt16(lblRed.Text);
            kirmizi = kirmizi + 1;
            lblRed.Text = kirmizi.ToString();
            this.BackColor = Color.FromArgb(kirmizi, yesil, 0);
        }

        private void btnBasla2_Click(object sender, EventArgs e)
        {
            timerGreen.Enabled = true;
        }

        private void btnDurdur2_Click(object sender, EventArgs e)
        {
            timerGreen.Enabled = false;
        }

        int yesil;
        private void timerGreen_Tick(object sender, EventArgs e)
        {
            yesil = Convert.ToInt16(lblGreen.Text);
            kirmizi = Convert.ToInt16(lblRed.Text);
            yesil = yesil + 1;
            lblGreen.Text = yesil.ToString();
            this.BackColor = Color.FromArgb(kirmizi, yesil, 0);
        }

        Random rastgele = new Random();//tanımlama işlemi yapıldı

        int mavi;
        private void btnRenkSec_Click(object sender, EventArgs e)
        {
            kirmizi = rastgele.Next(0, 255);
            yesil = rastgele.Next(0, 255);
            mavi = rastgele.Next(0, 255);
            lblRed.Text = kirmizi.ToString();
            lblGreen.Text = yesil.ToString();
            lblBlue.Text = mavi.ToString();
            this.BackColor = Color.FromArgb(kirmizi, yesil, mavi);
        }

        private void tBarRed_Scroll(object sender, EventArgs e)
        {
            kirmizi = tBarRed.Value;
            yesil = tBarGreen.Value;
            mavi = tBarBlue.Value;
            this.BackColor = Color.FromArgb(kirmizi, yesil, mavi);
        }

        private void tBarGreen_Scroll(object sender, EventArgs e)
        {
            kirmizi = tBarRed.Value;
            yesil = tBarGreen.Value;
            mavi = tBarBlue.Value;
            this.BackColor = Color.FromArgb(kirmizi, yesil, mavi);
        }

        private void tBarBlue_Scroll(object sender, EventArgs e)
        {
            kirmizi = tBarRed.Value;
            yesil = tBarGreen.Value;
            mavi = tBarBlue.Value;
            this.BackColor = Color.FromArgb(kirmizi, yesil, mavi);
        }

      
    }
}
