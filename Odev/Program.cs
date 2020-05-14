using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selmanödev
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            bilgiler blg = new bilgiler();
            blg.bilgi();
            
            Console.ReadKey();
           

        }

    }
    class secim
    {
        public void secimler(int mesafe) {
            int toplam = 0;
            
            sıvısinif ss = new sıvısinif();
            katiSinif ks = new katiSinif();
            try
            {
                Console.Write("Taşınacak Ürün(0:sıvı 1:katı 2:gaz 3:degerli ürün)");
                byte secim = Convert.ToByte(Console.ReadLine());


                switch (secim)

                {
                    case 0:
                        Console.Write("Toplam Tutar :" + ss.sivi(mesafe, toplam));
                        break;
                    case 1:
                        Console.Write("Toplam Tutar :" + ks.kati(mesafe, toplam));
                        break;
                    case 2:
                        Console.Write("Toplam Tutar :" + gazSinif.gaz(mesafe, toplam));
                        break;
                    case 3:
                        Console.Write("Toplam Tutar :" + degerliSinif.degerli(mesafe, toplam));
                        break;

                }


            }
            catch (OverflowException e)
            {
                Console.Write("ksadmadmkjad" + e);

            }





        }





    }
   

    class sıvısinif
    {
        public int sivi(int mesafe ,int toplam )
        {
            
            Console.Write("Sıvının Adı");
            string sAdi = Console.ReadLine();
            Console.Write("Sıvı ürünün tonajı");
            int sTonaj =Convert.ToInt32(  Console.ReadLine());
            Console.Write("Sıvı ürünün özgül agırlığı");
            int sAgırlık =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("*******************************");
             toplam =( sTonaj * 125 * mesafe)/100;
            
            return toplam;

        }

    }
    class katiSinif {
        public int kati(int mesafe,int toplam) {
            Console.Write("katı Ürünün  Adı");
            string kAdi = Console.ReadLine();
            Console.Write("katı ürünün tonajı");
            int kTonaj = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sıvı ürünün paket hacmi");
            int kHacmi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*******************************");
            toplam = kTonaj * 1 * mesafe + 1000;
            return toplam;



        }



    }
    class gazSinif
    {
        public static int gaz(int mesafe ,int toplam)
            {
            Console.Write("Gaz Ürünün  Adı");
            string gAdi = Console.ReadLine();
        Console.Write("gaz ürünün hacmi");
            int ghacim = Convert.ToInt32(Console.ReadLine());
        Console.Write("Gaz ürünün tipi");
            int gtip = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("*******************************");
            toplam =( ghacim * 11 * mesafe)/10 + 4000;
            return toplam;
            
            }
    }
    class degerliSinif
    {
        public static int degerli(int mesafe,int toplam)
        {
            Console.Write("Değerli Ürünün  Adı");
            string gAdi = Console.ReadLine();
            Console.Write("Değerli ürünün hacmi");
            int dhacim = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gaz ürünün tonajı");
            int dTonaj = Convert.ToInt32(Console.ReadLine());
            Console.Write("Değerli ürünün aded: ");
            int dAdet = Convert.ToInt32(Console.ReadLine());
            Console.Write("Değerli ürünün adet ağarlığı : ");
            int dAdetAgırlık = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("*******************************");
            if (dAdetAgırlık/dhacim>=1/2)
            {
                toplam = ((dAdetAgırlık * 15) / 10) + ((dhacim * 15) / 10) / 2 + ((mesafe * 15) / 10);
            }
            else
            {
                toplam = ((dhacim * 15) / 10) + mesafe * 2;
            }
            return toplam;
        }


    }
    }
    

