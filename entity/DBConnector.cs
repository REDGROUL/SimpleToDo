using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo.entity
{
    internal class DBConnector
    {
        private static DBConnector instance;

        private SqlConnection connection;
        private DBConnector()
        {
            connection = new SqlConnection("Server=localhost\\SQLEXPRESS;Database=test2;" +
            "Integrated Security=true; TrustServerCertificate=True;");
        }

        public static DBConnector getInstance()
        {
            if (instance == null)
            {
                instance = new DBConnector();
            }
            return instance;
        }

        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
