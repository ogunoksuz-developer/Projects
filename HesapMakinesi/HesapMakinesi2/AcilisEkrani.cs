using HesapMakinesi2.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi2
{
    public partial class AcilisEkrani : Form
    {
        private Timer tmr2;

        public AcilisEkrani()
        {
            InitializeComponent();
        }

        private void AcilisEkrani_Load(object sender, EventArgs e)
        {
            #region timerbölümü
             tmr2 = new Timer();
            tmr2.Interval = 1000 * 1/2;
            tmr2.Tick += tmr2_Tick;
            tmr2.Enabled = true;
            #endregion

            #region FormaResimEkleme
            PictureBox rsm = new PictureBox();
            rsm.Name = "pictureBox";
            rsm.Size = new Size(200, 150);
            rsm.Location = new Point(40, 60);
            rsm.Image = Properties.Resources.imperiaflex_0;
            // rsm.ImageLocation =  @"D:\Projeler\HesapMakinesi2\HesapMakinesi2\Resources\imperiaflex-0.jpg";

            this.Controls.Add(rsm);

            #endregion

            lblFormGiris.Text = "HOŞGELDİNİZ";
        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            tmr2.Enabled = false;
            tmr2.Stop();

            this.Hide();
        }
    }
}
