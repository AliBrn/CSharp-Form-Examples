using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Movie_App
{

    public partial class Form1 : Form
    {
        public int Age;
        public dynamic dataGrid;
        dukkan dkn = new dukkan();
       
        public Form1()
        {
            InitializeComponent();
            dataGrid = dataGridView1;

            dkn.filmleriYukle("C:\\Users\\Ali\\Desktop\\Film Sitesi\\StoreMovie.txt", Filmler);
        }

        
        
        private void kirala_btn_Click(object sender, EventArgs e)
        {
            string ad = ad_tb.Text; // Alma textboxdaki verileri
            string soyad = soyad_tb.Text;
            string tcNo = tctxtbox.Text;
            string cepNo = ceptxtbox.Text;
            int yas = Convert.ToInt32(yastxtbox.Text);
            int gun = Convert.ToInt32(gun_tb.Text);

            DataGridViewRow dgv = new DataGridViewRow();

            kisi user = new kisi(ad, soyad,yas,tcNo,cepNo);
            kiralanan_film kiralananFilm = new kiralanan_film(user, dukkan.baslangicKira);
           

            dgv.CreateCells(dataGrid);

            var SecilenFilm = Filmler.SelectedItem; // FİLM YÜKLEME
            var FilmListe = SecilenFilm.ToString().Split(' ');
            string fiyat = FilmListe[FilmListe.Length -1];
            dynamic movieName = " ";
            for(int i =0; i< FilmListe.Length-1; i++) //
            {
                movieName += FilmListe[i] + " ";
            }

            int day = Convert.ToInt32(gun_tb.Text);

            dkn.filmEkle("alinan_filmler.txt", kiralananFilm);

            dgv.Cells[0].Value = movieName; 
            dgv.Cells[1].Value = user.ad + " " + user.soyad;
            dgv.Cells[5].Value = day*Convert.ToInt32(fiyat); //TODO
            dgv.Cells[3].Value = tcNo;
            dgv.Cells[2].Value = yas;
            dgv.Cells[4].Value = cepNo;
            dataGrid.Rows.Add(dgv);
        }







        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void yastxtbox_TextChanged(object sender, EventArgs e)
        {
       
        }
    }
}
