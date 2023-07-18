using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi;//label nesnesindeki sayının tutulacağı değişken tanımlandı
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayi =Convert.ToInt16(lblSayac.Text);//label nesnesindeki karakterler sayıya çevirililerek değişkene yazıldı
            sayi = sayi - 1;//değişkenin içerisindeki değeri 1 arttırdık
            lblSayac.Text = sayi.ToString();//yeni değeri label nesnesine yazdırdık
            pbarDeger.Value = sayi;

            this.BackColor = Color.FromArgb(255 - (sayi * 2),0, 0);

            if (sayi == 0)
            {
                timer1.Enabled = false;
                MessageBox.Show("Süreniz bitti");
            }
        }

        private void tbarHiz_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = tbarHiz.Value;
        }

    }
}
