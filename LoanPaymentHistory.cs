﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

            dgvLoanPaymentHistory.GridColor = Color.SeaGreen;
            dgvLoanPaymentHistory.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dgvLoanPaymentHistory.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvLoanPaymentHistory.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            // Optionally, set other visual properties
            dgvLoanPaymentHistory.EnableHeadersVisualStyles = false;
            dgvLoanPaymentHistory.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dgvLoanPaymentHistory.DefaultCellStyle.SelectionBackColor = Color.Khaki;



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

        
    }

}