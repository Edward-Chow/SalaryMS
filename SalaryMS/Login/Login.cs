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
using System.Data.SqlClient;

namespace SalaryMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

            idTextbox.MaxLength = 10;
            passwordTextbox.PasswordChar = '*';
            toolTip1.InitialDelay = 0;
            toolTip1.ReshowDelay = 0;
            toolTip1.SetToolTip(idTextbox, "用户名为不超过8位纯数字");
            toolTip1.SetToolTip(passwordTextbox, "初始密码为职工号");
        }

        Operation operation = new Operation();

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("立刻退出系统？", "退出提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = idTextbox.Text;
            string usrepaw = passwordTextbox.Text;
            if (username == "" || usrepaw == "")
            {
                messageLab.Text = "请输入用户名或密码";
                return;
            }
            /*
             //数据库连接字符串（引号中的字符串为之前复制的那段字符）  
             //Data source=服务器名，Initial catalog=数据库名，User Id=sqlserver连接名，  
             //Password=数据库连接密码,integrated Security=True  
             string str = @"Data Source=LAPTOP-HC61RIUE\SQLEXPRESS01;Initial catalog=SalaryDb;integrated Security=True";
             SqlConnection conn = new SqlConnection(str);
             conn.Open();
             string selectsql = "Select * from 系统用户 where 用户名 = '" + idTextbox.Text + "' and 密码='" + passwordTextbox.Text + "'and 部门名称='" + departmentComboBox.Text + "'";
             SqlCommand cmd = new SqlCommand(selectsql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
             cmd.CommandType = CommandType.Text; 
             SqlDataReader sdr;
             sdr = cmd.ExecuteReader();
             */

            int userid = Convert.ToInt32(idTextbox.Text);

            if (operation.FindExist("Select * from 系统用户 where 用户名 = '" + idTextbox.Text + "' and 密码='" + passwordTextbox.Text + "'and 部门名称='" + departmentComboBox.Text + "'"))
            {
                messageLab.Text = "登陆成功!";

                if (this.departmentComboBox.Text.Equals("人事部"))
                {
                    personnelLogin personnelForm = new personnelLogin(userid);
                    personnelForm.Show();         
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;//这里实现登陆成功后关掉登录界面 
                }
                else if(this.departmentComboBox.Text.Equals("财务部"))
                {
                    fininceLogin fininceForm = new fininceLogin(userid);
                    fininceForm.Show();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;//这里实现登陆成功后关掉登录界面 
                }
                else
                {
                    staffLogin staffForm = new staffLogin(userid);//登陆成功显示主界面  
                    staffForm.Show();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;//这里实现登陆成功后关掉登录界面
                }

                this.Hide();
            }
            else
            {
                messageLab.Text = "登陆失败!请核对信息重新登陆！";
                return;
            }
        }
    }
}
