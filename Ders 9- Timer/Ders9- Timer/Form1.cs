using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders9__Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Zaman_Click(object sender, EventArgs e)
        {
            //     label1.Text = DateTime.Now.ToString(); // Convert yapmalısın

            //    label2.Text=DateTime.Now.Second.ToString(); // Aynı kullanım en son çevirmeden ne cinsi istediğini bilmelisin
            Zaman.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // timer true yapmazsan çalışmaz aktif değil çünkü geldiğinde
            label1.Text=DateTime.Now.Hour.ToString();
            label2.Text=DateTime.Now.Minute.ToString();
            label3.Text=DateTime.Now.Second.ToString();
        }
    }
}
