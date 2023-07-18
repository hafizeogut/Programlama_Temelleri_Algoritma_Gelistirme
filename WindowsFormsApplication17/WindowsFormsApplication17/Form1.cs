using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=vt.mdb");
        private void txtPadi_Load(object sender, EventArgs e)
        {
            hadiyapgari("select * from pasta","pasta");
        }

        private void hadiyapgari(string gelenistek, string hangisi)
        {
            baglanti.Open();
            OleDbCommand kurye = new OleDbCommand(gelenistek, baglanti);
            OleDbDataAdapter uygunlastirici = new OleDbDataAdapter(kurye);
            DataTable sanaltablo = new DataTable();
            uygunlastirici.Fill(sanaltablo);
            baglanti.Close();
            if (hangisi == "pasta") dgvPasta.DataSource = sanaltablo;
            else if (hangisi == "icerik") dgvIcerik.DataSource = sanaltablo;
        }

        private void dgvPasta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dgvPasta.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPadi.Text = dgvPasta.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPboyut.Text = dgvPasta.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPtur.Text = dgvPasta.Rows[e.RowIndex].Cells[3].Value.ToString();
            hadiyapgari("select * from icerik where ID= '" + lblID.Text + "'", "icerik");
        }

        private void temizle()
        {
            txtPadi.Text = "";
            txtPtur.Text = "";
            txtPboyut.Text = "";
            lblID.Text = "";
            dgvIcerik.DataSource = "";
        }

        private void bntEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string istek = "insert into pasta (padi,pboyut,ptur) values ('" + txtPadi.Text + "','" + txtPboyut.Text + "','" + txtPtur.Text + "')";
            OleDbCommand kurye = new OleDbCommand(istek, baglanti);
            kurye.ExecuteNonQuery();
            baglanti.Close();

            hadiyapgari("select * from pasta", "pasta");
            temizle();
            MessageBox.Show("Ekleme işlemi başarılı");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string istek = "delete * from pasta where ID=" + lblID.Text;
            OleDbCommand kurye = new OleDbCommand(istek, baglanti);
            kurye.ExecuteNonQuery();
            baglanti.Close();
            hadiyapgari("select * from pasta", "pasta");
            temizle();
            MessageBox.Show("Silme işlemi tamamlandı");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string istek = "update pasta set padi='" + txtPadi.Text + "' ,pboyut='" + txtPboyut.Text + "', ptur='" + txtPtur.Text + "' where ID=" + lblID.Text;
            OleDbCommand kurye = new OleDbCommand(istek, baglanti);
            kurye.ExecuteNonQuery();
            baglanti.Close();

            hadiyapgari("select * from pasta", "pasta");
            temizle();
            MessageBox.Show("Güncelleme işlemi başarılı");
        }

        private void btnEkle2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string istek = "insert into icerik (ID,malzeme,miktar,birim) values ('"+lblID.Text+"','" + txtMalzeme.Text + "','" + txtMiktar.Text + "','" + txtBirim.Text + "')";
            OleDbCommand kurye = new OleDbCommand(istek, baglanti);
            kurye.ExecuteNonQuery();
            baglanti.Close();
            temizle();
            hadiyapgari("select * from icerik", "icerik");
            
            MessageBox.Show("Ekleme işlemi başarılı");
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            Form1 frm1 = new Form1();
           
            frm2.Show();
            frm1.Close();
        }

    }
}
