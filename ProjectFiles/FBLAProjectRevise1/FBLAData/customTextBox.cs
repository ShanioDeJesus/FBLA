using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLAData
{
  public  class customTextBox : TextBox
    {
        private Button thisBtn;
        public Button associatedButton
        {
            get
            {
                return thisBtn;
            }
            set
            {
                thisBtn = value;
            }
        }
        private Control thisBorder;
        public Control Border
        {
            get
            {
                return thisBorder;
            }
            set
            {
                thisBorder = value;
                setBorder();
            }
        }
        public Form thisForm { get; set; }
        public customTextBox()
        {
            this.BackColor = Color.White;
            this.ForeColor = Color.Black;
            this.BorderStyle = BorderStyle.None;
            this.Font = new Font("Segoe UI", 10);
            this.GotFocus += thisGotFocus;
            this.LostFocus += thisLostFocus;
            this.ParentChanged += thisParentChanged;
            this.Move += thisMove;
            this.Resize += thisResize;
            this.ForeColorChanged += thisForeColorChange;
            this.FontChanged += thisFontChanged;
        }
        private void thisGotFocus(object sender, EventArgs e)
        {
            this.FindForm().AcceptButton = associatedButton;
        }
        private void thisLostFocus(object sender, EventArgs e)
        {
            this.FindForm().AcceptButton = null;
        }
        private void thisFontChanged(object sender, EventArgs e)
        {
            setBorder();
        }
        private void setBorder()
        {
            try
            {
                thisBorder.Location = new Point(this.Location.X, this.Location.Y + this.Height);
                thisBorder.Width = this.Width;
                thisBorder.Height = 1;
                thisBorder.BackColor = this.ForeColor;
                thisBorder.Show();
                thisBorder.BringToFront();
                thisBorder.BackColor = this.ForeColor;
            }
            catch
            {

            }
        }
        private void thisParentChanged(object sender, EventArgs e)
        {

        }
        private void thisMove(object sender, EventArgs e)
        {
            try
            {
                thisBorder.Location = new Point(this.Location.X, this.Location.Y + this.Height);
            }
            catch
            {

            }
        }
        private void thisResize(object sender, EventArgs e)
        {
            try
            {
                thisBorder.Width = this.Width;
                thisBorder.Height = 1;
            }
            catch
            {

            }
        }
        private void thisForeColorChange(object sender, EventArgs e)
        {
            try
            {
                thisBorder.BackColor = this.ForeColor;
            }
            catch
            {

            }
        }
    }
}
