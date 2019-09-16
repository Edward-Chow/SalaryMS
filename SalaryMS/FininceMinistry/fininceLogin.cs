using System;
using SalaryMS.FininceMinistry;
using SalaryMS.Connection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryMS
{
    public partial class fininceLogin : Form
    {
        Operation operation = new Operation();
        public int userid;

        public fininceLogin(int id)
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

        private void queryButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.textBox1.Text);
            StaffallMonthSalary samsform = new StaffallMonthSalary(id);
            samsform.ShowDialog();
        }

        private void staffListButton_Click(object sender, EventArgs e)
        {
            AllStaffSalary assForm = new AllStaffSalary();
            assForm.ShowDialog();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            SalaryStandardQuery ssqForm = new SalaryStandardQuery();
            ssqForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select 职工号 from 员工信息";
            List<int> list = operation.CountStaff(sql);
            bool flag = false;
            try
            {
                foreach (var item in list)
                {
                    string edusql = "select 工资 from 学历工资 join 员工信息 on (学历工资.学历 = 员工信息.学历) where 职工号 = '" + item.ToString() + "'";
                    double eduSalary = Convert.ToDouble(operation.Find(edusql));
                    string jobtitlesql = "select 工资 from 职称工资 join 员工信息 on (职称工资.职称 = 员工信息.职称) where 职工号 = '" + item.ToString() + "'";
                    double jtSalary = Convert.ToDouble(operation.Find(jobtitlesql));
                    string jobtimeSql = "select 工资 from 工龄工资 join 员工信息 on (工龄工资.工龄 = 员工信息.工龄) where 职工号 = '" + item.ToString() + "'";
                    double jtimeSalary = Convert.ToDouble(operation.Find(jobtimeSql));

                    string minisql_late = "select 迟到每天扣款 from 其他工资标准 join 员工信息 on (其他工资标准.部门编号 = 员工信息.部门编号) where 职工号 = '" + item.ToString() + "'";
                    double late = Convert.ToDouble(operation.Find(minisql_late));
                    string minisql_abs = "select 缺勤每天扣款 from 其他工资标准 join 员工信息 on (其他工资标准.部门编号 = 员工信息.部门编号) where 职工号 = '" + item.ToString() + "'";
                    double abs = Convert.ToDouble(operation.Find(minisql_abs));
                    string minisql_leave = "select 请假每天扣款 from 其他工资标准 join 员工信息 on (其他工资标准.部门编号 = 员工信息.部门编号) where 职工号 = '" + item.ToString() + "'";
                    double leave = Convert.ToDouble(operation.Find(minisql_leave));
                    string minisql_overtime = "select 加班每天奖金 from 其他工资标准 join 员工信息 on (其他工资标准.部门编号 = 员工信息.部门编号) where 职工号 = '" + item.ToString() + "'";
                    double overtime = Convert.ToDouble(operation.Find(minisql_overtime));

                    DateTime time_min = this.dateTimePicker1.Value.Date;
                    DateTime time_max = time_min.AddMonths(1).AddMilliseconds(-3);
                    string late_days_sql = "select 迟到天数 from 考勤情况 where 职工号 = '" + item.ToString() + "' and 日期 >= '" + time_min.ToString() + "' and 日期 <= '" + time_max.ToString() + "'";
                    int lateday = Convert.ToInt32(operation.Find(late_days_sql));
                    string abs_days_sql = "select 缺勤天数 from 考勤情况 where 职工号 = '" + item.ToString() + "' and 日期 >= '" + time_min.ToString() + "' and 日期 <= '" + time_max.ToString() + "'";
                    int absdays = Convert.ToInt32(operation.Find(abs_days_sql));
                    string leave_days_sql = "select 请假天数 from 考勤情况 where 职工号 = '" + item.ToString() + "' and 日期 >= '" + time_min.ToString() + "' and 日期 <= '" + time_max.ToString() + "'";
                    int leavedays = Convert.ToInt32(operation.Find(leave_days_sql));
                    string overtime_days_sql = "select 请假天数 from 考勤情况 where 职工号 = '" + item.ToString() + "' and 日期 >= '" + time_min.ToString() + "' and 日期 <= '" + time_max.ToString() + "'";
                    int overtimedays = Convert.ToInt32(operation.Find(overtime_days_sql));

                    double basesalary = eduSalary + jtSalary + jtimeSalary;
                    double overtimesalary = overtime * overtimedays;
                    double deduction = late * lateday + leave * leavedays + abs * absdays;
                    double monthsalary = basesalary + overtimesalary - deduction;

                    string insert_sql = "insert into 工资表(职工号,日期,基本工资,加班费,扣款,当月工资) values('"
                        + item.ToString() + "','" + time_min.ToString() + "'," + basesalary + "," + overtimesalary + "," + deduction + "," + monthsalary + ")";

                    operation.Insert(insert_sql);

                }
             }
             catch (System.Data.SqlClient.SqlException e1)
            {
                MessageBox.Show("不能重复生成该月工资", "提示", MessageBoxButtons.OK);
                flag = true;
            }
            finally
            {
                operation.CloseConnection();

            }
            if(flag == false)
            {
                MessageBox.Show("生成成功！", "提示", MessageBoxButtons.OK);
            }
            
        }
        
        private void setButton_Click(object sender, EventArgs e)
        {
            SalaryStandardSetting form = new SalaryStandardSetting();
            form.ShowDialog();
        }
    }
}
