using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string secilenyemek;
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.jet.OLEDB.4.0;Data Source=vt.mdb");
        private void cBoxTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter kurye=new OleDbDataAdapter("select * from yemekler where Tur='" + cBoxTur.SelectedItem.ToString() + "'", baglanti);
            DataTable sanaltablo = new DataTable();
            kurye.Fill(sanaltablo);
            baglanti.Close();
            dgvYiyecek.DataSource = sanaltablo;
        }

        private void dgvYiyecek_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pBoxResim.ImageLocation=dgvYiyecek.Rows[e.RowIndex].Cells[5].Value.ToString();
            lblTarif.Text =dgvYiyecek.Rows[e.RowIndex].Cells[6].Value.ToString();
            secilenyemek = dgvYiyecek.Rows[e.RowIndex].Cells[1].Value.ToString();
            baglanti.Open();
            OleDbDataAdapter kurye = new OleDbDataAdapter("select * from icerik where Adi='" + secilenyemek + "'", baglanti);
            DataTable sanaltablo = new DataTable();
            kurye.Fill(sanaltablo);
            baglanti.Close();
            lBoxMalzeme.Items.Clear();
            for (int a = 0; a < sanaltablo.Rows.Count; a++)
            {
                lBoxMalzeme.Items.Add(sanaltablo.Rows[a][2].ToString() + " " + sanaltablo.Rows[a][3].ToString()+"gr");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBoxKisi.SelectedIndex = 0;
            cBoxTur.SelectedIndex = 0;
            cBoxZaman.SelectedIndex = 0;
        }

        private void cBoxKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter kurye = new OleDbDataAdapter("select * from icerik where Adi='" + secilenyemek + "'", baglanti);
            DataTable sanaltablo = new DataTable();
            kurye.Fill(sanaltablo);
            baglanti.Close();
            lBoxMalzeme.Items.Clear();
            int malzememiktari;
            int secilenkisisayisi;
            int hesap;
            for (int a = 0; a < sanaltablo.Rows.Count; a++)
            {
                malzememiktari=Convert.ToInt16( sanaltablo.Rows[a][3].ToString());
                secilenkisisayisi=Convert.ToInt16(cBoxKisi.SelectedItem.ToString());
                hesap=malzememiktari*secilenkisisayisi;
                lBoxMalzeme.Items.Add(sanaltablo.Rows[a][2].ToString() + " " + hesap + "gr");
            }
        }
    }
}
