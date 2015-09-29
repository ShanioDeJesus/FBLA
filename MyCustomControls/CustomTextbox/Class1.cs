using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class CustomTextbox: TextBox
{

    //Set Styles, Visuals and Fonts
    Panel BtmBorder = new Panel();
    public CustomTextbox()
    {
        this.ForeColor = Color.Black;
        this.BackColor = Color.White;
        this.Cursor = Cursors.Hand;
        this.AutoSize = false;
        this.Margin = new Padding(3, 3, 3, 3);
        this.Padding = new Padding(3, 3, 3, 3);
        this.Size = new Size(75, 30);
        BtmBorder.BackColor = Color.Black;
        BtmBorder.Size = new Size(this.Width, 1);
        BtmBorder.Location = new Point(this.Location.X, this.Location.Y + this.Height);
        //this.Move += thisMove;
        //this.Resize += thisResize;
        //this.ForeColorChanged += thisColorChanged;
        this.Paint += thisTextBox_Paint;
        this.Controls.Add(BtmBorder);
    }

    //public void thisResize(object sender, EventArgs e)
    //{
    //    BtmBorder.Size = new Size(this.Width, 1);
    //}
    //public void thisMove(object sender, EventArgs e)
    //{
    //    BtmBorder.Location = new Point(this.Location.X, this.Location.Y + this.Height);
    //}
    //public void thisColorChanged(object sender, EventArgs e)
    //{
    //    BtmBorder.BackColor = this.ForeColor;
    //}
    private void thisTextBox_Paint(object sender, PaintEventArgs e)
    {
        Pen tPen;
        Graphics gLine;

        gLine = e.Graphics;
       this.Font = this.Font;
       this.Height = this.Height - 2;
       this.Width = this.Width;
        tPen = new Pen(Color.DarkGray, 1.0F);
        int cordX1 = this.Location.X;
        int cordX2 = this.Location.X + this.Width;
        int cordY1 = this.Height - 1;
        int cordY2 = this.Height - 1;
        gLine.DrawLine(tPen, cordX1, cordY1, cordX2, cordY2);

    }
}
