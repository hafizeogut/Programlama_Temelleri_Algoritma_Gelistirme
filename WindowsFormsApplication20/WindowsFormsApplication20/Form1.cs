using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int s1, s2, sonuc;
        int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            oyunbasla();
        }

        private int sayiuret()
        {
            Random rnd = new Random();
            int sayi=rnd.Next(0, 100);
            return sayi;
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=vt.mdb");
        private void vtekle(string veri)
        {
            baglanti.Open();
            OleDbCommand kurye = new OleDbCommand("insert into oyun (soru) values ('" + veri + "')", baglanti);
            kurye.ExecuteNonQuery();
            baglanti.Close();

        }

        private void vtguncelle(string soru,string cevap,string durum)
        {
            baglanti.Open();
            OleDbCommand kurye = new OleDbCommand("update oyun set cevap='" + cevap + "', durum='"+durum+"' where soru='"+soru+"'", baglanti);
            kurye.ExecuteNonQuery();
            baglanti.Close();

        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            int tahmin = Convert.ToInt16(txtCevap.Text);
            if (tahmin == sonuc)
            {
                vtguncelle(lblSoru.Text, txtCevap.Text, "Doğru");
                sayac++; // sayac=sayac+1;
                oyunbasla();
                txtCevap.Text = "";
            }
            else
            {
                oyunbitti();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (progressBar1.Value < 1)
            {
                oyunbitti();
                timer1.Enabled = false;
            }
            else progressBar1.Value--;
        }



        private void oyunbitti()
        {
            vtguncelle(lblSoru.Text, txtCevap.Text, "Yanlış");
            MessageBox.Show("Oyun bitti " + sayac + " kadar doğru yaptınız");
            lblSoru.Text = "";
            txtCevap.Text = "";
            progressBar1.Value = 120;
            timer1.Enabled = false;
        }


        private void oyunbasla()
        {
            s1 = sayiuret();
            tekrar: s2 = sayiuret();
            if (s1 == s2) goto tekrar;
            lblSoru.Text = s1 + "+" + s2 + "=?";
            vtekle(lblSoru.Text);
            sonuc = s1 + s2;
        }

    }
}
