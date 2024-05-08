using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EAC_STAFF_WELFARE_LMS
{
    class dbConnect
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        private string _connectionString;
        public string myConnection() {
            _connectionString = @"Data Source=EDDY-SP\SQLEXPRESS;Initial Catalog=EacLMSDB;Integrated Security=True";
            return _connectionString; 
        }

        public DataTable getTable(string query)
        {
            cn.ConnectionString = _connectionString;
            cmd = new SqlCommand(query, cn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            return dataTable;
        }
    }
}
