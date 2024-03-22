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
    public partial class CurrentTask : UserControl
    {

        private string _taskName;
        private string _taskStatus;
        private DateTime taskStop;
        private DateTime taskStart;
        private long id;
        private ITaskDao taskDao;
        public CurrentTask(long id, string text, string status, DateTime start, DateTime stop)
        {
            InitializeComponent();
            taskDao = new TaskDataBaseDao();
            this.id = id;
            taskName.Text = text;
            taskStatus.Text = status;
            Start.Text = start.ToString();
            Stop.Text = stop.ToString();

        }

        private void CurrentTask_Click(object sender, EventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TaskEntity t = new TaskEntity();
            t.setId(id);
            try {
                taskDao.deleteTask(t);

                this.Hide();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void CurrentTask_AutoSizeChanged(object sender, EventArgs e)
        {
            
        }

        private void taskStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
