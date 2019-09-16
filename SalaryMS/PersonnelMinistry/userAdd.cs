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
    public partial class userAdd : Form
    {
        Operation operation = new Operation();
        public userAdd()
        {
            InitializeComponent();
        }

        private void addStaffGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(staffNumTextBox.Text);
            string name = nameTextBox.Text;
            string username = usernameBox1.Text;
            string password = passwordBox1.Text;
            string ministryname =minComboBox.SelectedItem.ToString();

            string sql = "insert into 系统用户(职工号,名字,用户名,密码,部门名称) values('"
                + id + "','" + name + "','" + username + "','" + password + "','" + ministryname + "')";
            bool result = operation.InsertStaff(sql);
            if (result)
            {
                MessageBox.Show("插入成功", "提示", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("插入失败", "提示", MessageBoxButtons.OK);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
