using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace VeritabanıİşlemleriVeriKaydetme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MEHMETPC\\SQL;Initial Catalog=Kayıtlar;Integrated Security=True");
        private void KayitlariGetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM GelenlerTablosu",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Adsoyad"].ToString();
                ekle.SubItems.Add(oku["Firma"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KayitlariGetir();
        }
        private void Kaydet()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert into GelenlerTablosu  (Adsoyad,Firma) Values ('" + AdıSoyadıtextBox.Text.ToString() + " ','" + textBox1.Text.ToString() + " ')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            KayitlariGetir();
        }
        private void KaydetButton_Click(object sender, EventArgs e)
        {
            Kaydet();
        }
    }
}
