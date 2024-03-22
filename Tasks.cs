using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using todo.dao.abstracts;
using todo.dao.impl;
using todo.entity;

namespace todo
{
    public partial class Tasks : Form
    {

        private User authUser = BaseSecurity.getAuthUser();
        private ITaskDao taskDao;
        public Tasks()
        {
            InitializeComponent();

            taskDao = new TaskDataBaseDao();
            TaskEntity taskEntity = new TaskEntity();
            taskEntity.setUserId(authUser.getId());
            List <TaskEntity> tasks = taskDao.findTask(taskEntity);

            foreach(TaskEntity task in tasks)
            {
                flowLayoutPanel1.Controls.Add(new CurrentTask(task.getId(), task.getName(), task.getStatus(), task.getTimeStart(), task.getTimeStop()));
            }

         
           
        }

        private void Tasks_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void saveTask_Click(object sender, EventArgs e)
        {
            TaskEntity newTask = new TaskEntity();
          
            newTask.setUserId(authUser.getId());
            newTask.setName(newTaskName.Text);
            newTask.setStatus(newTaskStatus.Text);
            newTask.setTimeStart(datetime_start.Value);
            newTask.setTimeStop(datetime_stop.Value);

            try
            {
                taskDao.saveTask(newTask);
                flowLayoutPanel1.Controls.Add(new CurrentTask(newTask.getId(), newTask.getName(), newTask.getStatus(), newTask.getTimeStart(), newTask.getTimeStop()));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Tasks_Resize(object sender, EventArgs e)
        {
        }
    }
}
