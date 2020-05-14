using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        #region tanımlamalar
        static bool isLeftAligned = false;
        const string cellLeftTop = "┌";
        const string cellRightTop = "┐";
        const string cellLeftBottom = "└";
        const string cellRightBottom = "┘";
        const string cellHorizontalJointTop = "┬";
        const string cellHorizontalJointbottom = "┴";
        const string cellVerticalJointLeft = "├";
        const string cellTJoint = "┼";
        const string cellVerticalJointRight = "┤";
        const string cellHorizontalLine = "─";
        const string cellVerticalLine = "│";
        #endregion
        static int secim = 0;

        public enum Secenekler
        {
            FilmEkle = 1,
            FilmSirala = 2,
            FilmGuncelle = 3,
            FilmAdaGoreGetir = 4,
            FilmSil = 5,
            MenudenCik = 6,
        }

        // baglanti nesnesi oluşturulur:
        public static SqlConnection baglanti;

        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Console.ResetColor();

            string filmler = string.Empty;
            string film = string.Empty;
            string karar = string.Empty;

            baglanti = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Projeler\Projelerim\ConsoleApplication1\Database1.mdf;Integrated Security=True;Context Connection=False");
            do
            {
                EkranTasarimi();

                Console.WriteLine("menüden bir işlem seçinizzz");
                secim = Convert.ToInt32(Console.ReadLine());

                if (secim == (int)Secenekler.FilmEkle)
                {

                    Console.WriteLine("eklemek istediğiniz film ismini giriniz");
                    film = Console.ReadLine();

                    FilmEkle(film);
                    film = string.Empty;
                }
                else if (secim == (int)Secenekler.FilmGuncelle)
                {
                    Console.WriteLine("güncellemek istediğiniz filmin ıd sini giriniz");
                    int idGüncel = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("filmin yeni adini griniz");
                    string yeniAd = Console.ReadLine();
                    FilmGuncelle(idGüncel, yeniAd);

                }
                else if (secim == (int)Secenekler.FilmSil)
                {
                    Console.WriteLine("silmek istediğiniz filmin id sini giriniz");
                    int idSil = Convert.ToInt32(Console.ReadLine());
                    Program.FilmSil(idSil);
                }
                else if (secim == (int)Secenekler.FilmSirala)
                {
                    Console.WriteLine("***************FİLM LİSTEMİZ***************");
                    FilmleriGetir();
                }
                else if (secim == (int)Secenekler.FilmAdaGoreGetir)
                {
                    Console.WriteLine("Aramak istediğiniz film");
                    string query = Console.ReadLine();

                    FilmleriAdaGoreGetir(query);
                }
                else if (secim == (int)Secenekler.MenudenCik)
                {
                    MenudenCik();
                    break;
                }

                Console.WriteLine("devam etmek istermisiniz E/H");
                karar = Console.ReadLine();

            } while (karar == "e" || karar == "E");



        }

        private static void EkranTasarimi()
        {
            Ekran();
            Menuler();
        }

        private static void Ekran()
        {
            string a = "*";
            string b = " ";
            #region ekran1
            Console.Write("                 ");
            Console.Write(cellLeftTop);
            for (int i = 0; i < 50; i++)
            {
                Console.Write(cellHorizontalLine);
            }
            Console.WriteLine(cellRightTop);
            Console.Write("                 ");
            Console.Write(cellVerticalLine);
            for (int j = 0; j < 50; j++)
            {
                Console.Write(b);
            }
            Console.WriteLine(cellVerticalLine);
            Console.Write("                 ");
            Console.Write(cellVerticalLine);
            Console.Write("     " + "HOŞGELDİNİZ OGUN OKSUZ FİLM KOLEKSİYONUNA" + "    ");
            Console.WriteLine(cellVerticalLine);
            Console.Write("                 ");
            Console.Write(cellVerticalLine);
            for (int k = 0; k < 50; k++)
            {
                Console.Write(b);
            }
            Console.WriteLine(cellVerticalLine);
            Console.Write("                 ");
            Console.Write(cellLeftBottom);
            for (int t = 0; t < 50; t++)
            {
                Console.Write(cellHorizontalLine);
            }
            Console.WriteLine(cellRightBottom);
            Console.WriteLine();
            Console.WriteLine();
            #endregion
            #region ekran2
            for (int r = 0; r < 80; r++)
            {
                Console.Write(a);
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int y = 0; y < 27; y++)
            {
                Console.Write(b);
            }
            Console.Write(cellLeftTop);
            for (int p = 0; p < 30; p++)
            {
                Console.Write(cellHorizontalLine);
            }
            Console.WriteLine(cellRightTop);
            for (int l = 0; l < 27; l++)
            {
                Console.Write(b);
            }
            Console.Write(cellVerticalLine);
            for (int f = 0; f < 30; f++)
            {
                Console.Write(b);
            }
            Console.WriteLine(cellVerticalLine);
            for (int g = 0; g < 27; g++)
            {
                Console.Write(b);
            }
            Console.Write(cellVerticalLine);
            Console.Write("           " + "ANA MENÜ" + "           ");
            Console.WriteLine(cellVerticalLine);
            for (int c = 0; c < 27; c++)
            {
                Console.Write(b);
            }
            Console.Write(cellVerticalLine);
            for (int m = 0; m < 30; m++)
            {
                Console.Write(b);
            }
            Console.WriteLine(cellVerticalLine);
            Console.Write("                           ");
            Console.Write(cellLeftBottom);
            for (int n = 0; n < 30; n++)
            {
                Console.Write(cellHorizontalLine);
            }
            Console.Write(cellRightBottom);
            #endregion


        }

        private static void Menuler()
        {
            string bosluk = " ";
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 30; i++)
            {
                Console.Write(bosluk);
            }
            Console.Write(cellLeftTop);
            for (int k = 0; k < 24; k++)
            {
                Console.Write(cellHorizontalLine);
            }
            Console.WriteLine(cellRightTop);
            Console.Write("                              ");
            Console.Write(cellVerticalLine);
            Console.Write("1-  FİLM EKLE");
            Console.Write("           ");
            Console.WriteLine(cellVerticalLine);
            for (int j = 0; j < 30; j++)
            {
                Console.Write(bosluk);
            }
            Console.Write(cellVerticalJointLeft);
            for (int h = 0; h < 24; h++)
            {
                Console.Write(cellHorizontalLine);
            }
            Console.WriteLine(cellVerticalJointRight);
            for (int f = 0; f < 30; f++)
            {
                Console.Write(bosluk);
            }
            Console.Write(cellVerticalLine);
            Console.Write("2-  FİLM LİSTELE");
            Console.Write("        ");
            Console.WriteLine(cellVerticalLine);
            for (int t = 0; t < 30; t++)
            {
                Console.Write(bosluk);
            }
            Console.Write(cellVerticalJointLeft);
            for (int y = 0; y < 24; y++)
            {
                Console.Write(cellHorizontalLine);
            }
            Console.WriteLine(cellVerticalJointRight);
            for (int r = 0; r < 30; r++)
            {
                Console.Write(bosluk);
            }
            Console.Write(cellVerticalLine);
            Console.Write("3-  FİLM DÜZELT");
            Console.Write("         ");
            Console.WriteLine(cellVerticalLine);
            for (int n = 0; n < 30; n++)
            {
                Console.Write(bosluk);
            }
            Console.Write(cellVerticalJointLeft);
            for (int p = 0; p < 24; p++)
            {
                Console.Write(cellHorizontalLine);
            }
            Console.WriteLine(cellVerticalJointRight);
            for (int q = 0; q < 30; q++)
            {
                Console.Write(bosluk);
            }
            Console.Write(cellVerticalLine);
            Console.Write("4-  FİLM ARA");
            Console.Write("            ");
            Console.WriteLine(cellVerticalLine);
            for (int a = 0; a < 30; a++)
            {
                Console.Write(bosluk);
            }
            Console.Write(cellVerticalJointLeft);
            for (int s = 0; s < 24; s++)
            {
                Console.Write(cellHorizontalLine);
            }
            Console.WriteLine(cellVerticalJointRight);
            for (int d = 0; d < 30; d++)
            {
                Console.Write(bosluk);
            }
            Console.Write(cellVerticalLine);
            Console.Write("5-  FİLM SİL");
            Console.Write("            ");
            Console.WriteLine(cellVerticalLine);
            for (int v = 0; v < 30; v++)
            {
                Console.Write(bosluk);
            }
            Console.Write(cellVerticalJointLeft);
            for (int x = 0; x < 24; x++)
            {
                Console.Write(cellHorizontalLine);
            }
            Console.WriteLine(cellVerticalJointRight);
            for (int o = 0; o < 30; o++)
            {
                Console.Write(bosluk);
            }
            Console.Write(cellVerticalLine);
            Console.Write("6-  ÇIKIŞ");
            Console.Write("               ");
            Console.WriteLine(cellVerticalLine);
            for (int u = 0; u < 30; u++)
            {
                Console.Write(bosluk);
            }
            Console.Write(cellLeftBottom);
            for (int c = 0; c < 24; c++)
            {
                Console.Write(cellHorizontalLine);
            }
            Console.WriteLine(cellRightBottom);




        }

        private static void FilmEkle(string filmAdi)
        {
            try
            {

                // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur:                  
                SqlCommand cmd = new SqlCommand("INSERT INTO Filmler (FilmAdi) VALUES (@ad)", baglanti);


                // TextBox'lardan alınan bilgiler etiketlere, oradan da sorguya gönderilir:
                cmd.Parameters.AddWithValue("@ad", filmAdi);

                //Bağlantı kapalı ise açılır:
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }


                // Sorgu çalıştırılır:
                cmd.ExecuteNonQuery();


                // Bağlantı kapatılır:
                baglanti.Close();

            }


// Bir yerde hata varsa catch ile yakalanır ve mesaj verilir:
            catch (SqlException)
            {

            }

        }

        private static void FilmGuncelle(int filmId, string yeniFilmAdi)
        {
            try
            {

                // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur:                  
                SqlCommand cmd = new SqlCommand("UPDATE Filmler SET FilmAdi=@ad WHERE Id=@id", baglanti);


                // TextBox'lardan alınan bilgiler etiketlere, oradan da sorguya gönderilir:
                cmd.Parameters.AddWithValue("@id", filmId);
                cmd.Parameters.AddWithValue("@ad", yeniFilmAdi);

                //Bağlantı kapalı ise açılır:
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }


                // Sorgu çalıştırılır:
                cmd.ExecuteNonQuery();


                // Bağlantı kapatılır:
                baglanti.Close();

            }


// Bir yerde hata varsa catch ile yakalanır ve mesaj verilir:
            catch (SqlException)
            {

            }

        }

        private static void FilmSil(int filmId)
        {
            try
            {

                // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur:                  
                SqlCommand cmd = new SqlCommand("delete from Filmler WHERE ID=@id", baglanti);


                // TextBox'lardan alınan bilgiler etiketlere, oradan da sorguya gönderilir:
                cmd.Parameters.AddWithValue("@id", filmId);

                //Bağlantı kapalı ise açılır:
                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }


                // Sorgu çalıştırılır:
                cmd.ExecuteNonQuery();


                // Bağlantı kapatılır:
                baglanti.Close();

            }


// Bir yerde hata varsa catch ile yakalanır ve mesaj verilir:
            catch (SqlException)
            {

            }

        }

        static void FilmleriGetir(string query)
        {

            // Bağlantı durumu kontrol edilip kapalı ise açılır:

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur:

            SqlCommand cmd = new SqlCommand("SELECT * FROM Filmler ORDER BY Id asc", baglanti);


            /* Veriler ile proje arasında adaptör görevi 

            
            sağlayan bir ara eleman olan adp nesnesi oluşturulur: */

            SqlDataAdapter adp = new SqlDataAdapter(cmd);


            // DataTable türündeki dtable nesnesi oluşturulur:

            DataTable dtable = new DataTable();
            adp.Fill(dtable);


            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                Console.WriteLine("Id : " + dtable.Rows[i]["Id"].ToString() + " Film Adi : " + dtable.Rows[i]["FilmAdi"].ToString());

            }


            // adp'nin çalıştırdığı sql sorgusunun getirdiği sonuçlar dtable'a aktarılır:




            // dataGridView'ımız verileri dtable'dan alır ve gösterir:



            // Bağlantı kapatılır:

            baglanti.Close();
        }

        static void FilmleriAdaGoreGetir(string film)
        {

            // Bağlantı durumu kontrol edilip kapalı ise açılır:

            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }


            // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur:

            SqlCommand cmd = new SqlCommand("SELECT * FROM Filmler where FilmAdi LIKE '%"+film+"%'Id ORDER BY  asc", baglanti);

           // cmd.Parameters.AddWithValue("@ad", film);
            /* Veriler ile proje arasında adaptör görevi 

            
            sağlayan bir ara eleman olan adp nesnesi oluşturulur: */

            SqlDataAdapter adp = new SqlDataAdapter(cmd);
          

            // DataTable türündeki dtable nesnesi oluşturulur:

            DataTable dtable = new DataTable();
            adp.Fill(dtable);


            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                Console.WriteLine("Id : " + dtable.Rows[i]["Id"].ToString() + " Film Adi : " + dtable.Rows[i]["FilmAdi"].ToString());

            }


            // adp'nin çalıştırdığı sql sorgusunun getirdiği sonuçlar dtable'a aktarılır:




            // dataGridView'ımız verileri dtable'dan alır ve gösterir:



            // Bağlantı kapatılır:

            baglanti.Close();
        }

        static void MenudenCik()
        {
                 
            int yildizSayisi = 20;
            int boslukSayisi = 0;
            string yildiz = "*";
            string bosluk = " ";

            do
            {
                for (int sayac = 0; sayac < boslukSayisi; sayac++)
                {
                    Console.Write(bosluk);
                }

                for (int sayac = 0; sayac < yildizSayisi; sayac++)
                {
                    Console.Write(yildiz);
                }

                Console.Write("CIKIS");

                for (int sayac = 0; sayac < yildizSayisi; sayac++)
                {
                    Console.Write(yildiz);
                }

                for (int sayac = 0; sayac < boslukSayisi; sayac++)
                {
                    Console.Write(bosluk);
                }

                yildizSayisi--;
                boslukSayisi++;

                Thread.Sleep(1000 * 1);
                Console.WriteLine();

                Console.Clear();
                EkranTasarimi();
              

            } while (yildizSayisi!=-1);


        }

        }

    }



