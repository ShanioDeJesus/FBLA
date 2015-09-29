using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
public class CustomFlatButton : Label
{
    #region Properties

    //Properties
    Color buttoncolor = Color.SkyBlue;
    public Color ButtonColor
    {
        get
        {
            return buttoncolor;
        }

        set
        {
            buttoncolor = value;
        }
    }

    //---
    Color buttonovercolor = Color.DarkBlue;
    public Color ButtonOverColor
    {
        get
        {
            return buttonovercolor;
        }

        set
        {
            buttonovercolor = value;
        }
    }

    //---
    Color buttondowncolor = Color.Orange;
    public Color ButtonDownColor
    {
        get
        {
            return buttondowncolor;
        }

        set
        {
            buttondowncolor = value;
        }
    }

    //---
    Color buttonovertextcolor = Color.White;
    public Color ButtonOverTextColor
    {
        get
        {
            return buttonovertextcolor;
        }

        set
        {
            buttonovertextcolor = value;
        }
    }
    //---
    Color buttondowntextcolor = Color.Black;
    public Color ButtonDownTextColor
    {
        get
        {
            return buttondowntextcolor;
        }

        set
        {
            buttondowntextcolor = value;
        }
    }

    Color checkcolor;
    public Color CheckColor
    {
        get
        {
            return checkcolor;
        }

        set
        {
            checkcolor = value;
        }
    }
    Color checkTextcolor;
    public Color CheckTextColor
    {
        get
        {
            return checkTextcolor;
        }

        set
        {
            checkTextcolor = value;
            //Sets the Checked State
            if (check == true)
            {
                this.BackColor = CheckColor;
                this.ForeColor = CheckTextColor;
            }
            else
            {
                this.BackColor = ButtonColor;
                this.ForeColor = DefaultForeColor;
            }
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
    public bool check = false;
    public bool Check
    {
        get
        {
            return check;
        }
        set
        {
            check = value;
            //Sets the Checked State
            if (check == true)
            {
                this.BackColor = CheckColor;
                this.ForeColor = CheckTextColor;
            }
            else
            {
                this.BackColor = ButtonColor;
            }
        }

    }
    #endregion

    public CustomFlatButton()
    {
        this.ForeColor = Color.Black;
        this.BackColor = buttoncolor;
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
        down = false;
        this.ForeColor = buttonovertextcolor;
        this.BackColor = buttonovercolor;
    }

    //MouseDown for label
    bool down;
    private void mouseDown(object sender, EventArgs e)
    {
        this.ForeColor = buttondowntextcolor;
        this.BackColor = buttondowncolor;
        down = true;
    }

    //MouseLeave for label
    private void mouseLeave(object sender, EventArgs e)
    {
        this.ForeColor = defaultcolor;
        this.BackColor = buttoncolor;
        if (check == true)
        {
            this.BackColor = CheckColor;
            this.ForeColor = CheckTextColor;
        }
        down = false;
    }

    //MouseUP for label
    private void mouseUp(object sender, EventArgs e)
    {
        if (down == true)
        {
            this.ForeColor = buttonovertextcolor;
            this.BackColor = ButtonOverColor;
            if (check == true)
            {
                this.BackColor = CheckColor;
                this.ForeColor = CheckTextColor;
            }
        }
    }

    //SetDefaultColor on LostFocus
    private void lostFocus(object sender, EventArgs e)
    {
        this.ForeColor = defaultcolor;
        this.BackColor = buttoncolor;
        if (check == true)
        {
            this.BackColor = CheckColor;
            this.ForeColor = CheckTextColor;
        }
        down = false;
    }
}
