using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OlEDB.4.0;Data Source=vt.mdb");//bağlantı cümlesi
        private void btnGoster_Click(object sender, EventArgs e)
        {
            baglanti.Open();//bağlantıyı açtım
            string sql = "Select isim,tel from skor where isim like \"%a%\"";//hangi tablodan hangi veriyi çeleceğimi belirttim
            OleDbCommand kurye = new OleDbCommand(sql, baglanti);//istediğim işlemi belirttiğim adresteki veri tabanından yapılmasını sağladım
            OleDbDataAdapter adaptor = new OleDbDataAdapter(kurye);//gelen verileri uygunlaştırdım
            DataTable sanaltablo = new DataTable();//gelen verileri yazabilmek için sanal bir tablo oluşturdum
            adaptor.Fill(sanaltablo);//sanal tabloyu uygunlaştırılan verilerle doldurdum
            baglanti.Close();//bağlantımı kapattım
            dgvSkor.DataSource = sanaltablo;// data grid view nesnemin veri kaynağını sanal tablo olarak yönlendirdim.
        }
    }
}
