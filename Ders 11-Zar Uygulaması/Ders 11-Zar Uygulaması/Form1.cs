using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_11_Zar_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd=new Random();
         int toplamben = 0;  // Global değişken yetiyor 1 tane  o zaten sürekli sıfırlayıp bitiriyor
        int toplampc = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = true;
            int a=rnd.Next(1,7);// zar 1 ve  6 arası olcak
            int b=rnd.Next(1,7);
            toplamben = toplamben + a + b;

            label3.Text = a.ToString();
            label4.Text=b.ToString();
            label15.Text=toplamben.ToString();
            if(a==1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar1.png";
            }
            if (a == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar2.png";
            }
            if (a == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar3.png";
            }
            if (a == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar4.png";
            }
            if (a ==5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar5.png";
            }
            if (a == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar6.jpg";
            }



            if (b == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar1.png";
            }
            if (b == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar2.png";
            }
            if (b== 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar3.png";
            }
            if (b == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar4.png";
            }
            if (b == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar5.png";
            }
            if (b == 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar6.jpg";
            }





        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;    
            int c = rnd.Next(1, 7);// zar 1 ve  6 arası olcak
            int d = rnd.Next(1, 7);
            toplampc= toplampc + c +d;

            label8.Text = c.ToString();
            label10.Text = d.ToString();
            label16.Text = toplampc.ToString();
           
            if (c == 1)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar1.png";
            }
            if (c == 2)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar2.png";
            }
            if (c == 3)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar3.png";
            }
            if (c == 4)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar4.png";
            }
            if (c == 5)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar5.png";
            }
            if (c == 6)
            {
                pictureBox1.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar6.jpg";
            }



            if (d == 1)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar1.png";
            }
            if (d == 2)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar2.png";
            }
            if (d == 3)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar3.png";
            }
            if (d == 4)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar4.png";
            }
            if (d == 5)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar5.png";
            }
            if (d== 6)
            {
                pictureBox2.ImageLocation = "C:\\Users\\Ali\\Desktop\\Resim Desktop\\zar6.jpg";
            }

            // En son kazananı belirlemeyi  button2 koycaz çünkü en son bunda bitmesi gerek
            if(toplamben>100 && toplamben > toplampc)
            {
                label5.Text = "Tebrikler kazandnız :):):)";
            }
            if(toplampc>100 && toplampc>toplamben) // En son 2.sinde hak bitiriyor
            {
                label5.Text = "Üzgünüz kaybettiniz :(:(:(";

            }


        }
    }
}
