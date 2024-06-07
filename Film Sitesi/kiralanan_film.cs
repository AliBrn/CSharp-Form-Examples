using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Movie_App
{
    public class kiralanan_film : Film
    {
        internal string ad;

        public kisi kiralayan { get ; set; }
        public Film kiralananFilm { get; set; }  // Kalıtım aldıgımız sınıfı 
        public int kiraBedeli { get; set; }
        public kiralanan_film(kisi ad, int kira) : base(ad.ad,kira) {
            this.kiralayan = ad;
            this.kiraBedeli = kira;
            
        }

        public double Tutar(int day) { // Fiyat Hesapladıgımız
            
            return day * kiraBedeli;
        }
       
    }
}
