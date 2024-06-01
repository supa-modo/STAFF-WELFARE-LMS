using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EAC_STAFF_WELFARE_LMS
{
    public partial class LoanPaymentHistory : Form
    {
        private string loanId; // Change to string
        private SqlConnection cn;
        private SqlCommand cmd;
        private dbConnect dbConn;

        public LoanPaymentHistory(string loanId) // Change to string
        {
            InitializeComponent();
            this.loanId = loanId;
            dbConn = new dbConnect();
            cn = new SqlConnection(dbConn.myConnection());
            LoadPaymentHistory();
        }

        private void LoadPaymentHistory()
        {
            int i = 0;
            dgvLoanPaymentHistory.Rows.Clear();

            string query = "SELECT PaymentID, LoanID, AmountPaid, PendingBalance, PaymentDate " +
                           "FROM LoanPayments WHERE LoanID = @LoanID";
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.Add("@LoanID", SqlDbType.NVarChar, 50).Value = loanId; // Use NVarChar and adjust length

            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    // Add data to DataGridView
                    dgvLoanPaymentHistory.Rows.Add(
                        dr["PaymentID"],
                        dr["LoanID"],
                        dr["AmountPaid"],
                        dr["PendingBalance"],
                        ((DateTime)dr["PaymentDate"]).ToString("dd-MMM-yyyy")
                    );
                }
                dr.Close();
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

        private void picBxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }

}
