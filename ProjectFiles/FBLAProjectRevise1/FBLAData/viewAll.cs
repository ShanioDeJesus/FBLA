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

namespace FBLAData
{
    public partial class viewAll : UserControl
    {
        public DataWindow thisWindow { get; set; }
        public DataSet dataSet { get; set; }
        public viewAll()
        {
            InitializeComponent();
        }
        //Reload Members and Info from databases. Also load chapte info Add schools to Drop Down boxes if neccesary
        private void loadDataTable_DoWork(object sender, DoWorkEventArgs e)
        {

            loadingItem1.setText("Loading members");

            try

            {
                string query = "SELECT * From [members]";
                using (OleDbConnection conn = new OleDbConnection(thisWindow.secureConnectionString))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                    {
                        dataSet = new DataSet();
                        adapter.Fill(dataSet, "mainTable");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("A problem occured while trying to load. Error message: " + ex.Message.ToString(), "");
            }

        }

        private void loadDataTable_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            contentHolder.Enabled = true;
            loadingItem1.Hide();
            this.Enabled = true;
            reloadInfo(false);
        }
        //Reload table and datagridviews
        public void reloadInfo(bool ReloadFromDatabase = false)
        {
            contentHolder.Enabled = false;
            try
            {
                loadingItem1.Show();
                if (ReloadFromDatabase == true)
                {
                    if (loadDataTable.IsBusy == false)
                    { loadDataTable.RunWorkerAsync(); }

                }
                else
                {
                    if (loaddatainfo.IsBusy == false)
                    {
                        loaddatainfo.RunWorkerAsync();
                    }

                    membersList.DataSource = null;
                    membersList.DataSource = dataSet.Tables[0];
                    if (thisWindow.CurrentChapter == 0)
                    {
                        (membersList.DataSource as DataTable).DefaultView.RowFilter = null;
                    }
                    else
                    {
                        (membersList.DataSource as DataTable).DefaultView.RowFilter = string.Format("[Chapter Number] = '{0}'", thisWindow.CurrentChapter);

                    }
                    sortByBox.Items.Clear();
                    viewCheckBox.Items.Clear();
                    viewCheckBox.CheckOnClick = true;
                    searchByBox.Items.Clear();
                    foreach (DataGridViewColumn c in membersList.Columns)
                    {
                        sortByBox.Items.Add(c.HeaderText);
                        viewCheckBox.Items.Add(c.HeaderText);
                        viewCheckBox.SetItemChecked(c.Index, true);
                        searchByBox.Items.Add(c.HeaderText);
                    }
                    sortByBox.SelectedIndex = 0;
                    orderByBox.SelectedIndex = 0;
                    searchByBox.SelectedIndex = 0;
                    loadingItem1.Hide();
                    contentHolder.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                loadingItem1.Hide();
                MessageBox.Show("Failed to load. Error message: " + ex.Message);
            }

        }

        //Resize right Panel
        bool isResizeingRightPanel = false;
        int RightPanelMouseDownX;
        private void resizeMemberInfo_MouseDown(object sender, MouseEventArgs e)
        {
            isResizeingRightPanel = true;
            RightPanelMouseDownX = e.X;
        }

        private void resizeMemberInfo_MouseUp(object sender, MouseEventArgs e)
        {
            isResizeingRightPanel = false;
        }
        private void resizeMemberInfo_MouseMove(object sender, MouseEventArgs e)
        {
            if (isResizeingRightPanel == true)
            {
                //  editMemberPanel.Width = (this.Width - Cursor.Position.X) - this.Location.X;
                editMemberPanel.Width = MousePosition.X - thisWindow.Location.X;
            }
        }

        //========
        //View Checked changed 
        private void viewCheckBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            try
            {
                if (e.CurrentValue == CheckState.Unchecked)
                {
                    membersList.Columns[viewCheckBox.Items[e.Index].ToString()].Visible = true;
                }
                else
                {
                    membersList.Columns[viewCheckBox.Items[e.Index].ToString()].Visible = false;
                }
            }
            catch
            {

            }
        }
        //=========
        //Sorting list
        private void sortByBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderByBox.SelectedIndex == 0)
            {

                membersList.Sort(membersList.Columns[sortByBox.SelectedItem.ToString()], ListSortDirection.Ascending);
            }
            else
            {

                membersList.Sort(membersList.Columns[sortByBox.SelectedItem.ToString()], ListSortDirection.Descending);
            }
        }

        private void orderByBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderByBox.SelectedIndex == 0)
            {

                membersList.Sort(membersList.Columns[sortByBox.SelectedItem.ToString()], ListSortDirection.Ascending);
            }
            else
            {

                membersList.Sort(membersList.Columns[sortByBox.SelectedItem.ToString()], ListSortDirection.Descending);
            }
        }

        private void membersList_Sorted(object sender, EventArgs e)
        {
            sortByBox.SelectedItem = membersList.SortedColumn.Name;
            orderByBox.SelectedItem = membersList.SortOrder.ToString();
        }
        //==========
        //Search
        #region search members
        int previousSearchIndex = 0;
        private void searchList_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                foreach (DataGridViewRow row in membersList.Rows)
                {
                    if (exactMatchCheck.Checked == true)
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
                    else
                    {
                        if (findNext == false)
                        {
                            if (row.Cells[searchFor].Value.ToString().ToLower().Contains(searchValue))
                            {
                                e.Result = row.Index;
                                previousSearchIndex = row.Index;
                                break;
                            }

                        }
                        else
                        {
                            if (row.Cells[searchFor].Value.ToString().ToLower().Contains(searchValue) && row.Index > previousSearchIndex)
                            {
                                e.Result = row.Index;
                                previousSearchIndex = row.Index;
                                break;
                            }

                        }
                    }

                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
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
                if (r.Index > 0)
                {
                    membersList.FirstDisplayedScrollingRowIndex = r.Index - 1;
                }
                else
                {
                    membersList.FirstDisplayedScrollingRowIndex = r.Index;
                }

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
                    searchFor = searchByBox.SelectedItem.ToString();
                    findNext = true;
                    searchValue = searchBox.Text.ToLower();

                    searchList.RunWorkerAsync();
                }

                //Executes find
                if (e.KeyCode == Keys.Enter && findNext == false)
                {
                    searchBox.Enabled = false;
                    searchFor = searchByBox.SelectedItem.ToString();
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
        #endregion
        //=========
        #region loadFooterInfo
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
                using (OleDbConnection conn = new OleDbConnection(thisWindow.secureConnectionString))
                using (OleDbCommand cmd = new OleDbCommand("SELECT * from members", conn))
                {
                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            itotalmembers += 1;
                            if (reader["Amount Owed"] != null && Convert.ToBoolean(reader["Active"]) == true)
                            {
                                iactive += 1;
                            }
                            else
                            {
                                nactive += 1;
                            }
                            if (reader["Amount Owed"] != null && reader["Amount Owed"].ToString() != "$0")
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
        #endregion
        private void button1_Click(object sender, EventArgs e)
        {
            SaveDataBase();
        }
        public void SaveDataBase()
        {
            membersList.EndEdit();
            membersList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            loadingItem1.Show();
            loadingItem1.setText("Saving");
            contentHolder.Enabled = false;
            if (saveChanges.IsBusy == false)
            {
                saveChanges.RunWorkerAsync();
            }

        }
        private void saveChanges_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                string selectStatement = "SELECT * From [members];";
                OleDbConnection conn = new OleDbConnection(thisWindow.secureConnectionString);
                conn.Open();
                OleDbDataAdapter OleDbDa = new OleDbDataAdapter();
                OleDbDa.SelectCommand = new OleDbCommand(selectStatement, conn);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(OleDbDa);
                cb.QuotePrefix = "[";
                cb.QuoteSuffix = "]";
                OleDbDa.InsertCommand = cb.GetInsertCommand();
                OleDbDa.DeleteCommand = cb.GetDeleteCommand();
                OleDbDa.UpdateCommand = cb.GetUpdateCommand();
                OleDbDa.Update(dataSet, "mainTable");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while trying to save. Message: " + ex.Message);
            }


        }

        private void saveChanges_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            contentHolder.Enabled = true;
            loadingItem1.Hide();
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {

        }

        private void saveChangesBtn_Click(object sender, EventArgs e)
        {
          SaveDataBase();
        }

        private void refreshDBBtn_Click(object sender, EventArgs e)
        {
            reloadInfo(true);
        }

        private void editMemberPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this member?","",MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                membersList.Rows.Remove(membersList.SelectedRows[0]);
            }

        }

        private void viewAll_Load(object sender, EventArgs e)
        {

        }



        //===========
    }
}
