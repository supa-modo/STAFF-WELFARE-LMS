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
            CalculateAndDisplayTotalSavings();
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
            string query = "SELECT SavingsId, s.PFNo AS PFNo, " +
                           "CONCAT(m.FirstName, ' ', ISNULL(m.MiddleName + ' ', ''), m.LastName) AS ApplicantName, " +
                           "m.MonthlySavings AS MonthlySavingsDeduction, " +
                           "SavingsAccountBalance, LastUpdated, 'ACTIVE' AS Status " +
                           "FROM Savings s " +
                           "INNER JOIN Members m ON s.PFNo = m.MemberPFNo " +
                           "WHERE SavingsId LIKE '%' + @txtSearch + '%' " +
                           "OR s.PFNo LIKE '%' + @txtSearch + '%' " +
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
                        ((DateTime)dr["LastUpdated"]).ToString("dd-MMM-yyyy"));
                    
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
                    LoadSavingsIntoDataGridView();
                    CalculateAndDisplayTotalSavings();
                }
            }
        }


        //Function that calculates the total savings balance when called
        private void CalculateAndDisplayTotalSavings()
        {
            // Define the SQL query to calculate the total savings
            string query = "SELECT SUM(SavingsAccountBalance) AS TotalSavings FROM Savings";
            SqlCommand cmd = new SqlCommand(query, cn);

            try
            {
                cn.Open();
                // Execute the query and get the result
                object result = cmd.ExecuteScalar();

                // Check if the result is not null
                if (result != DBNull.Value)
                {
                    // Convert the result to decimal and display it in the label
                    decimal totalSavings = Convert.ToDecimal(result);
                    labelTotalSavings.Text = totalSavings.ToString("C"); // Currency format
                }
                else
                {
                    // If no savings found, display 0 in the label
                    labelTotalSavings.Text = "0";
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


        private void Savings_Load(object sender, EventArgs e)
        {
            LoadSavingsIntoDataGridView();
            CalculateAndDisplayTotalSavings();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadSavingsIntoDataGridView();
        }
    }
}
