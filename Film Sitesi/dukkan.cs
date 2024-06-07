using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Movie_App
{
    public class dukkan
    {
   
        public void filmleriYukle(string path, ListBox lb)
        {
            try
            {
                StreamReader stream = new StreamReader(path); // Film YÜKLEME için dosya
                string ekleme = stream.ReadLine();
                while(ekleme != null)
                {
                    lb.Items.Add(ekleme);
                    ekleme = stream.ReadLine();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Film yüklemede bir hata oluştu! " + ex.Message);
            }
        }

        public void filmEkle(string dsya, kiralanan_film Film)
        {
            
            
                StreamWriter stw = new StreamWriter(dsya);
                stw.WriteLine(Film.kiralayan+" "+Film.ad + " " + Film.GunlukKiraBedeli);
          
        }

    }
}
