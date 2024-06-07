using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Not_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Hesaplaya tıkladıgın an listboxitem add ile   listbox isim not1 not2 yazar sayılar string geldi diye convert yapıp
            //  onların ortalamayı hesaplar listbox4 e yazar listbox geçti kldı efekti için en son eklenen if else arasına yazdırma
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(textBox3.Text);
            int sayi=Convert.ToInt32(textBox2.Text);
            int sayi2=Convert.ToInt32(textBox3.Text);
            int ortalama = (sayi + sayi2) / 2;
            listBox4.Items.Add(ortalama);
            if (ortalama > 50)
            {
                listBox5.Items.Add("Geçtiniz");
            }else
            {
                listBox5.Items.Add("Kaldınız");
            }
            
        }

    }
}
