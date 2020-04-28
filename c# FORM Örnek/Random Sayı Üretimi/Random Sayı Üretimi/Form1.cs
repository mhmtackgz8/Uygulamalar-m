using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random_Sayı_Üretimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.Hide();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Show();
            Random newnumber = new Random();
            int Ekranayaz = newnumber.Next(92, 98);
            label1.Text = Ekranayaz.ToString();
            int sayi;
            //sayi = Convert.ToInt32(Console.ReadKey());
            if (textBox1.Text == label1.Text)
            {
                MessageBox.Show("Tebrikler Sayıyı Buldunuz");
            }
            else
                MessageBox.Show("Sayıyı Bulamadınız");
            textBox1.Text = "";



        }
    }




  
