using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLAProject
{
    public partial class editMember : Form
    {
        HomeScreen parForm;
        public editMember(HomeScreen HomeScreenThatOpenThis, string MemberNumber, string First, string Last, string School, string Email, string state, string grade, string year, string active, string owed)
        {
            InitializeComponent();
            parForm = HomeScreenThatOpenThis;
            firstBox.Text = First;
            memIdBox.Text = MemberNumber;
            lastBox.Text = Last;
            schoolBox.Text = School;
            emailBox.Text = Email;
            stateCombo.SelectedItem = state;
            gradeBox.Text = grade;
            yearBox.Text = year;
            oweBox.Text = owed.Replace("$","");
            if (active == "Yes")
            {
                activeMemberCheck.Checked = true;
            }
            else
            {
                activeMemberCheck.Checked = false;
            }

        }
        bool failedtest = false;
        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            failedtest = false;
            //checks if email is valid
            if (CheckValidEmail(emailBox.Text) == false)
            {
                failedtest = true;
                invalidEmail.Show();
            }
            else
            {
                //checks if all fields are complete
                foreach (TextBox t in this.Controls.OfType<TextBox>())
                {
                    if (t.Text == "")
                    {
                        failedtest = true;

                    }
                }
                if (failedtest == true)
                {
                    MessageBox.Show("All fields must be filled!", "");
                }
            }

            //if all required componets are true then create member
            if (failedtest == false)
            {
                string isActive;
                if (activeMemberCheck.Checked == true)
                {
                    isActive = "Yes";
                }
                else
                {
                    isActive = "No";
                }
                parForm.reloadInfo();
                this.Close();
                members.updateMember(memIdBox.Text, firstBox.Text, lastBox.Text, schoolBox.Text, stateCombo.SelectedItem.ToString(), emailBox.Text, yearBox.Text, isActive, "$" + oweBox.Text, gradeBox.Text);
                parForm.reloadInfo();
            }

        }



        private void oweBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void yearBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private bool CheckValidEmail(string Email)
        {
            bool isEmail = Regex.IsMatch(Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (isEmail == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            if (CheckValidEmail(emailBox.Text) == false)
            {
                invalidEmail.Show();
            }
            else
            {
                invalidEmail.Hide();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editMember_Load(object sender, EventArgs e)
        {
            stateCombo.SelectedIndex = 0;
        }

        private void deleteMember_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to delete this member?", "Delete?",MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                members.DeleteMember(memIdBox.Text);
                this.Close();
                parForm.reloadInfo();
            }
        }
    }
}
