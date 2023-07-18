using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;//veri tabanı ile bağlantı kurmak için gerekli kodların bulunduğu kütüphaneyi projeme ekledim

namespace WindowsFormsApplication15
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }



        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=vt.mdb");
        private void btnGoster_Click(object sender, EventArgs e)
        {
            goster();
        }




        private void dgvOgrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dgvOgrenci.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAd.Text = dgvOgrenci.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtYas.Text = dgvOgrenci.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtBoy.Text = dgvOgrenci.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCinsiyet.Text = dgvOgrenci.Rows[e.RowIndex].Cells[4].Value.ToString();
        }




        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtAd.Text == "") MessageBox.Show("Öncelikle bir kişi seçiniz");
            else
            {
                baglanti.Open();
                string istek = "delete from ogrenci where ID="+ lblID.Text;
                OleDbCommand kurye = new OleDbCommand(istek, baglanti);
                kurye.ExecuteNonQuery();
                baglanti.Close();
                lblID.Text = "";
                txtAd.Text = "";
                txtBoy.Text = "";
                txtCinsiyet.Text = "";
                txtYas.Text = "";
                goster();
            }
        }

        void goster()
        {
            baglanti.Open();//bağlantıyı açtım
            string istek = "select * from ogrenci where adi like '%" + txtAra.Text + "%'"; //ogrenci tablosundan tüm verileri seç
            OleDbCommand kurye = new OleDbCommand(istek, baglanti);//belirttiğim bağlantı üzerinden istediğim verileri getir
            OleDbDataAdapter uygunlastir = new OleDbDataAdapter(kurye);//gelen verileri uygunlaştır
            baglanti.Close();//abağlantıyı kapat
            DataTable sanaltablo = new DataTable();//gelen veriler için sanal bir tablo oluşturduk.
            uygunlastir.Fill(sanaltablo);//sanal tablomun içini uygunlaştırılmış verilerle doldurdum
            dgvOgrenci.DataSource = sanaltablo;//data grid view nesnemin veri kaynağı sanal tablo oalrak ayarladım.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            goster();
        }
    }
}
