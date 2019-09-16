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
    public partial class userDelete : Form
    {
        Operation operation = new Operation();

        public userDelete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否确认删除？", "提示", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string sql1 = "select * from 系统用户 where 用户名 = '" + textBox1.Text + "'";
                if (operation.FindExist(sql1))
                {
                    string sql = "delete from 系统用户 where 用户名 = '" + textBox1.Text + "'";
                    bool result = false;
                    result = operation.DeleteStaff(sql);
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("此用户不存在", "提示", MessageBoxButtons.OK);
                }



            }
        }
    }
}
