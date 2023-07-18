using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=vt.mdb");
        private void btnBaglan_Click(object sender, EventArgs e)
        {
            hadiyapgari("select * from pasta","pasta");
        }
       

       

        private void dgvPc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dgvPc.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtPadi.Text = dgvPc.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPboyut.Text = dgvPc.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPtur.Text = dgvPc.Rows[e.RowIndex].Cells[3].Value.ToString();
            hadiyapgari("select * from icerik where ID= '" + lblID.Text + "'", "icerik");
        }

        private void hadiyapgari(string gelenistek, string hangisi)
        {
            baglanti.Open();
            OleDbCommand kurye = new OleDbCommand(gelenistek, baglanti);
            OleDbDataAdapter uygunlastirici = new OleDbDataAdapter(kurye);
            DataTable sanaltablo = new DataTable();
            uygunlastirici.Fill(sanaltablo);
            baglanti.Close();
            if (hangisi == "pasta") dgvPc.DataSource = sanaltablo;
            else if (hangisi == "icerik") dgvİcerik.DataSource = sanaltablo;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtPadi.Text == "") MessageBox.Show("Silmek için önce veri seçmelisiniz");
            else
            {
                baglanti.Open();
                string silmekodu="Delete * from pasta where ID="+lblID.Text;
                OleDbCommand kurye=new OleDbCommand(silmekodu,baglanti);
                kurye.ExecuteNonQuery();
                baglanti.Close();
               
                hadiyapgari("select * from pasta", "pasta");
                dgvİcerik.DataSource = "";
                MessageBox.Show("Pasta veri tabanından silinmişti");
            }
        }

        int say = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (say == 0)
            {
                txtPboyut.Text = "";
                
                txtPadi.Text = "";
                txtPtur.Text = "";
                txtPboyut.Enabled = true;
               
                txtPadi.Enabled = true;
                txtPtur.Enabled = true;
                say = say + 1;
            }
            else
            {

                if (txtPadi.Text == "" || txtPboyut.Text == "" ||  txtPtur.Text == "") MessageBox.Show("Eklemek için önce veri girmelisiniz");
                else
                {
                    baglanti.Open();
                    string eklemekodu = "Insert into pasta (padi,pboyut,ptur) values ('" + txtPadi.Text + "','" + txtPboyut.Text + "','" + txtPtur.Text + "')";
                    OleDbCommand kurye = new OleDbCommand(eklemekodu, baglanti);
                    kurye.ExecuteNonQuery();
                    baglanti.Close();

                    hadiyapgari("select * from pasta", "pasta");
                    dgvİcerik.DataSource = "";
                    MessageBox.Show("Pasta veri tabanına eklenmiştir");
                    say = 0;
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string guncellemekodu = "update pasta SET padi ='" + txtPadi.Text + "', pboyut='" + txtPboyut.Text + "', ptur='" + txtPtur.Text + "' where ID="+lblID.Text;
            OleDbCommand kurye = new OleDbCommand(guncellemekodu, baglanti);
            kurye.ExecuteNonQuery();
            baglanti.Close();

            hadiyapgari("select * from pasta", "pasta");
            dgvİcerik.DataSource = "";
            MessageBox.Show("Pastalar güncellenmiştir");
        }

        private void btnİsil_Click(object sender, EventArgs e)
        {
            if (txtMalzeme.Text == "") MessageBox.Show("Silmek için önce veri seçmelisiniz");
            else
            {
                baglanti.Open();
                string silmekodu = "Delete * from icerik where ID=" + lblID.Text;
                OleDbCommand kurye = new OleDbCommand(silmekodu, baglanti);
                kurye.ExecuteNonQuery();
                baglanti.Close();

                hadiyapgari("select * from icerik", "icerik");
                dgvİcerik.DataSource = "";
                MessageBox.Show("İcerik veri tabanından silinmişti");
            }
        }

        private void btnİekle_Click(object sender, EventArgs e)
        {
            if (txtMalzeme.Text == "" || txtMiktar.Text == "" || txtBirim.Text == "") MessageBox.Show("Eklemek için önce veri girmelisiniz");
            else
            {
                baglanti.Open();
                string eklemekodu = "Insert into icerik (malzeme,miktar,birim) values ('" + txtMalzeme.Text + "','" + txtMiktar.Text + "','" + txtBirim.Text + "')";
                OleDbCommand kurye = new OleDbCommand(eklemekodu, baglanti);
                kurye.ExecuteNonQuery();
                baglanti.Close();

                hadiyapgari("select * from icerik", "icerik");
                dgvİcerik.DataSource = "";
                MessageBox.Show("icerik veri tabanına eklenmiştir");
                say = 0;
            }
        }
    }
}
