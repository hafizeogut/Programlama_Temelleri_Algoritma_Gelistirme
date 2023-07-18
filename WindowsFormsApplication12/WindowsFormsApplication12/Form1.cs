using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random sec = new Random();
        int red, green, blue;
        private void btnRenk_Click(object sender, EventArgs e)
        {
            red = sec.Next(0, 255);
            green = sec.Next(0, 255);
            blue = sec.Next(0, 255);
            this.BackColor = Color.FromArgb(red, green, blue);
        }


        Random rnd = new Random();
        int s1, s2, s3, s4, s5, s6;
        private void btnSayi_Click(object sender, EventArgs e)
        {
            s1 = rnd.Next(1, 49);
            git1: s2 = rnd.Next(1, 49);
            if (s1 == s2) goto git1;
            git2: s3 = rnd.Next(1, 49);
            if (s3 == s1 || s3 == s2) goto git2;
            git3: s4 = rnd.Next(1, 49);
            if (s4 == s1 || s4 == s2 || s4 == s3) goto git3;
        }
    }
}
