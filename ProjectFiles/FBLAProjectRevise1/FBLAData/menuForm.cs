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
    public partial class menuForm : Form
    {

        //Generates drop shadow, Only works if user enables

        //protected override CreateParams CreateParams
        //{
        //    get
        //    {
        //        const int CS_DROPSHADOW = 0x20000;
        //        CreateParams cp = base.CreateParams;
        //        cp.ClassStyle |= CS_DROPSHADOW;
        //        return cp;
        //    }
        //}
        //=============================
        public DataWindow thisWindow { get; set; }
        public menuForm(DataWindow parForm)
        {
            InitializeComponent();
            thisWindow = parForm;
            thisWindow.Resize += parentFormResize;
            thisWindow.Move += parentFormMove;
        }

        private void menuForm_Load(object sender, EventArgs e)
        {

        }
        private void parentFormMove(object sender, EventArgs e)
        {
            this.Location = new Point(thisWindow.Location.X, thisWindow.Location.Y);
        }
        private void parentFormResize(object sender, EventArgs e)
        {
            this.Height = thisWindow.ClientSize.Height - (thisWindow.menuBtn.Location.Y);
        }
        private void menuForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                this.Location = thisWindow.PointToScreen(thisWindow.ClientRectangle.Location);
                this.Height = thisWindow.ClientSize.Height;
            }
            else
            {

            }

        }

        private void menuForm_Deactivate(object sender, EventArgs e)
        {
            ex = false;
            contentPanel.Hide();
            slideOut.Start();
            //this.Hide();
        }
        public void slideShow()
        {
            menuItemsPanel.Hide();
            this.Show();
            //this.Location = new Point(thisWindow.PointToScreen(thisWindow.ClientRectangle.Location).X, thisWindow.PointToScreen(thisWindow.ClientRectangle.Location).Y + thisWindow.menuBtn.Location.Y + thisWindow.menuBtn.Height);
            //this.Height = thisWindow.ClientSize.Height - (thisWindow.menuBtn.Location.Y + thisWindow.menuBtn.Height);
            this.Location = new Point(thisWindow.Location.X, thisWindow.Location.Y);
            this.Height = thisWindow.ClientSize.Height - (thisWindow.menuBtn.Location.Y);
            slideIn.Start();
        }
        private void slideIn_Tick(object sender, EventArgs e)
        {
            this.Activate();
            slideOut.Stop();
            if (this.Width >= 180)
            {
                slideIn.Stop();
            }
            else
            {
                if (this.Width <= 100)
                {
                    this.Width += 20;
                }
                if (this.Width >= 100 && this.Width <= 160)
                {
                    menuItemsPanel.Show();
                    menuItemsPanel.BringToFront();
                    this.Width += 10;
                }
                if (this.Width >= 160 && this.Width <= 200)
                {
                    this.Width += 5;
                }
            }
        }

        private void slideOut_Tick(object sender, EventArgs e)
        {
            menuItemsPanel.Hide();
            slideIn.Stop();
            if (this.Width <= 60)
            {
                this.Width = 20;
                this.Hide();
                slideOut.Stop();
            }
            else
            {
                this.Width -= 50;
            }
        }

        private void setChapterBtn_Click(object sender, EventArgs e)
        {
            //thisWindow.setTab(thisWindow.chapterSelectPanel, (CustomFlatButton.CustomFlatButton)sender);
            //((CustomFlatButton.CustomFlatButton)sender).Check = true;
            expand(chapterSelectPanel);
        }

        private void viewAllBtn_Click(object sender, EventArgs e)
        {
            thisWindow.setTab(thisWindow.viewAllMembers, (CustomFlatButton)sender);
        }

        private void bulkBtn_Click(object sender, EventArgs e)
        {
            thisWindow.setTab(thisWindow.addMem, (CustomFlatButton)sender);
            ((CustomFlatButton)sender).Check = true;
        }

        private void editChapterBtn_Click(object sender, EventArgs e)
        {
            expand(editChapter);
        }

        private void customFlatButton2_Click(object sender, EventArgs e)
        {
            thisWindow.Close();
        }

        private void lockBtn_Click(object sender, EventArgs e)
        {
            thisWindow.closeBtn.Enabled = false;
            thisWindow.menuBtn.Enabled = false;
            thisWindow.userNameLabel.Text = thisWindow.LoginUserName + " is signed in.";
            thisWindow.lockScreen.Show();
            thisWindow.lockScreen.BringToFront();
            thisWindow.passBox.Focus();
            this.ControlBox = false;
            if (thisWindow.CurrentTab != null) { thisWindow.CurrentTab.Enabled = false; }

            thisWindow.Hide();

            thisWindow.LoginForm.Show();
            thisWindow.LoginForm.BringToFront();
        }

        private void chapterSelectPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        bool ex = false;
        Control p = new Control();
        public void expand(Control PanelToShow)
        {
            p.Hide();
            if (p == PanelToShow)
            {
                if (ex == false)
                {
                    slideoutmore.Start();
                }
                else
                {
                    slideinmore.Start();
                }
            }
            else
            {
                p = PanelToShow;
                slideoutmore.Start();
            }

        }
        private void slideoutmore_Tick(object sender, EventArgs e)
        {
            contentPanel.Show();
            contentPanel.BringToFront();
            slideOut.Stop();
            slideinmore.Stop();
            slideIn.Stop();
            if (ex == true)
            {
                if (this.Width >= 200)
                {
                    this.Width -= 20;
                }
                else
                {
                    ex = false;
                }
            }
            else
            {
                if (this.Width <= 460)
                {
                    this.Width += 20;
                }
                else
                {

                    p.Show();
                    p.BringToFront();
                    ex = true;
                    slideoutmore.Stop();
                }
            }


        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            thisWindow.setTab(thisWindow.settingsTab, (CustomFlatButton)sender);
            ((CustomFlatButton)sender).Check = true;
        }

        private void slideinmore_Tick(object sender, EventArgs e)
        {
            p.Hide();
            slideOut.Stop();
            slideoutmore.Stop();
            slideIn.Stop();
            if (this.Width >= 200)
            {
                this.Width -= 20;

            }
            else
            {
                contentPanel.Hide();
                p.Hide();
                ex = false;
                slideinmore.Stop();
            }

        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            thisWindow.setTab(thisWindow.reportsTab, (CustomFlatButton)sender);
            thisWindow.reportsTab.reloadInfo();
            ((CustomFlatButton)sender).Check = true;
        }
        //Create Chapter
        private void createChapter_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int count;
                using (OleDbConnection conn = new OleDbConnection(thisWindow.secureConnectionString))
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

                    //Create into list of all chapter
                    OleDbConnection con3 = new OleDbConnection();
                    con3.ConnectionString = thisWindow.secureConnectionString;
                    OleDbCommand cmd3 = new OleDbCommand();
                    cmd3.Connection = con3;
                    con3.Open();
                    cmd3.CommandText = "INSERT INTO allchapters([allchapters])VALUES(" + Convert.ToInt32(newChapterNumberBox.Text) + ");";
                    cmd3.ExecuteNonQuery();
                    con3.Close();

                    //Insert new row for this chapter into the informatioin table
                    OleDbConnection con1 = new OleDbConnection();
                    con1.ConnectionString = thisWindow.secureConnectionString;
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.Connection = con1;
                    con1.Open();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "Insert INTO [info]([number],[street],[state],[city],[zip],[email],[fax],[advisors],[county],[school],[ChapterNumber]) VALUES( @num, @str,  @s, @c,  @zip, @e, @fax,@adv, @cty, @sch, @fnd);";
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
                    cmd.Parameters.AddWithValue("@fnd", Convert.ToInt32(newChapterNumberBox.Text));
                    cmd.ExecuteNonQuery();
                    con1.Close();
                    e.Result = true;
                }


            }
            catch (Exception ex)
            {
                e.Result = false;
                DialogResult result = new CustomMessageBox("Something happened", "An error occured whilte trying to create the chapter. Message: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
                slideShow();
                expand(chapterSelectPanel);

            }
        }

        private void createChapter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            //Checks to see if failed
            if (Convert.ToBoolean(e.Result) == true)
            {
                thisWindow.allChapters.Add(Convert.ToInt32(newChapterNumberBox.Text));
                chapterSelector.Items.Add(Convert.ToInt32(newChapterNumberBox.Text));
                thisWindow.setChapter(Convert.ToInt32(newChapterNumberBox.Text), false, true);
                expand(editChapter);
                editChapter.chapterSchool.Text = creatChapterSchoolbox.Text;
                if (editChapter.autoFill.IsBusy == false)
                {
                    editChapter.autoFill.RunWorkerAsync();
                }
            }
            else if (e.Result == null)
            {
                DialogResult result = new CustomMessageBox("Duplicate", "That chapter already exists", MessageBoxButtons.OK).ShowDialog();
                slideShow();
                expand(chapterSelectPanel);
            }
            loadingItem1.Hide();
        }

        private void createChapterBtn_Click(object sender, EventArgs e)
        {

            if (createChapter.IsBusy == false && creatChapterSchoolbox.Text != "" && newChapterNumberBox.Text != "")
            {
                loadingItem1.Show();
                loadingItem1.setText("Creating Chapter");
                createChapter.RunWorkerAsync();
            }
            else
            {
                DialogResult result = new CustomMessageBox("Something happened", "You must fill the School name and the Chapter number field!", MessageBoxButtons.OK).ShowDialog();

                slideShow();
                expand(chapterSelectPanel);
            }

        }

        private void newChapterNumberBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }
        //================
        //Set chapter

        private void setCurrentChapter_Click(object sender, EventArgs e)
        {
            if (chapterSelector.SelectedItem != null)
            {
                setCurrentChapter.Enabled = false;
                chapterSelector.Enabled = false;
                try
                {
                    if (thisWindow.allChapters.Contains(Convert.ToInt32(chapterSelector.SelectedItem)))
                    {
                        thisWindow.setChapter(Convert.ToInt32(chapterSelector.SelectedItem), false, false);
                    }
                    else
                    {
                        setCurrentChapter.Enabled = true;
                        chapterSelector.Enabled = true;
                        DialogResult result = new CustomMessageBox("Chapter not found", "That chapter does not exists", MessageBoxButtons.OK).ShowDialog();
                        slideShow();
                        expand(chapterSelectPanel);
                    }

                }
                catch (Exception ex)
                {
                    setCurrentChapter.Enabled = true;
                    chapterSelector.Enabled = true;
                    DialogResult result = new CustomMessageBox("Something happened", "An error occured while setting chapter. Message: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
                    slideShow();
                    expand(chapterSelectPanel);
                }
                setCurrentChapter.Enabled = true;
                chapterSelector.Enabled = true;
            }

        }

        //==========
        //View all chapters
        private void viewAllChaptersBtn_Click(object sender, EventArgs e)
        {
            setCurrentChapter.Enabled = false;
            chapterSelector.Enabled = false;
            try
            {
                thisWindow.setChapter(0, false, false);
            }
            catch (Exception ex)
            {
                setCurrentChapter.Enabled = true;
                chapterSelector.Enabled = true;
                DialogResult result = new CustomMessageBox("Something happened", "An error occured while trying to view all. Message: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
                slideShow();
                expand(chapterSelectPanel);
            }
            setCurrentChapter.Enabled = true;
            chapterSelector.Enabled = true;
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            expand(p);
        }

        private void hideMenu_Click(object sender, EventArgs e)
        {
            slideOut.Start();
        }

        private void editChapter_Load(object sender, EventArgs e)
        {

        }


        private void searchChapterSelectorBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Set the search string:
                string myString = searchChapterSelectorBox.Text;
                // Search starting from index -1:
                int index = chapterSelector.FindString(myString, -1);
                if (index != -1)
                {
                    chapterSelector.SetSelected(index, true);
                }
                else
                {

                }


            }
        }

        private void chapterSelector_DoubleClick(object sender, EventArgs e)
        {
            if (chapterSelector.SelectedItem != null)
            {
                setCurrentChapter_Click(setCurrentChapter, null);
            }
        }

        private void chapterSelector_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && chapterSelector.SelectedItem != null)
            {
                setCurrentChapter_Click(setCurrentChapter, null);
            }
        }

        private void generateChapterNumber_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                int? first = Enumerable.Range(1, int.MaxValue)
                                 .Except(thisWindow.allChapters)
                                 .FirstOrDefault();
                e.Result = first;
            }
            catch
            {
                e.Result = "";
                DialogResult result = new CustomMessageBox("Something happened", "Failed to generate number.", MessageBoxButtons.OK).ShowDialog();
            }

        }

        private void generateChapterNumber_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loadingItem1.Hide();
            newChapterNumberBox.Text = e.Result.ToString();
        }

        private void genNumberBtn_Click(object sender, EventArgs e)
        {
            loadingItem1.Show();
            loadingItem1.setText("Generating unused number");
            if (generateChapterNumber.IsBusy == false)
            {
                generateChapterNumber.RunWorkerAsync();
            }

        }

        private void menuForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    //=======================
}

