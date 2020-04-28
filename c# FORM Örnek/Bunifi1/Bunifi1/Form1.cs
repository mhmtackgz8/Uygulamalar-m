using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bunifi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel3_MouseHover(object sender, EventArgs e)
        {
            bunifuCustomLabel3.BackColor = Color.White;
            


        }

        private void bunifuCustomLabel1_MouseHover(object sender, EventArgs e)
        {
            bunifuCustomLabel1.BackColor = Color.White;
        }

        private void bunifuCustomLabel2_MouseHover(object sender, EventArgs e)
        {
            bunifuCustomLabel2.BackColor = Color.White;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (kadıMetroTextbox2.Text == "mehmet" || ŞifreMetroTextbox1.Text == "123") 
            {

                MessageBox.Show("Giriş Başarılı Hoşgeldiniz");
            }


            else
            {
                MessageBox.Show("Geçersiz Giriş");

            }
        }

        private void kadıMetroTextbox2_Click(object sender, EventArgs e)
        {
            kadıMetroTextbox2.Text = "";

        }

        private void ŞifreMetroTextbox1_Click(object sender, EventArgs e)
        {
            ŞifreMetroTextbox1.Text = "";
        }
    }
}
