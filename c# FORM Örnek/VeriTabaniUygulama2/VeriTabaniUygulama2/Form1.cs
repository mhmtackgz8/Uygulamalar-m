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

namespace VeriTabaniUygulama2
{
    public partial class Form1 : Form
    {   
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=MEHMETPC\\SQL;Initial Catalog=ogrenciler;Integrated Security=True");

        private void BaglantilariGetir()
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM Table_1",baglan);
            SqlDataReader oku = komut.ExecuteReader();

            while(oku.Read ())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["adisoyadi"].ToString();
                ekle.SubItems.Add(oku["şehir"].ToString());
                ekle.SubItems.Add(oku["okul"].ToString());
                listView1.Items.Add(ekle);

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BaglantilariGetir();
        }
    }
}
