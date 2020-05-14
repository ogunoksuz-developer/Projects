using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using System.Data;


namespace HesaplamaDll
{  
    public class AnaMenu
    {
        private static Form Ekran { get; set; }
        public static Button[] Btnlist { get; set; }
        public static int[] OperatorIndex { get; set; }

        public static MenuStrip CreateMenu(Form f)
        {
            Ekran = f;
            
            #region Create Menu
            MenuOgun mm = new MenuOgun();
            
            MenuStrip menu = new MenuStrip();// mm.CreateMenu(new Font("Arial", 12), "desese", "desese", Color.Red);
            menu.Text = "desese";
            menu.Name = "desese";
            menu.BackColor = Color.OrangeRed;
            menu.ForeColor = Color.Black;
            menu.Dock = DockStyle.Top;
            menu.Font = new Font("Arial", 12);

            // Create a Menu Item
            ToolStripMenuItem dosya = new ToolStripMenuItem("File");
            dosya.BackColor = Color.OrangeRed;
            dosya.ForeColor = Color.Black;
            dosya.Text = "dosya";
            dosya.Font = new Font("Arial", 12);
            dosya.TextAlign = ContentAlignment.MiddleCenter;
            dosya.ToolTipText = "Click Me";
           
            ToolStripMenuItem yenile = new ToolStripMenuItem("File2");
            yenile.BackColor = Color.OrangeRed;
            yenile.ForeColor = Color.Black;
            yenile.Text = "yenile";
            yenile.Font = new Font("Georgia", 12);
            yenile.TextAlign = ContentAlignment.BottomRight;
            yenile.ToolTipText = "Click Me";
            yenile.Click += yenile_Click;

            ToolStripMenuItem cikis = new ToolStripMenuItem("File2");
            cikis.BackColor = Color.OrangeRed;
            cikis.ForeColor = Color.Black;
            cikis.Text = "cikis";
            cikis.Font = new Font("Georgia", 12);
            cikis.TextAlign = ContentAlignment.BottomRight;
            cikis.ToolTipText = "Click Me";
            cikis.Click += cikis_Click;
            
            ToolStripMenuItem duzen = new ToolStripMenuItem("File");
            duzen.BackColor = Color.OrangeRed;
            duzen.ForeColor = Color.Black;
            duzen.Text = "duzen";
            duzen.Font = new Font("Arial", 12);
            duzen.TextAlign = ContentAlignment.MiddleCenter;
            duzen.ToolTipText = "Click Me";

            ToolStripMenuItem stil1 = new ToolStripMenuItem("File2");
            stil1.BackColor = Color.OrangeRed;
            stil1.ForeColor = Color.Black;
            stil1.Text = "stil1";
            stil1.Font = new Font("Georgia", 12);
            stil1.TextAlign = ContentAlignment.BottomRight;
            stil1.ToolTipText = "Click Me";
            stil1.Click += stil1_Click;

            ToolStripMenuItem stil2 = new ToolStripMenuItem("File2");
            stil2.BackColor = Color.OrangeRed;
            stil2.ForeColor = Color.Black;
            stil2.Text = "stil2";
            stil2.Font = new Font("Georgia", 12);
            stil2.TextAlign = ContentAlignment.BottomRight;
            stil2.ToolTipText = "Click Me";
            stil2.Click += stil2_Click;


            

            menu.Items.Add(dosya);
            menu.Items.Add(duzen);
            dosya.DropDownItems.Add(yenile);
            dosya.DropDownItems.Add(cikis);
            duzen.DropDownItems.Add(stil1);
            duzen.DropDownItems.Add(stil2);
            #endregion

            return menu;
        }

        static void stil2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < OperatorIndex.Length; i++)
                Btnlist[OperatorIndex[i]].BackColor = Color.Red;
        }

        static void stil1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<OperatorIndex.Length;i++)
            Btnlist[OperatorIndex[i]].BackColor = Color.Purple;
        }

        static void cikis_Click(object sender, EventArgs e)
        {
            Ekran.Close();
        }

        static void yenile_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
