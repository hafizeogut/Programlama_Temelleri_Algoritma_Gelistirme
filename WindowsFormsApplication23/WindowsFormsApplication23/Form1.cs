using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication23
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
            lboxNesneler.Items.Clear();
            baglanti.Open();
            string istek="select * from tablo where key like '%"+txtAra.Text+"%'";
            OleDbDataAdapter kurye = new OleDbDataAdapter(istek, baglanti);
            DataTable sanaltablo = new DataTable();
            kurye.Fill(sanaltablo);
            baglanti.Close();
            for (int a = 0; a < sanaltablo.Rows.Count; a++)
            {
                string istedigimveri = sanaltablo.Rows[a][2].ToString();
                lboxNesneler.Items.Add(istedigimveri);
            }
            
        }

        private void lboxNesneler_SelectedIndexChanged(object sender, EventArgs e)
        {
            pboxResim.ImageLocation = lboxNesneler.SelectedItem.ToString();
        }
    }
}
