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
        public signInForm LoginForm { get; set; }
        public string LoginUserName { get; set; }
        public string LoginPassword { get; set; }
        public int CurrentChapter { get; set; }
        public string secureConnectionString { get; set; }
        public List<int> allChapters { get; set; }
        public Control CurrentTab { get; set; }
        public bool firstRun = true;
        public menuForm thisMenu { get; set; }
        public DataWindow()
        {
            InitializeComponent();

        }

        private void DataWindow_Load(object sender, EventArgs e)
        {
            var br = new customBorder(this, titleBar, topBorder, leftBorder, rightBorder, bottomBorder, maxrestoreBtn, Properties.Resources.max1, Properties.Resources.restore1, toprightresize, topleftresize, bottomrightresize, bottomleftresize);
            var m = new menuForm(this);
            thisMenu = m;
            thisMenu.Width = 20;
            //Set all dropdown to controls
            thisMenu.creatChapterSchoolbox.ThisTextBox.AutoCompleteCustomSource.AddRange(LoginForm.schoolAuto.ToArray());
            thisMenu.editChapter.chapterSchool.AutoCompleteCustomSource.AddRange(LoginForm.schoolAuto.ToArray());
            //Set Parent Window for UserControls
            thisMenu.editChapter.thisWindow = this;
            viewAllMembers.thisWindow = this;
            addMem.thisWindow = this;
            reportsTab.thisWindow = this;
            secureConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=storage.accdb; Persist Security Info=False; Jet OLEDB:Database Password='4GVMSucxoe';";
            foreach (int i in allChapters)
            {
                thisMenu.chapterSelector.Items.Add(i.ToString());
            }
            setChapter(0, false,false);
            setTab(viewAllMembers, thisMenu.viewAllBtn);
        }
        public void setChapter(int ChapterName, bool reloadFromDatabase, bool isNewChapter)
        {
            CurrentChapter = ChapterName;
            if (firstRun == true)
            {
                viewAllMembers.reloadInfo(true);
                firstRun = false;
                if (CurrentChapter != 0)
                {
                    viewChapterLabel.Text = "Viewing chapter " + CurrentChapter.ToString();
                    thisMenu.editChapterBtn.Enabled = true;
                    if (isNewChapter == false)
                    {
                        thisMenu.editChapter.reloadInfo();
                    }
                }
                else
                {
                    viewChapterLabel.Text = "Viewing all members from all chapters";
                    thisMenu.editChapterBtn.Enabled = false;
                }
            }
            else
            {
                if (CurrentChapter != 0)
                {
                    viewChapterLabel.Text = "Viewing chapter " + CurrentChapter.ToString();
                    thisMenu.editChapterBtn.Enabled = true;
                    if (isNewChapter == false)
                    {
                        thisMenu.editChapter.reloadInfo();
                    }
                    viewAllMembers.reloadInfo(reloadFromDatabase);
                    setTab(viewAllMembers, thisMenu.viewAllBtn);
                }
                else
                {
                    viewChapterLabel.Text = "Viewing all members from all chapters";
                    thisMenu.editChapterBtn.Enabled = false;
                    viewAllMembers.reloadInfo(reloadFromDatabase);
                    setTab(viewAllMembers, thisMenu.viewAllBtn);
                }
            }
            addMem.reloadInfo();
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



        #region startScreenButtons

        #endregion

        #region menubarButtons
        private void viewAllBtn_Click(object sender, EventArgs e)
        {

        }

        private void selectChapterBtn_Click(object sender, EventArgs e)
        {

        }

        private void editChapterBtn_Click(object sender, EventArgs e)
        {

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
            setTab(addMem, thisMenu.bulkBtn);
        }

        private void chapterSaveChanges_Click(object sender, EventArgs e)
        {

        }

        private void startPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void setTab(Control Tab, CustomFlatButton pushed)
        {
            CurrentTab = Tab;
            foreach (CustomFlatButton c in thisMenu.menuItemsPanel.Controls.OfType<CustomFlatButton>())
            {
                c.Check = false;
            }
            pushed.Check = true;
            this.Activate();
            Tab.Show();
            Tab.BringToFront();
        }


        bool skipSave = false;
        private void DataWindow_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (skipSave == false)
            {
                DialogResult result = new CustomMessageBox("Sign out", "Would you like to save any changes made?", MessageBoxButtons.YesNoCancel).ShowDialog();
                if (result == DialogResult.Yes)
                {
                    //Save everything; On different threads so it will save in the background
                    viewAllMembers.SaveDataBase();
                    if (CurrentChapter != 0)
                    {
                        thisMenu.editChapter.saveData(true);
                    }

                    e.Cancel = true;
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
            if (thisMenu.editChapter.saveChanges.IsBusy == false && viewAllMembers.saveChanges.IsBusy == false)
            {
                skipSave = true;
                this.Close();
            }
        }


        private void bulkBtn_Click(object sender, EventArgs e)
        {
            setTab(addMem, thisMenu.bulkBtn);
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
                closeBtn.Enabled = true;
                menuBtn.Enabled = true;
                lockScreen.Hide();
                if (CurrentTab != null) { CurrentTab.Enabled = true; }
                this.ControlBox = true;
            }
            if (errorCode == 4)
            {
                MessageBox.Show("A problem occured while trying to log in. Error message: " + e.Result.ToString(), "");
            }
            loadingItem1.Hide();
        }

        private void customLabelButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm.Show();
            LoginForm.Activate();
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

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void signOutBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            thisMenu.slideShow();
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void startChapterPick_Click(object sender, EventArgs e)
        {
            thisMenu.slideShow();
            thisMenu.expand(thisMenu.chapterSelectPanel);
        }

        private void startEditChapterInfo_Click(object sender, EventArgs e)
        {
            thisMenu.slideShow();
            thisMenu.expand(thisMenu.editChapter);
        }

        private void startSearchMember_Click(object sender, EventArgs e)
        {
            setTab(viewAllMembers, thisMenu.viewAllBtn);
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
