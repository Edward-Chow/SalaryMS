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
    public partial class AttendanceInsert : Form
    {
        Operation operation = new Operation();

        public AttendanceInsert()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int userid = Convert.ToInt32(textBox1.Text);
            DateTime mintime = dateTimePicker1.Value.Date;
            string absence = comboBox1.SelectedItem.ToString();
            string leave = comboBox2.SelectedItem.ToString();
            string late = comboBox3.SelectedItem.ToString();
            string overtiem = comboBox4.SelectedItem.ToString();

            string sql = "insert into 考勤情况(职工号,日期,缺勤天数,请假天数,迟到天数,加班天数) values('" + userid + "','" + mintime + "','" + absence + "','" + leave + "','" + late + "','" + overtiem + "')";
            if (operation.InsertStaff(sql))
                MessageBox.Show("插入成功", "提示", MessageBoxButtons.OK);
            else
                MessageBox.Show("插入失败", "提示", MessageBoxButtons.OK);

        }
    }
}
