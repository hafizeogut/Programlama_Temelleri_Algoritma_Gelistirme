using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ders
{
    public partial class ARIZA : Form
    {
        public ARIZA()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source =vt.mdb");
        private void btnEkle_Click(object sender, EventArgs e)
        {
            bag.Open();
            OleDbCommand EKLE = new OleDbCommand("INSERT INTO  ariza_takip(Anakart,Islemci,RAM,HDD)VALUES('" + txtAnakart.Text + "','" + txtIslemci.Text + "','" + txtRam.Text + "','" + txtHdd.Text + "')", bag);
            int sonuc = EKLE.ExecuteNonQuery();
            bag.Close();
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            bag.Open();
            OleDbCommand GOSTER = new OleDbCommand("Select * from ariza_takip",bag);
            OleDbDataAdapter da = new OleDbDataAdapter(GOSTER);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGoster.DataSource = dt;
            bag.Close();
        }

        private void dgvGoster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblID1.Text=dgvGoster.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtAnakart.Text=dgvGoster.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtIslemci.Text=dgvGoster.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRam.Text=dgvGoster.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtHdd.Text=dgvGoster.Rows[e.RowIndex].Cells[4].Value.ToString();


        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            bag.Open();
            OleDbCommand sil = new OleDbCommand("DELETE FROM ariza_takip WHERE Anakart='" + txtAnakart + "'", bag);
            int sonuc = sil.ExecuteNonQuery();
            bag.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            bag.Open();
            OleDbCommand komut = new OleDbCommand("UPDATE ariza_takip Anakart='"+txtAnakart.Text+"',Islemci='"+txtIslemci.Text+"',RAM='"+txtRam.Text+"',HDD='"+txtHdd+"')",bag);
            int sonuc = komut.ExecuteNonQuery();
            bag.Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            bag.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM ariza_takip WHERE Anakart like '%" + txtAnakartAra.Text + "%'", bag);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGoster.DataSource = dt;
            bag.Close();
        }

        private void btnAraislem_Click(object sender, EventArgs e)
        {
            bag.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM ariza_takip  WHERE Islemci like '%" +txtIslemciAra.Text + "%'");
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGoster.DataSource = dt;
            bag.Close();
        }

         
    }
}
