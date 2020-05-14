using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = 0;
            bool durum = false;

            Console.WriteLine("bir sayi giriniz");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < sayi; i++)
            {
                durum = true;

                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        durum = false;
                        break;
                    }
                }

                if (durum == true)
                    Console.WriteLine(i);
            }
                  
            Console.ReadKey();
        }

        public static string kontrol { get; set; }
    }
}
