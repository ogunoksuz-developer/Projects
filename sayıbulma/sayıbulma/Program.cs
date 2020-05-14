using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sayıbulma
{
    class Program
    {
        static void Main(string[] args)
        {
            int hak = 5;
            Random rnd = new Random();
            int tutulan = rnd.Next(1, 100);
            int sayi = 0;
            while (hak > 0)
            {
                Console.WriteLine(" bir sayi giriniz");
                sayi = Convert.ToInt32(Console.ReadLine());
                hak = hak - 1;
                if (sayi <= 100)
                {
                    if (sayi == tutulan)
                    {
                        Console.WriteLine("dogru tahmin");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("kalan tahmin hakkiniz");
                    }

                }
                else
                {
                    Console.WriteLine("sayınız cok büyük");

                }
            }



            if (hak == 0)
            {

                Console.WriteLine("tahmin hakkınınız kalmamıştır tutulan sayi" + "    " + tutulan + "idi");

            }

            Console.ReadKey();
        }
    }
}

