using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_9_Kronometre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dakika = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled =true; // Timer false seçersen tıkladıgında çalışır buttona
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Zamana göre artıyor
            // 100 ms saniye seçrsen 10 salise 1 saniye eder onu 1000 yaparsan 1 artışda 1 saniye olur 5000 olursa 5 saniye 1 saniye olur
            int sayi = Convert.ToInt32(label1.Text);
            sayi++;
            label1.Text = sayi.ToString();

            if (sayi == 60)
            {
                sayi = 0;
                label1.Text = sayi.ToString();
                dakika++;
                label2.Text = dakika.ToString();


            }

        }
    }
}
