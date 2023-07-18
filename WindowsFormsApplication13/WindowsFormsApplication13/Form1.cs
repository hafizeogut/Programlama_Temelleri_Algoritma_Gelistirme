using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rastgele = new Random();
        int s1, s2,s3;
        private void btnTahmin_Click(object sender, EventArgs e)
        {
            s1= rastgele.Next(1, 50);

           git2: s2 = rastgele.Next(1, 50);
            if (s1 == s2) goto git2;

            git3: s3 = rastgele.Next(1, 50);
            if (s1 == s3 || s2 == s3) goto git3;



            lbl1.Text = s1.ToString();
            lbl2.Text = s2.ToString();
            lbl3.Text = s3.ToString();
        }
    }
}
