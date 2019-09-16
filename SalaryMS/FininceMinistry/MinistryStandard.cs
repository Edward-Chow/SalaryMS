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

namespace SalaryMS.FininceMinistry
{
    public partial class MinistryStandard : Form
    {
        Operation operation = new Operation();

        public MinistryStandard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "update 其他工资标准 set 迟到每天扣款 = '" + textBox1.Text + "', 缺勤每天扣款 = '" + textBox2.Text + "', 请假每天扣款 = '" + textBox3.Text + "', 加班每天奖金 = '" + textBox4.Text + "' where 部门编号 = '" + comboBox1.SelectedItem.ToString().Substring(0, 1) + "'";
            if (operation.UpdateStaff(sql))
                MessageBox.Show("更新成功", "提示", MessageBoxButtons.OK);
            else
                MessageBox.Show("更新失败", "提示", MessageBoxButtons.OK);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
