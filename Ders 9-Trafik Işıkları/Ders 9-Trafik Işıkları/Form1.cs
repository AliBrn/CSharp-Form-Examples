using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_9_Trafik_Işıkları
{
    public partial class Form1 : Form
    {
        int time = 0; // Global değişkenimiz
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = Convert.ToInt32(label2.Text); // zaman 0  zamanı sayıya çevirip arttırdık sonra labelı arttırıyoruz
            time++;    // label değişkende zaman var  zaman 30 olunca buton 2 sarı olcak
            label2.Text=time.ToString();
            if (time == 30)
            {
                button2.BackColor = Color.Yellow;


            }
            if (time == 40) // 40 oluncada  labelda sayaç devam etcek  buton 1  buton 2 gri  buton 3 yeşil
            {
                button1.BackColor = Color.Gray;
                button2.BackColor = Color.Gray;
                button3.BackColor = Color.Green;

            }
            if (time == 60) // 60 olunca tekrar eski haline döncek buton 2 zaten gray
            {
                time = 0;
                label2.Text = time.ToString();
                button1.BackColor = Color.Red;
                button3.BackColor = Color.Gray;

            }
          
            
                 
                
            

            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true; // Bunu butonla yaparken form yüklerken sayıyor true yapcan başlangıç 0 zaten
            button1.BackColor = Color.Red;         // Form ilk başladıgında çalışssın  zamanlama ilk buton kırmızı
        }
    }
}
