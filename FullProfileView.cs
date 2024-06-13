using System;
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
        }

        private void picBxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void metrobtnEdit_Click(object sender, EventArgs e)
        {
            // Enabling the controls for editing
            SetControlsReadOnly(false);
            btnSave.Visible = true;
            btnCancel.Visible = true;
            metrobtnEdit.Visible = false;
            txtFName.Focus();
        }


        private void btnSave_Click_1(object sender, EventArgs e)
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

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            loadFullProfile();
            SetControlsReadOnly(true);
            btnSave.Visible = false;
            btnCancel.Visible = false;
            metrobtnEdit.Visible = true;
        }
    }
}
