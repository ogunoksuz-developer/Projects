using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesaplamaDll
{
    public class Metotlar
    {
        public static bool RakamaBasildi(string value)
        {
            if (value == "0" || value == "1" || value == "2" || value == "3" || value == "4" || value == "5" || value == "6" || value == "7" || value == "8" || value == "9" || value == "0")

                return true;
         
            return false; 

        }

        public static string FormKayan(int baslangic, int bitis, int kelimeUzunluk, string formName)
        {
            if (baslangic == 0)
            {
                return formName.Substring(baslangic, bitis);
            }
            else
            {
                string baslangicText = string.Empty;
                string ikinciText = string.Empty;

                baslangicText = formName[kelimeUzunluk - 1].ToString();

                ikinciText = formName.Substring(0, bitis - 1);

                return baslangicText + "" + ikinciText;

            }
        
        }
    }
}
