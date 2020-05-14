using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            Bitmap drawBitmap;
            // Bu değişkene pictureBox1in resmini atıyoruz.
            drawBitmap = (Bitmap)pictureBox1.Image;
            // Ve en önemli yer olan resmimizi çevirme kısmı. Biz 90 derece çevirdik ama farklı seçeneklerde var. (270,180 derece vs...)
            drawBitmap.RotateFlip(RotateFlipType.Rotate90FlipXY);
            // Bir üst satırda değişkenimize gönderdiğimiz resmi çevirmiştik, yani pictureBoxımızdaki resmi değil. Bu yüzden alttaki satırı yapmamız gerekiyor.
            pictureBox1.Image = drawBitmap;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            pictureBox1.Left += rd.Next();
            if (pictureBox1.Left > Right)
            {
                timer1.Stop();
                MessageBox.Show("ddsfdsf");
            }
        }
    }
    
}

