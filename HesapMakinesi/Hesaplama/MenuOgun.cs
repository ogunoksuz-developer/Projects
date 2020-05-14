using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesaplamaDll
{
    public class MenuOgun : MenuStrip
    {
        private Font f { get; set; }
        private string n { get; set; }
        private string t { get; set; }
        private Color b { get; set; }


        public MenuOgun CreateMenu(Font font, string name, string text, Color backColor)
        {
            this.f = font;
            this.t = text;
            this.n = "OGUN" + name;
            this.b = backColor;

            MenuOgun menu = new MenuOgun();

            menu.Font = f;
            menu.Text = n;
            menu.Name = t;
            menu.BackColor = b;

            return menu;
        }
    }
}
