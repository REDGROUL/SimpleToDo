using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using todo.dao.abstracts;
using todo.dao.impl;
using todo.entity;

namespace todo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        private void AuthBtn_Click(object sender, EventArgs e)
        {
            User authUser = new User(0, "", AuthLogin.Text, AuthPassword.Text);

            try {
                authUser = new BaseSecurity().auth(authUser);
                this.Hide();
                Tasks f2 = new Tasks();
              

                if(f2.ShowDialog() == DialogResult.Cancel)
                {
                    this.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Проверьте данные");
            }
        }


    }
}
