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
using SalaryMS.PersonnelMinistry;

namespace SalaryMS
{
    public partial class personnelLogin : Form
    {
        public int userid;
        Operation operation = new Operation();
       
        public personnelLogin(int id)
        {
            this.userid = id;
            InitializeComponent();
            String sql = "select 名字 from 系统用户 where 用户名 = '" + id + "'";
            welcomeLabel.Text = operation.Find(sql) + "，欢迎使用工资管理系统";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Login loginForm = new Login();
            loginForm.Show();
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void staffListButton_Click(object sender, EventArgs e)
        {
            stafflist listForm = new stafflist();
            listForm.ShowDialog();
        }

        private void jobNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void queryButton_Click(object sender, EventArgs e)
        {
           
             string temp = textBox1.Text;
             if(temp == "")
            {
                MessageBox.Show("工号不能为空！", "提示", MessageBoxButtons.OK);
            }
            else
            {
                int userid = Convert.ToInt32(temp);
                String sql = "select * from 员工信息 where 职工号 = " + userid;
                if(operation.FindExist(sql))
                {
                    StaffInfo infoform = new StaffInfo(userid);
                    infoform.ShowDialog();
                }
                else
                {
                    MessageBox.Show("此工号不存在！", "提示", MessageBoxButtons.OK);
                }
                
            }

        }

        private void addStaffButton_Click(object sender, EventArgs e)
        {
            staffAdd addForm = new staffAdd();
            addForm.ShowDialog();
        }

        private void deleteStaffButton_Click(object sender, EventArgs e)
        {
            StaffDelete deleteForm = new StaffDelete();
            deleteForm.ShowDialog();
        }

        private void inputAttendancebutton_Click(object sender, EventArgs e)
        {
            AttendanceInsert insertForm = new AttendanceInsert();
            insertForm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sql = "select * from 系统用户 where 用户名 = '" + textBox2.Text + "'";
            if(operation.FindExist(sql))
            {
                userpower addForm = new userpower(textBox2.Text);
                addForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("此用户不存在！", "提示", MessageBoxButtons.OK);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            userAdd addForm = new userAdd();
            addForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            userDelete deleteForm = new userDelete();
            deleteForm.ShowDialog();
        }
    }
}
