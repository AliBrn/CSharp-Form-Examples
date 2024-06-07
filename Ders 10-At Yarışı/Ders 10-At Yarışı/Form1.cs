using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_10_At_Yarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatuzaklık; // Sola uzaklıkları başlangıç olcak
        int ikinciatuzaklık;
        int ucuncuatuzaklık;
        Random rastgele=new Random();
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Süre için
            int derece = Convert.ToInt32(label7.Text);
            derece++;
            label7.Text = derece.ToString();  // Normal kronometre gibi bunu timer 1 de hesapladık bitincede duruyor

            // Timer çalıştıgında olcaklar
            int birinciatgenislik = pictureBox1.Width;
            int ikinciatgenislik = pictureBox2.Width;  
            int ucuncuatgenislik = pictureBox3.Width;  // Genişlikleri ve sola uzaklıklarını biliyor
            
            // Atın soldan uzaklıgın artarak ilerlemesi
          
            pictureBox1.Left += rastgele.Next(5, 15);
            pictureBox2.Left += rastgele.Next(5, 15);
            pictureBox3.Left += rastgele.Next(12, 15);
            int bitisuzakligi = label5.Left; // Labelin sol tarafı bitişin uzaklıgı


            // Canlı Yarış sahnesi Başlangıç için width gerek yok o bitişte lazım canlıda soldan uzaklık fazlaysa yeter
            if(pictureBox1.Left>pictureBox2.Left+5 && pictureBox1.Left > pictureBox3.Left + 5)
            {
                label6.Text = "Birinci at yarışta önde";
            }
            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5)
            {
                label6.Text = "İkinci attan ani bir atak";
            }
            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = " Üçüncü at tam umudunu kaybetmişken yarışa tutunuyor";
            }



            // Yarışın BitİŞİ

            if (birinciatgenislik + pictureBox1.Left >= bitisuzakligi) // Eşit büyük yaptık at fazla ileri gidebilir ya da denk gelsede olur
            {
                timer1.Enabled = false; // At dursun
                label6.Text = "Bir numaralı at yarışı kazandı";

            }
            if (ikinciatgenislik + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false; // At dursun
                label6.Text = "İki numaralı at yarışı kazandı";
            }

            if (ucuncuatgenislik + pictureBox3.Left >= bitisuzakligi) 
            {
                timer1.Enabled = false; // At dursun
                label6.Text = "Üç numaralı at yarışı kazandı";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatuzaklık = pictureBox1.Left; // Sola uzaklık tanımladık üstte sadece bu soldan uzaklaştıkça bitişe varcak arttırcaz
            ikinciatuzaklık = pictureBox2.Left;   // sağ kullansak - yi kullanırdık
            ucuncuatuzaklık = pictureBox3.Left;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;// Buttona bastıgım anda kullanacağım
            

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
