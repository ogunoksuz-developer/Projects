using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class dortgen
    {
        private int saat;
        private int dakika;
        private int saniye;
        //Saat değerini kontrol et
        public void Saat(int saat1)
        {
            if (saat<24 && saat>=0)
            {
                saat = saat1;
            }
            else
            {
                saat1 = 00;
            }

           
        }
        public int Saat1 {
            get
            {
                return saat;
            }
            set
            {
                if (value < 24 && value >= 0)
                    saat = value;
                else
                    saat = 00;
            }


        }
        // Dakika değerini kontrol et
        public int Dakika
        {
            get
            {
                return dakika;
            }
            set
            {
                if (value < 60 && value >= 00)
                    dakika = value;
                else
                    dakika = 00;
            }
        }
        // Saniye değerini kontrol et
        public int Saniye
        {
            get
            {
                return saniye;
            }
            set
            {
                if (value < 60 && value >= 0)
                    saniye = value;
                else
                    saniye = 00;
            }
        }
        public void saatGoruntule()
        {
            Console.WriteLine(saat + " : " + dakika + " : " + saniye);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            
            dortgen zaman = new dortgen();
          zaman.Saat(19);
        zaman.Saat1 = 19;
        zaman.Dakika = 07;
        zaman.Saniye = 59;
            
            Console.WriteLine(zaman.Dakika +":"+zaman.Saat1+":"+zaman.Saniye);
            zaman.saatGoruntule();
            Console.ReadKey();
        }
    }
}
