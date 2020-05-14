using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesaplamaDll
{
    class metotlar2
    {

        public static bool operativeTıklandı(string op)
        {
            if (op == "+" || op == "-" || op == "*" || op == "/"|| op== "C")
            
                return true;


            return false;
        
        }
    }
}
