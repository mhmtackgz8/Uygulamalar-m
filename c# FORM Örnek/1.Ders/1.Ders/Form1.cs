using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.Ders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, hesapla;
            sayi1 = Convert.ToInt32(sayi1textBox.Text);
            sayi2 = Convert.ToInt32(sayi2textBox.Text);
            hesapla = sayi1 + sayi2;
            SonuctextBox.Text = hesapla.ToString();

            if (hesapla >= 6)
            {
                MessageBox.Show("Sayı 6'dan büyüktür.");
            }
            else
            {
                MessageBox.Show("Sayı 6'dan küçüktür.");
            }
        }
        
    }
}
