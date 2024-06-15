using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace EAC_STAFF_WELFARE_LMS
{
    public partial class LoanPaymentHistory : Form
    {
        private string loanId; 
        private SqlConnection cn;
        private SqlCommand cmd;
        private dbConnect dbConn;

        public LoanPaymentHistory(string loanId)
        {
            InitializeComponent();
            this.loanId = loanId;
            dbConn = new dbConnect();
            cn = new SqlConnection(dbConn.myConnection());
            LoadPaymentHistory();
        }



        private void LoadPaymentHistory()
        {

            dgvLoanPaymentHistory.GridColor = Color.LightGray;
            dgvLoanPaymentHistory.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvLoanPaymentHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvLoanPaymentHistory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

           dgvLoanPaymentHistory.EnableHeadersVisualStyles = false;
            dgvLoanPaymentHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvLoanPaymentHistory.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;


            try
            {
                cn.Open();
                string query2 = "SELECT ApplicantName from Loans WHERE LoanID = @LoanID";
                cmd = new SqlCommand(query2, cn);
                cmd.Parameters.AddWithValue("@loanId", loanId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    labelApplicant.Text = reader["ApplicantName"].ToString();
                }
                reader.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message); ;
            }
            finally
            {
                cn.Close();
            }



            int i = 0;
            dgvLoanPaymentHistory.Rows.Clear();

            string query = "SELECT PaymentID, LoanID, AmountPaid, PendingBalance, PaymentDate " +
                           "FROM LoanPayments WHERE LoanID = @LoanID";
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.Add("@LoanID", SqlDbType.NVarChar, 50).Value = loanId; 

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

        private int lastClickedRowIndex = -1;

        private void dgvLoanPaymentHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLoanPaymentHistory.Rows.Count && e.ColumnIndex >= 0)
            {
                DataGridViewRow clickedRow = dgvLoanPaymentHistory.Rows[e.RowIndex];

                if (e.RowIndex == lastClickedRowIndex)
                {
                    clickedRow.DefaultCellStyle.BackColor = Color.White;

                    lastClickedRowIndex = -1;
                }
                else
                {
                    if (lastClickedRowIndex != -1)
                    {
                        dgvLoanPaymentHistory.Rows[lastClickedRowIndex].DefaultCellStyle.BackColor = Color.White;
                    }

                    clickedRow.DefaultCellStyle.BackColor = Color.Khaki;

                    lastClickedRowIndex = e.RowIndex;
                }
            }
        }
    }

}
