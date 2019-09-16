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
    public partial class SalaryStandardQuery : Form
    {
        Operation operation = new Operation();

        public SalaryStandardQuery()
        {
            InitializeComponent();
            this.dataGridView1.ReadOnly = true;
            this.dataGridView2.ReadOnly = true;
            this.dataGridView3.ReadOnly = true;
            this.dataGridView4.ReadOnly = true;
        }

        private void SalaryStandardQuery_Load(object sender, EventArgs e)
        {
            string sql1 = "select * from 职称工资";
            operation.DataBind(this.dataGridView1, sql1);
            string sql2 = "select * from 学历工资";
            operation.DataBind(this.dataGridView2, sql2);
            string sql3 = "select * from 工龄工资";
            operation.DataBind(this.dataGridView3, sql3);
            string sql4 = "select 部门名称,迟到每天扣款,缺勤每天扣款,请假每天扣款,加班每天奖金 from 其他工资标准 join 部门信息 on (部门信息.部门编号 = 其他工资标准.部门编号)";
            operation.DataBind(this.dataGridView4, sql4);
            InitDataGridViewHead();
        }

        private void InitDataGridViewHead()
        {
            this.dataGridView1.Columns[0].HeaderText = "职称";
            this.dataGridView1.Columns[1].HeaderText = "工资";

            this.dataGridView2.Columns[0].HeaderText = "学历";
            this.dataGridView2.Columns[1].HeaderText = "工资";

            this.dataGridView3.Columns[0].HeaderText = "工龄";
            this.dataGridView3.Columns[1].HeaderText = "工资";

            this.dataGridView4.Columns[0].HeaderText = "部门";
            this.dataGridView4.Columns[1].HeaderText = "迟到每天扣款";
            this.dataGridView4.Columns[2].HeaderText = "缺勤每天扣款";
            this.dataGridView4.Columns[3].HeaderText = "请假每天扣款";
            this.dataGridView4.Columns[4].HeaderText = "加班每天奖金";
        }
    }
}
