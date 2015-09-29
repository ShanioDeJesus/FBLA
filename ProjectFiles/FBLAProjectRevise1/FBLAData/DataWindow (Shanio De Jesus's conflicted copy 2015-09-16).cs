using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLAData
{
    public partial class DataWindow : Form
    {
        public signInForm LoginForm { get; set; }
        public string LoginUserName { get; set; }
        public string LoginPassword { get; set; }
        public int CurrentChapter { get; set; }
        public string secureConnectionString { get; set; }
        public List<int> allChapters { get; set; }
        public Control CurrentTab { get; set; }
        public bool firstRun = true;
        public DataWindow()
        {
            InitializeComponent();

        }

        private void DataWindow_Load(object sender, EventArgs e)
        {
            //Set all dropdown to controls
            creatChapterSchoolbox.AutoCompleteCustomSource.AddRange(LoginForm.schoolAuto.ToArray());
            editChapter.chapterSchool.AutoCompleteCustomSource.AddRange(LoginForm.schoolAuto.ToArray());
            //Set Parent Window for UserControls
            editChapter.thisWindow = this;
            viewAllMembers.thisWindow = this;
            addMem.thisWindow = this;
            secureConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=storage.accdb; Persist Security Info=False; Jet OLEDB:Database Password='4GVMSucxoe';";
            chapterSelectPanel.Show();
            chapterSelectPanel.BringToFront();
            chapter.Text = "Current chapter: " + CurrentChapter;
            foreach (int i in allChapters)
            {
                chapterSelectBox.AutoCompleteCustomSource.Add(i.ToString());
            }
            setChapter(0, false);

        }
        public void setChapter(int ChapterName, bool reloadFromDatabase)
        {
            CurrentChapter = ChapterName;
            if (firstRun == true)
            {
                viewAllMembers.reloadInfo(true);
                firstRun = false;
                startPanel.Show();
                startPanel.BringToFront();
                if (CurrentChapter != 0)
                {
                    editChapterBtn.Enabled = true;
                    editChapter.reloadInfo();
                }
                else
                {
                    editChapterBtn.Enabled = false;
                }
            }
            else
            {
                if (CurrentChapter != 0)
                {
                    editChapterBtn.Enabled = true;
                    editChapter.reloadInfo();
                    viewAllMembers.reloadInfo(reloadFromDatabase);
                    setTab(viewAllMembers, viewAllBtn.Location.X, 97);
                }
                else
                {
                    editChapterBtn.Enabled = false;
                    viewAllMembers.reloadInfo(reloadFromDatabase);
                    setTab(viewAllMembers, viewAllBtn.Location.X, 97);
                }
            }

            setCurrentChapter.Enabled = true;
            chapterSelectBox.Enabled = true;
            chapter.Text = "Current chapter: " + ChapterName;

        }


        //===========

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Suspend layout on resize and move and maximize
        private void DataWindow_ResizeBegin(object sender, EventArgs e)
        {
            SuspendLayout();
        }

        private void DataWindow_ResizeEnd(object sender, EventArgs e)
        {
            ResumeLayout(true);

        }
        private void DataWindow_Move(object sender, EventArgs e)
        {

        }
        //==========





        private void menuBar_Paint(object sender, PaintEventArgs e)
        {

        }


        private void startPanel_VisibleChanged(object sender, EventArgs e)
        {
            if (startPanel.Visible == false)
            {
                menuBar.Show();
            }
            else
            {
                menuBar.Hide();
            }
        }
        #region startScreenButtons
        private void startSignout_Click(object sender, EventArgs e)
        {
            startPanel.Hide();
            signOutBtn_Click(signOutBtn, null);
        }

        private void startSearchMember_Click(object sender, EventArgs e)
        {
            startPanel.Hide();
            viewAllBtn_Click(viewAllBtn, null);
        }
        #endregion

        #region menubarButtons
        private void viewAllBtn_Click(object sender, EventArgs e)
        {
            setTab(viewAllMembers, viewAllBtn.Location.X, 97);
        }

        private void selectChapterBtn_Click(object sender, EventArgs e)
        {
            setTab(chapterSelectPanel, selectChapterBtn.Location.X, 97);
        }

        private void editChapterBtn_Click(object sender, EventArgs e)
        {
            setTab(editChapter, editChapterBtn.Location.X, 97);
        }
        #endregion

        private void startSettings_Click(object sender, EventArgs e)
        {

        }

        private void startReports_Click(object sender, EventArgs e)
        {

        }

        private void startExport_Click(object sender, EventArgs e)
        {

        }

        private void startImport_Click(object sender, EventArgs e)
        {

        }

        private void startAddMember_Click(object sender, EventArgs e)
        {

        }

        private void chapterSaveChanges_Click(object sender, EventArgs e)
        {

        }

        private void startPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void setTab(Control Tab, int moveSelectedToX, int moveSelectedToY)
        {
            //foreach (UserControl p in this.Controls.OfType<UserControl>())
            //{
            //    p.Hide();
            //}

            CurrentTab = Tab;
            moveBarX = moveSelectedToX;
            moveBarY = moveSelectedToY;
            if (moveBarX < selectedBar.Location.X)
            {
                moveRight = false;
            }
            else
            {
                moveRight = true;
            }
            moveSelectedBar.Start();
            Tab.Show();
            Tab.BringToFront();
        }

        private int moveBarX;
        private int moveBarY;
        private bool moveRight = false;
        private void moveSelectedBar_Tick(object sender, EventArgs e)
        {
            if (moveRight == true)
            {

                selectedBar.Left += 10;
                if (selectedBar.Location.X >= moveBarX)
                {
                    selectedBar.Location = new Point(moveBarX, moveBarY);
                    moveSelectedBar.Stop();
                }
            }
            else
            {
                selectedBar.Left -= 10;
                if (selectedBar.Location.X <= moveBarX)
                {
                    selectedBar.Location = new Point(moveBarX, moveBarY);
                    moveSelectedBar.Stop();
                }
            }
        }

        private void setCurrentChapter_Click(object sender, EventArgs e)
        {

            setCurrentChapter.Enabled = false;
            chapterSelectBox.Enabled = false;
            try
            {
                if (allChapters.Contains(Convert.ToInt32(chapterSelectBox.Text)))
                {
                    setChapter(Convert.ToInt32(chapterSelectBox.Text), false);
                }
                else
                {
                    setCurrentChapter.Enabled = true;
                    chapterSelectBox.Enabled = true;
                    MessageBox.Show("That chapter does not exist");
                }

            }
            catch (Exception ex)
            {
                setCurrentChapter.Enabled = true;
                chapterSelectBox.Enabled = true;
                MessageBox.Show("An error occured while trying set chapter. Message: " + ex.Message);
            }

        }

        private void chapter_Click(object sender, EventArgs e)
        {
            selectChapterBtn_Click(selectChapterBtn, null);
        }

        private void startChapterPick_Click(object sender, EventArgs e)
        {
            setTab(chapterSelectPanel, selectChapterBtn.Location.X, 97);
            startPanel.Hide();
        }

        private void startEditChapterInfo_Click(object sender, EventArgs e)
        {
            startPanel.Hide();
            editChapterBtn_Click(editChapterBtn, null);
        }

        bool skipSave = false;
        private void DataWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (skipSave == false)
            {
                DialogResult result = MessageBox.Show("Would you like to save any changes made?", "Return to Sign in screen", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    //Save everything; On different threads so it will save in the background
                    viewAllMembers.SaveDataBase();
                    if (CurrentChapter != 0)
                    {
                        editChapter.saveData();
                    }

                    e.Cancel = true;
                    menuBar.Hide();
                    loadingItem1.Show();
                    loadingItem1.BringToFront();
                    loadingItem1.setText("Saving");
                    checkForCompletedSaved.Start();
                }
                else if (result == DialogResult.No)
                {

                    e.Cancel = false;
                    LoginForm.Show();
                    LoginForm.BringToFront();
                }
                else if (result == DialogResult.Cancel)
                {
                    //cancel close
                    e.Cancel = true;
                }
            }

        }

        //When a sign out is requested, this timer is here to check when all saves are done
        private void checkForCompletedSaved_Tick(object sender, EventArgs e)
        {
            if (editChapter.saveChanges.IsBusy == false && viewAllMembers.saveChanges.IsBusy == false)
            {
                skipSave = true;
                this.Close();
            }
        }

        private void viewAllChaptersBtn_Click(object sender, EventArgs e)
        {
            setCurrentChapter.Enabled = false;
            chapterSelectBox.Enabled = false;
            try
            {
                setChapter(0, false);
            }
            catch (Exception ex)
            {
                setCurrentChapter.Enabled = true;
                chapterSelectBox.Enabled = true;
                MessageBox.Show("An error occured while trying set chapter. Message: " + ex.Message);
            }
        }

        private void bulkBtn_Click(object sender, EventArgs e)
        {
            setTab(addMem, bulkBtn.Location.X, 97);
        }

        private int errorCode;
        private void checkLogin_DoWork(object sender, DoWorkEventArgs e)
        {
            loadingItem1.setText("Checking login");
            try
            {

                //Check password
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=pass.accdb;Persist Security Info=False; Jet OLEDB:Database Password='4GVMSucxoe';"))
                using (OleDbCommand cmd = new OleDbCommand(" SELECT * from " + LoginUserName, conn))
                {

                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    //if (Reader.HasRows)
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (reader["Password"].ToString() == passBox.Text)
                            {
                                errorCode = 3;
                            }
                            else
                            {
                                errorCode = 2;
                            }

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                errorCode = 4;
                e.Result = ex.Message.ToString();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loadingItem1.Show();
            checkLogin.RunWorkerAsync();
        }

        private void checkLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            passBox.Clear();
            if (errorCode == 2)
            {
                MessageBox.Show("Password is incorrect.", "");
            }

            if (errorCode == 3)
            {
                lockScreen.Hide();
                CurrentTab.Enabled = true;
                this.ControlBox = true;
            }
            if (errorCode == 4)
            {
                MessageBox.Show("A problem occured while trying to log in. Error message: " + e.Result.ToString(), "");
            }
            loadingItem1.Hide();
        }

        private void lockBtn_Click(object sender, EventArgs e)
        {
            userNameLabel.Text = LoginUserName + " is signed in.";
            lockScreen.Show();
            lockScreen.BringToFront();
            passBox.Focus();
            this.ControlBox = false;
            CurrentTab.Enabled = false;
            this.Hide();

            LoginForm.Show();
            LoginForm.BringToFront();
        }

        private void customLabelButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.Show();
            LoginForm.Activate();
        }

        private void createChapter_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int count;
                using (OleDbConnection conn = new OleDbConnection(secureConnectionString))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        string cmdStr = "Select count(*) from [allchapters] where [allchapters] = " + newChapterNumberBox.Text + ";";

                        OleDbCommand checkCmd = new OleDbCommand(cmdStr, conn);

                        count = (int)checkCmd.ExecuteScalar();
                        conn.Close();
                    }

                }
                if (count > 0)
                {
                    e.Result = null;
                }
                else
                {
                    //add chapter info to db
                    string cmdString = "CREATE TABLE [" + newChapterNumberBox.Text + "] ([school] char(25),[number] char(25), [street] char(25), [state] char(25), [city] char(25), [zip] char(25), [email] char(25), [fax] char(25), [advisors] char(25), [county] char(25), [findnumber] int);"; //YOUR SQL COMMAND TO CREATE A TABLE
                    OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=info.accdb;Persist Security Info=False; Jet OLEDB:Database Password='4GVMSucxoe';");

                    OleDbCommand create = new OleDbCommand(cmdString, connection);

                    connection.Open();
                    create.ExecuteNonQuery();
                    connection.Close();

                    //Create into list of all chapter
                    OleDbConnection con3 = new OleDbConnection();
                    con3.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=storage.accdb;Persist Security Info=False; Jet OLEDB:Database Password='4GVMSucxoe';";
                    OleDbCommand cmd3 = new OleDbCommand();
                    cmd3.Connection = con3;
                    con3.Open();
                    cmd3.CommandText = "INSERT INTO allchapters([allchapters])VALUES(" + Convert.ToInt32(newChapterNumberBox.Text) + ");";
                    cmd3.ExecuteNonQuery();
                    con3.Close();


                    OleDbConnection con1 = new OleDbConnection();
                    con1.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=info.accdb;Persist Security Info=False; Jet OLEDB:Database Password='4GVMSucxoe';";
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con1;
                    con1.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert INTO [" + newChapterNumberBox.Text + "]([number],[street],[state],[city],[zip],[email],[fax],[advisors],[county],[school],[findnumber]) VALUES( @num, @str,  @s, @c,  @zip, @e, @fax,@adv, @cty, @sch, @fnd);";
                    cmd.Parameters.AddWithValue("@num", "");
                    cmd.Parameters.AddWithValue("@str", "");
                    cmd.Parameters.AddWithValue("@s", "");
                    cmd.Parameters.AddWithValue("@c", "");
                    cmd.Parameters.AddWithValue("@zip", "");
                    cmd.Parameters.AddWithValue("@e", "");
                    cmd.Parameters.AddWithValue("@fax", "");
                    cmd.Parameters.AddWithValue("@adv", "");
                    cmd.Parameters.AddWithValue("@cty", "");
                    cmd.Parameters.AddWithValue("@sch", "");
                    cmd.Parameters.AddWithValue("@fnd", 1);
                    cmd.ExecuteNonQuery();
                    con1.Close();
                    e.Result = true;
                }


            }
            catch (Exception ex)
            {
                e.Result = false;
                MessageBox.Show("An error occured while trying to create chapter. Message: " + ex.Message);

            }
        }

        private void createChapter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (Convert.ToBoolean(e.Result) == true)
            {
                allChapters.Add(Convert.ToInt32(newChapterNumberBox.Text));
                setChapter(Convert.ToInt32(newChapterNumberBox.Text), false);
                setTab(editChapter, editChapterBtn.Location.X, 97);
                editChapter.chapterSchool.Text = creatChapterSchoolbox.Text;
                if (editChapter.autoFill.IsBusy == false)
                {
                    editChapter.autoFill.RunWorkerAsync();
                }
            }
            else if (e.Result == null)
            {
                MessageBox.Show("That chapter already exists.", "Matching Chapter Numbers");
            }
            loadingItem1.Hide();
            menuBar.Show();
        }

        private void createChapterBtn_Click(object sender, EventArgs e)
        {

            if (createChapter.IsBusy == false && creatChapterSchoolbox.Text != "" && newChapterNumberBox.Text != "")
            {
                loadingItem1.Show();
                loadingItem1.setText("Creating Chapter");
                menuBar.Hide();
                createChapter.RunWorkerAsync();
            }
            else
            {
                MessageBox.Show("The chapter number and school name box must be filled!", "Error");
            }

        }

        private void newChapterNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void DataWindow_VisibleChanged(object sender, EventArgs e)
        {
            passBox.Clear();
        }

        private void startLock_Click(object sender, EventArgs e)
        {

        }

        private void DataWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                LoginForm.userList.Items.Remove(LoginUserName);
            }
            catch
            {

            }
            LoginForm.Show();
            LoginForm.BringToFront();
        }
    }
}
