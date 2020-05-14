using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Kararlar
    {
        public void Karar1(double b_nok, double k_boyu, double r, double e, double kangal, double sonuc, double tl, double maliyet, double L)
        {
            Console.WriteLine("kaç tane birleştirme noktası kullanıcaksınız");
            b_nok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kaynak yapılacak boyu giriniz");
            k_boyu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kaynak uzunluğunu giriniz");
            L = Convert.ToInt32(Console.ReadLine());

            e = (L) * b_nok * k_boyu;
            Console.WriteLine(e + "tane elektrot kullanılır");
            Console.WriteLine("bir kangal kaç metre");
            kangal = Convert.ToInt32(Console.ReadLine());
            sonuc = e / kangal;
            Console.WriteLine(sonuc + "kangal kullanılır");
            Console.WriteLine("elektrotun metrsi ne kadar");
            tl = Convert.ToInt32(Console.ReadLine());

            maliyet = tl * e;
            Console.WriteLine(maliyet + "tl kullanılır");

        }
        public void Karar2(double b_nok, double k_boyu, double r, double e, double kangal, double sonuc, double tl, double maliyet, double L)
        {
            Console.WriteLine("kaç tane birleştirme noktası kullanıcaksınız");
            b_nok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kaynak yapılacak boyu giriniz");
            k_boyu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yarı çapı giriniz");
            r = Convert.ToInt32(Console.ReadLine());
            r = r / 1000;
            e = ((3 * r * r) / 4) * b_nok * k_boyu;
            Console.WriteLine(e + "tane elektrot kullanılır");
            Console.WriteLine("bir kangal kaç metre");
            kangal = Convert.ToInt32(Console.ReadLine());
            sonuc = e / kangal;
            Console.WriteLine(sonuc + "kangal kullanılır");
            Console.WriteLine("elektrotun metrsi ne kadar");
            tl = Convert.ToInt32(Console.ReadLine());
            maliyet = tl * e;
            Console.WriteLine(maliyet + "tl kullanılır");


        }
        public void Karar3(double b_nok, double k_boyu, double r, double e, double kangal, double sonuc, double tl, double maliyet, double L)
        {
            Console.WriteLine("kaç tane birleştirme noktası kullanıcaksınız");
            b_nok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kaynak yapılacak boyu giriniz");
            k_boyu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yarı çapı giriniz");
            r = Convert.ToInt32(Console.ReadLine());
            r = r / 1000;
            e = ((3 * r * r) / 4) * b_nok * k_boyu;
            Console.WriteLine(e + "tane elektrot kullanılır");
            Console.WriteLine("bir kangal kaç metre");
            kangal = Convert.ToInt32(Console.ReadLine());
            sonuc = e / kangal;
            Console.WriteLine(sonuc + "kangal kullanılır");
            Console.WriteLine("elektrotun metrsi ne kadar");
            tl = Convert.ToInt32(Console.ReadLine());
            maliyet = tl * e;
            Console.WriteLine(maliyet + "tl kullanılır");



        }
        public void Karar4(double b_nok, double k_boyu, double r, double e, double kangal, double sonuc, double tl, double maliyet, double L)
        {
            Console.WriteLine("kaç tane birleştirme noktası kullanıcaksınız");
            b_nok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kaynak yapılacak boyu giriniz");
            k_boyu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yarı çapı giriniz");
            r = Convert.ToInt32(Console.ReadLine());
            r = r / 1000;
            e = ((3 * r * r) / 4) * b_nok * k_boyu;
            Console.WriteLine(e + "tane elektrot kullanılır");
            Console.WriteLine("bir kangal kaç metre");
            kangal = Convert.ToInt32(Console.ReadLine());
            sonuc = e / kangal;
            Console.WriteLine(sonuc + "kangal kullanılır");
            Console.WriteLine("elektrotun metrsi ne kadar");
            tl = Convert.ToInt32(Console.ReadLine());
            maliyet = tl * e;
            Console.WriteLine(maliyet + "tl kullanılır");

        }
        public void Karar5(double b_nok, double k_boyu, double r, double e, double kangal, double sonuc, double tl, double maliyet, double L)
        {
            Console.WriteLine("kaç tane birleştirme noktası kullanıcaksınız");
            b_nok = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("kaynak yapılacak boyu giriniz");
            k_boyu = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("yarı çapı giriniz");
            r = Convert.ToInt32(Console.ReadLine());
            r = r / 1000;
            e = ((3 * r * r) / 4) * b_nok * k_boyu;
            Console.WriteLine(e + "tane elektrot kullanılır");
            Console.WriteLine("bir kangal kaç metre");
            kangal = Convert.ToInt32(Console.ReadLine());
            sonuc = e / kangal;
            Console.WriteLine(sonuc + "kangal kullanılır");
            Console.WriteLine("elektrotun metrsi ne kadar");
            tl = Convert.ToInt32(Console.ReadLine());
            maliyet = tl * e;
            Console.WriteLine(maliyet + "tl kullanılır");

        }
        public static void Karar(int secim, double b_nok, double k_boyu, double r, double e, double kangal, double sonuc, double tl, double maliyet, double L)
        {
            if (secim == 1)
            {
                Karar1(b_nok, k_boyu, r, e, kangal, sonuc, tl, maliyet, L);
            }
            else if (secim == 2)
            {
                Karar2(b_nok, k_boyu, r, e, kangal, sonuc, tl, maliyet, L);

            }
            else if (secim == 3)
            {

                Karar3(b_nok, k_boyu, r, e, kangal, sonuc, tl, maliyet, L);


            }
            else if (secim == 4)
            {

                Karar4(b_nok, k_boyu, r, e, kangal, sonuc, tl, maliyet, L);


            }
            else if (secim == 5)
            {

                Karar5(b_nok, k_boyu, r, e, kangal, sonuc, tl, maliyet, L);

            }



        }
    }
}
