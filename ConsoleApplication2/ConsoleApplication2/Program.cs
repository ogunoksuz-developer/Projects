using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            {
                string a = " ";
                int sayi;
                Console.Write("sayi giriniz");
                sayi = Convert.ToInt32(Console.ReadLine());


                for (int i = 0; i < sayi; i++)
                {

                    for (int j = 0; j <= i; j++)
                    {                               
                            Console.Write(a+"*");
                          
                    }

                   Console.Write("\n");

                }

                Console.ReadLine();

            }

        }

    }
}