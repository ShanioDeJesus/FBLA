using FBLAProject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public class MyRenderer : ToolStripProfessionalRenderer
{
    // the width of image icons
    protected int iconwidth = 22;
    protected int paddingIconToText = 3;
    protected int paddingTextToShortCut = 20;
    protected int paddingShortCutToBoarder = 20;
    private enum TextType
    {
        Text = 0,
        Shortcut = 1
    }
    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
    {
        try
        {
            Color bc = theme.BackColor;
            if (((ToolStripMenuItem)e.Item).Checked == true)
            {
               bc= theme.HoverColor;
            }
            else
            {
               bc = theme.BackColor;
            }
            e.Item.ForeColor = theme.ForeColor;
            e.ToolStrip.BackColor = theme.BackColor;
            Rectangle rc = new Rectangle(Point.Empty, e.Item.Size);
            Color c = (Color)(e.Item.Selected ? theme.HoverColor : bc);
            using (SolidBrush brush = new SolidBrush(c))
            {
                e.Graphics.FillRectangle(brush, rc);
            }

          
        }
        catch (Exception ex)
        {
        }

    }

}
