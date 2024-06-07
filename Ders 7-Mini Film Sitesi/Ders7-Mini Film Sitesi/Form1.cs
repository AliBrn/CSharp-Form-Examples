using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ders7_Mini_Film_Sitesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loganToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "In a future where mutants are nearly extinct, an elderly and weary Logan leads a quiet life. But when Laura, a mutant child pursued by scientists, comes to him for help, he must get her to safety.";
            listBox1.Items.Add("Logan"); // Film
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void theDarknightToolStripMenuItem_Click(object sender, EventArgs e) // Film olarak The Darknight Seçersek
        {
            richTextBox1.Text = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.";
            listBox1.Items.Add("The Darknight"); // Film
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void buzDevriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Buzul çağı, dünyaya hüküm sürmeye başlamıştır. Bu ıssız ve korkunç dünyada bir başlarına olan zavallı hayvanlar, bir şekilde hayatta kalmanın yollarını aramaktadırlar. Uzun tüylü, kendi halinde bir mamut; karizmatik ve dişli bir kaplan ve muzır bir rakun, nasıl olduysa bu kaos esnasında bir araya gelmişlerdir. Bu üç birbirinden farklı türe mensup hayvanın odağında ise tek bir mevzu vardır. Buldukları küçük bebeği, insanlara ulaştırıp o bebeğin hayatını kurtarmak...";
            listBox1.Items.Add("Buz Devri"); // Film
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void arabalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "On the way to the biggest race of his life, a hotshot rookie race car gets stranded in a rundown town and learns that winning isn't everything in life.";
            listBox1.Items.Add("Cars"); // Film
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void yüzüklerinEfendisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.";
            listBox1.Items.Add("The Lord Of The Rings"); // Film
            listBox2.Items.Add(toolStripComboBox1.Text);

        }

        private void duneToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            richTextBox1.Text = "A noble family becomes embroiled in a war for control over the galaxy's most valuable asset while its heir becomes troubled by visions of a dark future.";
            listBox1.Items.Add("Dune"); // Film
            listBox2.Items.Add(toolStripComboBox1.Text); // ToolStrip ComboBox ekliyoruz puanı
        
        }

        private void ınceptionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vForVendettaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = " Film 2020 yılında ve İngiltere’de geçmektedir. Tarihte olaylar farklı gelişmiş, yokedici bir savaş dünyanın yüzünü değiştirmiştir. Yüzyıllar boyu libarelleşmenin simgesi olan İngiltere artık uzun bir süreden beri, totaliter ve faşist bir şekilde yönetilmektedir. Ne siyasi ne de kişisel özgürlüklerin olduğu bu ortamda aniden ortaya çıkan ve zaman zaman absürtlük derecesinde saçma terörist eylemlere kalkışan esrarengiz bir figür her şeyi değiştirecektir. Özgürlüğün anlamını bilmeyen genç bir kadını da... Gizemli V, belaya bulaşmış masum bir kadın olan Evey’i kurtarır. Ancak bu kurtarış, tam da ulusun kurtuluşunu temsil eder çünkü onun davranışı aslında toplumun uyanışını tetikleyen ve başkaldırıyı başlatan unsurdur. Tam da bu sebeple artık insanlık adına bir ayaklanma zamanıdır. Alan Moore’un romanından uyarlanan film, son derece epik bir hikayedir.";
            listBox1.Items.Add("V For Vendetta");
            listBox2.Items.Add(toolStripComboBox1.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
          
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void puanVerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
