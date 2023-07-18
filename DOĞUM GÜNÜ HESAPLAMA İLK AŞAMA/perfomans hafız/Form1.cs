using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace perfomans_hafız
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            int SY, SA, SG, DY, DA, DG, SonucG, SonucA, SonucY;
            SY = Convert.ToInt16(txtSimdikiyil.Text);
            SA = Convert.ToInt16(txtSimdikiay.Text);
            SG = Convert.ToInt16(txtSimdikigun.Text);
            DY = Convert.ToInt16(txtDogumyili.Text);
            DA = Convert.ToInt16(txtDogumayi.Text);
            DG = Convert.ToInt16(txtDogumgunu.Text);
            if (SG < DG)
            {
                SG = SG + 30;
                SA = SA - 1;
            }
            SonucG=SG-DG;
            if (SA < DA)
            {
                SA = SA + 12;
                SY = SY - 1;
            }
            SonucA = SA - DA;
            SonucY = SY - DY;
            lblSonucgun.Text = SonucG.ToString();
            lblSonucay.Text = SonucA.ToString();
            lblSonucyil.Text = SonucY.ToString();

        }
    }
}
