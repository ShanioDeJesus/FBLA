using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLAData
{
    public partial class CustomFlatBox : UserControl
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
        private Color borderColor;
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                Topborder.BackColor = borderColor;
                BottomBorder.BackColor = borderColor;
                LeftBorder.BackColor = borderColor;
                RightBorder.BackColor = borderColor;
            }
        }
        public CustomFlatBox()
        {
            InitializeComponent();
            ThisTextBox = TextBox;
            this.GotFocus += thisGotFocus;
            this.LostFocus += thisLostFocus;
            Topborder.BackColor = TextBox.ForeColor;
            BottomBorder.BackColor = TextBox.ForeColor;
            LeftBorder.BackColor = TextBox.ForeColor;
            RightBorder.BackColor = TextBox.ForeColor;
        }
        public TextBox ThisTextBox { get; set; }
        private void CustomFlatBox_BackColorChanged(object sender, EventArgs e)
        {
          TextBox.BackColor = this.BackColor;
        }

        private void TextBox_ForeColorChanged(object sender, EventArgs e)
        {

        }
        private void thisGotFocus(object sender, EventArgs e)
        {
            this.FindForm().AcceptButton = associatedButton;
        }
        private void thisLostFocus(object sender, EventArgs e)
        {
            this.FindForm().AcceptButton = null;
        }

        private void TextBox_BackColorChanged(object sender, EventArgs e)
        {
       
        }

        private void CustomFlatBox_Click(object sender, EventArgs e)
        {
            TextBox.Focus();
        }

        private void CustomFlatBox_ForeColorChanged(object sender, EventArgs e)
        {
            TextBox.ForeColor = this.ForeColor;
        }
    }
}
