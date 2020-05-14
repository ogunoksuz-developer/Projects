using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesaplamaDll
{
    public class EkranButonlari
    {
        private Button buton;
        public Button[] CreateButon()
        {
            Button[] btnList = new Button[16];
            string[] isaretler = {"9", "8", "7", "/",
            "6", "5", "4", "*",
            "3", "2", "1", "-",
            "0", "C", "=", "+"};

            #region Ekran Butonları
            for (int i = 0; i < 16; i++)
            {
                buton = new Button();
                buton.Text = isaretler[i];
                buton.Name = "btn" + i.ToString();
                buton.Size = new System.Drawing.Size(50, 25);

                #region Button Settings
                switch (i)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                        {
                            buton.Location = new Point(i * 50 + 10, 40);
                        } break;
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        {
                            buton.Location = new Point(i * 50 - 190, 65);
                        } break;
                    case 8:
                    case 9:
                    case 10:
                    case 11:
                        {
                            buton.Location = new Point(i * 50 - (190 + 200), 90);
                        } break;
                    case 12:
                    case 13:
                    case 14:
                    case 15:
                        {
                            buton.Location = new Point(i * 50 - (190 + 200 + 200), 115);
                        } break;
                    default:
                        break;
                }
                #endregion

                btnList[i] = buton;
                buton.Click += buton_Click;
            }


            #endregion

            return btnList;
        }
        public string girilenString { get; set; }
        public Panel panel1;
        public Label lbl1;
        public string eskiDeger;
        public string operativ;
        public bool newOperatorTiklandi;
        public int[] operatorIndex;
        public bool girilensayi;
        public double yenigirilen;
        public string oldOperativ;
        public bool operatorTiklandi;
        public double eskigirilen;
        public Hesaplama hes = new Hesaplama();

        public void buton_Click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            Button c = (Button)sender;
            girilenString = b.Text;

            eskiDeger = lbl1.Text;

            //lbl1.Text = girilenString;
            operativ = c.Text;

            if (Metotlar.RakamaBasildi(girilenString))
            {
                hes.ButtonEnabled(panel1, operatorIndex, true);
                Hesaplama.CEnabled(panel1, true);

                newOperatorTiklandi = false;
                if (lbl1.Text == "0" || girilensayi == true)
                {
                    lbl1.Text = girilenString;

                    if (lbl1.Text.Equals("0"))
                        eskiDeger = "" + girilenString;
                    else
                        eskiDeger = eskiDeger.Equals("0") ? "" + girilenString : eskiDeger + girilenString;

                }
                else
                {
                    lbl1.Text = lbl1.Text + girilenString;
                }

            }
            else
            {
                if (girilenString != "C")
                {
                    if (yenigirilen == 0)
                    {
                        newOperatorTiklandi = true;
                        oldOperativ = operativ;
                    }

                    operatorTiklandi = true;
                    operativ = girilenString;

                }

                if (girilenString != "=")
                    hes.tus_sakla(panel1, operatorIndex, false);
            }

            String tekst = "0" + lbl1.Text.Trim();

            if (!operatorTiklandi)
            {

                lbl1.Text = eskiDeger;
                eskigirilen = Convert.ToDouble(tekst);
            }
            else
            {
                if (newOperatorTiklandi)
                {

                    eskigirilen = Convert.ToDouble(tekst);
                }
                else
                {
                    if (Metotlar.RakamaBasildi(girilenString))
                    {
                        yenigirilen = Convert.ToDouble(girilenString);
                    }
                }
            }


            if (operatorTiklandi)
            {
                double sonuc = hes.hesapla(oldOperativ, eskigirilen, yenigirilen);

                if (yenigirilen != 0 && operativ == "=")
                {
                    yenigirilen = 0;
                    eskigirilen = sonuc;
                    lbl1.Text = Convert.ToString(sonuc);
                }
            }

            if (girilenString.Equals("C"))
            {

                girilensayi = true;
                lbl1.Text = "0";
                operatorTiklandi = false;
                newOperatorTiklandi = false;
                girilensayi = true;

                eskiDeger = "0";
                eskigirilen = 0;
                yenigirilen = 0;

                operativ = "=";
                oldOperativ = "=";


                hes.ButtonEnabled(panel1, operatorIndex, false);
            }

        }
    }

}