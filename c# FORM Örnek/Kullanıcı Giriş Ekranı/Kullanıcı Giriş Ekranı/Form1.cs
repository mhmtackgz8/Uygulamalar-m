using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kullanıcı_Giriş_Ekranı
{
    public partial class KullanıcıGirişForm : Form
    {
        public KullanıcıGirişForm()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            if(KullanıcıAdıTextBox.Text=="admin" && ŞifreTextBox.Text=="1234")
            {
                MessageBox.Show("Hoşgeldiniz");
                Form2 ekleform = new Form2();
                ekleform.Show();
                this.Hide();


            }
            else
                MessageBox.Show("Giriş Başarısız Lütfen Yeniden Deneyiniz");
            KullanıcıAdıTextBox.Text = " ";
            ŞifreTextBox.Text = " ";
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void KullanıcıGirişForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult x = MessageBox.Show("Programdan Çıkmak İstediğinizden Emin Misiniz?", "Çıkış Mesajı!", MessageBoxButtons.YesNo);
            if (x == DialogResult.Yes)
            {
                //Evet tıklandığında Yapılacak İşlemler
                Environment.Exit(0); // Evet tıklandığında uygulama kapanacak

            }
            else if (x == DialogResult.No)
            {
                // Hayır tıklandığında yapılacak işlemler
                e.Cancel = true; // Hayır tıklandığında iptal edilecek
            }
        }
    }
}
