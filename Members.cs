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
            string query = "SELECT MemberPFNo, FirstName, MiddleName, LastName, JobTitle, ContractEndDate, ContractType, EmailAddress, SecondaryEmail, PhoneNumber1, PhoneNumber2, PhysicalAddress " +
                           "FROM Members " +
                           "WHERE MemberPFNo LIKE '%' + @txtSearch + '%' " +
                           "OR (FirstName + ' ' + ISNULL(MiddleName, '') + ' ' + LastName) LIKE '%' + @txtSearch + '%' " +
                           "OR JobTitle LIKE '%' + @txtSearch + '%' " +
                           "OR ContractEndDate LIKE '%' + @txtSearch + '%' " +
                           "OR ContractType LIKE '%' + @txtSearch + '%' " +
                           "OR EmailAddress LIKE '%' + @txtSearch + '%' " +
                           "OR SecondaryEmail LIKE '%' + @txtSearch + '%' " +
                           "OR PhoneNumber1 LIKE '%' + @txtSearch + '%' " +
                           "OR PhoneNumber2 LIKE '%' + @txtSearch + '%' " +
                           "OR PhysicalAddress LIKE '%' + @txtSearch + '%';";

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
                    // Add data to DataGridView
                    dgvMembers.Rows.Add(i, dr["MemberPFNo"],
                                          dr["FirstName"].ToString() + " " +
                                          dr["MiddleName"].ToString() + " " +
                                          dr["LastName"].ToString(),
                                          dr["JobTitle"],
                                          dr["ContractEndDate"],
                                          dr["ContractType"],
                                          dr["EmailAddress"],
                                          dr["SecondaryEmail"],
                                          dr["PhoneNumber1"],
                                          dr["PhoneNumber2"],
                                          dr["PhysicalAddress"]);
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


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void metroBtnNew_Click(object sender, EventArgs e)
        {
            addMemberModule addMemberModule = new addMemberModule();
            addMemberModule.ShowDialog();
        }

        

        private void dgvMembers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn ||
                e.ColumnIndex == 2)
            {
                FullProfileView fullProfileView = new FullProfileView();
                fullProfileView.ShowDialog();
            }
        }
    }
}
