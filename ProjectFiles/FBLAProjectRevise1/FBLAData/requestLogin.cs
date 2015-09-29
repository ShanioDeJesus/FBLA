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
    public partial class requestLogin : Form
    {
        public requestLogin()
        {
            InitializeComponent();
        }

        private void requestLogin_Load(object sender, EventArgs e)
        {

        }
        public DialogResult loginSuccessful { get; set; }
        private string user;
        public void setInfo(string Message, string username)
        {
            user = username;
            messageLabel.Text = Message;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
           loginSuccessful= DialogResult.Cancel;
            this.Close();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loading.Show();
            loading.setText("Checking password");
            checkLogin.RunWorkerAsync();
        }

        public int errorCode;
        private void checkLogin_DoWork(object sender, DoWorkEventArgs e)
        {

            try
            {
                //Check password
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=pass.accdb;Persist Security Info=False; Jet OLEDB:Database Password='4GVMSucxoe';"))
                using (OleDbCommand cmd = new OleDbCommand(" SELECT * from " + user, conn))
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

        private void checkLogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (errorCode == 2)
            {
                MessageBox.Show("Password is incorrect.", "");
                loginSuccessful = DialogResult.Cancel;
                this.Close();
            }

            if (errorCode == 3)
            {
                loginSuccessful = DialogResult.Yes;
                this.Hide();
            }
            if (errorCode == 4)
            {
                MessageBox.Show("A problem occured while trying to log in. Error message: " + e.Result.ToString(), "");
            }
            loading.Hide();
        }

        private void requestLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            loginSuccessful = DialogResult.Cancel;
        }
    }
}
