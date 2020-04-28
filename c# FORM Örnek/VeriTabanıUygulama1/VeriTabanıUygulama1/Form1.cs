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

namespace VeriTabanıUygulama1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan=new SqlConnection("Data Source=MEHMETPC\\SQL;Initial Catalog=FLO;Integrated Security=True");
        private void VerileriGöster()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select * from PersonelTablosu", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["PersonelAd"].ToString();
                ekle.SubItems.Add(oku["PersonelSoyad"].ToString());
                ekle.SubItems.Add(oku["Görevi"].ToString());
                ekle.SubItems.Add(oku["Telefon_Numarası"].ToString());
                ekle.SubItems.Add(oku["Mail_Adresi"].ToString());
                ekle.SubItems.Add(oku["Eğitim_Durumu"].ToString());
                ekle.SubItems.Add(oku["İşeBaşlamaTarihi"].ToString());

            }
            baglan.Close();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            VerileriGöster();
        }
    }
}
