using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLAData
{
    class customBorder : Control
    {
        public Control thisForm { get; set; }
        public Panel titleBar { get; set; }
        public Panel topBorder { get; set; }
        public Panel leftBorder { get; set; }
        public Panel rightBorder { get; set; }
        public Panel bottomBorder { get; set; }
        public Label maxrestoreBtn { get; set; }
        public Panel topl { get; set; }
        public Panel topr { get; set; }
        public Panel btml { get; set; }
        public Panel btmr { get; set; }
        Image maxImage { get; set; }
        Image resImage { get; set; }
        public customBorder(Control parent, Panel titlebar, Panel TBorder, Panel lBorder, Panel rBorder, Panel bBorder, Label MaxAndRestoreBtn, Image MaxImage, Image RestoreImage, Panel TopRight, Panel TopLeft, Panel BottomRigh, Panel BottomLeft)
        {

            thisForm = parent;
            leftBorder = lBorder;
            titleBar = titlebar;
            rightBorder = rBorder;
            bottomBorder = bBorder;
            topBorder = TBorder;
            maxrestoreBtn = MaxAndRestoreBtn;
            maxImage = MaxImage;
            resImage = RestoreImage;

            topl = TopLeft;
            topr = TopRight;
            btmr = BottomRigh;
            btml = BottomLeft;

            //config titleBar
            titleBar.MouseDown += allBorderMouseDown;
            titleBar.MouseUp += allBorderMouseUp;
            titleBar.MouseMove += topBarMove;

            //config top
            topBorder.MouseDown += allBorderMouseDown;
            topBorder.MouseUp += allBorderMouseUp;
            topBorder.MouseMove += TopBorderMove;

            //config left
            leftBorder.MouseDown += allBorderMouseDown;
            leftBorder.MouseUp += allBorderMouseUp;
            leftBorder.MouseMove += LeftBorderMove;

            //config right
            rightBorder.MouseDown += allBorderMouseDown;
            rightBorder.MouseUp += allBorderMouseUp;
            rightBorder.MouseMove += RightBorderMove;

            //config bottom
            bottomBorder.MouseDown += allBorderMouseDown;
            bottomBorder.MouseUp += allBorderMouseUp;
            bottomBorder.MouseMove += BottomBorderMove;

            //config bottomleft
            btml.MouseDown += allBorderMouseDown;
            btml.MouseUp += allBorderMouseUp;
            btml.MouseMove += BottomLeftMove;

            //config bottomright
            btmr.MouseDown += allBorderMouseDown;
            btmr.MouseUp += allBorderMouseUp;
            btmr.MouseMove += BottomRightMove;

            //config topleft
            topl.MouseDown += allBorderMouseDown;
            topl.MouseUp += allBorderMouseUp;
            topl.MouseMove += TopLeftMove;

            //config topright
            topr.MouseDown += allBorderMouseDown;
            topr.MouseUp += allBorderMouseUp;
            topr.MouseMove += TopRightMove;
            ////SendBackBorders ORDER MATTERS!!!
            //titleBar.SendToBack();
            //bottomBorder.SendToBack();
            //leftBorder.SendToBack();
            //rightBorder.SendToBack();

            //Assign handlers to buttons
            maxrestoreBtn.Click += MaxOrRestore;

        }
        //Maximize, Restore
        bool maximized = false;
        Point restoreLocation;
        Size restoreSize;
        private void MaxOrRestore(object sender, EventArgs e)
        {
            if (maximized == false)
            {


                restoreSize = thisForm.Size;
                restoreLocation = thisForm.Location;
                Screen[] screens = Screen.AllScreens;
                Screen cur = Screen.FromControl(thisForm);

                thisForm.Location = new Point(cur.WorkingArea.X, cur.WorkingArea.Top);
                thisForm.Width = cur.WorkingArea.Width;
                thisForm.Height = cur.WorkingArea.Height;
                maximized = true;
                maxrestoreBtn.Image = resImage;

                leftBorder.Enabled = false;
                rightBorder.Enabled = false;
                topBorder.Enabled = false;
                bottomBorder.Enabled = false;
            }
            else
            {
                leftBorder.Enabled = true;
                rightBorder.Enabled = true;
                topBorder.Enabled = true;
                bottomBorder.Enabled = true;

                maximized = false;
                maxrestoreBtn.Image = maxImage;
                thisForm.Location = restoreLocation;
                thisForm.Size = restoreSize;
            }

        }

        //Used when user is draggin any border
        private bool isDragging = false;
        private bool isDocked = false;
        private Point mouseDownPoint;
        private void allBorderMouseDown(object sender, MouseEventArgs e)
        {
            mouseDownPoint = e.Location;
            isDragging = true;
        }
        private void allBorderMouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            //Checks witch screen the form is in
            Screen[] screens = Screen.AllScreens;
            Screen cur = Screen.FromControl(thisForm);


            //Dock left when dragged to the left of the screen
            if (Cursor.Position.X <= cur.WorkingArea.Left + 5 && Cursor.Position.X >= cur.WorkingArea.Left && maximized == false)
            {
                isDocked = true;
                restoreSize = thisForm.Size;
                thisForm.Location = new Point(cur.WorkingArea.X, cur.WorkingArea.Top);
                thisForm.Width = cur.WorkingArea.Width / 2;
                thisForm.Height = cur.WorkingArea.Height;
            }

            //Dock right when dragged to the right of the screen
            if (Cursor.Position.X >= cur.WorkingArea.Right - 5 && Cursor.Position.X <= cur.WorkingArea.Right  && maximized == false)
            {
                isDocked = true;
                restoreSize = thisForm.Size;
                thisForm.Location = new Point(cur.WorkingArea.Right - (cur.WorkingArea.Width / 2), cur.WorkingArea.Top);
                thisForm.Width = cur.WorkingArea.Width / 2;
                thisForm.Height = cur.WorkingArea.Height;
            } 
            //Maximize when form is dragged to the top
            if (Cursor.Position.Y <= cur.WorkingArea.Top + 5)
            {
                MaxOrRestore(maxrestoreBtn, null);
            }
        }

        //Move form
        private void topBarMove(object sender, MouseEventArgs e)
        {
            if (isDragging == true)
            {
                if (maximized == true)
                {
                    leftBorder.Enabled = true;
                    rightBorder.Enabled = true;
                    topBorder.Enabled = true;
                    bottomBorder.Enabled = true;
                    //restore form size and position if maximized
                    maximized = false;
                    maxrestoreBtn.Image = maxImage;
                    thisForm.Size = restoreSize;
                    mouseDownPoint.X = thisForm.Width / 2;
                }
                else if (isDocked == true)
                {
                    //restore form size and position if docked
                    isDocked = false;
                    thisForm.Size = restoreSize;
                }
                thisForm.Location = new Point(Cursor.Position.X - mouseDownPoint.X, Cursor.Position.Y - mouseDownPoint.Y);
            }
        }

        //Maximize on Double Click topbar
        private void topBarDblClick(object sender, MouseEventArgs e)
        {
            MaxOrRestore(maxrestoreBtn, null);
        }

        //Resize form with right border
        public void RightBorderMove(object sender, MouseEventArgs e)
        {
            if (isDragging == true)
            {
                thisForm.Width = Cursor.Position.X - thisForm.Location.X;
            }
        }

        //Resize form with bottom border
        public void BottomBorderMove(object sender, MouseEventArgs e)
        {
            if (isDragging == true)
            {
                thisForm.Height = Cursor.Position.Y - thisForm.Location.Y;
            }
        }

        //Resize form with left border
        public void LeftBorderMove(object sender, MouseEventArgs e)
        {
            if (isDragging == true)
            {
                int preFormPosX = thisForm.Location.X;
                thisForm.Location = new Point(Cursor.Position.X, thisForm.Location.Y);
                thisForm.Width = thisForm.Width + preFormPosX - thisForm.Location.X;
            }
        }

        //Resize form with top border
        public void TopBorderMove(object sender, MouseEventArgs e)
        {
            if (isDragging == true)
            {
                int preFormPosY = thisForm.Location.Y;
                thisForm.Location = new Point(thisForm.Location.X, Cursor.Position.Y);
                thisForm.Height = thisForm.Height + preFormPosY - thisForm.Location.Y;
            }
        }

        // Top Left Resize
        public void TopLeftMove(object sender, MouseEventArgs e)
        {
            if (isDragging == true)
            {
                int preFormPosY = thisForm.Location.Y;
                thisForm.Location = new Point(thisForm.Location.X, Cursor.Position.Y);
                thisForm.Height = thisForm.Height + preFormPosY - thisForm.Location.Y;

                int preFormPosX = thisForm.Location.X;
                thisForm.Location = new Point(Cursor.Position.X, thisForm.Location.Y);
                thisForm.Width = thisForm.Width + preFormPosX - thisForm.Location.X;
            }
        }

        // Top Right Resize
        public void TopRightMove(object sender, MouseEventArgs e)
        {
            if (isDragging == true)
            {
                int preFormPosY = thisForm.Location.Y;
                thisForm.Location = new Point(thisForm.Location.X, Cursor.Position.Y);
                thisForm.Height = thisForm.Height + preFormPosY - thisForm.Location.Y;

                thisForm.Width = Cursor.Position.X - thisForm.Location.X;
            }
        }

        // Bottom Left Resize
        public void BottomLeftMove(object sender, MouseEventArgs e)
        {
            if (isDragging == true)
            {
                int preFormPosX = thisForm.Location.X;
                thisForm.Location = new Point(Cursor.Position.X, thisForm.Location.Y);
                thisForm.Width = thisForm.Width + preFormPosX - thisForm.Location.X;

                thisForm.Height = Cursor.Position.Y - thisForm.Location.Y;
            }
        }

        //  Bottom Right Resize
        public void BottomRightMove(object sender, MouseEventArgs e)
        {
            if (isDragging == true)
            {
                thisForm.Width = Cursor.Position.X - thisForm.Location.X;
                thisForm.Height = Cursor.Position.Y - thisForm.Location.Y;
            }
        }
    }
}
