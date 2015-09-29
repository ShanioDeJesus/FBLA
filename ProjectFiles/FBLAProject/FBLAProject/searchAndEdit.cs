using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace FBLAProject
{
    public partial class searchAndEdit : UserControl
    {
        public MainWindow parForm;
        public MainWindow parform
        {
            get
            {
                return parForm;
            }
            set
            {
                parForm = value;
            }
        }
        public searchAndEdit()
        {
            InitializeComponent();
            parform = (MainWindow)ParentForm;
        }
        string searchValue;
        bool findNext = false;
        string searchFor;
        private DataTable backTable = null;
        private DataGridView searchGrid = new DataGridView();
        private void searchList_DoWork(object sender, DoWorkEventArgs e)
        {
            //Check if database is loaded
            if (backTable == null)
            {
                try
                {
                    backTable = loginInformation.thisDatabase();

                }
                catch (Exception ex)
                {
                    backTable = null;
                    MessageBox.Show("Failed to load Database: " + ex.Message);
                }
            }

            //Duplicates databse table and only displays search result
            var tempt = new DataTable();
            tempt = backTable.Copy();
            try
            {
                var d = new List<DataRow>();
                foreach (DataRow row in tempt.Rows)
                {
                    if (row.Field<string>(searchFor).ToLower().Equals(searchValue) == false)
                    {
                        d.Add(row);
                    }

                }
                foreach (DataRow row in d)
                {
                    tempt.Rows.Remove(row);
                }

                e.Result = tempt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to search: " + ex.Message);
            }

        }

        private void searchList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                membersList.DataSource = e.Result;
                membersList.Columns[0].Visible = false;
            }
            catch
            {

            }
            searchBox.Enabled = true;
            membersList.BringToFront();
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (searchList.IsBusy == false)
            {
                //Executes FindNext
                if (e.KeyCode == Keys.Enter)
                {
                    searchBox.Enabled = false;
                    searchFor = searchByCombo.SelectedItem.ToString();
                    searchValue = searchBox.Text.ToLower();
                    searchList.RunWorkerAsync();
                }

            }

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            selectedMember.Hide();
        }

        private void membersList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (membersList.SelectedRows.Count > 0)
                {
                    selectedMember.BringToFront();
                    selectedMember.Show();
                    memIdBox.Text = membersList.SelectedRows[0].Cells["Membership Number"].Value.ToString();
                    firstBox.Text = membersList.SelectedRows[0].Cells["First Name"].Value.ToString();
                    lastBox.Text = membersList.SelectedRows[0].Cells["Last Name"].Value.ToString();
                    schoolBox.Text = membersList.SelectedRows[0].Cells["School"].Value.ToString();
                    emailBox.Text = membersList.SelectedRows[0].Cells["Email"].Value.ToString();
                    stateCombo.SelectedItem = membersList.SelectedRows[0].Cells["State"].Value.ToString();
                    gradeBox.Text = membersList.SelectedRows[0].Cells["Grade"].Value.ToString();
                    yearBox.Text = membersList.SelectedRows[0].Cells["Year Joined"].Value.ToString();
                    oweBox.Text = membersList.SelectedRows[0].Cells["Amount Owed"].Value.ToString();
                    if (membersList.SelectedRows[0].Cells["Active"].Value.ToString() == "Yes")
                    {
                        activeMemberCheck.Checked = true;
                    }
                    else
                    {
                        activeMemberCheck.Checked = false;
                    }
                }
            }
            catch
            {

            }
        }

        private void membersList_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (membersList.SelectedRows.Count > 0)
                {
                    memIdBox.Text = membersList.SelectedRows[0].Cells["Membership Number"].Value.ToString();
                    firstBox.Text = membersList.SelectedRows[0].Cells["First Name"].Value.ToString();
                    lastBox.Text = membersList.SelectedRows[0].Cells["Last Name"].Value.ToString();
                    schoolBox.Text = membersList.SelectedRows[0].Cells["School"].Value.ToString();
                    emailBox.Text = membersList.SelectedRows[0].Cells["Email"].Value.ToString();
                    stateCombo.SelectedItem = membersList.SelectedRows[0].Cells["State"].Value.ToString();
                    gradeBox.Text = membersList.SelectedRows[0].Cells["Grade"].Value.ToString();
                    yearBox.Text = membersList.SelectedRows[0].Cells["Year Joined"].Value.ToString();
                    oweBox.Text = membersList.SelectedRows[0].Cells["Amount Owed"].Value.ToString().Replace("$", "");
                    if (membersList.SelectedRows[0].Cells["Active"].Value.ToString() == "Yes")
                    {
                        activeMemberCheck.Checked = true;
                    }
                    else
                    {
                        activeMemberCheck.Checked = false;
                    }
                }
            }
            catch
            {

            }
        }

        private void memIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstBox_TextChanged(object sender, EventArgs e)
        {
            membersList.SelectedRows[0].Cells["First Name"].Value = firstBox.Text;
            membersList.SelectedRows[0].Cells["Last Name"].Value = lastBox.Text;
            membersList.SelectedRows[0].Cells["School"].Value = schoolBox.Text;
            membersList.SelectedRows[0].Cells["Email"].Value = emailBox.Text;
            membersList.SelectedRows[0].Cells["State"].Value = stateCombo.SelectedItem;
            membersList.SelectedRows[0].Cells["Grade"].Value = gradeBox.Text;
            membersList.SelectedRows[0].Cells["Year Joined"].Value = yearBox.Text;
            membersList.SelectedRows[0].Cells["Amount Owed"].Value = "$" + oweBox.Text;

        }

        private void stateCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            membersList.SelectedRows[0].Cells["State"].Value = stateCombo.SelectedItem;
        }

        private void activeMemberCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (activeMemberCheck.Checked == true)
            {
                membersList.SelectedRows[0].Cells["Active"].Value = "Yes";
            }
            else
            {
                membersList.SelectedRows[0].Cells["Active"].Value = "No";
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
                membersList.SelectedRows[0].Cells["Email"].Value = emailBox.Text;
                invalidEmail.Hide();
            }
        }
        private bool CheckValidEmail(string Email)
        {
            bool isEmail = System.Text.RegularExpressions.Regex.IsMatch(Email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
            if (isEmail == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
            
            }
            catch
            {

            }
        }
    }
}
