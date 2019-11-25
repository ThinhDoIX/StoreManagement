using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager
{
    public class ConnectionString
    {
        private string connectString = "Data Source=.;Initial Catalog=StoreDB;Integrated Security=True";
        private SqlConnection conn;

        public ConnectionString()
        {
            conn = new SqlConnection(this.connectString);
        }

        public bool openConnection()
        {
            try
            {
                conn.Open();
                return true;
            }
            catch
            {
                ;
            }
            return false;
        }

        public bool closeConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch
            {
                ;
            }
            return false;
        }

        public SqlConnection getConnection()
        {
            if(conn != null)
            {
                return conn;
            }
            return null;
        }
    }
}
