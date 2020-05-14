using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cls1 = new Class1();
            Console.Write("sayiyi girin");
            cls1.sayi = Convert.ToInt32(Console.ReadLine());
            deneme2 dnm2 = new deneme2();
            dnm2.metot();
            Console.Write("sayiyi girin");
            dnm2.sayi =Convert.ToInt32( Console.ReadLine());
            Console.ReadKey();
        }

    }

    class deneme1{
        public string ad;
        public int sayi;



    }

    class deneme2 : deneme1 {

        public void metot()
        {
            Console.Write("ad giriniz");
            ad = Console.ReadLine();
            
        }


    }
}
