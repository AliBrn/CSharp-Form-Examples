using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_11_Timer_Takım_Renklendirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int saniye = 0;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL= "C:\\Users\\Ali\\Desktop\\Müzik Desktop\\fb.mp3";
            
                

        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye = Convert.ToInt32(label1.Text);
            saniye++;
            label1.Text=saniye.ToString();
           
            if (checkBox1.Checked == true)
            {
                if (saniye % 10 == 0)
                { // 10 11 12 13 14 15  
                    button9.BackColor = Color.Yellow;
                    button2.BackColor = Color.Blue;
                    button3.BackColor = Color.Yellow;
                    button4.BackColor = Color.Blue;
                    button5.BackColor = Color.Yellow;
                    button6.BackColor = Color.Blue;
                    button7.BackColor = Color.Yellow;
                    button8.BackColor = Color.Blue;
                }
                  if (saniye%10==5) {
                    button9.BackColor = Color.Blue;
                    button2.BackColor = Color.Yellow;
                    button3.BackColor = Color.Blue;
                    button4.BackColor = Color.Yellow;
                    button5.BackColor = Color.Blue;
                    button6.BackColor = Color.Yellow;
                    button7.BackColor = Color.Blue;
                    button8.BackColor = Color.Yellow;
                }
            }
            if (checkBox2.Checked == true)
            {
                if (saniye % 10 == 0)
                { // 10 11 12 13 14 15  
                    button9.BackColor = Color.Yellow;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Yellow;
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Yellow;
                    button6.BackColor = Color.Red;
                    button7.BackColor = Color.Yellow;
                    button8.BackColor = Color.Red;
                }
                if (saniye % 10 == 5)
                {
                    button9.BackColor = Color.Red;
                    button2.BackColor = Color.Yellow;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Yellow;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Yellow;
                    button7.BackColor = Color.Red;
                    button8.BackColor = Color.Yellow;
                }
            }


            if (checkBox3.Checked == true)
            {
                if (saniye % 10 == 0)
                { // 10 11 12 13 14 15  
                    button9.BackColor = Color.Black;
                    button2.BackColor = Color.White;
                    button3.BackColor = Color.Black;
                    button4.BackColor = Color.White;
                    button5.BackColor = Color.Black;
                    button6.BackColor = Color.White;
                    button7.BackColor = Color.Black;
                    button8.BackColor = Color.White;
                }
                if (saniye % 10 == 5)
                {
                    button9.BackColor = Color.White;
                    button2.BackColor = Color.Black;
                    button3.BackColor = Color.White;
                    button4.BackColor = Color.Black;
                    button5.BackColor = Color.White;
                    button6.BackColor = Color.Black;
                    button7.BackColor = Color.White;
                    button8.BackColor = Color.Black;
                }
            }
            if (checkBox4.Checked == true)
            {
                if (saniye % 10 == 0)
                { // 10 11 12 13 14 15  
                    button9.BackColor = Color.Red;
                    button2.BackColor = Color.Blue;
                    button3.BackColor = Color.Red;
                    button4.BackColor = Color.Blue;
                    button5.BackColor = Color.Red;
                    button6.BackColor = Color.Blue;
                    button7.BackColor = Color.Red;
                    button8.BackColor = Color.Blue;
                }
                if (saniye % 10 == 5)
                {
                    button9.BackColor = Color.Blue;
                    button2.BackColor = Color.Red;
                    button3.BackColor = Color.Blue;
                    button4.BackColor = Color.Red;
                    button5.BackColor = Color.Blue;
                    button6.BackColor = Color.Red;
                    button7.BackColor = Color.Blue;
                    button8.BackColor = Color.Red;
                }
            }





        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\Ali\\Desktop\\Müzik Desktop\\gs.mp3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;// Zamanlayıcıya göre renk değişimi oluyor o yüzden olması önemli
            axWindowsMediaPlayer1.URL = "C:\\Users\\Ali\\Desktop\\Müzik Desktop\\bjk.mp3";

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            axWindowsMediaPlayer1.URL = "C:\\Users\\Ali\\Desktop\\Müzik Desktop\\ts.mp3";

        }
    }
}
