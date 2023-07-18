using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pBarsure.Value--;
        }

        int s1, s2, sonuc;
        int sayac = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            s1 = sayiuret();
            tekrar: s2 = sayiuret();
            if (s1 == s2) goto tekrar;
            sonuc = s1 + s2;
            lblSoru.Text = s1 + "+" + s2 + "=?";
            yaz(lblSoru.Text);
        }

        private int sayiuret()
        {
            Random rnd = new Random();
            int sayi = rnd.Next(0, 100);
            return sayi;
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0; Data Source=vt.mdb");
        private void yaz(string istek)
        {
            baglanti.Open();
            OleDbCommand kurye = new OleDbCommand("insert into oyun (soru) values ('" + istek + "')", baglanti);
            kurye.ExecuteNonQuery();//ekleme, güncelleme, silme işlemlerinde bu şekilde kullanılır
            baglanti.Close();
        }

        private void guncelle(string soru,string cevap,string durum)
        {
            baglanti.Open();
            OleDbCommand kurye = new OleDbCommand("update oyun set cevap='"+cevap+"', durum='"+durum+"' where soru='"+lblSoru.Text+"'", baglanti);
            kurye.ExecuteNonQuery();//ekleme, güncelleme, silme işlemlerinde bu şekilde kullanılır
            baglanti.Close();
        }

        private void btnCevap_Click(object sender, EventArgs e)
        {
            int tahmin=Convert.ToInt16(txtCevap.Text);
            if (tahmin == sonuc)
            {
                sayac++; //   sayac=sacay+1;
                guncelle(lblSoru.Text, txtCevap.Text, "Doğru");
                s1 = sayiuret();
                tekrar: s2 = sayiuret();
                if (s1 == s2) goto tekrar;
                sonuc = s1 + s2;
                lblSoru.Text = s1 + "+" + s2 + "=?";
                yaz(lblSoru.Text);
                txtCevap.Text = "";
                txtCevap.Focus();
            }
            else
            {
                guncelle(lblSoru.Text, txtCevap.Text, "Yanlış");
                MessageBox.Show("oyun bitti "+ sayac+ " kadar doğrunuz var");
                timer1.Enabled = false;
                lblSoru.Text = "";
                txtCevap.Text = "";
            }
        }

    }
}
