using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_11_Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soru = 0; // Soru sayısı
        int dogru = 0; // Dogru ve yanlıs sayıları
        int yanlis = 0;
        int sure = 20; // Kalan sure
        private void button5_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; // Zamanlama çalışır
            button1.Enabled = true; // Butonlar aktif olur buton 5 her tıkladıgımda
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            sure = 20; // baslangıc surem 20 saniye
            label6.Text = sure.ToString(); // Bunu yapmasaydım  20 den değil 1 saniye eksik sayar
           
            soru++; // soru sayısını hep arttırırm button 5 tıkladıgımda
            button5.Text = "İleri"; // buton başlattan ileri ismine sahip olur
            label10.Text = soru.ToString(); // Dönüştürürüm SORU sayısı
            if (soru == 1) { // SoRU 1  İFLE KONTROL EDERİZ
                richTextBox1.Text = "Türkiye kaç ilden oluşmaktadır";
                button1.Text = "80";
                button2.Text = "81";
                button3.Text = "82";
                button4.Text = "84";
                label7.Text = "81"; // Doğru cevap 81 label7 de tutuyoz hep sabit
            }
            if (soru == 2)
            {
                richTextBox1.Text = "Türkiyenin en büyük yüz ölçümüne sahip ili";
                button1.Text = "İstanbul";
                button2.Text = "İzmir";
                button3.Text = "Diyarbakır";
                button4.Text = "Konya";
                label7.Text = "Konya"; // Doğru cevaba konya atadık
                
            }
            if (soru == 3)
            {
                richTextBox1.Text = "Türkiye kaç bölgeden oluşur";
                button1.Text = "5";
                button2.Text = "6";
                button3.Text = "7";
                button4.Text = "8";
                label7.Text = "7"; // Doğru cevaba 7 atadık
            }
            if (soru == 4)
            {
                MessageBox.Show("Tebrikler  dogru sayınız: " + dogru + "Yanlıs sayınız: " + yanlis);  // En son mesajla doğru yanlış söyleriz
                button5.Enabled = false; // butonu pasif yaparız
            }
                
         




        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;

            label8.Text = button1.Text; // button 1 e tıkladıysan onu labela kaydedip doğru label ile yanlış label kıyası yapcan
            if(label8.Text == label7.Text) // Eğer doğruysa doğru sayısını arttırır dogru yazdırcaz
            {
                dogru++;
                label5.Text = dogru.ToString();

            }
            else
            {  // Yanlıssa yanlıs sayısın arttırrı yanlıs yazar
                yanlis++;
                label4.Text=yanlis.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;
            label8.Text=button2.Text;
            if (label8.Text == label7.Text)
            {
                dogru++;
                label5.Text=dogru.ToString();
            }
            else
            {
                yanlis++;
                label4.Text=yanlis.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;
            label8.Text = button3.Text;
            if (label8.Text == label7.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label4.Text = yanlis.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            timer1.Enabled = false;
            label8.Text = button4.Text;
            if (label8.Text == label7.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label4.Text = yanlis.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sure--; //  Timer en son azaltma yaparız
            label6.Text=sure.ToString();   // Bunuda label6 yazarız

        }
    }
}
