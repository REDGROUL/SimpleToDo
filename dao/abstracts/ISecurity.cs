using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todo.entity;

namespace todo.dao.abstracts
{
    internal interface ISecurity
    {
        User auth(User user);
        User logout(User user);
    }
}
