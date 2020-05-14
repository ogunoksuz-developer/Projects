using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selmanödev
{
    class bilgiler
    {
        public void bilgi()
            {
            //Console.WriteLine("müşterinin adını giriniz");
            //string mAdi = Console.ReadLine();
            //Console.Write("müşterinin adresini giriniz");
            //string mAdres = Console.ReadLine();
            //Console.Write("müşterinin telefonunu giriniz");
            //string mtel = (Console.ReadLine());
            //Console.Write("müşterinin faks numarası giriniz");
            //string mFNo = (Console.ReadLine());
            //Console.Write("müşterinin mail adresini giriniz");
            //string mMail = Console.ReadLine();
            //Console.Write("müşterinin web sitesi linki");
            //string mWeb = (Console.ReadLine());
            //Console.Write("müşterinin vergi nosu");
            //string mVergi = Console.ReadLine();
            //Console.Write("en son sipariş verdiği tarih");
            //DateTime mTarih = Convert.ToDateTime(Console.ReadLine());
            Console.Write(" ürünü taşınacak mesafe");
            int mesafe = Convert.ToInt32(Console.ReadLine());
            secim sc = new secim();
            sc.secimler(mesafe);
        }
    }
}
