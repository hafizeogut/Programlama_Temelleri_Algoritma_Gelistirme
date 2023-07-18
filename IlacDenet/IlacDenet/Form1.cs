using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace IlacDenet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb"); 
        string Ilac;
        private void dgvGoster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Ilac = dgvGoster.Rows[e.RowIndex].Cells[1].Value.ToString();
            pboxResim.ImageLocation = dgvGoster.Rows[e.RowIndex].Cells[4].Value.ToString();
            lblKullanim.Text = dgvGoster.Rows[e.RowIndex].Cells[2].Value.ToString();
            lblYanEtki.Text = dgvGoster.Rows[e.RowIndex].Cells[3].Value.ToString();
            baglanti.Open();
            OleDbDataAdapter kurye = new OleDbDataAdapter("select * from IlacKullanim where IlacAd='" + Ilac + "'", baglanti);
            DataTable sanaltablo = new DataTable();
            kurye.Fill(sanaltablo);
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("select * from IlacKullanim", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvGoster.DataSource = dt;
            baglanti.Close();
        }
    }
}
