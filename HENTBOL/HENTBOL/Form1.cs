using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HENTBOL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.Jet.Oledb.4.0;Data Source = vt\\vt.mdb");
        private void Form1_Load(object sender, EventArgs e)
        {
            cboxHentbol.SelectedIndex = 0;
        }
        private void cboxHentbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboxHentbol.SelectedIndex == 1)
            {
                pboxRes.ImageLocation = "SEKIL.jpg";
                baglanti.Open();
                OleDbCommand Element = new OleDbCommand("SELECT * FROM  Hentbol", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(Element);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                lblHareketAd.Text = cboxHentbol.SelectedIndex.ToString();
                lblOzellik1.Text = dt.Rows[0][1].ToString(); 
            }

            else if (cboxHentbol.SelectedIndex == 2)
            {
                pboxRes.ImageLocation = "SEKIL2.jpg";
                baglanti.Open();
                OleDbCommand Element = new OleDbCommand("SELECT * FROM  Hentbol", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(Element);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                lblHareketAd.Text = cboxHentbol.SelectedIndex.ToString();
                lblOzellik1.Text = dt.Rows[1][1].ToString(); 
            }

            else if (cboxHentbol.SelectedIndex == 3)
            {
                pboxRes.ImageLocation = "SEKIL3.jpg";
                baglanti.Open();
                OleDbCommand Element = new OleDbCommand("SELECT * FROM  Hentbol", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(Element);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                lblHareketAd.Text = cboxHentbol.SelectedIndex.ToString();
                lblOzellik1.Text = dt.Rows[2][1].ToString(); 
            }

            else if (cboxHentbol.SelectedIndex == 4)
            {
                pboxRes.ImageLocation = "SEKIL4.jpg";
                baglanti.Open();
                OleDbCommand Element = new OleDbCommand("SELECT * FROM  Hentbol", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(Element);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                lblHareketAd.Text = cboxHentbol.SelectedIndex.ToString();
                lblOzellik1.Text = dt.Rows[3][1].ToString(); 
            }

            else if (cboxHentbol.SelectedIndex == 5)
            {
                pboxRes.ImageLocation = "SEKIL5.jpg";
                baglanti.Open();
                OleDbCommand Element = new OleDbCommand("SELECT * FROM  Hentbol", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(Element);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                lblHareketAd.Text = cboxHentbol.SelectedIndex.ToString();
                lblOzellik1.Text = dt.Rows[4][1].ToString(); 
            }
            else if (cboxHentbol.SelectedIndex == 6)
            {
                pboxRes.ImageLocation = "SEKIL6.jpg";
                baglanti.Open();
                OleDbCommand Element = new OleDbCommand("SELECT * FROM  Hentbol", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(Element);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                lblHareketAd.Text = cboxHentbol.SelectedIndex.ToString();
                lblOzellik1.Text = dt.Rows[5][1].ToString(); 
            }
            else if (cboxHentbol.SelectedIndex == 7)
            {
                pboxRes.ImageLocation = "SEKIL7.jpg";
                baglanti.Open();
                OleDbCommand Element = new OleDbCommand("SELECT * FROM  Hentbol", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(Element);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                lblHareketAd.Text = cboxHentbol.SelectedIndex.ToString();
                lblOzellik1.Text = dt.Rows[6][1].ToString(); 
            }
            else if (cboxHentbol.SelectedIndex == 8)
            {
                pboxRes.ImageLocation = "SEKIL8.jpg";
                baglanti.Open();
                OleDbCommand Element = new OleDbCommand("SELECT * FROM  Hentbol", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(Element);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                lblHareketAd.Text = cboxHentbol.SelectedIndex.ToString();
                lblOzellik1.Text = dt.Rows[7][1].ToString(); 
            }
            else if (cboxHentbol.SelectedIndex == 9)
            {
                pboxRes.ImageLocation = "SEKIL9.jpg";
                baglanti.Open();
                OleDbCommand Element = new OleDbCommand("SELECT * FROM  Hentbol", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(Element);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close(); lblHareketAd.Text = cboxHentbol.SelectedIndex.ToString();
                lblOzellik1.Text = dt.Rows[8][1].ToString(); 
            }
            else if (cboxHentbol.SelectedIndex == 10)
            {
                pboxRes.ImageLocation = "SEKIL10.jpg";
                baglanti.Open();
                OleDbCommand Element = new OleDbCommand("SELECT * FROM  Hentbol", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(Element);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                lblHareketAd.Text = cboxHentbol.SelectedIndex.ToString();
                lblOzellik1.Text = dt.Rows[9][1].ToString(); 
            }
            else if (cboxHentbol.SelectedIndex == 11)
            {
                pboxRes.ImageLocation = "SEKIL11.jpg";
                baglanti.Open();
                OleDbCommand Element = new OleDbCommand("SELECT * FROM  Hentbol", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(Element);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                lblHareketAd.Text = cboxHentbol.SelectedIndex.ToString();
                lblOzellik1.Text = dt.Rows[10][1].ToString(); 
            }
            else if (cboxHentbol.SelectedIndex == 12)
            {
                pboxRes.ImageLocation = "SEKIL12.jpg";
                baglanti.Open();
                OleDbCommand Element = new OleDbCommand("SELECT * FROM  Hentbol", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(Element);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close(); 
                lblHareketAd.Text = cboxHentbol.SelectedIndex.ToString();
                lblOzellik1.Text = dt.Rows[11][1].ToString(); 
            }
            else if (cboxHentbol.SelectedIndex == 13)
            {
                pboxRes.ImageLocation = "SEKIL13.jpg";
                baglanti.Open();
                OleDbCommand Element = new OleDbCommand("SELECT * FROM  Hentbol", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(Element);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                lblHareketAd.Text = dt.Rows[11][1].ToString();
                lblOzellik1.Text = dt.Rows[12][1].ToString(); 
            }
            else if (cboxHentbol.SelectedIndex == 14)
            {
                pboxRes.ImageLocation = "SEKIL14.jpg";
                baglanti.Open();
                OleDbCommand Element = new OleDbCommand("SELECT * FROM  Hentbol", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(Element);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close(); 
                lblHareketAd.Text = cboxHentbol.SelectedIndex.ToString();
                lblOzellik1.Text = dt.Rows[11][1].ToString(); 

            }
            else if (cboxHentbol.SelectedIndex == 15)
            {
                pboxRes.ImageLocation = "SEKIL15.jpg";
                baglanti.Open();
                OleDbCommand Element = new OleDbCommand("SELECT * FROM  Hentbol", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(Element);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close(); 
                lblHareketAd.Text = cboxHentbol.SelectedIndex.ToString();
                lblOzellik1.Text = dt.Rows[14][1].ToString(); 

            }
            else if (cboxHentbol.SelectedIndex == 16)
            {
                pboxRes.ImageLocation = "SEKIL16.jpg";
                baglanti.Open();
                OleDbCommand Element = new OleDbCommand("SELECT * FROM  Hentbol", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(Element);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close();
                lblHareketAd.Text = cboxHentbol.SelectedIndex.ToString();
                lblOzellik1.Text = dt.Rows[15][1].ToString(); 

            }
            else if (cboxHentbol.SelectedIndex == 17)
            {
                pboxRes.ImageLocation = "SEKIL17.jpg";
                baglanti.Open();
                OleDbCommand Element = new OleDbCommand("SELECT * FROM  Hentbol", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(Element);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close(); lblHareketAd.Text = cboxHentbol.SelectedIndex.ToString();
                lblOzellik1.Text = dt.Rows[16][1].ToString(); 

            }

            else if (cboxHentbol.SelectedIndex == 18)
            {
                pboxRes.ImageLocation = "SEKIL18.jpg";
                baglanti.Open();
                OleDbCommand Element = new OleDbCommand("SELECT * FROM  Hentbol", baglanti);
                OleDbDataAdapter da = new OleDbDataAdapter(Element);
                DataTable dt = new DataTable();
                da.Fill(dt);
                baglanti.Close(); lblHareketAd.Text = cboxHentbol.SelectedIndex.ToString();
                lblOzellik1.Text = dt.Rows[17][1].ToString(); 

            } 
        }


    }
}
