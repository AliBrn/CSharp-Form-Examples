using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders6_Tyt_Ayt_Puan_Hesaplama
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double ortalama = Convert.ToDouble(textBox1.Text);
            double ortgercek = (ortalama * 60) / 100;
            label12.Text=ortgercek.ToString();
         
            double turkce=Convert.ToDouble(textBox2.Text);
            double sosyal=Convert.ToDouble(textBox3.Text);  
            double matematik=Convert.ToDouble(textBox4.Text);   
            double fen=Convert.ToDouble(textBox5.Text);

            double fenpuan = fen * 3.4;
            double matematikpuan = matematik * 3.3;
            double turkcepuan = turkce * 3.3;
            double sosyalpuan = sosyal * 3.4;

            double tytpuan = fenpuan + matematikpuan + turkcepuan + sosyalpuan+ortgercek;
            label10.Text=tytpuan.ToString();  

        }
    }
}
