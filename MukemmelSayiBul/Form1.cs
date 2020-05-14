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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
                if (textBox1.Text == "ogun" && textBox2.Text == "123456")
                {
                    MessageBox.Show("Giriş işlemi başarılı.");
                    this.Hide();
                    Mukemmel ac = new Mukemmel();
                    ac.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya parola hatalı.");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    }

