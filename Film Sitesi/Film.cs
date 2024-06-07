using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Movie_App
{
    public class Film
    {
        public string FilmName;
        public double GunlukKiraBedeli;

        public Film(string FilmName, double GunlukKiraBedeli)
        {
            this.FilmName= FilmName;
            this.GunlukKiraBedeli = GunlukKiraBedeli;
        }
    }
}
