using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Mukemmel : Form
    {
        public Mukemmel()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region tanımlamalar
            int toplam = 0;
            int[] sayilar = new int[4];
            int index = 0;
            lbl.Text = "mükemmel sayılar";
            string carpan = string.Empty;
            int k = 0;
            #endregion
          
            #region islemler
            for (int i = 2; ; i++)
            {
                toplam = 0;

                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        toplam += j;// toplam=toplam+j;
                    }
                }
                if (i == toplam)
                {
                    sayilar[index] = i;
                    index++;

                }
                if (index == 4)
                    break;
            }
            #endregion

            #region ListBoxa Yazdır
            for (int t = 0; t < index; t++)
            {
                carpan = string.Empty;
                for (int c = 1; c < sayilar[t]; c++)
                {
                    if (sayilar[t] % c == 0)
                    {
                        carpan = carpan  + c.ToString() + ",";

                    }
                }

                lstBox.Items.Add(sayilar[k] + "=" + carpan);
                k++;

            }
            #endregion

           
        }
    }
}