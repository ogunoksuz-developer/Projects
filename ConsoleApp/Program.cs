using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("bir kelime giriniz");
            string kelime = Console.ReadLine();

            DikUcgen(kelime);

            Program pr = new Program();
            pr.Exit(kelime);




        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public  void Exit(string kelime)
        {
            int yildizSayisi = 20;
            int boslukSayisi = 0;
            string yildiz = "*";
            string bosluk = " ";

            do
            {
                for (int sayac = 0; sayac < boslukSayisi; sayac++)
                {
                    Console.Write(bosluk);
                }

                for (int sayac = 0; sayac < yildizSayisi; sayac++)
                {
                    Console.Write(yildiz);
                }

                Console.Write("CIKIS");

                for (int sayac = 0; sayac < yildizSayisi; sayac++)
                {
                    Console.Write(yildiz);
                }

                for (int sayac = 0; sayac < boslukSayisi; sayac++)
                {
                    Console.Write(bosluk);
                }

                yildizSayisi--;
                boslukSayisi++;

                Thread.Sleep(1000 * 1);
                Console.WriteLine();

                Console.Clear();

                DikUcgen(kelime);

            } while (yildizSayisi!=-1);


        }

        public static void DikUcgen(string kelime)
        {
           
            int bosluk_sayisi = 2 * kelime.Length + 10;
            string b = " ";

            for (int i = 0; i < kelime.Length; i++)
            {
                bosluk_sayisi = bosluk_sayisi - 2;

                Console.Write(kelime.Substring(0, i + 1));

                for (int k = 0; k < bosluk_sayisi; k++)
                {
                    Console.Write(b);
                }

                //for (int k = 0; k <= i; k++)
                //{
                //    Console.Write(kelime[i-k]);
                //}

                Console.Write(ReverseString(kelime).Substring(kelime.Length - (i + 1), i + 1));

                Console.WriteLine();

            }
        }
    }
}
