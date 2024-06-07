using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ntp_Ödevi
{
    public class Ogrenci
    {
        public string isim;
        public string name;
        public string numara;
        public int vizeNot;
        public int finalNot;
       public Ogrenci(string isim, string name, string numara, int vizeNot, int finalNot)
        {
            this.isim = isim;
            this.name = name;
            this.numara = numara;
            this.vizeNot = vizeNot;
            this.finalNot = finalNot;
        }
    }
}
