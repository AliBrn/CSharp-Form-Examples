using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ntp_Ödevi
{
    public class Stack <T>
    {
        public T[] dizi;
        public int kapasite;
        int tane;
        public Stack(int kapasite)
        {
            this.kapasite = kapasite;
            tane = -1;
            dizi = new T[kapasite];
                
        }
        bool BosMu()
        {
            return tane == -1;
        }
        bool DoluMu()
        {
            return tane == dizi.Length - 1;

        }

        public void Push(T eleman)
        {
            if (!DoluMu()){
                tane = tane + 1;
                dizi[tane]= eleman;
            }
            else
            {
                Console.WriteLine("Boş"); // label da yazarsın
            }
            
        }

        public T Pop()
        {
            T sonuc = dizi[tane];
            if (!BosMu()) {
               
                   // Sildiğimi göstermek için
                tane--;
                return sonuc;
            }
            return sonuc;

        }


        public void yazdır()
        {
            for (int i = 0; i < tane + 1; i++)
            {
                MessageBox.Show(dizi[i] + "");
            }
        }

    }
}
