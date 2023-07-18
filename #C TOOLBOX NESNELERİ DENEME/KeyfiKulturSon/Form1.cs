using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KeyfiKulturSon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void gizleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void çıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hakkımdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ASD");
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            panel1.Width = 175;
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            panel1.Width = 10;
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //errorProvider1.SetError(txtad,"");
            label2.Text = txtad.Text.Substring(0, 4);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            this.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            this.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar4_Scroll(object sender, ScrollEventArgs e)
        {
            this.Width = hScrollBar4.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = " ANA EKRAN ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = this.Text.Substring(1) + this.Text.Substring(0, 1);
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            this.Height = vScrollBar1.Value;
        }
    }
}
