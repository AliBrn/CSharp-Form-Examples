using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ntp_Ödevi
{
    public class Queue<T>
    {
        int kapasite;
        T[] dizi;
        int adet;
        public Queue(int kapasite)
        {
            this.kapasite = kapasite;
            dizi = new T[kapasite];
            adet = -1;
        }

        public void enQueue(T yeni)
        {
            adet++;
            dizi[adet] = yeni;
            if(adet >= kapasite)
            {
                throw new Exception("Kuyruk Dolu");
            }
        }
        public T deQueue()
        {
            T yedek = dizi[0];

            for(int i = 0; i < adet; i++)
            {
                dizi[i] = dizi[i + 1];
            }
            adet--;
            return yedek;
        }


        public void yazdır()
        {
            for(int i = 0;i < adet+1 ; i++)
            {
                MessageBox.Show(dizi[i] + "");
            }
        }






    }
}
