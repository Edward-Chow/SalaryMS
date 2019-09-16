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
    public partial class StaffInfo : Form
    {
        public int userid;
        Operation operation = new Operation();

        public StaffInfo(int id)
        {
            InitializeComponent();
            this.dataGridView1.ReadOnly = true;
            this.userid = id;
        }

        private void StaffInfo_Load(object sender, EventArgs e)
        {
            string sql = "select 职工号,职务,姓名,性别,年龄,学历,工龄,职称,银行卡号,部门名称 from 员工信息 join 部门信息 on (员工信息.部门编号 = 部门信息.部门编号) where 职工号 = '" + userid + "'";
            operation.DataBind(this.dataGridView1, sql);
            InitDataGridViewHead();
        }

        private void InitDataGridViewHead()
        {
            this.dataGridView1.Columns[0].HeaderText = "职工号";

            this.dataGridView1.Columns[1].HeaderText = "职务";

            this.dataGridView1.Columns[2].HeaderText = "姓名";

            this.dataGridView1.Columns[3].HeaderText = "性别";

            this.dataGridView1.Columns[4].HeaderText = "年龄";

            this.dataGridView1.Columns[5].HeaderText = "学历";

            this.dataGridView1.Columns[6].HeaderText = "工龄";

            this.dataGridView1.Columns[7].HeaderText = "职称";

            this.dataGridView1.Columns[8].HeaderText = "银行卡号";

            this.dataGridView1.Columns[9].HeaderText = "部门";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
