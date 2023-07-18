using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissingList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection connection = new OleDbConnection("Provider = Microsoft.Jet.Oledb.4.0;Data Source = vt\\vt.mdb");
        public void MissingListCek()
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("SELECT * FROM MissingList", connection);
            OleDbDataAdapter da = new OleDbDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvShow.DataSource = dt;
            connection.Close();
        }
        public void Clean()
        {
            txtNowNumber.Text = txtMaterial.Text = txtWhere.Text = txtHowMuch.Text ="";
        }
        //WHERE ÖZEL BİR KARAKTERDİR O YÜZDEN DEĞİŞKEN ADI OLARAK VERİLMEZ.
        // int string double gibi düşün :)
        private void btnAdd_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand("INSERT INTO MissingList (NowNumberID,Material,WhereIsThe,HowMuch) VALUES (@NowNumberID,@Material,@WhereIsThe,@HowMuch)", connection);
            command.Parameters.AddWithValue("@NowNumberID", txtNowNumber.Text);
            command.Parameters.AddWithValue("@Material", txtMaterial.Text);
            command.Parameters.AddWithValue("@WhereIsThe", txtWhere.Text);
            command.Parameters.AddWithValue("@HowMuch", txtHowMuch.Text);
            int Result = command.ExecuteNonQuery();
            if (Result > 0)
            {
                Clean();
                connection.Close();
                MissingListCek();
                MessageBox.Show("SUCCESFULL", "IMFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command= new OleDbCommand("DELETE FROM MissingList WHERE NowNumberID = @NowNumberID", connection);
            command.Parameters.AddWithValue("@NowNumberID", dgvShow.CurrentRow.Cells[0].Value.ToString());
            int Result = command.ExecuteNonQuery();
            if (Result > 0)
            {
                connection.Close();
                MissingListCek();
                MessageBox.Show("SUCCESFULL", "IMFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

    }
}
  
