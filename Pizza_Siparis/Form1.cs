using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Siparis
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

        private void button1_Click(object sender, EventArgs e)
        {
            //comboBox1.Items.Add(); Combo box elemanı aynı şekil ekleyebiliriz
            listBox1.Items.Add(textBox1.Text); // Listbox items add ekleme yaparız
            listBox2.Items.Add(textBox2.Text);  // ( yazdıgımız nerdeki yazı)
            listBox3.Items.Add(textBox3.Text);
            listBox4.Items.Add(comboBox1.Text); // List box yan yana sipariş alıp sipariş tamamsa yeni kişi alt alta sırayla  yazar
            listBox5.Items.Add(comboBox2.Text); // Birden fazla kişi yazmak için
            listBox6.Items.Add(label13.Text + "" + label14.Text + "" + label15.Text + "" + label16.Text + "" + label17.Text + "" + label18.Text); 
          // Seçtiklerimi labela ekledim label isimleri null atadım eğer seçmişsem labela gitcek labelda başta null oldugu için hangisinde varsa onu yazar       
        }
        // Grupboxda içindeki tüm işlemleri birlikte yürütür taşır

        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //  listBox6.Items.Add(checkBox1.Text); // Böyle çalışır ama alt alta yazar
            // Bizim sipariş sistemimiz yan yana yazmak gerektiriyor
            label13.Text = checkBox1.Text;
        
        }

        

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label14.Text = checkBox2.Text;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            label17.Text = checkBox5.Text;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            label18.Text = checkBox6.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            label15.Text = checkBox3.Text;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            label16.Text = checkBox4.Text;
        }













        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            comboBox1.Text = ""; // bUNLARDA cLEAR olmadıgı için null yapıyoruz
            comboBox2.Text = "";  // Combobox Checkbox karıştırma biri alttan seçme diğeri tik
            label13.Text = "";
            label14.Text = "";
            label15.Text = ""; // En son değer burdan yazdıgı için burayı null yapmam yeter
            label16.Text = ""; // Görüntüde hala tikli olur
            label17.Text = "";
            label18.Text = "";
        }
    }
}
