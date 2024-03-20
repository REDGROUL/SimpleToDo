using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using todo.dao.abstracts;
using todo.entity;

namespace todo.dao.impl
{
    internal class BaseSecurity : ISecurity
    {

        SqlConnection sqlConnection = DBConnector.getInstance().getConnection();


        private static User AuthUser;
        public User auth(User user)
        {
            sqlConnection.Open();
            string sqlAuth = "SELECT * FROM users WHERE login = @login AND password = @password";
            SqlCommand authCommand = new SqlCommand(sqlAuth, sqlConnection);
            authCommand.Parameters.Add("@login", System.Data.SqlDbType.VarChar).Value = user.getLogin();
            authCommand.Parameters.Add("@password", System.Data.SqlDbType.VarChar).Value = user.getPassword();
            
            SqlDataReader authReader = authCommand.ExecuteReader();

            if (!authReader.HasRows)
            {
                sqlConnection.Close();
                throw new Exception();
            }

            while (authReader.Read())
            {
                user.setId((long)authReader.GetValue(0));
                user.setName((string)authReader.GetValue(1));

            }

            sqlConnection.Close();
            setUser(user);
            return user;            
        }

        public static User getAuthUser()
        {
            return AuthUser;
        }
        private void setUser(User user)
        {
            AuthUser = user;
        }

        public User logout(User user)
        {
            AuthUser = new User();
            return AuthUser;
        }


    }
}
