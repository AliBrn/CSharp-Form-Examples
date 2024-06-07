using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Odev_Makina
{
    public partial class Form1 : Form
    {

        string dosya = "C:\\Users\\Ali\\Desktop\\C# Kodları\\Makine.txt";
        public Form1()
        {
            InitializeComponent();
            DataGridView_Ekle(); // DataGridView'e veri ekler
            makinecmbx.SelectedIndex = 0;
           
           
            DateTime1.MinDate = new DateTime(2024, 1,1); // 1 tarih min değer
            DateTime1.MaxDate = new DateTime(2024, 2, 25); // 1 tarih max değer
            
            DateTime2.MinDate = new DateTime(2024,1,1);      // 2 tarih min değer 
            DateTime2.MaxDate = new DateTime(2024, 2, 25);  //  2 tarih max değer
        }
        
        public void DataGridView_Ekle()
        {
            
            string[] isimler;
            
            using (StreamReader stream = new StreamReader(dosya) )  // Okuyup datagriedView yazan kısım
            {
                
                isimler = stream.ReadLine().Split(',');

                    foreach (string header in isimler)
                    {
                        dataGridView1.Columns.Add(header, header); // Sütun başlıklarını DataGridView'e ekler
                }

                    string line;
                    while ((line = stream.ReadLine()) != null)
                    {
                        string[] veri= line.Split(','); // Her satırı okuyup veri dizisine ayırır
                    dataGridView1.Rows.Add(veri); // Veriyi DataGridView'e ekler
                }
                }

            }

        private void InitializeComboBox()
        {
            List<string> makine = new List<string>(); //Combobox başlangıç öğelerini yapıyor

            using (StreamReader str = new StreamReader(dosya))
            {
                str.ReadLine();

                string satir;
                while ((satir = str.ReadLine()) != null) 
                {
                    string[] data = satir.Split(',');
                    if (!makine.Contains(data[0]))
                    {
                        makine.Add(data[0]);  // Makine isimlerini listeye ekler
                    }
                }
            }

            makinecmbx.Items.Add("Makine Seçiniz"); // ComboBox'a "Makine Seçiniz" seçeneğini ekler
            makinecmbx.Items.AddRange(makine.ToArray()); // Makine isimlerini ComboBox'a ekler
          
        }
        
        
        private void TabloyaUygula()
        {
            GrafikTablo.Series.Clear();
            GrafikTablo.Series.Add("Günlük Üretim");
            GrafikTablo.Series.Add("Beklenen Üretim");

            foreach (DataGridViewRow row in dataGridView1.Rows) // Tabloyu oluştuma kısmı
            {
                if (row.IsNewRow || !row.Visible) continue;

                string date = row.Cells[1].Value.ToString(); // Tarih bilgisini alır tablodan yatay kısmın ilk satıra bunu yazar


                int gercek = Convert.ToInt32(row.Cells[3].Value);   // Gerçek üretim miktarını alır 3 cü satır sayısını kaç tane olsun
                GrafikTablo.Series["Günlük Üretim"].Points.AddXY(date, gercek); // Grafik serisine ekler


                int beklenti = Convert.ToInt32(row.Cells[2].Value); // Beklenen üretim miktarını alır  kapasitesi 2 satır kaplasın
                GrafikTablo.Series["Beklenen Üretim"].Points.AddXY(date, beklenti); // Grafik serisine ekler

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters(); // Filtreleme işlemini yapar comboboxdan seçtiğimiz değere göre
        }




        private void ApplyFilters()
        {
            DateTime baslangic = DateTime1.Value; // 1. tarih seçicinin değerini alır
            DateTime bitis = DateTime2.Value;      // 2. tarih seçicinin değerini alır
            string  SeciliMakine = makinecmbx.SelectedItem?.ToString();//  Seçili makineyi alır comboboxdan

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                DateTime rowDate = Convert.ToDateTime(row.Cells[1].Value); // Satırdaki tarihi alır
                bool tarih = rowDate >= baslangic && rowDate <= bitis; // Tarihin aralıkta olup olmadığını kontrol eder
                bool Makine = SeciliMakine == "Makine Seçiniz" || row.Cells[0].Value.ToString() == SeciliMakine; // Makinenin seçili makineyle eşleşip eşleşmediğini kontrol eder


                row.Visible = makine && tarih; // Satırı uygunluğuna göre görünür yapar
            }
        }

      
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }






       
       
        private void button1_Click(object sender, EventArgs e)
        {
            TabloyaUygula();
        }





    }



}
