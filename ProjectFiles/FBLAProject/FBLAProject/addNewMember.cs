using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FBLAProject
{
    public partial class addNewMember : Form
    {
        HomeScreen parForm;

        public addNewMember(HomeScreen HomeScreenThatOpenThis)
        {
            InitializeComponent();
            parForm = HomeScreenThatOpenThis;
            yearBox.Text = DateTime.Today.Year.ToString();
            foreach (DataRow r in loginInformation.schoolTable.Rows)
            {
                if (r.Field<string>(0).ToLower().Contains(schoolBox.Text.ToLower()))
                {
                    try
                    {
                        schoolBox.AutoCompleteCustomSource.Add(r.Field<string>(0).ToString() + " , " + r.Field<string>(1).ToString() + " , " + r.Field<string>(2).ToString() + " , " + r.Field<string>(3).ToString());
                    }
                    catch
                    {

                    }

                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool failedtest;
        private void addMemberBtn_Click(object sender, EventArgs e)
        {
            failedtest = false;

            //Checks if mem number already exists
            if (members.doesIdExist(memIdBox.Text) == true)
            {
                failedtest = true;
                MessageBox.Show("That membership number already exists", "");

            }
            else
            {
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
                    members.AddMember(memIdBox.Text, firstBox.Text, lastBox.Text, schoolBox.Text, stateCombo.SelectedItem.ToString(), emailBox.Text, Convert.ToInt32(yearBox.Text), isActive, "$" + oweBox.Text, gradeBox.Text);
                    parForm.reloadInfo();
                    this.Close();
                }

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

        private void memIdBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void emailBox_Leave(object sender, EventArgs e)
        {

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
        private void addNewMember_Load(object sender, EventArgs e)
        {
            stateCombo.SelectedIndex = 0;
        }

        //Generate unused id

        private void genNumber_DoWork(object sender, DoWorkEventArgs e)
        {
            var templist = new List<string>();
            try
            {
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=storage.accdb"))
                using (OleDbCommand cmd = new OleDbCommand(" SELECT * from members", conn))
                {
                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            templist.Add(reader["Membership Number"].ToString());
                        }
                    }
                }
                e.Result = Convert.ToInt64(templist.Max()) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while trying to generate number: " + ex.ToString());
                e.Result = "";
            }


        }

        private void genNumber_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            memIdBox.Text = e.Result.ToString();

            genBtn.Enabled = true;
            addMemberBtn.Enabled = true;
        }

        private void genBtn_Click(object sender, EventArgs e)
        {
            genNumber.RunWorkerAsync();
            genBtn.Enabled = false;
            addMemberBtn.Enabled = false;
        }

        private void schoolBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void schoolBox_KeyUp(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode == Keys.Enter)
            //{
            //    if (backgroundWorker1.IsBusy == false)
            //    {
            //      //  listBox1.Items.Clear();
            //        backgroundWorker1.RunWorkerAsync();
            //    }
            //}
        }
    }
}
