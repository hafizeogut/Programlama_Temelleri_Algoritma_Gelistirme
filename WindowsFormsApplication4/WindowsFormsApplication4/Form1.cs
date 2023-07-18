using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            int yas;
            yas = Convert.ToInt16(cboxYas.Text);
            if (yas < 15)
            {
                MessageBox.Show("Büyüde gel","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                //ilk kısıma mesaj
                //ikinci kısıma mesajın çıktığı kutunun başlığı
                //üçüncü kısım mesaj kutusundaki düğmenin ne olacağı
                //dördüncü kısım mesaj kutusundaki simge
            }
            else if (yas > 14)
            {
                lblDurum.Text = "hoş geldiniz";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboxYas.SelectedIndex = 1;
        }
    }
}
