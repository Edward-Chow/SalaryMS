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
    public partial class EducationStandard : Form
    {
        Operation operation = new Operation();

        public EducationStandard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "update 学历工资 set 工资 = '" + textBox2.Text + "' where 学历 = '" + comboBox1.SelectedItem.ToString() + "'";
            if (operation.UpdateStaff(sql))
                MessageBox.Show("更新成功", "提示", MessageBoxButtons.OK);
            else
                MessageBox.Show("更新失败", "提示", MessageBoxButtons.OK);
        }
    }
}
