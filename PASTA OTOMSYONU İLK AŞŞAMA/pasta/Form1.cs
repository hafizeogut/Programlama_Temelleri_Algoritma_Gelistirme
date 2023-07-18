using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace pasta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=vt.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open(); 
            OleDbCommand kurye = new OleDbCommand( "Insert into pasta(Padi,Pboyut,Ptur) values ('" + txtPadi.Text + "','" + txtPboy.Text + "','" + txtPtur.Text + "') ", baglanti);
            kurye.ExecuteNonQuery();
            baglanti.Close();

            hadiyapgari("select * from pasta", "pasta");
            dgvMalzeme.DataSource = "";
            MessageBox.Show("pasta veri tabanına eklenmiştir");
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
            else if (hangisi == "malzeme") dgvMalzeme.DataSource = sanaltablo;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtPadi.Text == "") MessageBox.Show("Silmek için önce veri seçmelisiniz");
            else
            {
                baglanti.Open();
                string silmekodu = "Delete * from pasta where ID=" + lblID.Text;
                OleDbCommand kurye = new OleDbCommand(silmekodu, baglanti);
                kurye.ExecuteNonQuery();
                baglanti.Close();

                hadiyapgari("select * from pasta", "pasta");
                dgvMalzeme.DataSource = "";
                MessageBox.Show("Bilgisayar veri tabanından silinmişti");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string guncellemekodu = "update pasta SET Padi='" + txtPadi.Text + "', Pboyut='" +txtPboy.Text+ "', Ptur='" +txtPtur.Text + "', where ID=" + lblID.Text;
            OleDbCommand kurye = new OleDbCommand(guncellemekodu, baglanti);
            kurye.ExecuteNonQuery();
            baglanti.Close();

            hadiyapgari("select * from pasta", "pasta");
            dgvMalzeme.DataSource = "";
            MessageBox.Show("Bilgisayar güncellenmiştir");
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            hadiyapgari("select * from pasta", "pasta");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvPasta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dgvPasta.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPadi.Text = dgvPasta.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPboy.Text= dgvPasta.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPtur.Text = dgvPasta.Rows[e.RowIndex].Cells[3].Value.ToString(); 
            hadiyapgari("select * from malzeme where ID= '" + lblID.Text + "'", "malzeme");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand kurye = new OleDbCommand("Insert into malzeme(Malzeme,Miktar,Birim) values ('" + txtPastaAdi.Text + "','" + txtPastaBoy.Text + "','" + txtPastaTuru.Text + "') ", baglanti);
            kurye.ExecuteNonQuery();
            baglanti.Close();

            hadiyapgari("select * from malzeme", "malzeme");
          
        }

        private void btnSill_Click(object sender, EventArgs e)
        {
            if (txtPadi.Text == "") MessageBox.Show("Silmek için önce veri seçmelisiniz");
            else
            {
                baglanti.Open();
                string silmekodu = "Delete * from malzeme where ID=" + lblIDD.Text;
                OleDbCommand kurye = new OleDbCommand(silmekodu, baglanti);
                kurye.ExecuteNonQuery();
                baglanti.Close();

                hadiyapgari("select * from malzeme", "malzeme");
                
            }
        }

        private void btnGuncellee_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string guncellemekodu = "update pasta set Malzeme='" + txtPastaAdi.Text + "', Miktar='" + txtPastaBoy.Text + "', Birim='" + txtPastaTuru.Text + "', where ID=" + lblIDD.Text;
            OleDbCommand kurye = new OleDbCommand(guncellemekodu, baglanti);
            kurye.ExecuteNonQuery();
            baglanti.Close();

            hadiyapgari("select * from malzeme", "malzeme");
            
        }

        private void dgvMalzeme_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dgvMalzeme.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPastaAdi.Text = dgvMalzeme.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPastaBoy.Text = dgvMalzeme.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPastaTuru.Text = dgvMalzeme.Rows[e.RowIndex].Cells[3].Value.ToString();
            hadiyapgari("select * from malzeme where ID= '" + lblID.Text + "'", "pasta");
        }

    }
}
