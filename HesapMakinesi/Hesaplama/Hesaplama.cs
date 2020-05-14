using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesaplamaDll
{
    public class Hesaplama
    {
        public void Run(string girilen, string gOperativ, string lblText, Label lbl, string eskiDeger)
        {
           
        }

        public double hesapla(string op, double a, double b)
        {
            double s = 0;
            switch (op)
            {
                case "=":
                    s = a;
                    break;
                case "+":
                    s = a + b;
                    break;
                case "-":
                    s = a - b;
                    break;
                case "*":
                    s = a * b;
                    break;
                case "/":
                    s = a / b;
                    break;
            }

            return s;


        }

        public void ButtonEnabled(Panel pnl, int[] operatorIndex,bool isEnabled)
        {    
            

            foreach (var item in operatorIndex)
            {
                pnl.Controls[item].Enabled = isEnabled;
            }
        }

        public static void CEnabled(Panel pnl, bool isEnabled)
        {
            pnl.Controls[13].Enabled = isEnabled;
        }

        public void tus_sakla(Panel pnl, int[] operatorIndex, bool isEnabled)
        {
            foreach (var item in operatorIndex)
            {
                pnl.Controls[item].Enabled = isEnabled;
            }
        
        }
    
    }
}
