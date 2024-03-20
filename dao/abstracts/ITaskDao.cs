using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using todo.entity;

namespace todo.dao.abstracts
{
    internal interface ITaskDao
    {
        TaskEntity saveTask(TaskEntity task);
        List<TaskEntity> findTask(TaskEntity task);
        TaskEntity deleteTask(TaskEntity task);
        TaskEntity updateTask(TaskEntity task);
    }
}
