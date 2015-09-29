using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Xml.XPath;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace FBLAProject
{

    public partial class HomeScreen : UserControl
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
        public HomeScreen()
        {
            InitializeComponent();
            searchByCombo.SelectedIndex = 0;
            searchOptionsContext.Renderer = new MyRenderer();

        }
        //Change memberList sort by from DoropDown
        private void sortbyCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataGridViewColumn c = membersList.Columns[sortbyCombo.SelectedItem.ToString()];
            membersList.Sort(c, ListSortDirection.Ascending);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string searchValue = searchBox.Text;
            membersList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            membersList.ClearSelection();
            membersList.CurrentCell = null;
            try
            {
                foreach (DataGridViewRow row in membersList.Rows)
                {
                    row.Visible = false;
                    if (row.Cells[0].Value.ToString().Equals(searchValue))
                    {
                        row.Visible = true;
                    }
                }
            }
            catch (Exception exc)
            {

            }

        }



        private void membersList_Sorted(object sender, EventArgs e)
        {
            sortbyCombo.SelectedItem = membersList.SortedColumn.Name;
            sortOrderCombo.SelectedItem = membersList.SortOrder.ToString();
        }

        private void sortOrderCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortOrderCombo.SelectedIndex == 0)
            {

                membersList.Sort(membersList.Columns[sortbyCombo.SelectedItem.ToString()], ListSortDirection.Ascending);
            }
            else
            {

                membersList.Sort(membersList.Columns[sortbyCombo.SelectedItem.ToString()], ListSortDirection.Descending);
            }

        }
        public void reloadInfo()
        {

            schoolBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            if (schoolBox.AutoCompleteCustomSource.Count == 0)
            {
                MessageBox.Show(loginInformation.schoolAuto[0]);
                schoolBox.AutoCompleteCustomSource.AddRange(loginInformation.schoolAuto.ToArray());
            }

            try
            {
                searchBox.Enabled = false;
                totalMembersLabel.Text = "Members: Calculating..";
                membersOwingLabel.Text = "Members owing: Calculating..";
                totalAmtLabel.Text = "Total amount owed: Calculating..";
                activeMembersLabel.Text = "Active members: Calculating..";
                nonActiveMembersLabel.Text = "Non-active members: Calculating..";
                // loadinfo.RunWorkerAsync();
                membersList.DataSource = loginInformation.thisDatabase();
                loaddatainfo.RunWorkerAsync();
                membersList.Columns[0].Visible = false;
                searchBox.Enabled = true;
                membersList.Columns[1].ReadOnly = true;
                //  membersList.Columns["State"].dropd
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while loading data." + ex.Message);
            }

        }




        private void loadinfo_DoWork(object sender, DoWorkEventArgs e)
        {

        }



        private void loadinfo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                sortbyCombo.Enabled = true;
                searchByCombo.Enabled = true;
                sortOrderCombo.Enabled = true;
                sortbyCombo.SelectedIndex = 4;
                sortOrderCombo.SelectedIndex = 0;
                searchBox.Text = "Type search and hit Enter";
                searchBox.Enabled = true;
                membersList.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while loading data." + ex.Message);
            }
        }
        private void loadinfo_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }


        private void customLabelButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Reload list from the database?", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                reloadInfo();
            }
        }

        private void loaddatainfo_DoWork(object sender, DoWorkEventArgs e)
        {
            var listOfString = new List<string>();
            int iamt = 0;
            int iactive = 0;
            int nactive = 0;
            Decimal imemowing = 0;
            int itotalmembers = 0;

            try
            {
                //Read each row and gather info for the footer
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=storage.accdb"))
                using (OleDbCommand cmd = new OleDbCommand(" SELECT * from " + loginInformation.username(), conn))
                {
                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            itotalmembers += 1;
                            if (reader["Active"].ToString() == "Yes")
                            {
                                iactive += 1;
                            }
                            else
                            {
                                nactive += 1;
                            }
                            if (reader["Amount Owed"].ToString() != "$0")
                            {
                                imemowing += Convert.ToDecimal(reader["Amount Owed"].ToString().Replace("$", ""));
                                iamt += 1;
                            }
                        }
                    }
                }
                listOfString.Add("Members: " + itotalmembers.ToString());
                listOfString.Add("Total owed: $" + imemowing.ToString());
                listOfString.Add("Members owing: " + iamt.ToString());
                listOfString.Add("Active members: " + iactive.ToString());
                listOfString.Add("Non-Active members: " + (itotalmembers - iactive).ToString());
                e.Result = listOfString;
            }
            catch (Exception ex)
            {
                e.Result = listOfString;
                MessageBox.Show("An error occured: " + ex.Message);
            }
        }

        private void loaddatainfo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                List<string> listOfString = (List<string>)e.Result;
                totalMembersLabel.Text = listOfString[0];
                membersOwingLabel.Text = listOfString[1];
                totalAmtLabel.Text = listOfString[2];
                activeMembersLabel.Text = listOfString[3];
                nonActiveMembersLabel.Text = listOfString[4];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                totalMembersLabel.Text = "Failed to load data";
                membersOwingLabel.Text = "Failed to load data";
                totalAmtLabel.Text = "Failed to load data";
                activeMembersLabel.Text = "Failed to load data";
                nonActiveMembersLabel.Text = "Failed to load data";
            }

        }
        int previousSearchIndex = 0;
        private void searchList_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                foreach (DataGridViewRow row in membersList.Rows)
                {
                    if (findNext == false)
                    {
                        if (row.Cells[searchFor].Value.ToString().ToLower().Equals(searchValue))
                        {
                            e.Result = row.Index;
                            previousSearchIndex = row.Index;
                            break;
                        }

                    }
                    else
                    {
                        if (row.Cells[searchFor].Value.ToString().ToLower().Equals(searchValue) && row.Index > previousSearchIndex)
                        {
                            e.Result = row.Index;
                            previousSearchIndex = row.Index;
                            break;
                        }

                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }

        private void searchList_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            try
            {
                if (Convert.ToInt64(e.Result) < previousSearchIndex)
                {
                    MessageBox.Show("No more results found.", "");
                    findNext = false;
                }
                DataGridViewRow r = membersList.Rows[Convert.ToInt32(e.Result)];
                r.Selected = true;
                membersList.FirstDisplayedScrollingRowIndex = r.Index;
            }
            catch
            {
                try
                {
                    membersList.ClearSelection();
                    membersList.FirstDisplayedScrollingRowIndex = 0;
                }
                catch
                {

                }
            }
            searchBox.Enabled = true;
            searchBox.Focus();
        }
        string searchValue;
        bool findNext = false;
        string searchFor;
        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {

            if (searchList.IsBusy == false)
            {
                //Executes FindNext
                if (e.KeyCode == Keys.Enter && findNext == true)
                {
                    searchBox.Enabled = false;
                    searchFor = searchByCombo.SelectedItem.ToString();
                    findNext = true;
                    searchValue = searchBox.Text.ToLower();

                    searchList.RunWorkerAsync();
                }

                //Executes find
                if (e.KeyCode == Keys.Enter && findNext == false)
                {
                    searchBox.Enabled = false;
                    searchFor = searchByCombo.SelectedItem.ToString();
                    previousSearchIndex = 0;
                    findNext = false;
                    searchValue = searchBox.Text.ToLower();
                    searchList.RunWorkerAsync();
                    findNext = true;
                }
            }


        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            //Resets find when search was changed
            findNext = false;
        }
        bool isSelected = false;
        private void searchBox_Click(object sender, EventArgs e)
        {
            if (isSelected == true)
            {
                searchBox.DeselectAll();
                isSelected = false;
            }
            else
            {
                searchBox.SelectAll();
                isSelected = true;
            }

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            var cm = new addNewMember(this);
            cm.ShowDialog();
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (membersList.Rows.Count > 0 && membersList.SelectedRows.Count > 0)
            {
                DataGridViewRow r = membersList.SelectedRows[0];
                var cm = new editMember(this, r.Cells[1].Value.ToString(), r.Cells[2].Value.ToString(), r.Cells[3].Value.ToString(), r.Cells[4].Value.ToString(), r.Cells[7].Value.ToString(), r.Cells[6].Value.ToString(), r.Cells[5].Value.ToString(), r.Cells[8].Value.ToString(), r.Cells[9].Value.ToString(), r.Cells[10].Value.ToString());
                cm.ShowDialog();
            }

        }

        //Resizes edit member dropdown so it fits the window
        private void HomeScreen_Resize(object sender, EventArgs e)
        {

        }

        private void infoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            report re = new report(membersList);
            re.Show();
            int i = 0;

        }


        private void customLabelButton1_Click_1(object sender, EventArgs e)
        {
            var c = new addNewMember(this);
            c.Show();
        }

        bool needsaving = false;
        bool failedtest = false;
        int curindex;
        private void membersList_SelectionChanged(object sender, EventArgs e)
        {
            //string isActive;
            //if (activeMemberCheck.Checked == true)
            //{
            //    isActive = "Yes";
            //}
            //else
            //{
            //    isActive = "No";
            //}
            //members.updateMember(memIdBox.Text, firstBox.Text, lastBox.Text, schoolBox.Text, stateCombo.SelectedItem.ToString(), emailBox.Text, yearBox.Text, isActive, "$" + oweBox.Text, gradeBox.Text);

            try
            {

                if (membersList.SelectedRows.Count > 0)
                {
                    curindex = membersList.Rows.IndexOf(membersList.SelectedRows[0]);
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
            catch (Exception ex)
            {

            }
        }

        //    if (activeMemberCheck.Checked == true)
        //    {
        //        isActive = "Yes";
        //    }
        //    else
        //    {
        //        isActive = "No";
        //    }
        //    members.updateMember(memIdBox.Text, firstBox.Text, lastBox.Text, schoolBox.Text, stateCombo.SelectedItem.ToString(), emailBox.Text, yearBox.Text, isActive, "$" + oweBox.Text, gradeBox.Text);
        //   // reloadInfo();
        //    needsaving = false;
        //}

        private void memIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstBox_TextChanged(object sender, EventArgs e)
        {
            try
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
                members.updateMember(memIdBox.Text, firstBox.Text, lastBox.Text, schoolBox.Text, stateCombo.SelectedItem.ToString(), emailBox.Text, yearBox.Text, isActive, "$" + oweBox.Text, gradeBox.Text);
                // reloadInfo();
                needsaving = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Uhhh");
            }

            //if (needsaving == false)
            //{
            //    if (membersList.SelectedRows[0].Cells["First Name"].Value != firstBox.Text ||
            //        membersList.SelectedRows[0].Cells["Last Name"].Value != lastBox.Text ||
            //        membersList.SelectedRows[0].Cells["Email"].Value != emailBox.Text ||
            //        membersList.SelectedRows[0].Cells["School"].Value != schoolBox.Text ||
            //        membersList.SelectedRows[0].Cells["State"].Value != stateCombo.SelectedItem ||
            //        membersList.SelectedRows[0].Cells["Grade"].Value != gradeBox.Text ||
            //        membersList.SelectedRows[0].Cells["Year Joined"].Value != yearBox.Text ||
            //        membersList.SelectedRows[0].Cells["Amount Owed"].Value != "$" + oweBox.Text
            //        )
            //    {
            //        needsaving = true;
            //    }
            //}
            // ;
            //membersList.SelectedRows[0].Cells["First Name"].Value = firstBox.Text;
            //
            //
            //
            //;
            //;
            //membersList.SelectedRows[0].Cells["Year Joined"].Value = yearBox.Text;
            //membersList.SelectedRows[0].Cells["Amount Owed"].Value = "$" + oweBox.Text;
            //membersList.SelectedRows[0].Cells["First Name"].Value = firstBox.Text;
            //membersList.SelectedRows[0].Cells["Last Name"].Value = lastBox.Text;
            //membersList.SelectedRows[0].Cells["School"].Value = schoolBox.Text;
            //membersList.SelectedRows[0].Cells["Email"].Value = emailBox.Text;
            //membersList.SelectedRows[0].Cells["State"].Value = stateCombo.SelectedItem;
            //membersList.SelectedRows[0].Cells["Grade"].Value = gradeBox.Text;
            //membersList.SelectedRows[0].Cells["Year Joined"].Value = yearBox.Text;
            //membersList.SelectedRows[0].Cells["Amount Owed"].Value = "$" + oweBox.Text;
        }

        private void stateCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            membersList.SelectedRows[0].Cells["State"].Value = stateCombo.SelectedItem;
            needsaving = true;
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
            needsaving = true;
        }


        private void addMemberBtn_Click(object sender, EventArgs e)
        {

        }

        private void schoolBox_Leave(object sender, EventArgs e)
        {

        }

        private void HomeScreen_VisibleChanged(object sender, EventArgs e)
        {
            //if (needsaving == true)
            //{
            //    if (membersList.SelectedRows.Count > 0)
            //    {
            //        failedtest = false;
            //        //checks if email is valid
            //        if (CheckValidEmail(emailBox.Text) == false)
            //        {
            //            failedtest = true;
            //            invalidEmail.Show();
            //        }
            //        else
            //        {
            //            //checks if all fields are complete
            //            foreach (TextBox t in this.Controls.OfType<TextBox>())
            //            {
            //                if (t.Text == "")
            //                {
            //                    failedtest = true;

            //                }
            //            }
            //            if (failedtest == true)
            //            {
            //                MessageBox.Show("All fields must be filled!", "");
            //            }
            //        }

            //        //if all required componets are true then create member
            //        if (failedtest == false)
            //        {
            //            string isActive;
            //            if (activeMemberCheck.Checked == true)
            //            {
            //                isActive = "Yes";
            //            }
            //            else
            //            {
            //                isActive = "No";
            //            }
            //            members.updateMember(memIdBox.Text, firstBox.Text, lastBox.Text, schoolBox.Text, stateCombo.SelectedItem.ToString(), emailBox.Text, yearBox.Text, isActive, "$" + oweBox.Text, gradeBox.Text);
            //            reloadInfo();
            //        }

            //    }
            //    needsaving = false;
            //}
        }

        private void emailBox_TextChanged_1(object sender, EventArgs e)
        {
            needsaving = true;
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
    }
}

