using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLAProject
{

    class loginInformation
    {
        private static DataTable databaseTable;
        private static string loginUsername;
        private static bool success;

        public static bool load(string Username)
        {
            try

            {
                    string query = "SELECT * From [" + loginUsername + "]";
                    using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=storage.accdb"))
                    {
                        using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                        {
                            DataSet ds = new DataSet();
                            adapter.Fill(ds);
                            databaseTable = ds.Tables[0];
                        }
                    }
                    return true;
            }
            catch
            {
                return false;
            }


        }
        public static DataTable thisDatabase()
        {
            return databaseTable;
        }
        public static string username()
        {
            return loginUsername;
        }

        //Load schools list
        public static DataTable schoolTable = null;
        public static List<string> schoolAuto = new List<string>();
        public static void loadSchools()
        {
            if (schoolTable == null)
            {
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
                            List<DataColumn> removeItems = new List<DataColumn>();
                            foreach (DataColumn item in schoolTable.Columns)
                            {
                                if (schoolTable.Columns.IndexOf(item) > 5)
                                {
                                    removeItems.Add(item);
                                }
                            }

                            foreach (DataColumn item in removeItems)
                                schoolTable.Columns.Remove(item);

                          
                        }

                    }
                }
                foreach (DataRow r in schoolTable.Rows)
                {

                        try
                        {
                            schoolAuto.Add(r.Field<string>(0).ToString() + " , " + r.Field<string>(1).ToString() + " , " + r.Field<string>(2).ToString() + " , " + r.Field<string>(3).ToString());
                        }
                        catch
                        {

                        }

                }
            }

        }
        public static void refreshTable()
        {

            try
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=storage.accdb");
                con.Open();
                string query = "SELECT * From " + loginUsername;
                using (OleDbConnection conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=storage.accdb"))
                {
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                    {
                        DataSet ds = new DataSet();
                        adapter.Fill(ds);
                        databaseTable = ds.Tables[0];
                    }
                }
            }
            catch
            {

            }

        }
        public static void logOut()
        {
            databaseTable = null;
            loginUsername = null;
            success = false;
        }
    }
}


