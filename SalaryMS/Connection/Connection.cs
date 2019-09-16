using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryMS.Connection
{
    class Connection
    {
        public static SqlConnection MyConnection()
        {
            string source = @"Data Source=LAPTOP-HC61RIUE\SQLEXPRESS01;Initial catalog=SalaryDb;integrated Security=True";
            return new SqlConnection(source);
        }
    }
}
