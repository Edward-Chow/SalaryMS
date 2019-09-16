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
    public partial class StaffallMonthSalary : Form
    {
        public int userid;
        Operation operation = new Operation();

        public StaffallMonthSalary(int userid)
        {
            InitializeComponent();
            this.dataGridView1.ReadOnly = true;
            this.userid = userid;
        }

        private void StaffallMonthSalary_Load(object sender, EventArgs e)
        {
            string sql = "select * from 工资表 where 职工号 = '" + this.userid + "' order by 日期 desc";
            operation.DataBind(this.dataGridView1, sql);
            InitDataGridViewHead();
        }

        private void InitDataGridViewHead()
        {
            this.dataGridView1.Columns[0].HeaderText = "职工号";

            this.dataGridView1.Columns[1].HeaderText = "日期";

            this.dataGridView1.Columns[2].HeaderText = "基本工资";

            this.dataGridView1.Columns[3].HeaderText = "加班费";

            this.dataGridView1.Columns[4].HeaderText = "扣款";

            this.dataGridView1.Columns[5].HeaderText = "当月工资";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
