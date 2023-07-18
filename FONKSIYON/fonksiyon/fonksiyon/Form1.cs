using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace fonksiyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
        private void btnAnaEkreneBag_Click(object sender, EventArgs e)
        {
            AnaEkran ae = new AnaEkran();
            ae.Show();
            this.Hide();
        }
    }
}
