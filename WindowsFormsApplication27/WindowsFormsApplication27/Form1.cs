using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random sayi = new Random();
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=vt.mdb");
        string dogrucevap;

        private void btnBasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        int c1, c2, c3, c4;
        private void btnBitir_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            baglanti.Open();
            OleDbDataAdapter kurye = new OleDbDataAdapter("select * from sorular where SN='" + lblHangiSoru.Text + "'", baglanti);
            DataTable sanaltablo = new DataTable();
            kurye.Fill(sanaltablo);
            baglanti.Close();
            lblSoru.Text = sanaltablo.Rows[0][2].ToString();
            c1 = sayi.Next(3, 7);//3-4-5-6
            lblA.Text = sanaltablo.Rows[0][c1].ToString();

            tekrar1: c2 = sayi.Next(3, 7);//3-4-5-6
            if (c1 == c2) goto tekrar1;
            lblB.Text = sanaltablo.Rows[0][c2].ToString();

            tekrar2: c3 = sayi.Next(3, 7);//3-4-5-6
            if (c1 == c3 || c2 == c3) goto tekrar2;
            lblC.Text = sanaltablo.Rows[0][c3].ToString();

            tekrar3: c4 = sayi.Next(3, 7);//3-4-5-6
            if (c1 == c4 || c2 == c4 || c3 == c4) goto tekrar3;
            lblD.Text = sanaltablo.Rows[0][c4].ToString();



            dogrucevap = sanaltablo.Rows[0][7].ToString();
            lblSure.Text = sanaltablo.Rows[0][8].ToString();
            timerSure.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHangiSoru.Text = sayi.Next(1, 5).ToString();
        }

        private void btnCevapla_Click(object sender, EventArgs e)
        {
            if (rbtnA.Checked && dogrucevap == "A")
            {
                lblDogru.Text = (Convert.ToInt16(lblDogru.Text) + 1).ToString();
                rbtnA.BackColor = Color.Green;
                lblA.BackColor = Color.Green;
            }
            else if (rbtnB.Checked && dogrucevap == "B")
            {
                lblDogru.Text = (Convert.ToInt16(lblDogru.Text) + 1).ToString();
                rbtnB.BackColor = Color.Green;
                lblB.BackColor = Color.Green;
            }
            else if (rbtnC.Checked && dogrucevap == "C")
            {
                lblDogru.Text = (Convert.ToInt16(lblDogru.Text) + 1).ToString();
                rbtnC.BackColor = Color.Green;
                lblC.BackColor = Color.Green;
            }
            else if (rbtnD.Checked && dogrucevap == "D")
            {
                lblDogru.Text = (Convert.ToInt16(lblDogru.Text) + 1).ToString();
                rbtnD.BackColor = Color.Green;
                lblD.BackColor = Color.Green;
            }
            else
            {
                
                if (rbtnA.Checked) rbtnA.BackColor = Color.Red;
                if (rbtnB.Checked) rbtnB.BackColor = Color.Red;
                if (rbtnC.Checked) rbtnC.BackColor = Color.Red;
                if (rbtnD.Checked) rbtnD.BackColor = Color.Red;
                MessageBox.Show("yanlış yaptınız, bize yanlış olmaz");
            }
        }

        private void timerSure_Tick(object sender, EventArgs e)
        {
            if (lblSure.Text == "0")
            {
                timerSure.Enabled = false;
                MessageBox.Show("Süre bitti");
            }
            else
            {
                lblSure.Text = (Convert.ToInt16(lblSure.Text) - 1).ToString();
            }
        }
    }
}
