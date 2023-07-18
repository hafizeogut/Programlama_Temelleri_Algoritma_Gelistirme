using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Emlak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("provider=microsoft.jet.OLEDB.4.0; DATA SOURCE=vt.mdb");

        private void Form1_Load(object sender, EventArgs e)
        {
            Goster();
        }
        private void Goster()
        {
            bag.Open();
            OleDbCommand GOSTER = new OleDbCommand("Select * from Emlak ", bag);
            OleDbDataAdapter da = new OleDbDataAdapter(GOSTER);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGoster.DataSource = dt;
            bag.Close();

        }
        private void Guncelle()
        {
            bag.Open();
            OleDbCommand YoneticiGuncelleCek = new OleDbCommand("SELECT * FROM Emlak WHERE il_ilce = '" + dgvGoster.CurrentRow.Cells[1].Value.ToString() + "'", bag);
            OleDbDataReader dr = YoneticiGuncelleCek.ExecuteReader();
            while (dr.Read())
            {
                txtIlce.Text = dr[1].ToString();
                txtAdres.Text = dr[2].ToString();
                txtKatSayisi.Text = dr[3].ToString();
                txtBulunduguYer.Text = dr[4].ToString();
                txtDaire.Text = dr[5].ToString();
                txtIsitma.Text = dr[6].ToString();
                txtAlan.Text = dr[7].ToString();
                txtOdaSayisi.Text = dr[8].ToString();
                txtBina.Text = dr[9].ToString();
                txtFiyat.Text = dr[10].ToString();
            }
            bag.Close();
            Goster();
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtIlce.Text == "")
            {
                MessageBox.Show("hata");
            }
            else
            {
                bag.Open();
            OleDbCommand ekle = new OleDbCommand("INSERT INTO Emlak(il_ilce,adres,kat_sayisi,b_kat,daire_no,isitma,alani,oda_sayisi,bina_yasi,fiyat)Values('" + txtIlce.Text + "','" + txtAdres.Text + "','" + txtKatSayisi.Text + "','" + txtBulunduguYer.Text + "','" + txtDaire.Text + "','" + txtIsitma.Text + "','" + txtAlan.Text + "','" + txtOdaSayisi.Text + "','" + txtBina.Text + "','" + txtFiyat.Text + "')", bag);
            ekle.ExecuteNonQuery();
            bag.Close();
            Goster();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
             if (txtIlce.Text == "")
            {
                MessageBox.Show("hata");
            }
            else
            {
            bag.Open();
            OleDbCommand sil = new OleDbCommand("DELETE FROM Emlak WHERE il_ilce = '" + dgvGoster.CurrentRow.Cells[1].Value.ToString() + "'", bag);
            sil.ExecuteNonQuery();
            bag.Close();
                Goster();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
               if (txtIlce.Text == "")
            {
                MessageBox.Show("hata");
            }
            else
            {
            bag.Open();
            string Ara = Convert.ToString(txtIlce.Text);
            OleDbCommand aramaKomutu = new OleDbCommand("SELECT * FROM Emlak WHERE il_ilce like '%" + Ara + "%'", bag);
            OleDbDataAdapter da = new OleDbDataAdapter(aramaKomutu);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGoster.DataSource = dt;
            bag.Close(); 
        }
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Guncelle();
        }

        private void dgvGoster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pboxResim.ImageLocation = dgvGoster.Rows[e.RowIndex].Cells[11].Value.ToString(); 
            
        }
 
    }
}
