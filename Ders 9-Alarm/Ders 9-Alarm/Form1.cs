using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_9_Alarm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < 24; i++)
            {
                comboBox1.Items.Add(i);    
            }
            for(int i = 0; i < 60; i++)
            {
                comboBox2.Items.Add(i);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.Hour.ToString();
            label6.Text=DateTime.Now.Minute.ToString();
            if(label6.Text==comboBox2.Text && label5.Text == comboBox1.Text)  // Hem saat hem dakika aynı ise alarm çalcak
            {
                timer1.Enabled = false;  // 1 kere çalsın kapansın diye
                axWindowsMediaPlayer1.URL = "C:\\Users\\Ali\\Desktop\\Müzik Desktop\\Gm.mp3";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }
    }
}
