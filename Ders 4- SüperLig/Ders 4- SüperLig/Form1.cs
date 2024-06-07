namespace Ders_4__SüperLig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "oyuncu" && textBox2.Text =="12345") {
            Form2 form=new Form2();
            form.Show();
            this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış Giriş");
            }
        }
    }
}
