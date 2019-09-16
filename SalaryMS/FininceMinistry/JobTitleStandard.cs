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
    public partial class JobTitleStandard : Form
    {
        Operation operation = new Operation();

        public JobTitleStandard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "update 职称工资 set 工资 = '" + textBox2.Text + "' where 职称 = '" + comboBox1.SelectedItem.ToString() + "'";
            if (operation.UpdateStaff(sql))
                MessageBox.Show("更新成功", "提示", MessageBoxButtons.OK);
            else
                MessageBox.Show("更新失败", "提示", MessageBoxButtons.OK);
        }
    }
}
