using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLAData
{
    public partial class signInForm : Form
    {
        public List<string> Usernames { get; set; }
        public List<int> chapters { get; set; }
        public signInForm()
        {
            InitializeComponent();
            loading.Show();
            beginLoad.RunWorkerAsync();
        }
        //1 = failed username, 2 = failed password, 3 = all good, 4 = Exception
        int errorCode = 0;
        private void checkLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            loading.setText("Signing in");
            try
            {
                //Check Username
                //if (Usernames.Contains(usernameBox.Text))
                //{
                //    errorCode = 3;
                //}
                //else
                //{
                //    errorCode = 1;
                //}
                //if (errorCode == 3)
                //{
                //Check password
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=pass.accdb;Persist Security Info=False; Jet OLEDB:Database Password='4GVMSucxoe';"))
                using (OleDbCommand cmd = new OleDbCommand(" SELECT * from [logins]", conn))
                {

                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (reader["Username"].ToString() == usernameBox.Text)
                            {
                                if (reader["Password"].ToString() == passBox.Text)
                                {
                                    errorCode = 3;
                                    break;
                                }
                                else
                                {
                                    errorCode = 2;
                                    break;
                                }

                            }
                            else
                            {
                                errorCode = 1;

                            }

                        }

                    }
                }
                //}
            }
            catch (Exception ex)
            {
                errorCode = 4;
                e.Result = ex.Message.ToString();
            }

        }
        private void checkLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (errorCode == 1)
            {
                MessageBox.Show("Username does not exist.", "");
            }
            if (errorCode == 2)
            {
                MessageBox.Show("Password is incorrect.", "");
            }

            if (errorCode == 3)
            {
                var dw = new DataWindow();
                dw.LoginForm = this;
                dw.LoginPassword = passBox.Text;
                dw.LoginUserName = usernameBox.Text;
                dw.allChapters = chapters;
                dw.Show();
                dw.Activate();
                this.Hide();
                this.usernameBox.Clear();
                this.passBox.Clear();
                this.usernameBox.Focus();
            }
            if (errorCode == 4)
            {
                MessageBox.Show("A problem occured while trying to log in. Error message: " + e.Result.ToString(), "");
            }
            loading.Hide();
        }
        private void beginLoad_DoWork(object sender, DoWorkEventArgs e)
        {
            //Loads all users
            try
            {
                loading.setText("Loading users");
                Usernames = new List<string>();
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=pass.accdb;Persist Security Info=False; Jet OLEDB:Database Password='4GVMSucxoe';");
                con.Open();
                DataTable MySchemaTable = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, new Object[] { null, null, null, "TABLE" });

                for (int i = 0; i < MySchemaTable.Rows.Count; i++)
                {
                    Usernames.Add(MySchemaTable.Rows[i].ItemArray[2].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("We could not load the users." + ex.Message);
            }

            //load all chapters
            try
            {
                chapters = new List<int>();
                loading.setText("Loading chapters");
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=storage.accdb;Persist Security Info=False; Jet OLEDB:Database Password='4GVMSucxoe';");

                OleDbCommand command = con.CreateCommand();
                con.Open();
                command.CommandText = "SELECT * FROM allchapters";
                OleDbDataReader reader;
                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    chapters.Add(Convert.ToInt32(reader["allchapters"]));
                }
                con.Close();
                loadSchools();

            }
            catch (Exception ex)
            {
                MessageBox.Show("We could not load the chapters." + ex.Message);
            }
        }

        private void beginLoad_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loginBtn.Enabled = true;
            passBox.Enabled = true;
            usernameBox.Enabled = true;
            usernameBox.Focus();
            loading.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            bool failed = false;
            foreach (DataWindow d in Application.OpenForms.OfType<DataWindow>())
            {
                if (d.LoginUserName == usernameBox.Text)
                {
                    failed = true;
                    MessageBox.Show("That user is already signed in.", "Sign in");
                }
            }
            if (failed == false)
            {
                loading.Show();
                checkLogin.RunWorkerAsync();
            }

        }

        private void passBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn.Focus();
                loading.Show();
                checkLogin.RunWorkerAsync();
            }
        }
        //Load schools list
        //TABLE COLUMNS SCHNAE LCITY LSTATE CONAME LSTREE LZIP
        public DataTable schoolTable = null;
        public List<string> schoolAuto = new List<string>();
        public void loadSchools()
        {
            if (schoolTable == null)
            {
                try
                {
                    loading.setText("Loading school list");
                    //Load school list
                    DataTable capDT;
                    dynamic connstr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + System.IO.Directory.GetCurrentDirectory() + "';Extended Properties='TEXT';";
                    dynamic SQL = "SELECT * FROM schoolssimple.csv";

                    capDT = new DataTable();

                    // USING will close and dispose of resources
                    using (OleDbConnection cn = new OleDbConnection(connstr))
                    {
                        using (OleDbCommand cmd = new OleDbCommand(SQL, cn))
                        {
                            cn.Open();
                            using (OleDbDataAdapter da = new OleDbDataAdapter(cmd))
                            {
                                da.Fill(capDT);
                                schoolTable = capDT;
                                //List<DataColumn> removeItems = new List<DataColumn>();
                                //foreach (DataColumn item in schoolTable.Columns)
                                //{
                                //    if (schoolTable.Columns.IndexOf(item) > 5)
                                //    {
                                //        removeItems.Add(item);
                                //    }
                                //}

                                //foreach (DataColumn item in removeItems)
                                //    schoolTable.Columns.Remove(item);


                            }

                        }
                    }
                    foreach (DataRow r in schoolTable.Rows)
                    {

                        try
                        {

                            schoolAuto.Add(r.Field<string>(0).ToString());
                        }
                        catch
                        {

                        }

                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load school list. Error message: " + ex.Message);
                }

            }
        }

        private void signInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.OfType<DataWindow>().Count() > 0)
            {
                e.Cancel = true;
            }
        }

        private void signInForm_VisibleChanged(object sender, EventArgs e)
        {
            this.usernameBox.Clear();
            this.passBox.Clear();
            userList.Items.Clear();
            foreach (DataWindow d in Application.OpenForms.OfType<DataWindow>())
            {
                userList.Items.Add(d.LoginUserName);
            }
        }

        private void userList_DoubleClick(object sender, EventArgs e)
        {
            foreach (DataWindow d in Application.OpenForms.OfType<DataWindow>())
            {
                if (d.LoginUserName == userList.SelectedItem.ToString())
                {
                    d.Show();
                    d.Activate();
                    this.Hide();
                    break;
                }
            }
        }
    }
}


