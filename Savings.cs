using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EAC_STAFF_WELFARE_LMS
{
    public partial class Savings : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        dbConnect dbConn;
        SqlDataReader dr;

        public Savings()
        {
            InitializeComponent();
            dbConn = new dbConnect();
            cn = new SqlConnection(dbConn.myConnection());
        }

        //Function that loads savings data to the savings datagridview from the database when called
        private void LoadSavingsIntoDataGridView()
        {
            int i = 0;
            dgvMemberSavings.Rows.Clear();

            // Defining parameter for search text
            SqlParameter txtSearchParam = new SqlParameter("@txtSearch", SqlDbType.NVarChar);
            txtSearchParam.Value = txtSearch.Text;

            // Defining the SQL query with parameters
            string query = "SELECT SavingsId, s.MemberPFNo AS PFNo, " +
                           "CONCAT(m.FirstName, ' ', ISNULL(m.MiddleName + ' ', ''), m.LastName) AS ApplicantName, " +
                           "m.MonthlySavings AS MonthlySavingsDeduction, " +
                           "SavingsAccountBalance, LastUpdated, 'ACTIVE' AS Status " +
                           "FROM Savings s " +
                           "INNER JOIN Members m ON s.MemberPFNo = m.PFNo " +
                           "WHERE SavingsId LIKE '%' + @txtSearch + '%' " +
                           "OR s.MemberPFNo LIKE '%' + @txtSearch + '%' " +
                           "OR SavingsAccountBalance LIKE '%' + @txtSearch + '%' " +
                           "OR LastUpdated LIKE '%' + @txtSearch + '%' " +
                           "OR CONCAT(m.FirstName, ' ', ISNULL(m.MiddleName + ' ', ''), m.LastName) LIKE '%' + @txtSearch + '%' " +
                           "OR m.MonthlySavings LIKE '%' + @txtSearch + '%';";

            // Defining the SqlCommand with connection and query
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.Add(txtSearchParam);

            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    // Adding data to DataGridView
                    dgvMemberSavings.Rows.Add(i,
                        dr["SavingsId"],
                        dr["PFNo"],
                        dr["ApplicantName"],
                        dr["MonthlySavingsDeduction"],
                        dr["SavingsAccountBalance"],
                        dr["LastUpdated"],
                        "ACTIVE");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }


        //Function that will add Monthly savings to Savings balance when called
        private void metroBtnRunSavingsUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();

                //command to execute the stored procedure
                cmd = new SqlCommand("UpdateSavingsAndLogHistory", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.ExecuteNonQuery();

                // Informing the user of the successful update
                MessageBox.Show("Savings update completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handling any errors that may have occurred
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensuring the connection is closed
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
    }
}
