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

        private void metroBtnRunSavingsUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Open the connection
                cn.Open();

                // Create the command to execute the stored procedure
                cmd = new SqlCommand("UpdateSavingsAndLogHistory", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Execute the command
                cmd.ExecuteNonQuery();

                // Inform the user of the successful update
                MessageBox.Show("Savings update completed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle any errors that may have occurred
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Ensure the connection is closed
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
        }
    }
}
