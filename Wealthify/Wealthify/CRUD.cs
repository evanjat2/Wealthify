using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Wealthify
{
    class CRUD
    {
        private static string getConnectionString()
        {
            string host = "Host=localhost;";
            string port = "Port=5432;";
            string db = "Database=wealthify;";
            string user = "Username=postgres;";
            string pass = "Password=postgres;";

            string conString = string.Format("{0}{1}{2}{3}{4}", host, port, db, user,pass);
            return conString;
        }

        public static NpgsqlConnection con = new NpgsqlConnection(getConnectionString());
        public static NpgsqlCommand cmd = default(NpgsqlCommand);
        public static string sql = string.Empty;

        public static DataTable PerformCrud(NpgsqlCommand com)
        {
            NpgsqlDataAdapter da = default(NpgsqlDataAdapter);
            DataTable dt = new DataTable();

            try
            {
                da = new NpgsqlDataAdapter();
                da.SelectCommand = com;
                da.Fill(dt);
                return dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "Perform CRUD operations failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;

            }
            return dt;
        }

    }
}
