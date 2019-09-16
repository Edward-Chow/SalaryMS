using System;
using SalaryMS.Connection;
using SalaryMS.Staff;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SalaryMS
{
    public partial class staffLogin : Form
    {
        Operation operation = new Operation();
        public int userid;

        public staffLogin(int id)
        {
            this.userid = id;
            InitializeComponent();
            String sql = "select 名字 from 系统用户 where 用户名 = '" + id + "'";
            label1.Text = operation.Find(sql) + "，欢迎使用工资管理系统";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void querysalaryButton_Click(object sender, EventArgs e)
        {
            DateTime time = this.dateTimePicker1.Value.Date;
            SalaryQuery queryForm = new SalaryQuery(this.userid, time);
            queryForm.ShowDialog();
        }
    }
}
