﻿using System;
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
    public partial class LoanApplications : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        dbConnect dbConn = new dbConnect();
        SqlDataReader dr;

        

        public LoanApplications()
        {
            InitializeComponent();
            cn = new SqlConnection(dbConn.myConnection());
            
        }


        public void LoadLoanApplicationsIntoDataGridView()
        {
            int i = 0;
            dgvLoanApplications.Rows.Clear();

            // Define parameter for search text
            SqlParameter txtSearchParam = new SqlParameter("@txtSearch", SqlDbType.NVarChar);
            txtSearchParam.Value = txtSearch.Text;

            // Define the SQL query with parameters
            string query = "SELECT LoanID, PFNo, LoanAmount, InterestRate, DurationOfPayment, MonthlyInstallments, " +
                           "ApplicantName, ApplicationDate, DueDate, PendingBalance, LoanStatus " +
                           "FROM Loans " +
                           "WHERE LoanID LIKE '%' + @txtSearch + '%' " +
                           "OR PFNo LIKE '%' + @txtSearch + '%' " +
                           "OR LoanAmount LIKE '%' + @txtSearch + '%' " +
                           "OR InterestRate LIKE '%' + @txtSearch + '%' " +
                           "OR DurationOfPayment LIKE '%' + @txtSearch + '%' " +
                           "OR MonthlyInstallments LIKE '%' + @txtSearch + '%' " +
                           "OR ApplicantName LIKE '%' + @txtSearch + '%' " +
                           "OR ApplicationDate LIKE '%' + @txtSearch + '%' " +
                           "OR LoanStatus LIKE '%' + @txtSearch + '%' " +
                           "OR DueDate LIKE '%' + @txtSearch + '%';";

            // Define the SqlCommand with connection and query
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.Add(txtSearchParam);

            try
            {
                cn.Open();
                // Execute the query
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    i++;
                    string interestRate = dr["InterestRate"].ToString() + "%";
                    // Add data to DataGridView
                    dgvLoanApplications.Rows.Add(i, 
                        dr["LoanID"], 
                        dr["PFNo"],
                        dr["ApplicantName"],
                        dr["LoanAmount"], 
                        /*dr["InterestRate"],*/ 
                        interestRate,
                        dr["DurationOfPayment"],
                        ((DateTime)dr["ApplicationDate"]).ToString("dd-MMM-yyyy"),
                        ((DateTime)dr["DueDate"]).ToString("dd-MMM-yyyy"),
                        dr["MonthlyInstallments"],
                        dr["PendingBalance"],
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

        private void LoanApplications_Load(object sender, EventArgs e)
        {
            LoadLoanApplicationsIntoDataGridView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadLoanApplicationsIntoDataGridView();
        }



        private int lastClickedRowIndex = -1;

        private void dgvLoanApplications_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not the header cell and the row index is valid
            if (e.RowIndex >= 0 && e.RowIndex < dgvLoanApplications.Rows.Count && e.ColumnIndex >= 0)
            {
                // Get the clicked row
                DataGridViewRow clickedRow = dgvLoanApplications.Rows[e.RowIndex];

                // Toggle background color of the clicked row
                if (e.RowIndex == lastClickedRowIndex)
                {
                    // If the same row is clicked again, revert back to default color
                    clickedRow.DefaultCellStyle.BackColor = Color.White;
                    lastClickedRowIndex = -1; // Reset last clicked row index
                }
                else
                {
                    // Reset the background color of the last clicked row, if any
                    if (lastClickedRowIndex != -1)
                    {
                        dgvLoanApplications.Rows[lastClickedRowIndex].DefaultCellStyle.BackColor = Color.White;
                    }

                    // Highlight the clicked row by changing its background color
                    clickedRow.DefaultCellStyle.BackColor = Color.Khaki; 
                    lastClickedRowIndex = e.RowIndex; // Store the index of the last clicked row
                }
            }
        }

        //Monthly deductions method
        private void RunMonthlyDeductions()
        {
            try
            {
                cn.Open();
                string query = @"
            UPDATE Loans 
            SET PendingBalance = PendingBalance - MonthlyInstallments
            WHERE LoanStatus = 'Active' AND PendingBalance >= MonthlyInstallments;

            INSERT INTO LoanPayments (LoanID, PaymentDate, AmountPaid, PendingBalance)
            SELECT LoanID, GETDATE(), MonthlyInstallments, PendingBalance - MonthlyInstallments
            FROM Loans
            WHERE LoanStatus = 'Active' AND PendingBalance >= MonthlyInstallments;
        ";

                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Monthly deductions have been successfully processed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void metroBtnNewLoan_Click_1(object sender, EventArgs e)
        {
            NewLoan newLoan = new NewLoan(this);
            newLoan.ShowDialog();
        }

        private void metroBtnRunLoansDeduction_Click(object sender, EventArgs e)
        {
            RunMonthlyDeductions();
            LoadLoanApplicationsIntoDataGridView();
        }
    }
}
