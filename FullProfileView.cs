using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EAC_STAFF_WELFARE_LMS
{
    public partial class FullProfileView : Form
    {
        private string pfNo;
        private SqlConnection cn;
        private SqlCommand cmd;
        private dbConnect dbConn;

        public FullProfileView(string pfNo)
        {
            InitializeComponent();
            this.pfNo = pfNo;
            dbConn = new dbConnect();
            cn = new SqlConnection(dbConn.myConnection());
            loadFullProfile();
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
    }
}
