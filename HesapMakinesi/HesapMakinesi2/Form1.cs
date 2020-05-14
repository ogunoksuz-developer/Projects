using HesaplamaDll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HesapMakinesi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Button buton =  new Button();
        Label lbl1;
        Button[] btnList;
        string eskiDeger = "0";
        bool operatorTiklandi = false;
        bool newOperatorTiklandi = false;
        bool girilensayi = true;
        double eskiGirilen = 0;
        double yeniGirilen = 0;
        string oldOperativ = "=";
        string girilen;
        string operativ;
        Timer timer;
        int[] operatorIndex = { 3, 7, 11, 14, 15 };

        Hesaplama hes = new Hesaplama();
        string formName = "HesapMakinesi-2015 || Ogün Öksüz ";
        int baslangic = 0;
        int bitis = 0;
        int kelimeUzunluk = 0;

        #region Form OnLoad
        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 1000 * 2 / 10;
            timer.Tick += timer_Tick;
 
            #region Create Menu

           // AnaMenu.Ekran = this;
            MenuStrip menu = AnaMenu.CreateMenu(this);

            this.Controls.Add(menu);

            #endregion

            this.Text = formName;
            kelimeUzunluk = formName.Length;
            bitis = kelimeUzunluk;
            lbl1 = new Label();
            this.Controls.Add(lbl1);
            lbl1.Text = "0";
            lbl1.Top = 30;
            lbl1.Left = 30;
            lbl1.Width = 100;

            EkranButonlari ek = new EkranButonlari();
            ek.girilenString = girilen;
            ek.panel1 = panel1;
            ek.girilensayi = girilensayi;
            ek.newOperatorTiklandi = newOperatorTiklandi;
            ek.oldOperativ = oldOperativ;
            ek.lbl1 = lbl1;
            ek.eskiDeger = eskiDeger;
            ek.operativ = operativ;
            ek.operatorIndex = operatorIndex;
            ek.yenigirilen = yeniGirilen;
            ek.operatorTiklandi = operatorTiklandi;
            ek.eskiDeger = eskiDeger;
            ek.eskigirilen = eskiGirilen;
            btnList = ek.CreateButon();

            AnaMenu.Btnlist = btnList;
            AnaMenu.OperatorIndex = operatorIndex;

            #region Panele Buton Ekleme
            foreach (Button item in btnList)
            {
                panel1.Controls.Add(item);
            }
            #endregion

            // hes.Esittir_Kalsın(panel1,op_in;false);
            hes.ButtonEnabled(panel1, operatorIndex, false);
            Hesaplama.CEnabled(panel1, false);
        }

      

        void timer_Tick(object sender, EventArgs e)
        {

            this.Text = Metotlar.FormKayan(baslangic, bitis, kelimeUzunluk, formName);

            baslangic = baslangic + 1;// baslangic++; baslangic+=1;
            formName = this.Text;

        }
        #endregion

       

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
                this.Close();

            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

    
    }
}
