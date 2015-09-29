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

namespace FBLAData
{
    public partial class editChapter : UserControl
    {
        public DataWindow thisWindow { get; set; }
        public DataTable chapterTable { get; set; }
        public List<string> chapterInformation { get; set; }
        public editChapter()
        {
            InitializeComponent();
        }

        private void chapterRemoveAdvisorBtn_Click(object sender, EventArgs e)
        {

        }
     
        public void reloadInfo()
        {
            contentHolder.Enabled = false;
            loading.Show();
            loading.setText("Loading information");
            if (loadInfo.IsBusy == false)
            {
                loadInfo.RunWorkerAsync();
            }

        }

        private void loadInfo_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                string query2 = "SELECT * From [info] WHERE ChapterNumber = " + thisWindow.CurrentChapter;
                using (OleDbConnection connection = new OleDbConnection(thisWindow.secureConnectionString))
                {
                    OleDbCommand command = new OleDbCommand(query2, connection);
                    connection.Open();
                    OleDbDataReader reader;
                    reader = command.ExecuteReader();

                    // Always call Read before accessing data.
                    while (reader.Read())
                    {
                        //sets chapterInformation as a new list of strings
                        chapterInformation = new List<string>(0);

                        //add school
                        chapterInformation.Insert(0, reader.GetString(0) ?? "None");

                        //add number
                        chapterInformation.Insert(1, reader.GetString(1) ?? "None");

                        //add street
                        chapterInformation.Insert(2, reader.GetString(2) ?? "None");

                        //add state
                        chapterInformation.Insert(3, reader.GetString(3) ?? "None");

                        //add city
                        chapterInformation.Insert(4, reader.GetString(4) ?? "None");

                        //add zip
                        chapterInformation.Insert(5, reader.GetString(5) ?? "None");

                        //add email
                        chapterInformation.Insert(6, reader.GetString(6) ?? "None");

                        //add fax
                        chapterInformation.Insert(7, reader.GetString(7) ?? "None");

                        //add advisors
                        chapterInformation.Insert(8, reader.GetString(8) ?? "None");

                        //add county
                        chapterInformation.Insert(9, reader.GetString(9) ?? "None");
                    }

                    // Always call Close when done reading.
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                DialogResult result = new CustomMessageBox("Something happened", "Failed to load chapter information from the database. Message: " + ex.Message,MessageBoxButtons.OK).ShowDialog();
            }
        }

        private void loadInfo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            contentHolder.Enabled = true;
            try
            {
                //Inserts information loaded from the database into the textboxes for editing  
                chapterSchool.Text = chapterInformation[0];
                chapterPhone.Text = chapterInformation[1];
                chapterStreet.Text = chapterInformation[2];
                chapterState.SelectedItem = chapterInformation[3];
                chapterCity.Text = chapterInformation[4];
                chapterZip.Text = chapterInformation[5];
                chapterEmail.Text = chapterInformation[6];
                chapterFax.Text = chapterInformation[7];
                chapterAdvisorBox.Text = chapterInformation[8];
                districtBox.Text = chapterInformation[9];

                //Sets the footer of the mainWindwo to the chapter currently viewing and the schoolname
                thisWindow.viewChapterLabel.Text = "Viewing chapter " + thisWindow.CurrentChapter.ToString() + ", " + chapterSchool.Text;
            }
            catch (Exception ex)
            {
                DialogResult result = new CustomMessageBox( "Something happened","Failed to load chapter information for editing. Message: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
            }

            //Hide only when the AutoFill is not occuring
            //This is needed when a new chapter is created.
            if (autoFill.IsBusy == false)
            {
                loading.Hide();
            }
        }

        bool failed = true;
        private void chapterSaveChanges_Click(object sender, EventArgs e)
        {
            //Hides the any error messages
            errorLabel.Hide();
            saveData(false);
        }
        public void saveData(bool SkipValidation)
        {
            failed = false;
            //validate fields
            if (SkipValidation == false)
            {
                foreach (TextBox t in contentHolder.Controls.OfType<TextBox>())
                {
                    if (t.Text == "" && t != chapterFax)
                    {
                        failed = true;
                        errorLabel.Show();
                        errorLabel.Text = ("The field " + t.Name.Replace("chapter", "") + " can not be left blank!");
                    }
                }
                if (chapterState.SelectedItem == null)
                {
                    failed = true;
                    errorLabel.Show();
                    errorLabel.Text = ("Please select a state!");
                }
                if (CheckValidEmail(chapterEmail.Text) == false)
                {
                    failed = true;
                    errorLabel.Show();
                    errorLabel.Text = ("Email address is invalid!");
                }
            }
            else
            {
                failed = false;
            }

            //if everything is good, SAVE!
            if (failed == false)
            {
                contentHolder.Enabled = false;
                loading.Show();
                loading.setText("Saving");

                if (saveChanges.IsBusy == false)
                {
                    saveChanges.RunWorkerAsync(chapterState.SelectedItem.ToString());
                }

            }
        }

        //Run save changes in the background
        private void saveChanges_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                OleDbConnection con1 = new OleDbConnection();
                con1.ConnectionString = thisWindow.secureConnectionString;
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con1;
                con1.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update [info] SET [number] = @num, [street] = @str, [state] = @s, [city] = @c, [zip] = @zip,[email] = @e,[fax] = @fax,[advisors] = @adv,[county] = @cty, [school] = @sch where [ChapterNumber] = " + thisWindow.CurrentChapter + ";";
                cmd.Parameters.AddWithValue("@num", chapterPhone.Text ?? "");
                cmd.Parameters.AddWithValue("@str", chapterStreet.Text ?? "");
                cmd.Parameters.AddWithValue("@s", e.Argument ?? "");
                cmd.Parameters.AddWithValue("@c", chapterCity.Text ?? "");
                cmd.Parameters.AddWithValue("@zip", chapterZip.Text ?? "");
                cmd.Parameters.AddWithValue("@e", chapterEmail.Text ?? "");
                cmd.Parameters.AddWithValue("@fax", chapterFax.Text ?? "");
                cmd.Parameters.AddWithValue("@adv", chapterAdvisorBox.Text ?? "");
                cmd.Parameters.AddWithValue("@cty", districtBox.Text ?? "");
                cmd.Parameters.AddWithValue("@sch", chapterSchool.Text ?? "");

                cmd.ExecuteNonQuery();
                con1.Close();
            }

            catch (Exception ex)
            {
                DialogResult result = new CustomMessageBox( "Something happened","An error occured while trying to save changes. Message: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
            }
        }

        private void saveChanges_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            contentHolder.Enabled = true;
            loading.Hide();
        }

        //Allow only numbersm dashes and decimals in a textbox. This is assigned to multiple textboxes.
        private void chapterPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }

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

        public void chapterSchool_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (autoFill.IsBusy == false && chapterSchool.Text != "")
                {
                    loading.Show();
                    loading.setText("Autofilling");
                    autoFill.RunWorkerAsync();
                }
            }
        }

        private void removeChapterBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = new CustomMessageBox("Confirm","Are you sure you want to delete this chapter and its members?",  MessageBoxButtons.YesNo).ShowDialog();
            if (result == DialogResult.Yes)
            {
                thisWindow.loadingItem1.Show();
                thisWindow.loadingItem1.setText("Deleting chapter");
                deleteChapter.RunWorkerAsync();

            }

        }

        private void deleteChapter_DoWork(object sender, DoWorkEventArgs e)
        {

            //Delete chapter information
            try
            {
                OleDbConnection con1 = new OleDbConnection();
                con1.ConnectionString = thisWindow.secureConnectionString;
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con1;
                con1.Open();
                cmd.CommandText = "DELETE FROM [info] WHERE [ChapterNumber] = " + thisWindow.CurrentChapter + ";";
                cmd.ExecuteNonQuery();
                con1.Close();
            }
            catch (Exception ex)
            {
                DialogResult result = new CustomMessageBox( "Something happened","An error occured while trying to delete chapter information. Message: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
            }

            //Delete chapter memebers
            thisWindow.loadingItem1.setText("Deleting members");
            try
            {
                OleDbConnection con2 = new OleDbConnection();
                con2.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=storage.accdb;Persist Security Info=False; Jet OLEDB:Database Password='4GVMSucxoe';";
                OleDbCommand cmd2 = new OleDbCommand();
                cmd2.Connection = con2;
                con2.Open();
                cmd2.CommandText = "DELETE FROM members WHERE [Chapter Number] = '" + thisWindow.CurrentChapter + "';";
                cmd2.ExecuteNonQuery();
                con2.Close();
            }
            catch (Exception ex)
            {
                DialogResult result = new CustomMessageBox( "Something happened","An error occured while trying to remove its members. Message: " + ex.Message, MessageBoxButtons.OK).ShowDialog();
            }

            //Removes chapter from the list of all chapters
            thisWindow.loadingItem1.setText("Removing chapter from list");
            try
            {
                OleDbConnection con3 = new OleDbConnection();
                con3.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=storage.accdb;Persist Security Info=False; Jet OLEDB:Database Password='4GVMSucxoe';";
                OleDbCommand cmd3 = new OleDbCommand();
                cmd3.Connection = con3;
                con3.Open();
                cmd3.CommandText = "DELETE FROM allchapters WHERE [allchapters] = " + thisWindow.CurrentChapter;
                cmd3.ExecuteNonQuery();
                con3.Close();
                try
                {
                    thisWindow.allChapters.Remove(Convert.ToInt32(thisWindow.CurrentChapter));
                }
                catch
                {

                }
            }
            catch (Exception ex)
            {
                DialogResult result = new CustomMessageBox("Something happened","An error occured whilte trying to delete chapter from the master file. Message: " + ex.Message,  MessageBoxButtons.OK).ShowDialog();
            }
        }

        private void deleteChapter_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                thisWindow.setChapter(0, false, false);
            }
            catch (Exception ex)
            {
                DialogResult result = new CustomMessageBox("Something happened","An error occured while tryiing to set chapter. Message: " + ex.Message,  MessageBoxButtons.OK).ShowDialog();
            }
            thisWindow.loadingItem1.Hide();
        }

        private void autoFill_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var temp = new List<string>(5);
                DataRow foundRow;
                foundRow = null;
                foreach (DataRow r in thisWindow.LoginForm.schoolTable.Rows)
                {
                    if (r.Field<string>(0) == chapterSchool.Text)
                    {
                        foundRow = r;
                    }

                }
                temp.Insert(0, foundRow.Field<string>("LCITY") ?? "");
                foreach (string str in chapterState.Items)
                {
                    if (str.Contains(foundRow.Field<string>("LSTATE")))
                    {
                        temp.Insert(1, str ?? "");
                        break;
                    }

                }
                temp.Insert(2, foundRow.Field<string>("CONAME") ?? "");
                temp.Insert(3, foundRow.Field<string>("LSTREE") ?? "");
                temp.Insert(4, foundRow.Field<int>("LZIP").ToString() ?? "");
                e.Result = temp;
            }
            catch (Exception ex)
            {
                //  MessageBox.Show(ex.ToString());
                e.Result = null;
            }

        }

        private void autoFill_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                var lst = (List<string>)e.Result;
                chapterCity.Text = lst[0];
                chapterState.SelectedItem = lst[1];
                districtBox.Text = lst[2];
                chapterStreet.Text = lst[3];
                chapterZip.Text = lst[4];
            }
            loading.Hide();
        }

        private void autoFillBtn_Click(object sender, EventArgs e)
        {
            if (autoFill.IsBusy == false && chapterSchool.Text != "")
            {
                loading.Show();
                loading.setText("Autofilling");
                autoFill.RunWorkerAsync();
            }
        }
    }
}
