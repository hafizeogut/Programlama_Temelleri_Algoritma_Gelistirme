﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbtnBayan_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(255, 0, 0);
        }

        private void rbtnBay_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.FromArgb(0, 0, 255);
        }

        private void rbtnFarketmez_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.BackColor = Color.Orange;
        }

        private void cboxBisiklet_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxBisiklet.Checked) txtYazi.Text = "Bisiklete dikkatli bin";
        }
    }
}
