using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaslaRed_Click(object sender, EventArgs e)
        {
            timerRed.Enabled = true;
        }

        private void btnDurdurRed_Click(object sender, EventArgs e)
        {
            timerRed.Enabled = false;
        }

        private void btnBaslaGreen_Click(object sender, EventArgs e)
        {
            timerGreen.Enabled = true;
        }

        private void btnDurdurGreen_Click(object sender, EventArgs e)
        {
            timerGreen.Enabled = false;
        }

        private void btnBaslaBlue_Click(object sender, EventArgs e)
        {
            timerBlue.Enabled = true;
        }

        private void btnDurdurBlue_Click(object sender, EventArgs e)
        {
            timerBlue.Enabled = false;
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            timerBlue.Enabled = false;
            timerGreen.Enabled = false;
            timerRed.Enabled = false;
            lblBlue.Text = "0";
            lblGreen.Text = "0";
            lblRed.Text = "0";
        }
        int sayired,sayigreen,sayiblue;
        private void timerRed_Tick(object sender, EventArgs e)
        {
            sayiblue = Convert.ToInt16(lblBlue.Text);
            sayigreen = Convert.ToInt16(lblGreen.Text);

            sayired = Convert.ToInt16(lblRed.Text);
            sayired = sayired + 1;
            lblRed.Text = sayired.ToString();
            if (sayired == 255)
            {
                timerRed.Enabled = false;
            }
            this.BackColor = Color.FromArgb(sayired, sayigreen, sayiblue);
        }

        private void timerGreen_Tick(object sender, EventArgs e)
        {
            sayiblue = Convert.ToInt16(lblBlue.Text);
            sayired = Convert.ToInt16(lblRed.Text);

            sayigreen = Convert.ToInt16(lblGreen.Text);
            sayigreen = sayigreen + 1;
            lblGreen.Text = sayigreen.ToString();
            if (sayigreen == 255)
            {
                timerGreen.Enabled = false;
            }
            this.BackColor = Color.FromArgb(sayired, sayigreen, sayiblue);
        }

        private void timerBlue_Tick(object sender, EventArgs e)
        {
            sayired = Convert.ToInt16(lblRed.Text);
            sayigreen = Convert.ToInt16(lblGreen.Text);

            sayiblue = Convert.ToInt16(lblBlue.Text);
            sayiblue = sayiblue + 1;
            lblBlue.Text = sayiblue.ToString();
            if (sayiblue == 255)
            {
                timerBlue.Enabled = false;
            }
            this.BackColor = Color.FromArgb(sayired, sayigreen, sayiblue);
        }
    }
}
