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
namespace VeritabaniKayitSilmeİşlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MEHMETPC\\SQL;Initial Catalog=kutuphane;Integrated Security=True");

        private void KitaplariGetir()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM  KitaplarTablosu",baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["id"].ToString();
                ekle.SubItems.Add(oku["KitapAdi"].ToString());
                ekle.SubItems.Add(oku["Yazar"].ToString());
                ekle.SubItems.Add(oku["Yayinevi"].ToString());
                ekle.SubItems.Add(oku["Sayfa_Sayısı"].ToString());
                listView1.Items.Add(ekle);
            }   
            baglanti.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            KitaplariGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand a = new SqlCommand("insert into KitaplarTablosu(id,KitapAdi,Yazar,Yayinevi,Sayfa_Sayısı)values('" +KitapNOtextBox.Text.ToString() + "','"+ KitapAditextBox.Text.ToString() + "','"+ YazartextBox.Text.ToString() + "','" + YayınevitextBox.Text.ToString() + "','" + SayfatextBox.Text.ToString() + "')", baglanti);
            a.ExecuteNonQuery();
            baglanti.Close();
            KitaplariGetir();
            KitapNOtextBox.Clear();
            KitapAditextBox.Clear();
            YazartextBox.Clear();
            YayınevitextBox.Clear();
            SayfatextBox.Clear();
        }
        int id = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand b = new SqlCommand("Delete From KitaplarTablosu where id = (" + id + ")", baglanti);
            b.ExecuteNonQuery();
            baglanti.Close();
            KitaplariGetir();
        }
        private void listView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            KitapNOtextBox.Text=listView1.SelectedItems[0].SubItems[0].Text;
            KitapAditextBox.Text = listView1.SelectedItems[0].SubItems[1].Text;
            YazartextBox.Text = listView1.SelectedItems[0].SubItems[2].Text;
            YayınevitextBox.Text = listView1.SelectedItems[0].SubItems[3].Text;
            SayfatextBox.Text = listView1.SelectedItems[0].SubItems[4].Text;
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(" Update kitaplar set id='" + KitapNOtextBox.Text.ToString() + "',KitapAdi='" + KitapAditextBox.Text.ToString() + "',Yazar='" + YazartextBox.Text.ToString() + "',YayınEvi='" + YayınevitextBox.Text.ToString() + "',Sayfa_Sayısı='" + SayfatextBox.Text.ToString() + "' where id=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            KitaplariGetir();
        }
    }
}
