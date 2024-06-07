using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders_8_Yolcu_Seyahat
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // KOLTUK 1
        {
          
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            listBox5.Items.Add(button1.Text);
            listBox6.Items.Add(comboBox3.Text);
            // Yol Ücret Kısmı    Taksim 80  Fatih 90     Kadıköy 60   Esenler 100
            // ComboBox normal seçsen labella oluyor label resetlemeye gerek yok
            
            if (comboBox1.Text == "Kadıköy")
            {
                label15.Text = "60";
            } else if(comboBox1.Text == "Esenler")
            {
                 label15.Text = "100";
            } else if (comboBox1.Text == "Taksim")
            {
                label15.Text = "80";
                
            }
             else if(comboBox1.Text =="Fatih")
            {
                label15.Text = "90";
               
            }
            listBox7.Items.Add(label15.Text);
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            



        }

        private void button7_Click(object sender, EventArgs e)
        {
            
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            listBox5.Items.Add(button7.Text);
            listBox6.Items.Add(comboBox3.Text);
            


           if (comboBox1.Text == "Kadıköy")
            {
                label15.Text = "60";
            }
            else if (comboBox1.Text == "Esenler")
            {
                label15.Text = "100";
            }
            else if (comboBox1.Text == "Taksim")
            {
                label15.Text = "80";

            }
            else if(comboBox1.Text =="Fatih")
            {
                label15.Text = "90";

            }
            listBox7.Items.Add(label15.Text);
            
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            
           

        }

        private void button6_Click(object sender, EventArgs e)
        {
            label15.Text = "";
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            listBox5.Items.Add(button6.Text);
            listBox6.Items.Add(comboBox3.Text);
            



            if (comboBox1.Text == "Kadıköy")
            {
                label15.Text = "60";
            }
            else if (comboBox1.Text == "Esenler")
            {
                label15.Text = "100";
            }
            else if (comboBox1.Text == "Taksim")
            {
                label15.Text = "80";

            }
            else
            {
                label15.Text = "90";

            } 
            listBox7.Items.Add(label15.Text); 

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label15.Text = "";
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            listBox5.Items.Add(button5.Text);
            listBox6.Items.Add(comboBox3.Text);
            



           if (comboBox1.Text == "Kadıköy")
            {
                label15.Text = "60";
            }
            else if (comboBox1.Text == "Esenler")
            {
                label15.Text = "100";
            }
            else if (comboBox1.Text == "Taksim")
            {
                label15.Text = "80";

            }
            else
            {
                label15.Text = "90";

            } 
            listBox7.Items.Add(label15.Text);
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label15.Text = "";
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            listBox5.Items.Add(button2.Text);
            listBox6.Items.Add(comboBox3.Text);
            



            if (comboBox1.Text == "Kadıköy")
            {
                label15.Text = "60";
            }
            else if (comboBox1.Text == "Esenler")
            {
                label15.Text = "100";
            }
            else if (comboBox1.Text == "Taksim")
            {
                label15.Text = "80";

            }
            else
            {
                label15.Text = "90";

            }
            listBox7.Items.Add(label15.Text); 

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label15.Text = "";
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            listBox5.Items.Add(button4.Text);
            listBox6.Items.Add(comboBox3.Text);
            



            if (comboBox1.Text == "Kadıköy")
            {
                label15.Text = "60";
            }
            else if (comboBox1.Text == "Esenler")
            {
                label15.Text = "100";
            }
            else if (comboBox1.Text == "Taksim")
            {
                label15.Text = "80";

            }
            else
            {
                label15.Text = "90";

            }
            listBox7.Items.Add(label15.Text); 

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label15.Text = "";
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            listBox5.Items.Add(button11.Text);
            listBox6.Items.Add(comboBox3.Text);
            


            if (comboBox1.Text == "Kadıköy")
            {
                label15.Text = "60";
            }
            else if (comboBox1.Text == "Esenler")
            {
                label15.Text = "100";
            }
            else if (comboBox1.Text == "Taksim")
            {
                label15.Text = "80";

            }
            else
            {
                label15.Text = "90";

            }
            listBox7.Items.Add(label15.Text); 

            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label15.Text = "";
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            listBox5.Items.Add(button3.Text);
            listBox6.Items.Add(comboBox3.Text);
            
            if (comboBox1.Text == "Kadıköy")
            {
                label15.Text = "60";
            }
            else if (comboBox1.Text == "Esenler")
            {
                label15.Text = "100";
            }
            else if (comboBox1.Text == "Taksim")
            {
                label15.Text = "80";

            }
            else
            {
                label15.Text = "90";

            }
            listBox7.Items.Add(label15.Text);



            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label15.Text = "";
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
            listBox3.Items.Add(comboBox1.Text);
            if (radioButton1.Checked == true)
            {
                listBox4.Items.Add(radioButton1.Text);
            }
            else
            {
                listBox4.Items.Add(radioButton2.Text);
            }
            listBox5.Items.Add(button10.Text);
            listBox6.Items.Add(comboBox3.Text);
            
            if (comboBox1.Text == "Kadıköy")
            {
                label15.Text = "60";
            }
            else if (comboBox1.Text == "Esenler")
            {
                label15.Text = "100";
            }
            else if (comboBox1.Text == "Taksim")
            {
                label15.Text = "80";

            }
            else
            {
                label15.Text = "90";

            }
            listBox7.Items.Add(label15.Text);



            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = "";
            comboBox3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
