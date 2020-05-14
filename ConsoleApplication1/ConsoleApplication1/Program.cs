using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim = 0;
            double b_nok = 0, k_boyu = 0, r = 0, e = 0, kangal = 0, sonuc = 0, tl = 0, maliyet = 0, L = 0;
            int devam = 0;
            do
            {
                Console.WriteLine("1-alın\n2-köşe\n3-bindirme\n4-T\n5-kenar");
                Console.WriteLine("bir işlem seçiniz");
                secim = Convert.ToInt32(Console.ReadLine());

                Kararlar karar = new Kararlar();

                karar.Karar1(b_nok, k_boyu, r, e, kangal, sonuc, tl, maliyet, L);
                //karar.Karar2(b_nok, k_boyu, r, e, kangal, sonuc, tl, maliyet, L);
                //karar.Karar3(b_nok, k_boyu, r, e, kangal, sonuc, tl, maliyet, L);
                //karar.Karar4(b_nok, k_boyu, r, e, kangal, sonuc, tl, maliyet, L);
                //karar.Karar5(b_nok, k_boyu, r, e, kangal, sonuc, tl, maliyet, L);
             
                Console.WriteLine("Devam etmek ister misiniz? 1 yada 0");
                devam = Convert.ToInt32(Console.ReadLine());

            } while (devam != 0);

            Console.WriteLine("yine bekleriz");

        }
    }
}
