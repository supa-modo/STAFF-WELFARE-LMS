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
            LoadMembersDataIntoDataGridView();
        }


        private void LoadMembersDataIntoDataGridView()
        {
            int i = 0;
            dgvMembers.Rows.Clear();

            // Define parameter for search text
            SqlParameter txtSearchParam = new SqlParameter("@txtSearch", SqlDbType.NVarChar);
            txtSearchParam.Value = txtSearch.Text;

            // Define the SQL query with parameters
            string query = "SELECT MemberPFNo, FirstName, MiddleName, LastName, JobTitle, ContractEndDate, ContractType, EmailAddress, PhoneNumber1, PhysicalAddress " +
                           "FROM Members " +
                           "WHERE MemberPFNo LIKE '%' + @txtSearch + '%' " +
                           "OR (FirstName + ' ' + ISNULL(MiddleName, '') + ' ' + LastName) LIKE '%' + @txtSearch + '%' " +
                           "OR JobTitle LIKE '%' + @txtSearch + '%' " +
                           "OR ContractEndDate LIKE '%' + @txtSearch + '%' " +
                           "OR ContractType LIKE '%' + @txtSearch + '%' " +
                           "OR EmailAddress LIKE '%' + @txtSearch + '%' " +
                           "OR PhoneNumber1 LIKE '%' + @txtSearch + '%' " +
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
                    dgvMembers.Rows.Add(i,
                                         dr["MemberPFNo"],
                                         dr["FirstName"].ToString() + " " +
                                         dr["MiddleName"].ToString() + " " +
                                         dr["LastName"].ToString(),
                                         dr["JobTitle"],
                                         ((DateTime)dr["ContractEndDate"]).ToString("dd-MMM-yyyy"), // Format the date here
                                         dr["ContractType"],
                                         dr["EmailAddress"],
                                         dr["PhoneNumber1"],
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
            LoadMembersDataIntoDataGridView();
        }

        private void metroBtnNew_Click(object sender, EventArgs e)
        {
            addMemberModule addMemberModule = new addMemberModule();
            addMemberModule.ShowDialog();
        }

       


        private int lastClickedRowIndex = -1;
        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is not the header cell and the row index is valid
            if (e.RowIndex >= 0 && e.RowIndex < dgvMembers.Rows.Count && e.ColumnIndex >= 0)
            {
                // Check if the clicked cell is not a button type cell
                if (dgvMembers.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
                {
                    return; // Exit the event handler if a button cell is clicked
                }

                // Get the clicked row
                DataGridViewRow clickedRow = dgvMembers.Rows[e.RowIndex];

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
                        dgvMembers.Rows[lastClickedRowIndex].DefaultCellStyle.BackColor = Color.White;
                    }

                    // Highlight the clicked row by changing its background color
                    clickedRow.DefaultCellStyle.BackColor = Color.Khaki;
                    lastClickedRowIndex = e.RowIndex; // Store the index of the last clicked row
                }
            }
        }


        private void dgvMembers_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
