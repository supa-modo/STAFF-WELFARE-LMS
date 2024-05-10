using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAC_STAFF_WELFARE_LMS
{
    public partial class Members : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        dbConnect dbConn = new dbConnect();
        SqlDataReader dr;

        public Members()
        {
            InitializeComponent();
            cn = new SqlConnection(dbConn.myConnection());
            
        }

        private void Members_Load(object sender, EventArgs e)
        {
            // Load data into DataGridView when the form loads
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            int i = 0;
            dgvMembers.Rows.Clear();

            // Define parameter for search text
            SqlParameter txtSearchParam = new SqlParameter("@txtSearch", SqlDbType.NVarChar);
            txtSearchParam.Value = txtSearch.Text;

            // Define the SQL query with parameters
            string query = "SELECT EMPLOYEE_CODE, EMPLOYEE_NAME, CURRENT_EMPLOYEE_STATUS, AGE_TEXT, " +
                           "NATIONALITY, MARITAL_STATUS, OFFICE, EMAIL " +
                           "FROM employeeMaster " +
                           "WHERE EMPLOYEE_CODE LIKE '%' + @txtSearch + '%' " +
                           "OR EMPLOYEE_NAME LIKE '%' + @txtSearch + '%' " +
                           "OR CURRENT_EMPLOYEE_STATUS LIKE '%' + @txtSearch + '%' " +
                           "OR AGE_TEXT LIKE '%' + @txtSearch + '%' " +
                           "OR NATIONALITY LIKE '%' + @txtSearch + '%' " +
                           "OR MARITAL_STATUS LIKE '%' + @txtSearch + '%' " +
                           "OR OFFICE LIKE '%' + @txtSearch + '%' " +
                           "OR EMAIL LIKE '%' + @txtSearch + '%';";

            // Define the SqlCommand with connection and query
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.Add(txtSearchParam);

            try
            {
                cn.Open();
                // Execute the query
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    // Add data to DataGridView
                    dgvMembers.Rows.Add(i, dr["EMPLOYEE_CODE"], dr["EMPLOYEE_NAME"], dr["CURRENT_EMPLOYEE_STATUS"], dr["AGE_TEXT"], dr["NATIONALITY"], dr["MARITAL_STATUS"], dr["OFFICE"], dr["EMAIL"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the DataReader and SqlConnection
                dr.Close();
                cn.Close();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void metroBtnNew_Click(object sender, EventArgs e)
        {
            addMemberModule addMemberModule = new addMemberModule();
            addMemberModule.ShowDialog();
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                addMemberModule addMemberModule = new addMemberModule();
                addMemberModule.ShowDialog();
            }

        }
    }
}
