using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cBoxTur.SelectedIndex = 0;
            cBoxZaman.SelectedIndex = 0;
            cBoxKisi.SelectedIndex = 0;
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
        private void cBoxTur_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter kurye = new OleDbDataAdapter("select * from yemekler where Tur='" + cBoxTur.SelectedItem.ToString() + "'", baglanti);
            DataTable sanaltablo = new DataTable();
            baglanti.Close();
            kurye.Fill(sanaltablo);
            dgvYemekler.DataSource = sanaltablo;
        }

        string yemekadi;
        private void dgvYemekler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lBoxMalzemeler.Items.Clear();
            pBoxResim.ImageLocation = dgvYemekler.Rows[e.RowIndex].Cells[5].Value.ToString();
            lblTarif.Text = dgvYemekler.Rows[e.RowIndex].Cells[6].Value.ToString();
            yemekadi = dgvYemekler.Rows[e.RowIndex].Cells[1].Value.ToString();
            
            baglanti.Open();
            OleDbDataAdapter kurye = new OleDbDataAdapter("select * from icerik where Adi='" +yemekadi + "'", baglanti);
            DataTable sanaltablo = new DataTable();
            kurye.Fill(sanaltablo);
            baglanti.Close();
            for (int a = 0; a < sanaltablo.Rows.Count; a++)
            {
                lBoxMalzemeler.Items.Add(sanaltablo.Rows[a][2].ToString() + " " + sanaltablo.Rows[a][3].ToString());
            }
        }

        private void cBoxKisi_SelectedIndexChanged(object sender, EventArgs e)
        {
            lBoxMalzemeler.Items.Clear();
            baglanti.Open();
            OleDbDataAdapter kurye = new OleDbDataAdapter("select * from icerik where Adi='" + yemekadi + "'", baglanti);
            DataTable sanaltablo = new DataTable();
            kurye.Fill(sanaltablo);
            baglanti.Close();
            for (int a = 0; a < sanaltablo.Rows.Count; a++)
            {
                lBoxMalzemeler.Items.Add(sanaltablo.Rows[a][2].ToString() + " " + (Convert.ToInt16(sanaltablo.Rows[a][3].ToString()) * Convert.ToInt16(cBoxKisi.SelectedItem.ToString())).ToString()  );
            }
        }

        private void btnBonusAra_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter kurye = new OleDbDataAdapter("select * from yemekler where Icerik like '%" + txtBonusAra.Text + "%'", baglanti);
            DataTable sanaltablo = new DataTable();
            baglanti.Close();
            kurye.Fill(sanaltablo);
            dgvYemekler.DataSource = sanaltablo;
        }
    }
}
