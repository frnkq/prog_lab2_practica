using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace PersonDirectory
{
    public static class DbConnection
    {
        static SqlConnection connection;

        public static SqlConnection GetConnection()
        {
            return connection;
        }
        public static void ConnectDB()
        {
            string connectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=AdventureWorks2012; Integrated Security=True;";
            connection = new SqlConnection(connectionString);
            connection.Open();
        }

        public static void DisconnectDB()
        {
            connection.Close();
        }
    }
}
