using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_4__SüperLig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rnd = new Random(); // Rastgele Sayı değer sınıfı atadık
        int fbpuan = 0;
        int gspuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;  // Global Tanımladık
        // Eksik Kısımlar Var Eklersin
        // 1-Hafta -----------------------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false; // Button1 e tıkladıgımdan sonra artık tıklanmaz oluyor
            int a = Convert.ToInt32(label7.Text);
            int b = Convert.ToInt32(label10.Text);
            int c = Convert.ToInt32(label9.Text);
            int d = Convert.ToInt32(label8.Text);
            //  a  fb   b gs   c bjk  d ts
            a = rnd.Next(0, 5);
            b = rnd.Next(0, 5);
            c = rnd.Next(0, 5);
            d = rnd.Next(0, 5);

            if (a > b)
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();

            }
            else if (a < b)
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            else
            {
                fbpuan = fbpuan + 1;
                gspuan = gspuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelfbpuan.Text = fbpuan.ToString();
            }

            if (c > d)
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            else if (c < d)
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            else
            {
                bjkpuan = bjkpuan + 1;
                tspuan = tspuan + 1;
                labeltspuan.Text = tspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            label7.Text = a.ToString(); // Bunu En son yazıyorum ilk sayıyla işlem yapmak için sonra uğraşırsı başa koyarsan
            label10.Text = b.ToString();
            label9.Text = c.ToString();
            label8.Text = d.ToString();


        }






        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        // 2 Hafta ---------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false; // Button2 e tıkladıgımdan sonra artık tıklanmaz oluyor
            int a = Convert.ToInt32(label13.Text); // Fb
            int b = Convert.ToInt32(label16.Text);  // GS
            int c = Convert.ToInt32(label14.Text);  // Bjk
            int d = Convert.ToInt32(label15.Text);   // Ts

            a = rnd.Next(0, 5); //  0 - 4  arası rastgele değer üretir
            b = rnd.Next(0, 5);
            c = rnd.Next(0, 5);
            d = rnd.Next(0, 5);

            if (b > d)
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();

            }
            else if (b < d)
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            else
            {
                tspuan = tspuan + 1;
                gspuan = gspuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }



            if (a > c)
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();
            }
            else if (a < c)
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            else
            {
                fbpuan = fbpuan + 1;
                bjkpuan = bjkpuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            label13.Text = a.ToString(); // Bunu En son yazıyorum ilk sayıyla işlem yapmak için sonra uğraşırsı başa koyarsan
            label16.Text = b.ToString();
            label14.Text = c.ToString(); // Fb gs bjk ve ts sabit harfle atadıgım için harflerle işlem yaptım
            label15.Text = d.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false; // Button3 e tıkladıgımdan sonra artık tıklanmaz oluyor
            int a = Convert.ToInt32(label25.Text); // Fb
            int b = Convert.ToInt32(label26.Text);  // GS
            int c = Convert.ToInt32(label27.Text);  // Bjk
            int d = Convert.ToInt32(label23.Text);   // Ts

            a = rnd.Next(0, 5); //  0 - 4  arası rastgele değer üretir
            b = rnd.Next(0, 5);
            c = rnd.Next(0, 5);
            d = rnd.Next(0, 5);

            if (a > d)
            {
                fbpuan = fbpuan + 3;
                labelfbpuan.Text = fbpuan.ToString();

            }
            else if (a < d)
            {
                tspuan = tspuan + 3;
                labeltspuan.Text = tspuan.ToString();
            }
            else
            {
                tspuan = tspuan + 1;
                fbpuan = fbpuan + 1;
                labelfbpuan.Text = fbpuan.ToString();
                labeltspuan.Text = tspuan.ToString();
            }



            if (b > c)
            {
                gspuan = gspuan + 3;
                labelgspuan.Text = gspuan.ToString();
            }
            else if (a < c)
            {
                bjkpuan = bjkpuan + 3;
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            else
            {
                gspuan = gspuan + 1;
                bjkpuan = bjkpuan + 1;
                labelgspuan.Text = gspuan.ToString();
                labelbjkpuan.Text = bjkpuan.ToString();
            }
            label25.Text = a.ToString(); // Bunu En son yazıyorum ilk sayıyla işlem yapmak için sonra uğraşırsı başa koyarsan
            label26.Text = b.ToString(); // üstte sayıyı random olarak int alıyoruz en son randomu  oraya yazmak için int ama
            label27.Text = c.ToString(); // Biz sayısal işlemi yapıp sonra stringe geri döndürüyoruz
            label23.Text = d.ToString(); // Fb gs bjk ve ts sabit harfle atadıgım için harflerle işlem yaptım

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(gspuan>fbpuan &&  gspuan>bjkpuan && gspuan > tspuan)
            {
                label36.Text = "Şampiyon Galatsaray";
                pictureBox1.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\gs.jpeg";
                axWindowsMediaPlayer1.URL = "C:\\Users\\Ali\\Desktop\\Müzik Desktop\\gs.mp3";
            }
            if (fbpuan > gspuan && fbpuan > bjkpuan && fbpuan > tspuan)
            {
                label36.Text = "Şampiyon Fenerbahçe";
                pictureBox1.ImageLocation= "C:\\Users\\Ali\\Desktop\\Resim Desktop\\fb.jpeg";
                axWindowsMediaPlayer1.URL = "C:\\Users\\Ali\\Desktop\\Müzik Desktop\\fb.mp3";
            }
            if (bjkpuan > fbpuan && bjkpuan > gspuan && bjkpuan > tspuan)
            {
                label36.Text = "Şampiyon Beşiktaş";
                pictureBox1.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\bjk.jpeg";
                axWindowsMediaPlayer1.URL = "C:\\Users\\Ali\\Desktop\\Müzik Desktop\\bjk.mp3";
            }
            if (tspuan > fbpuan && tspuan > bjkpuan && tspuan > gspuan)
            {
                label36.Text = "Şampiyon Trabzonspor";
                pictureBox1.ImageLocation= "C:\\Users\\Ali\\Desktop\\Resim Desktop\\ts.png";
                axWindowsMediaPlayer1.URL = "C:\\Users\\Ali\\Desktop\\Müzik Desktop\\ts.mp3";
            }
        }
    }
}
