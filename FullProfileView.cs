﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace EAC_STAFF_WELFARE_LMS
{
    public partial class FullProfileView : Form
    {
        private string pfNo;
        private SqlConnection cn;
        private SqlCommand cmd;
        private dbConnect dbConn;
        Members members;

        public FullProfileView(string pfNo, Members membersForm)
        {
            InitializeComponent();
            members = membersForm;
            this.pfNo = pfNo;
            dbConn = new dbConnect();
            cn = new SqlConnection(dbConn.myConnection());
            loadFullProfile();
            SetControlsReadOnly(true);
            btnSave.Visible = false;
            btnCancel.Visible = false;
            loadLoansData();
            CalculateTotalIndividualActiveLoans();
            CalculateTotalIndividualLoans();
            LoadSavingsHistoryIntoDataGridView();
        }

        private void picBxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void loadLoansData()
        {
            dgvIndividualLoans.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            int i = 0;
            dgvIndividualLoans.Rows.Clear();

            string query = "SELECT LoanID, LoanAmount, DurationOfPayment, InterestRate, ApplicationDate, DueDate, MonthlyInstallments, PendingBalance, LoanStatus FROM Loans WHERE PFNo = @StaffCode";
            cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@StaffCode", pfNo);

            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    decimal loanAmount = dr.GetDecimal(dr.GetOrdinal("LoanAmount"));
                    decimal pendingBalance = dr.GetDecimal(dr.GetOrdinal("PendingBalance"));
                    decimal amountPaid = loanAmount - pendingBalance;
                    string interestRate = dr["InterestRate"].ToString() + "%";

                    dgvIndividualLoans.Rows.Add(i,
                        dr["LoanID"],
                        loanAmount,
                        dr["DurationOfPayment"],
                        interestRate,
                        ((DateTime)dr["ApplicationDate"]).ToString("dd-MMM-yyyy"),
                        ((DateTime)dr["DueDate"]).ToString("dd-MMM-yyyy"),
                        amountPaid,
                        pendingBalance,
                        dr["LoanStatus"]
                    );
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }


        private void CalculateTotalIndividualLoans()
        {
            decimal totalIndividualLoans = 0;

            try
            {
                //Getting specific individual's total loans whether active or paid
                cn.Open();
                string query = "SELECT SUM(LoanAmount) AS TotalLoanAmount FROM Loans WHERE PFNo = @StaffCode";
                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@StaffCode", pfNo);

                Object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalIndividualLoans = Convert.ToDecimal(result);

                }
                labelTotalLoans.Text = totalIndividualLoans.ToString("C");

            }
            catch (Exception ex)
            {

                MessageBox.Show("An Error occured: " + ex.Message);
            }
            finally { 
                cn.Close(); 
            }
        }


        private void CalculateTotalIndividualActiveLoans()
        {
            decimal totalIndividualLoans = 0;

            try
            {
                //Getting specific individual's total active loans
                cn.Open();
                string query = "SELECT SUM(PendingBalance) AS TotalLoanAmount FROM Loans WHERE PFNo = @StaffCode AND LoanStatus = 'Active'";
                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@StaffCode", pfNo);

                Object result = cmd.ExecuteScalar();
                if (result != DBNull.Value)
                {
                    totalIndividualLoans = Convert.ToDecimal(result);

                }
                labelPendingLoans.Text = totalIndividualLoans.ToString("C");

            }
            catch (Exception ex)
            {

                MessageBox.Show("An Error occured: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }


        private void loadFullProfile()
        {
            try
            {
                cn.Open();
                string query = "SELECT MemberPFNo, FirstName, MiddleName, LastName, ContractStartDate, ContractEndDate, EmailAddress, SecondaryEmail, PhoneNumber1, PhoneNumber2, PhysicalAddress, JobTitle, Department, ContractType FROM Members WHERE MemberPFNo = @StaffCode";
                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@StaffCode", pfNo);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    labelPFNo2.Text = reader["MemberPFNo"].ToString();
                    txtFName.Text = reader["FirstName"].ToString();
                    txtMName.Text = reader["MiddleName"].ToString();
                    txtLName.Text = reader["LastName"].ToString();
                    txtPhone1.Text = reader["PhoneNumber1"].ToString();
                    txtPhone2.Text = reader["PhoneNumber2"].ToString();
                    txtEmail.Text = reader["EmailAddress"].ToString();
                    txtEmail2.Text = reader["SecondaryEmail"].ToString();
                    txtAddress.Text = reader["PhysicalAddress"].ToString();
                    txtTitle.Text = reader["JobTitle"].ToString();
                    txtDpt.Text = reader["Department"].ToString();
                    comboContract.Text = reader["ContractType"].ToString();
                    metroDateTimeStart.Value = Convert.ToDateTime(reader["ContractStartDate"]);
                    metroDateTimeEnd.Value = Convert.ToDateTime(reader["ContractEndDate"]);

                    labelEmail.Text = txtEmail.Text = reader["EmailAddress"].ToString();
                    labelJobTitle.Text = reader["JobTitle"].ToString();
                    string fullName = $"{reader["FirstName"]} {reader["MiddleName"]} {reader["LastName"]}".Trim();
                    labelFullName.Text = fullName;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }

        private void SetControlsReadOnly(bool readOnly)
        {
            txtFName.ReadOnly = readOnly;
            txtMName.ReadOnly = readOnly;
            txtLName.ReadOnly = readOnly;
            txtPhone1.ReadOnly = readOnly;
            txtPhone2.ReadOnly = readOnly;
            txtEmail.ReadOnly = readOnly;
            txtEmail2.ReadOnly = readOnly;
            txtAddress.ReadOnly = readOnly;
            txtTitle.ReadOnly = readOnly;
            txtDpt.ReadOnly = readOnly;
            comboContract.Enabled = !readOnly;
            metroDateTimeStart.Enabled = !readOnly;
            metroDateTimeEnd.Enabled = !readOnly;

            

        }


        private int lastClickedRowIndex = -1;
        private void dgvIndividualLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvIndividualLoans.Rows.Count && e.ColumnIndex >= 0)
            {
                DataGridViewRow clickedRow = dgvIndividualLoans.Rows[e.RowIndex];

                if (e.RowIndex == lastClickedRowIndex)
                {
                    clickedRow.DefaultCellStyle.BackColor = Color.White;
                    lastClickedRowIndex = -1;
                }
                else
                {
                    if (lastClickedRowIndex != -1)
                    {
                        dgvIndividualLoans.Rows[lastClickedRowIndex].DefaultCellStyle.BackColor = Color.White;
                    }

                    clickedRow.DefaultCellStyle.BackColor = Color.Khaki;
                    lastClickedRowIndex = e.RowIndex;
                }
            }
        }

        private void metrobtnEdit_Click_1(object sender, EventArgs e)
        {
            // Enabling the controls for editing
            SetControlsReadOnly(false);
            btnSave.Visible = true;
            btnCancel.Visible = true;
            metrobtnEdit.Visible = false;
            txtFName.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cn.Open();
                string query = "UPDATE Members SET FirstName = @FirstName, MiddleName = @MiddleName, LastName = @LastName, ContractStartDate = @ContractStartDate, ContractEndDate = @ContractEndDate, EmailAddress = @EmailAddress, SecondaryEmail = @SecondaryEmail, PhoneNumber1 = @PhoneNumber1, PhoneNumber2 = @PhoneNumber2, PhysicalAddress = @PhysicalAddress, JobTitle = @JobTitle, Department = @Department, ContractType = @ContractType WHERE MemberPFNo = @StaffCode";
                cmd = new SqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@FirstName", txtFName.Text);
                cmd.Parameters.AddWithValue("@MiddleName", txtMName.Text);
                cmd.Parameters.AddWithValue("@LastName", txtLName.Text);
                cmd.Parameters.AddWithValue("@ContractStartDate", metroDateTimeStart.Value);
                cmd.Parameters.AddWithValue("@ContractEndDate", metroDateTimeEnd.Value);
                cmd.Parameters.AddWithValue("@EmailAddress", txtEmail.Text);
                cmd.Parameters.AddWithValue("@SecondaryEmail", txtEmail2.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber1", txtPhone1.Text);
                cmd.Parameters.AddWithValue("@PhoneNumber2", txtPhone2.Text);
                cmd.Parameters.AddWithValue("@PhysicalAddress", txtAddress.Text);
                cmd.Parameters.AddWithValue("@JobTitle", txtTitle.Text);
                cmd.Parameters.AddWithValue("@Department", txtDpt.Text);
                cmd.Parameters.AddWithValue("@ContractType", comboContract.Text);
                cmd.Parameters.AddWithValue("@StaffCode", pfNo);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Profile updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                cn.Close();
                SetControlsReadOnly(true);
                btnSave.Visible = false;
                btnCancel.Visible = false;
                metrobtnEdit.Visible = true;
                members.LoadMembersDataIntoDataGridView();
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            loadFullProfile();
            SetControlsReadOnly(true);
            btnSave.Visible = false;
            btnCancel.Visible = false;
            metrobtnEdit.Visible = true;
        }


        //Function that loads savings data to the savings datagridview from the database when called
        private void LoadSavingsHistoryIntoDataGridView()
        {
            int i = 0;
            dgvSavingsHistory.Rows.Clear();

            // Defining the SQL query with parameters
            string query = @"SELECT 
                      sh.HistoryId, 
                      sh.PFNo, 
                      sh.TransactionDate, 
                      sh.Amount, 
                      sh.BalanceAfterTransaction,
                  CONCAT(m.FirstName, ' ', ISNULL(m.MiddleName + ' ', ''), m.LastName) AS ApplicantName
                  FROM SavingsHistory sh
                  INNER JOIN Members m ON sh.PFNo = m.MemberPFNo
                  WHERE sh.PFNo = @PFNo ORDER BY sh.HistoryId DESC;";

            // Defining the SqlCommand with connection and query
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@PFNo", "2304"); // Replace with the actual PFNo you want to filter by

            try
            {
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    // Adding data to DataGridView
                    dgvSavingsHistory.Rows.Add(i,
                        dr["HistoryId"],
                        dr["PFNo"],
                        ((DateTime)dr["TransactionDate"]).ToString("dd-MMM-yyyy"),
                        dr["Amount"],
                        dr["BalanceAfterTransaction"]);
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

        private void dgvSavingsHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvSavingsHistory.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            if (e.RowIndex >= 0 && e.RowIndex < dgvSavingsHistory.Rows.Count && e.ColumnIndex >= 0)
            {
                DataGridViewRow clickedRow = dgvSavingsHistory.Rows[e.RowIndex];

                if (e.RowIndex == lastClickedRowIndex)
                {
                    clickedRow.DefaultCellStyle.BackColor = Color.White;

                    lastClickedRowIndex = -1;
                }
                else
                {
                    if (lastClickedRowIndex != -1)
                    {
                        dgvSavingsHistory.Rows[lastClickedRowIndex].DefaultCellStyle.BackColor = Color.White;
                    }

                    clickedRow.DefaultCellStyle.BackColor = Color.Khaki;

                    lastClickedRowIndex = e.RowIndex;
                }
            }
        }

        private void dgvIndividualLoans_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            dgvIndividualLoans.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            if (e.RowIndex >= 0 && e.RowIndex < dgvIndividualLoans.Rows.Count && e.ColumnIndex >= 0)
            {
                DataGridViewRow clickedRow = dgvIndividualLoans.Rows[e.RowIndex];

                if (e.RowIndex == lastClickedRowIndex)
                {
                    clickedRow.DefaultCellStyle.BackColor = Color.White;

                    lastClickedRowIndex = -1;
                }
                else
                {
                    if (lastClickedRowIndex != -1)
                    {
                        dgvIndividualLoans.Rows[lastClickedRowIndex].DefaultCellStyle.BackColor = Color.White;
                    }

                    clickedRow.DefaultCellStyle.BackColor = Color.Khaki;

                    lastClickedRowIndex = e.RowIndex;
                }
            }
        }
    }
}
