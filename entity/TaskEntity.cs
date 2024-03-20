using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo.entity
{
    internal class TaskEntity
    {
        private long _id;
        private long _user_id;
        private string _name;
        private string _status;
        private DateTime _time_start;
        private DateTime _time_stop;


        
        public TaskEntity(long id, long user_id, string name,
            string status, DateTime time_start, DateTime time_stop)
        {
            _id = id;
            _user_id = user_id;
            _name = name;
            _status = status;
            _time_start = time_start;
            _time_stop = time_stop;

        }
        public TaskEntity() { 
        
        }


        public long getId()
        {
            return _id;
        }

        public long getUserId()
        {
            return _user_id;
        }


        public string getName()
        {
            return _name;

        }

        public string getStatus()
        {
            return _status;
        }

        public DateTime getTimeStart()
        {
            return _time_start;
        }

        public DateTime getTimeStop()
        {
            return _time_stop;
        }


        public void setId(long id)
        {
            _id = id;
        }
        public void setUserId(long userId) { 
            _user_id = userId;
        }

        public void setName(string name)
        {
            _name = name;
        }

        public void setStatus(string status)
        {
            _status = status;
        }

        public void setTimeStart(DateTime dateTime)
        {
            _time_start = dateTime;
        }

        public void setTimeStop(DateTime dateTime)
        {
            _time_stop = dateTime;
        }
    }
}