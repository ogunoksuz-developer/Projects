using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Windows.Forms;

using System.Data.SqlClient;

using System.IO;

namespace deneme1rsm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string resimPath;
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Resim Aç";

            openFileDialog1.Filter = "Jpeg Dosyası (*.jpg)|*.jpg|Gif Dosyası (*.gif)|*.gif|Png Dosyası (*.png)|*.png|Tif Dosyası (*.tif)|*.tif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)

            {

                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

                resimPath = openFileDialog1.FileName.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Resimimizi FileStream metoduyla okuma modunda açıyoruz.

            FileStream fs = new FileStream(resimPath, FileMode.Open, FileAccess.Read);

            //BinaryReader ile byte dizisi ile FileStream arasında veri akışı sağlanıyor.

            BinaryReader br = new BinaryReader(fs);

            /*ReadBytes ile FileStreamde belirtilen resim dosyasındaki byte lar
             
            byte dizisine aktarılıyor.
             
            */

            byte[] resim = br.ReadBytes((int)fs.Length);//www.gorselprogramlama.com

            br.Close();

            fs.Close();

            //Sql Veritabanı ve Kayıt işlemleri

            SqlConnection bag = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=data;Integrated Security=True");

            SqlCommand kmt = new SqlCommand("insert into resimbil(resim) Values (@image) ", bag);

            kmt.Parameters.Add("@image", SqlDbType.Image, resim.Length).Value = resim;//www.gorselprogramlama.com

            try

            {

                bag.Open();//www.gorselprogramlama.com

                kmt.ExecuteNonQuery();

                MessageBox.Show(" Veritabanına kayıt yapıldı.");

            }

            catch (Exception ex)//www.gorselprogramlama.com

            {

                MessageBox.Show(ex.Message.ToString());

            }

            finally

            {

                bag.Close();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
