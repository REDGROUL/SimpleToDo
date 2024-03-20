

using System;
using System.Collections.Generic;
using System.Data.SqlClient;

using todo.dao.abstracts;
using todo.entity;

namespace todo.dao.impl
{
    internal class TaskDataBaseDao : ITaskDao
    {


        private SqlConnection _connection = DBConnector.getInstance().getConnection();

        public TaskEntity deleteTask(TaskEntity task)
        {
            throw new NotImplementedException();
        }

        public List<TaskEntity> findTask(TaskEntity task)
        {
            _connection.Open();
            string sqlTask = "SELECT * FROM tasks WHERE user_id = @user_id";
            SqlCommand tasksCommand = new SqlCommand(sqlTask, _connection);
            tasksCommand.Parameters.Add("@user_id", System.Data.SqlDbType.BigInt).Value = task.getUserId();
           

            SqlDataReader tasksReader = tasksCommand.ExecuteReader();

            if (!tasksReader.HasRows)
            {
                _connection.Close();
                throw new Exception();
            }
            List<TaskEntity> tasks = new List<TaskEntity>();
            while (tasksReader.Read())
            {
                tasks.Add(new TaskEntity(
                    (long)tasksReader.GetValue(0),
                    (long)tasksReader.GetValue(1),
                    (string)tasksReader.GetValue(2),
                    (string)tasksReader.GetValue(3),
                    (DateTime)tasksReader.GetValue(4),
                    (DateTime)tasksReader.GetValue(5)
                    ));
            }



            _connection.Close();

            return tasks;
        }

        public TaskEntity saveTask(TaskEntity task)
        {
            _connection.Open();
            string addTask = "INSERT INTO tasks (user_id, name, status, time_start, time_stop) " +
                                        "VALUES (@user, @name, @status, @start, @stop)";
            SqlCommand authCommand = new SqlCommand(addTask, _connection);
            authCommand.Parameters.Add("@user", System.Data.SqlDbType.BigInt).Value = task.getUserId();
            authCommand.Parameters.Add("@name", System.Data.SqlDbType.VarChar).Value = task.getName();
            authCommand.Parameters.Add("@status", System.Data.SqlDbType.VarChar).Value = task.getStatus();
            authCommand.Parameters.Add("@start", System.Data.SqlDbType.DateTime).Value = task.getTimeStart();
            authCommand.Parameters.Add("@stop", System.Data.SqlDbType.DateTime).Value = task.getTimeStop();

            try
            {
                authCommand.ExecuteNonQuery();
                return task;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally {
                _connection.Close();
            }
        }

        public TaskEntity updateTask(TaskEntity task)
        {
            throw new NotImplementedException();
        }


    }
}
