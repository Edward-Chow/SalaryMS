using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryMS.Connection
{
    class Operation
    {
        SqlConnection con = Connection.MyConnection();

        public void CloseConnection()
        {
            con.Close();
        }

        public bool FindExist(string sql)
        {
            con.Open();
            bool exist = false;
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dataReader = cmd.ExecuteReader();
            if (dataReader.Read() == true)
            {
                exist = true;
            }
            con.Close();
            cmd.Dispose();
            return exist;
        }

        public string Find(string sql)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            object obj = cmd.ExecuteScalar();
            String dr = null;
            if (obj != null)
            {
                dr = obj.ToString();
            }
            con.Close();
            cmd.Dispose();
            return dr;
        }

        public void DataBind(DataGridView Dgv, string Sql)
        {
            con.Open();
            SqlDataAdapter Sda = new SqlDataAdapter(Sql, con);
            DataSet Ds = new DataSet();
            Sda.Fill(Ds);
            Dgv.DataSource = Ds.Tables[0];
            con.Close();
            Ds.Dispose();
        }

        public bool InsertStaff(string sql)
        {
            bool result = false;
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            if (cmd.ExecuteNonQuery() == 1)
                result = true;
            con.Close();
            cmd.Dispose();
            return result;
        }

        public void Insert(string sql)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            cmd.Dispose();
        }

        public bool DeleteStaff(string sql)
        {
            bool result = false;
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            if (cmd.ExecuteNonQuery() == 1)
                result = true;
            con.Close();
            cmd.Dispose();
            return result;
        }

        public bool UpdateStaff(string sql)
        {
            bool result = false;
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            int exe = -1;
            exe = cmd.ExecuteNonQuery();
            if (exe > 0)
                result = true;
            con.Close();
            cmd.Dispose();
            return result;
        }

        public List<int> CountStaff(string sql)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            List<int> list = new List<int>();
            foreach (DataRow row in dt.Rows)
            {
                list.Add(Convert.ToInt32(row["职工号"].ToString()));
            }
            con.Close();
            dt.Dispose();
            sda.Dispose();
            return list;
        }
    }
}
