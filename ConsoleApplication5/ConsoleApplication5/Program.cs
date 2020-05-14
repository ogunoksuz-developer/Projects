using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static string[,] dizi;
        static void Main(string[] args)
        {

            int satirSayisi;

            string yildizKarakter = "*", boslukKarakteri = " ";
          
            Console.Write("satir  sayısını giriniz");
            satirSayisi = Convert.ToInt32(Console.ReadLine());
            dizi = new string[satirSayisi, 2 * satirSayisi - 1];
       
            int yildizSayisi = 0;
            int boslukSayisi = 0;
            int baslangicBoslukSayisi = 0;
            int kolonSayisi = 2 * satirSayisi - 1;

            for (int i = 0; i < satirSayisi; i++)
            {

                yildizSayisi = 2 * i + 1;
                boslukSayisi = 2 * satirSayisi - 1 - (2 * i + 1);
                baslangicBoslukSayisi = boslukSayisi / 2;

                for (int j = 0; j < kolonSayisi; )
                {
                    if (j == baslangicBoslukSayisi)
                    {
                        for (int k = 0; k < yildizSayisi; k++)
                        {
                            dizi[i, j] = yildizKarakter;
                            j++;
                        }

                    }
                    else
                    {
                        for (int k = 0; k < baslangicBoslukSayisi; k++)
                        {
                            dizi[i, j] = boslukKarakteri;
                            j++;
                        }
                    }
                }
            }

            EkranaYazdir(satirSayisi, 2 * satirSayisi - 1);


            Console.ReadKey();
        }

        private static void EkranaYazdir(int satir, int kolon)
        {
            for (int i = 0; i < satir; i++)
            {
                for (int j = 0; j < kolon; j++)
                {
                    Console.Write(dizi[i, j]);
                }
                Console.WriteLine();
            }
        }

    }
}
