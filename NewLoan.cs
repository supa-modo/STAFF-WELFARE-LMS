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
    public partial class NewLoan : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        dbConnect dbConn = new dbConnect();
        LoanApplications loanApplications;

        public NewLoan(LoanApplications loanAppls)
        {
            InitializeComponent();
            cn = new SqlConnection(dbConn.myConnection());
            getLoanID();
            loanApplications = loanAppls;

            // Subscribe to the TextChanged event for txtLoanAmt and txtDuration
            txtLoanAmt.TextChanged += NewLoanTxtBoxes_TextChanged;
            txtDuration.TextChanged += NewLoanTxtBoxes_TextChanged;
        }

        private void picBxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void InsertNewLoanRecord()
        {
            // Validate textboxes and other controls
            if (string.IsNullOrWhiteSpace(txtPFNo.Text) || string.IsNullOrWhiteSpace(txtLoanAmt.Text) || string.IsNullOrWhiteSpace(txtDuration.Text) || string.IsNullOrWhiteSpace(txtInstallments.Text))
            {
                MessageBox.Show("Please fill in all the given fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string loanID = getLoanID(); 
            int pfNo;
            if (!int.TryParse(txtPFNo.Text, out pfNo))
            {
                MessageBox.Show("PFNo must be a valid number value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal loanAmount;
            if (!decimal.TryParse(txtLoanAmt.Text, out loanAmount))
            {
                MessageBox.Show("Loan amount must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            decimal interestRate;
            if (!decimal.TryParse(txtInterest.Text, out interestRate))
            {
                MessageBox.Show("Interest rate must be a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int durationOfPayment;
            if (!int.TryParse(txtDuration.Text, out durationOfPayment))
            {
                MessageBox.Show("Duration of payment must be a valid number (of months).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal monthlyInstallments;
            if (!decimal.TryParse(txtInstallments.Text, out monthlyInstallments))
            {
                MessageBox.Show("Monthly installments must be a valid number value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get applicant name from Members table
            string applicantName = GetApplicantName(pfNo);
            if (applicantName == null)
            {
                MessageBox.Show("No member found with the provided PFNo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate DueDate by adding durationOfPayment months to current date
            DateTime applicationDate = DateTime.Now;
            DateTime dueDate = applicationDate.AddMonths(durationOfPayment);

            // Confirm new loan addition
            string confirmationMessage = $"        Confirm New loan addition:\n \nApplicant Name - {applicantName}\nLoan amount - {loanAmount}\nDuration of Payment - {durationOfPayment} months\nMonthly Installments - {monthlyInstallments}";
            DialogResult result = MessageBox.Show(confirmationMessage, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                this.Close();
            } else if (result == DialogResult.No)
            {
                return;
            }

            // Insert data into the Loans table
            string query = "INSERT INTO Loans (LoanID, PFNo, LoanAmount, InterestRate, DurationOfPayment, MonthlyInstallments, ApplicantName, ApplicationDate, DueDate) " +
                           "VALUES (@LoanID, @PFNo, @LoanAmount, @InterestRate, @DurationOfPayment, @MonthlyInstallments, @ApplicantName, @ApplicationDate, @DueDate);";

            // Define parameters for the SQL query
            SqlParameter[] parameters =
            {
        new SqlParameter("@LoanID", loanID),
        new SqlParameter("@PFNo", pfNo),
        new SqlParameter("@LoanAmount", loanAmount),
        new SqlParameter("@InterestRate", interestRate), // Assuming interest rate is 0 for now
        new SqlParameter("@DurationOfPayment", durationOfPayment),
        new SqlParameter("@MonthlyInstallments", monthlyInstallments),
        new SqlParameter("@ApplicantName", applicantName),
        new SqlParameter("@ApplicationDate", applicationDate),
        new SqlParameter("@DueDate", dueDate)
    };

            // Define SqlCommand with connection and query
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddRange(parameters);

            try
            {
                cn.Open();
                // Execute the query
                cmd.ExecuteNonQuery();
                MessageBox.Show("New loan record inserted successfully!");
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

        private string GetApplicantName(int pfNo)
        {
            // Retrieve applicant name from Members table based on PFNo
            string query = "SELECT CONCAT(FirstName, ' ', ISNULL(MiddleName, ''), ' ', LastName) AS FullName FROM Members WHERE MemberPFNo = @PFNo;";

            // Define parameter for PFNo
            SqlParameter parameter = new SqlParameter("@PFNo", pfNo);

            // Define SqlCommand with connection and query
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.Add(parameter);

            try
            {
                cn.Open();
                // Execute the query
                object result = cmd.ExecuteScalar();
                if (result != null)
                {
                    return result.ToString();
                }
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

            return null; // Return null if no member found with the provided PFNo
        }



        public string getLoanID()
        {
            string sdate = DateTime.Now.ToString("yyyyMMddhhmmss");
            string loanID = "LA" + sdate;
            labelLoanID.Text = loanID;

            return loanID;

        }


        private void metroBtnSave_Click(object sender, EventArgs e)
        {
            InsertNewLoanRecord();
            loanApplications.LoadLoanApplicationsIntoDataGridView();
            loanApplications.CalculateAndDisplayTotalActiveLoans();
        }



        private void NewLoanTxtBoxes_TextChanged(object sender, EventArgs e)
        {
            CalculatedDivision();
        }

        private void CalculatedDivision()
        {
            // Ensure both txtLoanAmt and txtDuration have valid numbers
            if (double.TryParse(txtLoanAmt.Text, out double value1) &&
                double.TryParse(txtDuration.Text, out double value2))
            {
                // Avoid division by zero
                if (value2 != 0)
                {
                    double result = value1 / value2;
                    txtInstallments.Text = result.ToString();
                }
                else
                {
                    txtInstallments.Text = "Cannot divide by zero";
                }
            }
            else
            {
                txtInstallments.Text = "Invalid input";
            }
        }

    }
}
