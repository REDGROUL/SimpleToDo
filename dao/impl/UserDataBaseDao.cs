using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todo.dao.abstracts;
using todo.entity;

namespace todo.dao.impl
{
    internal class UserDataBaseDao : IUserDao
    {
        private SqlConnection _connection = DBConnector.getInstance().getConnection();
        public User deleteUser(User user)
        {
            throw new NotImplementedException();
        }

        public User findUser(User user)
        {
            return null;
        }

        public User saveUser(User user)
        {
            throw new NotImplementedException();
        }

        public User updateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
