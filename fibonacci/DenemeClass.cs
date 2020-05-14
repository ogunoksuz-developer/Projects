using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    public class DenemeClass
    {
        public List<int> ReturnFibonacci(int sayi)
        {
            byte a = 0, b = 1; byte c = 0;
            List<int> listFibonacci = new List<int>();

            while (c <= sayi)
            {
                c = (byte)(a + b);
                if (c > sayi)

                    break;
                a = b;
                b = c;

                listFibonacci.Add(c);
            }

            return listFibonacci;
        }

        public static List<int> ReturnFibonacciStatic(int sayi)
        {
            byte a = 0, b = 1; byte c = 0;
            List<int> listFibonacci = new List<int>();

            while (c <= sayi)
            {
                c = (byte)(a + b);
                if (c > sayi)

                    break;
                a = b;
                b = c;

                listFibonacci.Add(c);
            }

            return listFibonacci;
        }
    }
}
