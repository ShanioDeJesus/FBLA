using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLAProject
{

    class theme
    {
        public static Color ForeColor;
        public static Color BackColor;
        public static Color HoverColor;
        public static Color DownColor;
        public static void setTheme(Color TextColor, Color Back, Color Hover, Color Down)
        {
            ForeColor = TextColor;
            BackColor = Back;
            HoverColor = Hover;
            DownColor = Down;
        }
    }
}
