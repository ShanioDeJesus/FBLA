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
    public partial class addMembers : UserControl
    {
        public DataWindow thisWindow { get; set; }
        public addMembers()
        {
            InitializeComponent();

        }
        public void reloadInfo()
        {
            if (thisWindow.CurrentChapter != 0)
            {
                importLocationLabel.Text = "These members will be imported into this chapter: " + thisWindow.CurrentChapter + "\n If you want to import these members into their respected chapter numbers, set the chapter view to View All in Menu > Select chapter.";
            }
            else
            {
                importLocationLabel.Text = "These members will be imported into their respected chapters.";

            }
        }

        private void browseFileBtn_Click(object sender, EventArgs e)
        {
            browseFile.ShowDialog();
        }

        private void browseFile_FileOk(object sender, CancelEventArgs e)
        {
            filesSelectBox.Text = browseFile.FileName;
            loading.Show();
            loading.setText("Loading file");
            if (importWorker.IsBusy == false)
            {
                importWorker.RunWorkerAsync();
            }
        }
       
        private void importBtn_Click(object sender, EventArgs e)
        {
            //To clear the whole database, require admin password
            DialogResult result = new DialogResult();
            if (overAndAppend.Checked == true)
            {
                             result = new CustomMessageBox("Continue?", "ANY EXISTING MEMBERS WITH MATCHING MEMBERSHIP NUMBERS WILL BE OVERWRITTEN REGARDLESS THEIR CHAPTER NUMBER. CONTINUE?", MessageBoxButtons.YesNo).ShowDialog();
            }
            if (addAllnew.Checked == true)
            {
                result = new CustomMessageBox("Continue?", "ALL MEMBERS WILL BE ASSIGNED NEW MEMBERSHIP NUMBERS. CONTINUE?", MessageBoxButtons.YesNo).ShowDialog();
            }
    
            if (result == DialogResult.Yes)
            {
                loading.Show();
                loading.setText("Importing");
                addMemberDataViewList.EndEdit(DataGridViewDataErrorContexts.Commit);
                addMemberDataViewList.CommitEdit(DataGridViewDataErrorContexts.Commit);
                if (addToDbWorker.IsBusy == false)
                {
                    addToDbWorker.RunWorkerAsync();
                }
            }

        }

        private List<string> sheets;
        private DataSet dataSet { get; set; }
        private void importWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                sheets = new List<string>();
                dataSet = new DataSet();
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + filesSelectBox.Text + "';Extended Properties='Excel 12.0 Xml;HDR=YES;'");

                con.Open();
                DataTable MySchemaTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new Object[] { null, null, null, "TABLE" });

                for (int i = 0; i < MySchemaTable.Rows.Count; i++)
                {
                    sheets.Add(MySchemaTable.Rows[i].ItemArray[2].ToString());
                }

                dataSet = new DataSet();
                dataSet.Tables.Add(new DataTable("main"));
                foreach (DataColumn c in thisWindow.viewAllMembers.dataSet.Tables["mainTable"].Columns)
                {
                    dataSet.Tables["main"].Columns.Add(c.ColumnName, c.DataType);
                }
                OleDbCommand command = con.CreateCommand();
                foreach (string l in sheets)
                {
                    string query = "SELECT * From [" + l + "]";

                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, con))
                    {
                        var dt = new DataTable();
                        adapter.Fill(dt);
                        dataSet.Tables["main"].Merge(dt, true, MissingSchemaAction.Ignore);
                    }
                }
                con.Close();
                e.Result = true;
            }
            catch (Exception ex)
            {
                e.Result = false;
                MessageBox.Show("An error occured while trying to load the file. Message: " + ex.Message);
            }

        }

        private void importWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            addMemberDataViewList.DataSource = dataSet.Tables["main"];
            importBtn.Enabled = Convert.ToBoolean(e.Result);
            loading.Hide();
        }

        private void addToDbWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //There are thrree methods when importing
            //WE can overwrite existing and add any new ones, we can overwrite all data or add all data as new


            //This is used to replace existing data 
            string StrQuery;
            bool addToCurrentChapter;

            //Used to check if the members will be inserted to the selected chapter or to their own assigned chapters
            if (thisWindow.CurrentChapter != 0)
            {
                addToCurrentChapter = true;
            }
            else
            {
                addToCurrentChapter = false;
            }
            //Import using respective chapter or current chapter chapter
            if (addToCurrentChapter == false)
            {
                if (overAndAppend.Checked == true)
                {
                    try
                    {
                        int count;
                        for (int i = 0; i < dataSet.Tables["main"].Rows.Count; i++)
                        {
                            using (OleDbConnection conn = new OleDbConnection(thisWindow.secureConnectionString))
                            {
                                using (OleDbCommand cmd = new OleDbCommand())
                                {
                                    cmd.Connection = conn;
                                    conn.Open();
                                    string cmdStr = "Select count(*) from members where [Membership Number] = " + addMemberDataViewList.Rows[i].Cells["Membership Number"].Value + ";";

                                    OleDbCommand checkCmd = new OleDbCommand(cmdStr, conn);

                                    count = (int)checkCmd.ExecuteScalar();
                                    conn.Close();
                                }

                            }

                            if (count > 0)
                            {
                                using (OleDbConnection conn = new OleDbConnection(thisWindow.secureConnectionString))
                                {
                                    using (OleDbCommand cmd = new OleDbCommand())
                                    {
                                        cmd.Connection = conn;
                                        conn.Open();
                                        StrQuery = @"Update members SET [Chapter Number] = @cn,[First Name] = @fn, [Last Name] = @ln,[School] = @sch, [Grade] = @gr, [State] = @st, [Email] = @em, [Year Joined] = @yr,[Active] = @act,[Amount Owed] = @amt WHERE [Membership Number] = " + addMemberDataViewList.Rows[i].Cells["Membership Number"].Value + ";";


                                        cmd.Parameters.AddWithValue("@cn", addMemberDataViewList.Rows[i].Cells["Chapter Number"].Value);
                                        //+ addMemberDataViewList.Rows[i].Cells["Membership Number"].Value + "', '"
                                        cmd.Parameters.AddWithValue("@fn", addMemberDataViewList.Rows[i].Cells["First Name"].Value);
                                        cmd.Parameters.AddWithValue("@ln", addMemberDataViewList.Rows[i].Cells["Last Name"].Value);
                                        cmd.Parameters.AddWithValue("@sch", addMemberDataViewList.Rows[i].Cells["School"].Value);
                                        cmd.Parameters.AddWithValue("@gr", addMemberDataViewList.Rows[i].Cells["Grade"].Value);
                                        cmd.Parameters.AddWithValue("@st", addMemberDataViewList.Rows[i].Cells["State"].Value);
                                        cmd.Parameters.AddWithValue("@em", addMemberDataViewList.Rows[i].Cells["Email"].Value);
                                        cmd.Parameters.AddWithValue("@yr", addMemberDataViewList.Rows[i].Cells["Year Joined"].Value);
                                        cmd.Parameters.AddWithValue("@act", Convert.ToBoolean(addMemberDataViewList.Rows[i].Cells["Active"].Value));
                                        cmd.Parameters.AddWithValue("@amt", addMemberDataViewList.Rows[i].Cells["Amount Owed"].Value);

                                        cmd.CommandText = StrQuery;
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                    }
                                }
                            }
                            else
                            {
                                using (OleDbConnection conn = new OleDbConnection(thisWindow.secureConnectionString))
                                {
                                    using (OleDbCommand cmd = new OleDbCommand())
                                    {
                                        cmd.Connection = conn;
                                        conn.Open();
                                        //If Data Does not exist, add it
                                        StrQuery = @"INSERT INTO members([Chapter Number], [Membership Number], [First Name], [Last Name], [School], [Grade], [State], [Email], [Year Joined], [Active], [Amount Owed]) VALUES ('"
                                            + addMemberDataViewList.Rows[i].Cells["Chapter Number"].Value + "', '"
                                            + addMemberDataViewList.Rows[i].Cells["Membership Number"].Value + "', '"
                                            + addMemberDataViewList.Rows[i].Cells["First Name"].Value + "', '"
                                            + addMemberDataViewList.Rows[i].Cells["Last Name"].Value + "', '"
                                            + addMemberDataViewList.Rows[i].Cells["School"].Value + "', '"
                                            + addMemberDataViewList.Rows[i].Cells["Grade"].Value + "', '"
                                            + addMemberDataViewList.Rows[i].Cells["State"].Value + "', '"
                                            + addMemberDataViewList.Rows[i].Cells["Email"].Value + "', '"
                                            + addMemberDataViewList.Rows[i].Cells["Year Joined"].Value + "', "
                                            + addMemberDataViewList.Rows[i].Cells["Active"].Value + ", '"
                                            + addMemberDataViewList.Rows[i].Cells["Amount Owed"].Value + "');";
                                        cmd.CommandText = StrQuery;
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                    }
                                }
                            }
                        }
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("An error occured while trying to import data in part 1. Message: " + ex.Message);
                    }
                }

                //End Replace and appends


                //Start Append Data As New
                //This import all data as new ones. ignores membership number and assigns new ones.

                if (addAllnew.Checked == true)
                {
                    try
                    {
                        for (int i = 0; i < dataSet.Tables["main"].Rows.Count; i++)
                        {
                            using (OleDbConnection conn = new OleDbConnection(thisWindow.secureConnectionString))
                            {
                                using (OleDbCommand cmd = new OleDbCommand())
                                {
                                    cmd.Connection = conn;
                                    conn.Open();
                                    //If Data Does not exist, add it
                                    StrQuery = @"INSERT INTO members([Chapter Number],[First Name], [Last Name], [School], [Grade], [State], [Email], [Year Joined], [Active], [Amount Owed]) VALUES ('"
                                        + addMemberDataViewList.Rows[i].Cells["Chapter Number"].Value + "', '"
                                        + addMemberDataViewList.Rows[i].Cells["First Name"].Value + "', '"
                                        + addMemberDataViewList.Rows[i].Cells["Last Name"].Value + "', '"
                                        + addMemberDataViewList.Rows[i].Cells["School"].Value + "', '"
                                        + addMemberDataViewList.Rows[i].Cells["Grade"].Value + "', '"
                                        + addMemberDataViewList.Rows[i].Cells["State"].Value + "', '"
                                        + addMemberDataViewList.Rows[i].Cells["Email"].Value + "', '"
                                        + addMemberDataViewList.Rows[i].Cells["Year Joined"].Value + "', "
                                        + addMemberDataViewList.Rows[i].Cells["Active"].Value + ", '"
                                        + addMemberDataViewList.Rows[i].Cells["Amount Owed"].Value + "');";
                                    cmd.CommandText = StrQuery;
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured while trying to import data  in part 2. Message: " + ex.Message);
                    }

                }
                //End add as new

               
                //Import to current chapter==================================================================
            }
            else
            {
                if (overAndAppend.Checked == true)
                {
                    try
                    {
                        int count;
                        for (int i = 0; i < dataSet.Tables["main"].Rows.Count; i++)
                        {
                            using (OleDbConnection conn = new OleDbConnection(thisWindow.secureConnectionString))
                            {
                                using (OleDbCommand cmd = new OleDbCommand())
                                {
                                    cmd.Connection = conn;
                                    conn.Open();
                                    string cmdStr = "Select count(*) from members where [Membership Number] = " + addMemberDataViewList.Rows[i].Cells["Membership Number"].Value + ";";

                                    OleDbCommand checkCmd = new OleDbCommand(cmdStr, conn);

                                    count = (int)checkCmd.ExecuteScalar();
                                    conn.Close();
                                }

                            }

                            if (count > 0)
                            {
                                using (OleDbConnection conn = new OleDbConnection(thisWindow.secureConnectionString))
                                {
                                    using (OleDbCommand cmd = new OleDbCommand())
                                    {
                                        cmd.Connection = conn;
                                        conn.Open();
                                        StrQuery = @"Update members SET [Chapter Number] = @cn,[First Name] = @fn, [Last Name] = @ln,[School] = @sch, [Grade] = @gr, [State] = @st, [Email] = @em, [Year Joined] = @yr,[Active] = @act,[Amount Owed] = @amt WHERE [Membership Number] = " + addMemberDataViewList.Rows[i].Cells["Membership Number"].Value + ";";


                                        cmd.Parameters.AddWithValue("@cn", thisWindow.CurrentChapter);
                                        cmd.Parameters.AddWithValue("@fn", addMemberDataViewList.Rows[i].Cells["First Name"].Value);
                                        cmd.Parameters.AddWithValue("@ln", addMemberDataViewList.Rows[i].Cells["Last Name"].Value);
                                        cmd.Parameters.AddWithValue("@sch", addMemberDataViewList.Rows[i].Cells["School"].Value);
                                        cmd.Parameters.AddWithValue("@gr", addMemberDataViewList.Rows[i].Cells["Grade"].Value);
                                        cmd.Parameters.AddWithValue("@st", addMemberDataViewList.Rows[i].Cells["State"].Value);
                                        cmd.Parameters.AddWithValue("@em", addMemberDataViewList.Rows[i].Cells["Email"].Value);
                                        cmd.Parameters.AddWithValue("@yr", addMemberDataViewList.Rows[i].Cells["Year Joined"].Value);
                                        cmd.Parameters.AddWithValue("@act", Convert.ToBoolean(addMemberDataViewList.Rows[i].Cells["Active"].Value));
                                        cmd.Parameters.AddWithValue("@amt", addMemberDataViewList.Rows[i].Cells["Amount Owed"].Value);

                                        cmd.CommandText = StrQuery;
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                    }
                                }
                            }
                            else
                            {
                                using (OleDbConnection conn = new OleDbConnection(thisWindow.secureConnectionString))
                                {
                                    using (OleDbCommand cmd = new OleDbCommand())
                                    {
                                        cmd.Connection = conn;
                                        conn.Open();
                                        //If Data Does not exist, add it
                                        StrQuery = @"INSERT INTO members([Chapter Number], [Membership Number], [First Name], [Last Name], [School], [Grade], [State], [Email], [Year Joined], [Active], [Amount Owed]) VALUES ('"
                                            + thisWindow.CurrentChapter + "', '"
                                            + addMemberDataViewList.Rows[i].Cells["Membership Number"].Value + "', '"
                                            + addMemberDataViewList.Rows[i].Cells["First Name"].Value + "', '"
                                            + addMemberDataViewList.Rows[i].Cells["Last Name"].Value + "', '"
                                            + addMemberDataViewList.Rows[i].Cells["School"].Value + "', '"
                                            + addMemberDataViewList.Rows[i].Cells["Grade"].Value + "', '"
                                            + addMemberDataViewList.Rows[i].Cells["State"].Value + "', '"
                                            + addMemberDataViewList.Rows[i].Cells["Email"].Value + "', '"
                                            + addMemberDataViewList.Rows[i].Cells["Year Joined"].Value + "', "
                                            + addMemberDataViewList.Rows[i].Cells["Active"].Value + ", '"
                                            + addMemberDataViewList.Rows[i].Cells["Amount Owed"].Value + "');";
                                        cmd.CommandText = StrQuery;
                                        cmd.ExecuteNonQuery();
                                        conn.Close();
                                    }
                                }
                            }
                        }
                    }
                    catch (OleDbException ex)
                    {
                        MessageBox.Show("An error occured while trying to import data  in part 3. Message: " + ex.Message);
                    }
                }

                //End Replace and appends


                //Start Append Data As New
                //This import all data as new ones. ignores membership number and assigns new ones.

                if (addAllnew.Checked == true)
                {
                    try
                    {
                        for (int i = 0; i < dataSet.Tables["main"].Rows.Count; i++)
                        {
                            using (OleDbConnection conn = new OleDbConnection(thisWindow.secureConnectionString))
                            {
                                using (OleDbCommand cmd = new OleDbCommand())
                                {
                                    cmd.Connection = conn;
                                    conn.Open();
                                    //If Data Does not exist, add it
                                    StrQuery = @"INSERT INTO members([Chapter Number],[First Name], [Last Name], [School], [Grade], [State], [Email], [Year Joined], [Active], [Amount Owed]) VALUES ('"
                                        + thisWindow.CurrentChapter + "', '"
                                        + addMemberDataViewList.Rows[i].Cells["First Name"].Value + "', '"
                                        + addMemberDataViewList.Rows[i].Cells["Last Name"].Value + "', '"
                                        + addMemberDataViewList.Rows[i].Cells["School"].Value + "', '"
                                        + addMemberDataViewList.Rows[i].Cells["Grade"].Value + "', '"
                                        + addMemberDataViewList.Rows[i].Cells["State"].Value + "', '"
                                        + addMemberDataViewList.Rows[i].Cells["Email"].Value + "', '"
                                        + addMemberDataViewList.Rows[i].Cells["Year Joined"].Value + "', "
                                        + addMemberDataViewList.Rows[i].Cells["Active"].Value + ", '"
                                        + addMemberDataViewList.Rows[i].Cells["Amount Owed"].Value + "');";
                                    cmd.CommandText = StrQuery;
                                    cmd.ExecuteNonQuery();
                                    conn.Close();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occured while trying to import data in part 4. Message: " + ex.Message);
                    }

                }
                //End add as new

               
            }


        }

        private void addToDbWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            addMemberDataViewList.DataSource = null;
            filesSelectBox.Clear();
            importBtn.Enabled = false;
            thisWindow.setTab(thisWindow.viewAllMembers, thisWindow.thisMenu.viewAllBtn);
            loading.Hide();
            thisWindow.viewAllMembers.reloadInfo(true);
        }

    }
}
