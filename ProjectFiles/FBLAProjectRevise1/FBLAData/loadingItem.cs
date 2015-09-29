using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLAData
{
    public class loadingItem : PictureBox
    {
        public Color fcolor = Color.FromArgb(54, 73, 89);
        public Color TextColor
        {
            get
            {
                return fcolor;
            }
            set
            {
                fcolor = value;
            }
        }
        public loadingItem()
        {
            this.Image = FBLAData.Properties.Resources.loading;
            this.SizeMode = PictureBoxSizeMode.CenterImage;
            this.VisibleChanged += visChanged;
            this.Paint += thisPaint;
        }
        public void visChanged(object sender, EventArgs e)
        {
            this.BringToFront();
        }
        public void setText(string t)
        {
            paintText = t;
            this.Invalidate();
        }
        string paintText;
        public void thisPaint(object sender, PaintEventArgs e)
        {
            using (Font myFont = new Font("Segoe UI", 12))
            {
                SolidBrush myBrush;
                myBrush = new SolidBrush(TextColor);
                e.Graphics.DrawString(paintText, myFont, myBrush, new Point((this.Width / 2) - Convert.ToInt32((e.Graphics.MeasureString(paintText, myFont)).Width / 2), this.Height / 2 + this.Image.Height + 1));
            }
        }
    }
}

