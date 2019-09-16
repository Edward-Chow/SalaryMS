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

namespace SalaryMS
{
    public partial class staffAdd : Form
    {
        Operation operation = new Operation();
        bool result = false;

        public staffAdd()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(staffNumTextBox.Text);
            int ministryid = Convert.ToInt32(minNumComboBox.SelectedItem.ToString().Substring(0, 1));
            string position = positionComboBox.SelectedItem.ToString();
            string name = nameTextBox.Text;
            string gender = sexComboBox.SelectedItem.ToString();
            int old = System.DateTime.Now.Year - birthdayDateTimePicker.Value.Date.Year;
            string education = eduComboBox.SelectedItem.ToString();
            int joblong = System.DateTime.Now.Year - jobDateTimePicker.Value.Date.Year;
            string jobtitle = jobTitleComboBox.SelectedItem.ToString();
            int card = Convert.ToInt32(cardTextBox.Text);
            string sql = "insert into 员工信息(职工号,部门编号,职务,姓名,性别,年龄,学历,工龄,职称,银行卡号) values('"
                + id + "','" + ministryid + "','" + position + "','" + name + "','" + gender + "','" + old + "','" + education + "','" + joblong + "','" +
                jobtitle + "','" + card + "')";
            result = operation.InsertStaff(sql);
            if (result)
            {
                MessageBox.Show("插入成功", "提示", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("插入失败", "提示", MessageBoxButtons.OK);
            }
        }
    }
}
