using System;
using SalaryMS.Connection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryMS.PersonnelMinistry
{
    public partial class userpower : Form
    {
        Operation operation = new Operation();

        private string username1;
       
        public userpower(string username)
        {
            InitializeComponent();
            this.username1 = username;
            label1.Text = username;
            string sql = "select 部门名称 from 系统用户 where 用户名 = " + username;
            comboBox1.Text = operation.Find(sql);
        }

        private void userpower_Load(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

            string sql = "update 系统用户 set 部门名称 = '" + comboBox1.SelectedItem.ToString() + "' where 用户名 = " + username1; 
            if (operation.UpdateStaff(sql))
                MessageBox.Show("更新成功！", "提示", MessageBoxButtons.OK);
            else
                MessageBox.Show("更新失败！", "提示", MessageBoxButtons.OK);
        }
    }
}
