using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

public class CustomLabelButton : Label
{
    #region Properties
    //Properties --------------------------------

    public Color mouseovercolor = Color.Blue;
    public Color MouseOverColor
    {
        get
        {
            return mouseovercolor;
        }
        set
        {
            mouseovercolor = value;
        }
    }

    public Color mousedowncolor = Color.Orange;
    public Color MouseDownColor
    {
        get
        {
            return mousedowncolor;
        }
        set
        {
            mousedowncolor = value;
        }
    }

    public Color defaultcolor = Color.Black;
    public Color DefaultForeColor
    {
        get
        {
            return defaultcolor;
            this.ForeColor = defaultcolor;
        }
        set
        {
            defaultcolor = value;
            this.ForeColor = defaultcolor;
        }
    }

    //End Properties-----------------------------
    #endregion


    //Set Styles, Visuals and Fonts
    public CustomLabelButton()
    {
        this.ForeColor = defaultcolor;
        this.BackColor = Color.Transparent;
        this.Cursor = Cursors.Hand;
        this.AutoSize = false;
        this.Margin = new Padding(3, 3, 3, 3);
        this.Padding = new Padding(3, 3, 3, 3);
        this.Size = new Size(75, 30);
        this.TextAlign = ContentAlignment.MiddleCenter;

        this.MouseEnter += mouseOver;
        this.MouseLeave += mouseLeave;
        this.MouseDown += mouseDown;
        this.MouseUp += mouseUp;
        this.LostFocus += lostFocus;
    }

    //Mouse over for label
    private void mouseOver(object sender, EventArgs e)
    {
        this.ForeColor = mouseovercolor;
        down = false;
    }

    //MouseDown for label
    bool down;
    private void mouseDown(object sender, EventArgs e)
    {
        this.ForeColor = mousedowncolor;
        down = true;
    }

    //MouseLeave for label
    private void mouseLeave(object sender, EventArgs e)
    {
        this.ForeColor = defaultcolor;
        down = false;
    }

    //MouseUP for label
    private void mouseUp(object sender, EventArgs e)
    {
        if (down==true)
        {
            this.ForeColor = mouseovercolor;
        }

    }
    private void lostFocus(object sender, EventArgs e)
    {
        this.ForeColor = defaultcolor;
        down = false;
    }

}

