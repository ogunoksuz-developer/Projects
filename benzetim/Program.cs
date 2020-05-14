using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace benzetim
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("lamdayı giriniz");
            double lamda = Convert.ToDouble(Console.ReadLine());
            Console.Write("x giriniz");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("x faktariyeli gir");
            double xfak = Convert.ToDouble(Console.ReadLine());
           double e=2.71;
            double toplam = Math.Pow(lamda, x)*Math.Pow(e,-lamda)/(xfak) ;
            Console.Write(toplam);
            Console.ReadKey();
            


        }
    }
}
