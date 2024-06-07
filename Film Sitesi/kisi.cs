using System.Windows.Forms;

namespace OOP_Movie_App
{
    public class kisi
    {
        public string ad { get; set; }
        public string soyad { get; set; }

        public string TcNo; // Get ve Set yap düzenle Forma Ekliycem

        public string TelNo;
        public int yas;

       public string TcKimlik
        {
            get { return TcNo; }
            set
            {
                if (TcNo.Length == 11)
                {
                    TcNo = value;
                }
                else
                {
                    MessageBox.Show("Hatalı giriş tekrar deneyin");
                }
            }
        }

        public string Telefon
        {
            get { return TelNo; }
            set
            {
                if (TelNo.Length == 11)
                    TelNo = value;
                else
                {
                    MessageBox.Show("Eksik tuşlama tekrar deneyiniz");
                }
            }
        }

       public int Yas
        {
            get { return yas; }
            set
            {
                if (yas >= 15)
                    yas = value;
                else
                    MessageBox.Show("Yaşınız tutmuyor");

            }
        }
        public kisi(string ad, string soyad, int yas, string TcNo, string TelNo)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.TcNo = TcNo;
            this.TelNo = TelNo;
            this.yas = yas;
            
        }

    }
}
