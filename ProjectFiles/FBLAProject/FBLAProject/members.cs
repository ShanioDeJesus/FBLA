using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Data.OleDb;
using System.Data;

namespace FBLAProject
{
    class members
    {




        //ADDS new member to storage.xml based on the info provided
        public static void AddMember(string MembershipNumber, string FirstName, string LastName, string School, string State, string Email, int YearJoined, string ActiveMember, string AmountOwed, string Grade)
        {
            try
            {
                //adds new member to database

                using (var con = new OleDbConnection())
                {
                    con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                        @"Data Source=storage.accdb;";
                    con.Open();

                    using (var cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;
                        cmd.CommandType = System.Data.CommandType.Text;
                        cmd.CommandText = @"INSERT INTO " + loginInformation.username() + " ([Membership Number],[First Name],[Last Name],[School],[Grade],[State],[Email],[Year Joined],[Active],[Amount Owed]) VALUES ('" + MembershipNumber + "','" + FirstName + "','" + LastName + "','" + School + "','" + Grade + "','" + State + "','" + Email + "','" + YearJoined + "','" + ActiveMember + "','" + AmountOwed + "')";
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while trying to create member " + ex.Message);
                {

                }

            }
            loginInformation.refreshTable();
        }

        //Edits members
        public static void updateMember(string MembershipNumber, string FirstName, string LastName, string School, string State, string Email, string YearJoined, string ActiveMember, string AmountOwed, string Grade)
        {
            //try
            //{
                OleDbConnection con1 = new OleDbConnection();
                con1.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                              @"Data Source=storage.accdb;";
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con1;
                con1.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "Update [" + loginInformation.username() + "] SET [First Name] = @fn, [Last Name] = @ln, [School] = @s, [State] = @st, [Email] = @e,[Year Joined] = @y,[Active] = @a,[Amount Owed] = @amt,[Grade] = @gr where [Membership Number] = '" + MembershipNumber + "';";
                cmd.Parameters.AddWithValue("@fn", FirstName);
                cmd.Parameters.AddWithValue("@ln", LastName);
                cmd.Parameters.AddWithValue("@s", School);
                cmd.Parameters.AddWithValue("@st", State);
                cmd.Parameters.AddWithValue("@e", Email);
                cmd.Parameters.AddWithValue("@y", YearJoined);
                cmd.Parameters.AddWithValue("@a", ActiveMember);
                cmd.Parameters.AddWithValue("@amt", AmountOwed);
                cmd.Parameters.AddWithValue("@gr", Grade);
                cmd.ExecuteNonQuery();
                con1.Close();
            //}


            //{
            //    MessageBox.Show("An error occured while trying to edit member. " + ex.Message, "");
            //}
            loginInformation.refreshTable();
        }
        //ChecksIfMembershipExistsByID
        public static bool doesIdExist(string IDNumber)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=storage.accdb"))
                using (OleDbCommand cmd = new OleDbCommand(" SELECT * from " + loginInformation.username(), conn))
                {

                    conn.Open();
                    OleDbDataReader reader = cmd.ExecuteReader();
                    //if (Reader.HasRows)
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            if (reader["Membership Number"].ToString() == IDNumber)
                            {
                                return true;
                            }

                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while trying to match membership numbers: " + ex.Message);
            }

            return false;
        }



        public static void DeleteMember(string MembershipNumber)
        {
            try
            {
                OleDbConnection con1 = new OleDbConnection();
                con1.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;" +
                              @"Data Source=storage.accdb;";
                OleDbCommand cmd = new OleDbCommand();
                cmd.Connection = con1;
                con1.Open();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM " + loginInformation.username() + " WHERE[Membership NUmber] = " + MembershipNumber + ";";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Member Deleted", "");
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while trying to delete member. " + ex.Message);
            }
            loginInformation.refreshTable();
        }
    }
}
