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
            hadiyapgari("select * from pc","pc");
        }
        private void btnAraIslemci_Click(object sender, EventArgs e)
        {
            hadiyapgari("select * from pc where islemci like '%" + txtIslemci.Text + "%'","pc");
        }
        private void btnAraAnakart_Click(object sender, EventArgs e)
        {
            hadiyapgari("select * from pc where anakart like '%" + txtAnakart.Text + "%'","pc");
        }

       

        private void dgvPc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID.Text = dgvPc.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMainboard.Text = dgvPc.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCPU.Text = dgvPc.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRAM.Text = dgvPc.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtHDD.Text = dgvPc.Rows[e.RowIndex].Cells[4].Value.ToString();
            hadiyapgari("select * from onarim where ID= '" + lblID.Text + "'", "tamir");
        }

        private void hadiyapgari(string gelenistek, string hangisi)
        {
            baglanti.Open();
            OleDbCommand kurye = new OleDbCommand(gelenistek, baglanti);
            OleDbDataAdapter uygunlastirici = new OleDbDataAdapter(kurye);
            DataTable sanaltablo = new DataTable();
            uygunlastirici.Fill(sanaltablo);
            baglanti.Close();
            if (hangisi == "pc") dgvPc.DataSource = sanaltablo;
            else if (hangisi == "tamir") dgvTamir.DataSource = sanaltablo;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string istek = "delete * from pc where ID=" + lblID.Text;
            OleDbCommand kurye = new OleDbCommand(istek, baglanti);
            kurye.ExecuteNonQuery();
            baglanti.Close();
            hadiyapgari("select * from pc", "pc");
            temizle();
            MessageBox.Show("Silme işlemi tamamlandı");
        }


        private void temizle()
        {
            txtMainboard.Text = "";
            txtCPU.Text = "";
            txtHDD.Text = "";
            txtRAM.Text = "";
            lblID.Text = "";
            dgvTamir.DataSource = "";
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string istek = "insert into pc (anakart,islemci,ram,hdd) values ('" + txtMainboard.Text + "','" + txtCPU.Text + "','" + txtRAM.Text + "','" + txtHDD.Text + "')";
            OleDbCommand kurye = new OleDbCommand(istek, baglanti);
            kurye.ExecuteNonQuery();
            baglanti.Close();

            hadiyapgari("select * from pc", "pc");
            temizle();
            MessageBox.Show("Ekleme işlemi başarılı");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string istek = "update pc set anakart='" + txtMainboard.Text + "' ,islemci='" + txtCPU.Text + "', ram='" + txtRAM.Text + "', hdd='" + txtHDD.Text + "' where ID=" + lblID.Text;
            OleDbCommand kurye = new OleDbCommand(istek, baglanti);
            kurye.ExecuteNonQuery();
            baglanti.Close();

            hadiyapgari("select * from pc", "pc");
            temizle();
            MessageBox.Show("Güncelleme işlemi başarılı");
        }


    }
}
