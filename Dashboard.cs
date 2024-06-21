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
    public partial class Dashboard : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        dbConnect dbConn = new dbConnect();
        SqlDataReader dr;

        public Dashboard()
        {
            InitializeComponent();
            cn = new SqlConnection(dbConn.myConnection());
            LoadLoanApplicationsIntoDataGridView();
        }


        public void LoadLoanApplicationsIntoDataGridView()
        {
            
            int i = 0;
            dgvLoansDashBoard.Rows.Clear();

            // Define the SQL query with parameters
            string query = "SELECT LoanID, PFNo, LoanAmount, InterestRate, DurationOfPayment, " +
                           "ApplicantName, ApplicationDate, DueDate, PendingBalance, LoanStatus " +
                           "FROM Loans " +
                           "WHERE LoanStatus = 'Active'";

            // Define the SqlCommand with connection and query
            SqlCommand cmd = new SqlCommand(query, cn);

            try
            {
                cn.Open();
                // Execute the query
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    string interestRate = dr["InterestRate"].ToString() + "%";

                    // Calculate the %Paid
                    decimal loanAmount = Convert.ToDecimal(dr["LoanAmount"]);
                    decimal pendingBalance = Convert.ToDecimal(dr["PendingBalance"]);
                    decimal percentPaid = ((loanAmount - pendingBalance) / loanAmount) * 100;

                    // Add data to DataGridView
                    dgvLoansDashBoard.Rows.Add(i,
                        dr["LoanID"],
                        dr["PFNo"],
                        dr["ApplicantName"],
                        loanAmount,
                        interestRate,
                        dr["DurationOfPayment"],
                        ((DateTime)dr["ApplicationDate"]).ToString("dd-MMM-yyyy"),
                        ((DateTime)dr["DueDate"]).ToString("dd-MMM-yyyy"),
                        pendingBalance,
                        percentPaid.ToString("F2") + "%",
                        dr["LoanStatus"]
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                // Close the SqlConnection
                cn.Close();
            }
        }

        private int lastClickedRowIndex = -1;

        private void dgvLoansDashBoard_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvLoansDashBoard.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            if (e.RowIndex >= 0 && e.RowIndex < dgvLoansDashBoard.Rows.Count && e.ColumnIndex >= 0)
            {
                DataGridViewRow clickedRow = dgvLoansDashBoard.Rows[e.RowIndex];

                if (e.RowIndex == lastClickedRowIndex)
                {
                    clickedRow.DefaultCellStyle.BackColor = Color.White;

                    lastClickedRowIndex = -1;
                }
                else
                {
                    if (lastClickedRowIndex != -1)
                    {
                        dgvLoansDashBoard.Rows[lastClickedRowIndex].DefaultCellStyle.BackColor = Color.White;
                    }

                    clickedRow.DefaultCellStyle.BackColor = Color.Khaki;

                    lastClickedRowIndex = e.RowIndex;
                }
            }
        }

        private void dgvLoansDashBoard_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
                if (e.RowIndex >= 0 && e.RowIndex < dgvLoansDashBoard.Rows.Count && e.ColumnIndex >= 0)
                {
                    DataGridViewRow clickedRow = dgvLoansDashBoard.Rows[e.RowIndex];
                    string loanId = clickedRow.Cells["LoanID"].Value.ToString();
                    LoanPaymentHistory loanPaymentHistoryForm = new LoanPaymentHistory(loanId);
                    loanPaymentHistoryForm.ShowDialog();
                }
        }
    }
}
