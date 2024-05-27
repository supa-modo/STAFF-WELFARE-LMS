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
    public partial class addMemberModule : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        dbConnect dbConn = new dbConnect();

        public addMemberModule()
        {
            InitializeComponent();
            cn = new SqlConnection(dbConn.myConnection());
        }


        private void InsertNewMemberRecord()
        {
            // Validating textboxes and other controls
            if (string.IsNullOrWhiteSpace(txBxPFNo.Text) || string.IsNullOrWhiteSpace(txtFName.Text) || string.IsNullOrWhiteSpace(txtLName.Text) || string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPhone1.Text) || string.IsNullOrWhiteSpace(txtAddress.Text) || string.IsNullOrWhiteSpace(txtBxJobTitle.Text) || string.IsNullOrWhiteSpace(txtBxDpt.Text) || comboBoxContractType.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int memberPFNo;
            if (!int.TryParse(txBxPFNo.Text, out memberPFNo))
            {
                MessageBox.Show("MemberPFNo must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime contractStartDate = metroDateStartCt.Value;
            DateTime contractEndDate = metroDateEndCt.Value;

            // Validating email format
            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email address is not in a valid format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                txtEmail.SelectAll();
                return;
            }

            // Inserting data into the database
            string firstName = txtFName.Text;
            string middleName = txtMName.Text;
            string lastName = txtLName.Text;
            string emailAddress = txtEmail.Text;
            string secondaryEmail = txtSecEmail.Text;
            string phoneNumber1 = txtPhone1.Text;
            string phoneNumber2 = txtPhone2.Text;
            string physicalAddress = txtAddress.Text;
            string jobTitle = txtBxJobTitle.Text;
            string department = txtBxDpt.Text;
            string contractType = comboBoxContractType.SelectedItem.ToString(); // Assuming comboBoxContractType contains contract types
            string monthlySavings = textBoxSavings.Text;

            // Define the SQL query
            string query = "INSERT INTO Members (MemberPFNo, FirstName, MiddleName, LastName, ContractStartDate, ContractEndDate, EmailAddress, SecondaryEmail, PhoneNumber1, PhoneNumber2, PhysicalAddress, JobTitle, Department, ContractType, MonthlySavings) " +
                           "VALUES (@MemberPFNo, @FirstName, @MiddleName, @LastName, @ContractStartDate, @ContractEndDate, @EmailAddress, @SecondaryEmail, @PhoneNumber1, @PhoneNumber2, @PhysicalAddress, @JobTitle, @Department, @ContractType, @MonthlySavings);";

            // Define parameters for the SQL query
            SqlParameter[] parameters =
            {
        new SqlParameter("@MemberPFNo", memberPFNo),
        new SqlParameter("@FirstName", firstName),
        new SqlParameter("@MiddleName", middleName),
        new SqlParameter("@LastName", lastName),
        new SqlParameter("@ContractStartDate", contractStartDate),
        new SqlParameter("@ContractEndDate", contractEndDate),
        new SqlParameter("@EmailAddress", emailAddress),
        new SqlParameter("@SecondaryEmail", secondaryEmail),
        new SqlParameter("@PhoneNumber1", phoneNumber1),
        new SqlParameter("@PhoneNumber2", phoneNumber2),
        new SqlParameter("@PhysicalAddress", physicalAddress),
        new SqlParameter("@JobTitle", jobTitle),
        new SqlParameter("@Department", department),
        new SqlParameter("@ContractType", contractType),
        new SqlParameter("@MonthlySavings", monthlySavings)
    };

            // Define SqlCommand with connection and query
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddRange(parameters);

            try
            {
                cn.Open();
                // Execute the query
                cmd.ExecuteNonQuery();
                MessageBox.Show("New member added successfully!");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Close the SqlConnection
                cn.Close();
            }

            
        }


        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }




        private void picBxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSaveMember_Click(object sender, EventArgs e)
        {
            InsertNewMemberRecord();
            
        }
    }
}
