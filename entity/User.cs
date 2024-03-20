using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo.entity
{
    internal class User
    {
        private long _id;
        private string _name;
        private string _login;
        private string _password;


        
        public User(long id, string name, string login, 
            string password)
        {
            _id = id; 
            _name = name;
            _login = login;
            _password = password;
        }
        public User()
        {

        }

        public void setId(long id)
        {
            _id = id;
        }
        public void setName(string name)
        {
            _name = name;
        }
        public void setLogin(string login)
        {
            _login = login;
        }

        public void setPassword(string password)
        {
            _password = password;
        }

        public long getId()
        {
            return _id;
        }

        public string getName()
        {
            return _name;
        }

        public string getLogin()
        {
            return _login;
        }

        public string getPassword()
        {
            return _password;
        }

    }
}
