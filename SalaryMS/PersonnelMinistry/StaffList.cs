using System;
using SalaryMS.Connection;
using SalaryMS.PersonnelMinistry;
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
    public partial class stafflist : Form
    {
        Operation operation = new Operation();

        public stafflist()
        {
            InitializeComponent();
            this.dataGridView1.ReadOnly = true;
        }

        private void StaffList_Load(object sender, EventArgs e)
        {
            string sql = "select 职工号,姓名 from 员工信息";
            operation.DataBind(this.dataGridView1, sql);
            InitDataGridViewHead();
        }

        private void InitDataGridViewHead()
        {
            this.dataGridView1.Columns[0].HeaderText = "职工号";

            this.dataGridView1.Columns[1].HeaderText = "姓名";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StaffUpdate updateForm = new StaffUpdate();
            int a = dataGridView1.CurrentRow.Index;
            updateForm.label1.Text += dataGridView1.Rows[a].Cells[0].Value;
            updateForm.label2.Text += dataGridView1.Rows[a].Cells[1].Value;
            updateForm.ShowDialog();
        }
    }
}
