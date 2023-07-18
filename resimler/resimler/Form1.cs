using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace resimler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=vt.mdb");
        private void btnAra_Click(object sender, EventArgs e)
        {
            lboxResım.Items.Clear();
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT * FROM cicekler WHERE key like '%" + txtAra.Text + "%'", baglanti);
            OleDbDataAdapter da = new OleDbDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            baglanti.Close();
            for (int a = 0; a < dt.Rows.Count; a++)
            {
                string istedigimveri = dt.Rows[a][2].ToString();
                lboxResım.Items.Add(istedigimveri);
            }
        }

        private void lboxResım_SelectedIndexChanged(object sender, EventArgs e)
        {
            string listedekiyazi = lboxResım.SelectedItem.ToString();
            pictureBox1.ImageLocation = listedekiyazi;
  
        }

        private void txtAra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
