using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev
{
    public partial class Form1 : Form
    {
        Matematik math;
        string eskikelime;
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Mutlak Değer
            math = new Matematik();  // Math sınıfından ekleme
            int sayi; 
            sayi = Convert.ToInt32(textBox1.Text); // Stringi textboxdaki sayıya çevirme
            eskikelime = sayi.ToString(); // Alınanı textboxdaki Stringe döndürme
            int deger = math.Mutlak(sayi);// Math sınıfından Mutlak fonksiyonu çağırıp değere atama
            textBox1.Text = deger.ToString(); // Textbox String olarak yollama


        }



        private void button2_Click(object sender, EventArgs e)
        {
           // Karekök    
            math = new Matematik();  // Üstteki aynı işlemi
            double sayi;
            sayi = Convert.ToInt32(textBox1.Text); 
            eskikelime = sayi.ToString();
            double karekok = math.Karekok(sayi);
            textBox1.Text = karekok.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Max bulma Dizi alıyoruz , olursa her dizi elemanına ekleyip sonra kıyaslama convert işlemi var
            math= new Matematik();
            eskikelime= textBox1.Text;
            textBox1.Text = math.MaxBul(textBox1.Text) + "";


        }

        private void button4_Click(object sender, EventArgs e)
        {
            math= new Matematik();
            // Sinüs Hesaplama
            double sayi = Convert.ToDouble(textBox1.Text);
            eskikelime = sayi.ToString();
            double sinus_degeri =math.SinusHesapla(sayi);
            textBox1.Text = sinus_degeri.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
          // Cosinüs Hesaplama
            math = new Matematik();
            int sayi1;
            sayi1 = Convert.ToInt32(textBox1.Text);
            eskikelime = sayi1.ToString();
            double cos = math.CosinusHesaplaDerece(sayi1);
            textBox1.Text = cos.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
           // Önceki veriyi kaydetme
            textBox1.Text = eskikelime;

        }




        private void button7_Click(object sender, EventArgs e)
        {
            // Yeni form boyutu 
            Form fm = new Form();
            fm.Size = new Size(500, 500);
        
            fm.Paint += new PaintEventHandler(Form1_Paint);
            fm.Show();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          // Renk Çizim yeri
            Graphics g = e.Graphics;
            Pen pen1= new Pen(Color.OrangeRed, 7);
            Pen pen2 = new Pen(Color.Yellow, 7);
            Pen pen3 = new Pen(Color.Bisque, 7);
            Form fmm = sender as Form;

           
            // Y ekseninde gözükmesi
            float originY = fmm.ClientSize.Height/2; 
        

           
            float Baslama = float.Parse(textBox2.Text);
            float Bitis = float.Parse(textBox3.Text);

            float BasDeger = float.Parse(textBox2.Text);
            if (radioButton1.Checked)
            {
                // Sinüs Grafik Çizim Şekli
                List<PointF> SinCiz = new List<PointF>();
                float genlik= (originY - 20); 
                float frekans = (float)(2 * Math.PI / (Bitis - Baslama)); 

                for (float x = Baslama; x <= Bitis; x += 1)
                {
                    float sinY = genlik * (float)Math.Sin(frekans * (x - Baslama)) + originY;
                    SinCiz.Add(new PointF(Width / 2 + (x - Baslama) + BasDeger, sinY));
                }

                
                if (SinCiz.Count > 1)
                {
                    g.DrawLines(pen2, SinCiz.ToArray());
                }
            }
            if (radioButton2.Checked)
            {
                // Cosinüs Grafik Çizim Şekli
                List<PointF> cosPoints = new List<PointF>();
                float genlikc = (originY - 50); // Genlik
                float frekansc = (float)(2 * Math.PI / (Bitis - Baslama)); // Frekans

                for (float x = Baslama; x <= Bitis; x +=1)
                {
                    float cosY = genlikc * (float)Math.Cos(frekansc * (x - Baslama)) + originY;
                    cosPoints.Add(new PointF(Width / 2 + (x - Baslama) + BasDeger + 82, cosY));
                }

                
                if (cosPoints.Count > 0)
                {
                    g.DrawLines(pen3, cosPoints.ToArray());
                }
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    public class Matematik
    {
        public Matematik() { }

        public int Mutlak(int sayi)
        {
            if (sayi < 0)
            {
                return -sayi;
            }
            return sayi;
        }



        public double Karekok(double sayi)
        {
            double x = 10;
            for (int i = 1; i <= 10; i++)
            {
                x = ((sayi / x) + x) / 2;
            }
            return x;

        }


        public  int MaxBul(string sayi)
        {
            string[] k = sayi.Split(',');

            int max = Convert.ToInt32(k[0]);
            for (int i = 0; i < k.Length; i++)
            {
                if (Convert.ToInt32(k[i]) > max)
                    max = Convert.ToInt32(k[i]);
            }
            return max;
        }


        public double faktoriyel(int x)
        {
            if (x == 0)
            {
                return 1;
            }
            double result = 1;
            for (int i = 1; i <= x; i++)
            {
                result = result * i;
            }
            return result;
        }
        public double usAlma(double x, int y)
        {
            double carp = 1;
            for (int i = 1; i <= y; i++)
            {
                carp = carp * x;
            }
            return carp;

        }
       public double SinusHesaplaRadyan(double radyan)
        {
            double sinus_degeri = radyan; 
            double isaret = -1; 
            double radyan_kare = radyan * radyan;
            double faktoriyel = 1; // Faktöriyel değeri
            for (int i = 3; i <= 19; i += 2) 
            {
                faktoriyel *= (i - 1) * i; 
                sinus_degeri += isaret * usAlma(radyan, i) / faktoriyel; 
                isaret *= -1; 
            }
            return sinus_degeri; 
        }

        public double DereceToRadyan(double derece)
        {

            return derece * (Pi() / 180); // Dereceyi radyan cinsine çevir
        }
        public double SinusHesapla(double derece)
        {
            double radyan = DereceToRadyan(derece); 
            return SinusHesaplaRadyan(radyan); 
        }
        public double Pi()
        {
            double pi = 3.1415926535897932384626433832795028841971693993751058209749445923078164062862089986280348253421170679;
            return pi;
        }



        public double CosinusHesaplaDerece(double derece)
        {

            double radyan = derece * (Pi() / 180); // Dereceyi radyan cinsine çevir
            return CosinusHesaplaRadyan(radyan); // Radyan cinsinden hesaplanan cosinüs değerini döndür
        }

        public double CosinusHesaplaRadyan(double x, int nTerimler = 12)
        {
            double cosinus = 0;
            for (int i = 0; i < nTerimler; i++)
            {
                double katsayi = (i % 2 == 0) ? 1 : -1;
                int us = 2 * i;
                cosinus += (katsayi * usAlma(x, us)) / faktoriyel(us);
            }
            return cosinus;
        }




    }
}




