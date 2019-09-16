using System;
using 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalaryMS.Staff
{
    public partial class SalaryLogin : Form
    {
        public SalaryLogin(int userid)
        {
            InitializeComponent();
            String sql = "select 名字 from 系统用户 where 用户名 = '" + userid + "'";
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
