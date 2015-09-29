using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLAData
{
    public partial class CustomMessageBox : Form
    {
        //Generates drop shadow, Only works if user enables

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        //=============================

        public MessageBoxButtons MsgButtons { get; set; }
        public string TitleText { get; set; }
        public string Message { get; set; }
        public CustomMessageBox(string Title, string Msg, MessageBoxButtons Buttons)
        {
            InitializeComponent();
            MsgButtons = Buttons;
            Message = Msg;
            TitleText = Title;
        }


        //When this dialog is shown, set proper text and button visibiltites based on what is set in MsgButtons
        private void CustomMessageBox_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                messagelabel.Text = Message;
                titleLabel.Text = TitleText;
                if (MsgButtons == MessageBoxButtons.OK)
                {
                    btn1.Show();
                    btn1.Text = "Ok";
                }
                if (MsgButtons == MessageBoxButtons.OKCancel)
                {
                    btn2.Show();
                    btn2.Text = "Cancel";
                    btn2.BringToFront();

                    btn1.Show();
                    btn1.Text = "Ok";
                    btn1.BringToFront();
                }
                if (MsgButtons == MessageBoxButtons.YesNo)
                {
                    btn1.Show();
                    btn1.Text = "Yes";
                    btn2.Show();
                    btn2.Text = "No";

                    btn2.BringToFront();
                    btn1.BringToFront();
                }
                if (MsgButtons == MessageBoxButtons.YesNoCancel)
                {
                    btn1.Show();
                    btn1.Text = "Yes";
                    btn2.Show();
                    btn2.Text = "No";
                    btn3.Show();
                    btn3.Text = "Cancel";

                    btn3.BringToFront();
                    btn2.BringToFront();
                    btn1.BringToFront();
                }
            }


        }

        //Returns dialog result based on what is set in MsgButtons and what the button is assigned to
        private void btn1_Click(object sender, EventArgs e)
        {
            if (MsgButtons == MessageBoxButtons.OK)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            if (MsgButtons == MessageBoxButtons.OKCancel)
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            if (MsgButtons == MessageBoxButtons.YesNo)
            {
                DialogResult = DialogResult.Yes;
                this.Close();
            }
            if (MsgButtons == MessageBoxButtons.YesNoCancel)
            {
                DialogResult = DialogResult.Yes;
                this.Close();
            }
        }

        //Returns dialog result based on what is set in MsgButtons and what the button is assigned to
        private void btn2_Click(object sender, EventArgs e)
        {
            if (MsgButtons == MessageBoxButtons.OKCancel)
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
            if (MsgButtons == MessageBoxButtons.YesNo)
            {
                DialogResult = DialogResult.No;
                this.Close();
            }
            if (MsgButtons == MessageBoxButtons.YesNoCancel)
            {
                DialogResult = DialogResult.No;
                this.Close();
            }
        }

        //Returns dialog result based on what is set in MsgButtons and what the button is assigned to
        private void btn3_Click(object sender, EventArgs e)
        {
            if (MsgButtons == MessageBoxButtons.YesNoCancel)
            {
                DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
