using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesaplamaDll
{
    public class temizleme
    {
        public static void clean(string value, Label lbl,bool gir_sayi,bool op_tık,bool new_op,string es_deger,double eskiGirilen, double yeniGirilen,string operativ,string   oldOperativ)
        {                        
            if (value == "C")
            {
                gir_sayi= true;
                lbl.Text = "0";
                op_tık = false;
                new_op = false;
                gir_sayi = true;

                es_deger = "0";
                eskiGirilen = 0;
                yeniGirilen = 0;

                operativ = "=";
                oldOperativ = "=";
            
            }
        
        }
    }
}
