using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            string kelime = string.Empty;

            Console.WriteLine("bir kelime giriniz");
            kelime = Console.ReadLine();

            if (!string.IsNullOrEmpty(kelime)) //kelime != null && kelime != ""
            {
                for (int i = 0; i <= kelime.Length; i++)
                {
                    Console.Write(kelime[kelime.Length - i - 1]);
                }
            }
            else
                Console.WriteLine("Kelime girilmedi");
                Console.WriteLine(DateTime.Now);

            Console.ReadKey();
        }
    }

}