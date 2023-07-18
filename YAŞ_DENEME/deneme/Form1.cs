using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrol_Click(object sender, EventArgs e)
        {
            int Yas;
            Yas = Convert.ToInt16(cboxYas.Text);
            if (Yas<15)
            {
                MessageBox.Show("Büyüde Gel","yaşınız ufak",MessageBoxButtons.OK,MessageBoxIcon.Stop);
                //ilk yazıkutunun içikde çıkan
                //ikinci yazı başlık
                //üçünçü kısım onay düğmesi çeşidi
                //dördüncü kısım uyarı ikonu
            }
            else
            {
                MessageBox.Show("Buyrun");
            }

                
        }
    }
}
