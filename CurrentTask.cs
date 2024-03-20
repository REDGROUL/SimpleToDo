using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todo
{
    public partial class CurrentTask : UserControl
    {

        private string _taskName;
        public CurrentTask(string text)
        {
            InitializeComponent();

            taskName.Text = text;
            _taskName = text;
        }

        private void CurrentTask_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_taskName);
        }
    }
}
