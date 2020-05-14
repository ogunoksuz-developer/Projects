using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Text.RegularExpressions;


namespace MusteriKayit
{
    public partial class Form1 : Form
    {
        public static SqlConnection baglanti;

        public Form1()
        {
            InitializeComponent();
            baglanti = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Projeler\Projelerim\MusteriKayit\Database1.mdf;Integrated Security=True");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisiGetir();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();


                if (!string.IsNullOrEmpty(textBox2.Text)) //textBox2.Text != null && textBox2.Text != "" 
                {

                    if (TcKimlikNoKontrol(textBox2.Text)==true)
                    {
                      string txt = textBox3.Text;
                      Boolean kontrol = false;
                      for (byte a = 0; a < txt.Length; a++)
                          if (txt[a] < '0' || txt[a] > '9')
                          {
                              kontrol = true;
                              break;
                          }
                        if(kontrol==true)
                   
                    {

                       string kayit = "insert into musteriler(tcno,isim,soyisim,telefon,adres) values (@tcno,@isim,@soyisim,@telefon,@adres)";

                       SqlCommand komut = new SqlCommand(kayit, baglanti);
                       komut.Parameters.AddWithValue("@tcno", textBox2.Text);
                       komut.Parameters.AddWithValue("@isim", textBox3.Text);
                       komut.Parameters.AddWithValue("@soyisim", textBox4.Text);
                       komut.Parameters.AddWithValue("@telefon", textBox5.Text);
                       komut.Parameters.AddWithValue("@adres", textBox6.Text);

                       komut.ExecuteNonQuery();
                       baglanti.Close();
                       MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");

                       kisiGetir();
                       Temizle();
                   }
                   else
                   {
                       MessageBox.Show("İsim formatı uygun değil.");
                   }
                       
                    }
                    else
                    {
                        MessageBox.Show("Tc Kimlik No formatı uygun degil.");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Tc Kimlik No Giriniz.");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + ex.Message);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        void Temizle()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        void kisiGetir()
        {


            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT * FROM musteriler ORDER BY musterino", baglanti);

            SqlDataAdapter adp = new SqlDataAdapter(cmd);

            DataTable dtable = new DataTable();


            adp.Fill(dtable);
            dataGridView1.DataSource = dtable;

            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM musteriler WHERE musterino=@id", baglanti);
                cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);

                if (baglanti.State == ConnectionState.Closed)
                {
                    baglanti.Open();
                }

                cmd.ExecuteNonQuery();

                baglanti.Close();

                kisiGetir();

                MessageBox.Show("Silindi.");
            }
            catch (SqlException)
            {
                MessageBox.Show("Hata olustu!");
            }
        }

        private bool TcKimlikNoKontrol(string tcNo)
        {
            Regex regex = new Regex(@"^[1-9]{1}[0-9]{9}[0,2,4,6,8]{1}$");
            Match match = regex.Match(tcNo);

            if (match.Success)
            {
                return true;
            }

            return false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}


