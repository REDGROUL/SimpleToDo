using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todo.entity;

namespace todo.dao.abstracts
{
    interface IUserDao
    {
        User saveUser(User user);
        User findUser(User user);
        User updateUser(User user);
        User deleteUser(User user);

    }
}
