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
    public partial class StaffUpdate : Form
    {
        Operation operation = new Operation();

        public StaffUpdate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(label1.Text);
            int ministryid = Convert.ToInt32(comboBox1.SelectedItem.ToString().Substring(0, 1));
            string position = comboBox5.SelectedItem.ToString();
            string gender = comboBox2.SelectedItem.ToString();
            int old = System.DateTime.Now.Year - dateTimePicker1.Value.Date.Year;
            string education = comboBox3.SelectedItem.ToString();
            int joblong = System.DateTime.Now.Year - dateTimePicker2.Value.Date.Year;
            string jobtitle = comboBox4.SelectedItem.ToString();
            int card = Convert.ToInt32(textBox2.Text);

            string sql = "update 员工信息 set 部门编号 = '" + ministryid + "', 职务 = '" + position + "', 性别 = '" + gender + "', 年龄 = '" + old + "', 学历 = '" + education + "', 工龄 = '" + joblong + "', 职称 = '" + jobtitle + "', 银行卡号 = '" + card + "' where 职工号 = '" + userid + "'";
            if (operation.UpdateStaff(sql))
                MessageBox.Show("更新成功！", "提示", MessageBoxButtons.OK);
            else
                MessageBox.Show("更新失败！", "提示", MessageBoxButtons.OK);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StaffUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
