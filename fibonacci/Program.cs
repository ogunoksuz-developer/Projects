
using dllTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sayi = 0;
            Console.WriteLine("kacicinci sayıya kadar itersiniz");
            sayi = Convert.ToByte(Console.ReadLine());

            TestDLL nesne = new TestDLL();
            DenemeClass nesne2 = new DenemeClass();

            List<int> fibonnacciList = nesne.ReturnFibonacci(sayi);
            List<int> fibonnacciList2 = nesne2.ReturnFibonacci(sayi);
            fibonnacciList2 = DenemeClass.ReturnFibonacciStatic(sayi);

            for (int i = 0; i < fibonnacciList.Count; i++)
            {
                Console.Write(fibonnacciList[i].ToString()+" ");
            }

            Console.WriteLine("");

            foreach (int item in fibonnacciList)
            {
                Console.Write(item.ToString()+" ");
            }

            Console.WriteLine("");

            foreach (int item in fibonnacciList2)
            {
                Console.Write(item.ToString() + " ");
            }

            Console.ReadKey();
        }

    }
}

