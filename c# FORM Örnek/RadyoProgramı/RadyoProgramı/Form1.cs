using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadyoProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      

        private void AlaturkaButton_CheckedChanged(object sender, EventArgs e)
        {


            axWindowsMediaPlayer2.URL = " http://stream.radyoalaturka.com.tr:9100/;";
            label1.Show();
            label1.Text = "Radyo Alaturka Dinliyorsunuz...";
            label3.Text = DateTime.Now.ToString();
            label3.Show();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            axWindowsMediaPlayer2.URL = "http://kralpopwmp.radyotvonline.com:80/;";
            label1.Text = "KRAL POP Dinliyorsunuz...";
            label3.Text = DateTime.Now.ToString();
            label3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Hide();
            button2.Hide();
            button1.Hide();
            label3.Hide();
            label2.Hide();
        }

        private void BESTButton_CheckedChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "http://46.20.7.125/listen.pls";
            label1.Show();
            label1.Text = "BEST FM Dinliyorsunuz...";
            label3.Text = DateTime.Now.ToString();
            label3.Show();

        }

        private void ArabeskButton_CheckedChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "http://yayin.damarfm.com:8080/mp3";
            label1.Text = "DAMAR FM Dinliyorsunuz...";
            label1.Show();
            label3.Text = DateTime.Now.ToString();
            label3.Show();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "http://45.32.154.169:9300/;";
            label1.Text = "İSTANBUL FM Dinliyorsunuz...";
            label1.Show();
            label3.Text = DateTime.Now.ToString();
            label3.Show();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "http://31.192.215.204:9986/; ";
            label1.Text = "Radyo Mavi Boncuk Dinliyorsunuz...";
            label1.Show();
            label3.Show();
            label3.Text = DateTime.Now.ToString();
            
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = " http://46.20.3.231/;";
            label1.Text = "Radyo VİVA  Dinliyorsunuz...";
            label1.Show();
            label3.Show();
            label3.Text = DateTime.Now.ToString();
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "http://94.102.4.16:7602/;";
            label1.Text = "Radyo Enerji  Dinliyorsunuz...";
            label1.Show();
            label3.Show();
            label3.Text = DateTime.Now.ToString();
        }

       

     

        private void radioButton9_CheckedChanged_1(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "https://17753.live.streamtheworld.com/METRO_FM.mp3";
            label1.Text = "Metro FM  Dinliyorsunuz...";
            label1.Show();
            label3.Show();
            label3.Text = DateTime.Now.ToString();

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.URL = "https://17703.live.streamtheworld.com/JOY_FM.mp3";
            label1.Text = "JOY FM  Dinliyorsunuz...";
            label1.Show();
            label3.Show();
            label3.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.pause();
            button2.Show();
            button1.Hide();
           
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.play();
            button1.Visible = true;
            button2.Visible = false;
        }

       

        private void AlaturkaButton_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Hide();
            button1.Show();
        }

        private void radioButton2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Hide();
            button1.Show();
        }

        private void BESTButton_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Hide();
            button1.Show();
        }

        private void ArabeskButton_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Hide();
            button1.Show();
        }

        private void İSTANBULButton_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Hide();
            button1.Show();
        }

        private void radioButton3_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Hide();
            button1.Show();
            
        }

        private void radioButton4_MouseDown(object sender, MouseEventArgs e)
        {
            button2.Hide();
            button1.Show();
        }

        private void radioButton14_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Hide();
            button1.Show();
        }

        private void radioButton9_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Hide();
            button1.Show();
        }

        private void radioButton8_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Hide();
            button1.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString();
        }

      
    }
}


       




      

