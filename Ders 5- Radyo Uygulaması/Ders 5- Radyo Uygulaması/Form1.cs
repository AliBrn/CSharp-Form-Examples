using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace Ders_5__Radyo_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL= "https://ssldyg.radyotvonline.com/smil/smil:kralfm.smil/playlist.m3u8";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://listen.powerapp.com.tr/powerpop/abr/playlist.m3u8";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = " https://n10101m.mediatriple.net/numberoneturk";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Direk programı kapatmamızı sağlar
        }
    }
}
