using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random();
        int sayi;
        int sure = 0;

        string dogrucevap;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=vt.mdb");
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi = rnd.Next(1,5);
            lblRsoru.Text = sayi.ToString();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnBitir_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            baglanti.Open();
            OleDbDataAdapter kurye = new OleDbDataAdapter("select * from sorular where SN='" + lblRsoru.Text + "'", baglanti);
            DataTable sanaltablo = new DataTable();
            kurye.Fill(sanaltablo);
            baglanti.Close();
            lblSoru.Text = sanaltablo.Rows[0][2].ToString();

            int cevap1 = rnd.Next(3, 7);
            lblA.Text = sanaltablo.Rows[0][cevap1].ToString();

            tekrar1: int cevap2 = rnd.Next(3, 7);
            if (cevap2 == cevap1) goto tekrar1;
            lblB.Text=sanaltablo.Rows[0][cevap2].ToString();

            tekrar2: int cevap3 = rnd.Next(3, 7);
            if (cevap3 == cevap1 || cevap3 == cevap2) goto tekrar2;
            lblC.Text=sanaltablo.Rows[0][cevap3].ToString();

           
            tekrar3: int cevap4 = rnd.Next(3, 7);
            if (cevap1 == cevap4 || cevap2 == cevap4 || cevap3 == cevap4) goto tekrar3;
            lblD.Text=sanaltablo.Rows[0][cevap4].ToString();

            dogrucevap = sanaltablo.Rows[0][7].ToString();
            sure =Convert.ToInt16( sanaltablo.Rows[0][8].ToString());
            lblSure.Text = sure.ToString();
            timerSure.Enabled = true;
        }

        private void btnCevapla_Click(object sender, EventArgs e)
        {
            timerSure.Enabled = false;
            if (dogrucevap == "A" && rbtnA.Checked)
            {
                lblDS.Text = (Convert.ToInt16(lblDS.Text) + 1).ToString();
                rbtnA.BackColor = Color.Green;
            }
            else if (dogrucevap == "B" && rbtnB.Checked)
            {
                lblDS.Text = (Convert.ToInt16(lblDS.Text) + 1).ToString();
                rbtnB.BackColor = Color.Green;
            }
            else if (dogrucevap == "C" && rbtnC.Checked)
            {
                lblDS.Text = (Convert.ToInt16(lblDS.Text) + 1).ToString();
                rbtnC.BackColor = Color.Green;
            }
            else if (dogrucevap == "D" && rbtnD.Checked)
            {
                lblDS.Text = (Convert.ToInt16(lblDS.Text) + 1).ToString();
                rbtnD.BackColor = Color.Green;
            }
            else
            {
  
                if (rbtnA.Checked) rbtnA.BackColor = Color.Red;
                if (rbtnB.Checked) rbtnB.BackColor = Color.Red;
                if (rbtnC.Checked) rbtnC.BackColor = Color.Red;
                if (rbtnD.Checked) rbtnD.BackColor = Color.Red;
                MessageBox.Show("ahhhaaaaa yanlış");
            }
        }

        private void timerSure_Tick(object sender, EventArgs e)
        {
            if (lblSure.Text == "0")
            {
                timerSure.Enabled = false;
                MessageBox.Show("ahhhaaaaa süre bitti");
            }
            else lblSure.Text = (Convert.ToInt16(lblSure.Text) - 1).ToString();
        }
    }
}
