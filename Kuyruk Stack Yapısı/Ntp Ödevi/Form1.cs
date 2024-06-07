using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ntp_Ödevi
{
   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        Stack<string> stack = new Stack<string>(10);
        Queue<string> kuyruk= new Queue<string>(10);

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            string Eleman= textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text;
            
            stack.Push(Eleman);
            listBox1.Items.Insert(0, Eleman); // Her geleni 0 ekliyoruz
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            stack.Pop();
            listBox1.Items.RemoveAt(0);
   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string deger = textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + " " + textBox4.Text;
            kuyruk.enQueue(deger);
            listBox2.Items.Add(deger); // Direk listbox2 eklersin üstten  bir sonraki üste gelir silceksen en üstten silersin
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kuyruk.deQueue();
            listBox2.Items.RemoveAt(0);
        }
    }
}
