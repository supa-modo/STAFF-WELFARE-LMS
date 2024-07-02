using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportDataSource = Microsoft.Reporting.WinForms.ReportDataSource;

namespace EAC_STAFF_WELFARE_LMS
{
    public partial class Reports : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        dbConnect dbConn = new dbConnect();
       

        public Reports()
        {
            InitializeComponent();
            cn = new SqlConnection(dbConn.myConnection());
        }


        private void ResetReportViewer()
        {
            reportViewer.Reset();
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.ReportPath = string.Empty;
        }

        private void btnAllLoans_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT LoanID, PFNo, ApplicantName, LoanAmount, DurationOfPayment, ApplicationDate, DueDate, PendingBalance, LoanStatus FROM Loans", cn);
            SqlDataAdapter d5 = new SqlDataAdapter(cmd);
            DataTable dt5 = new DataTable();
            d5.Fill(dt5);
            ResetReportViewer();

            // Creating a new ReportDataSource with the fetched data and setting the path to the .rdlc report file then adding new source to datasources
            ReportDataSource sourceLoans = new ReportDataSource("AllLoansDataset", dt5);
            reportViewer.LocalReport.ReportPath = "C:/Users/Administrator/OneDrive/Desktop/Projects/EAC STAFF WELFARE LMS/LoansReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(sourceLoans);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void btnActiveLoans_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT LoanID, PFNo, ApplicantName, LoanAmount, DurationOfPayment, ApplicationDate, DueDate, PendingBalance, LoanStatus FROM Loans WHERE LoanStatus = 'Active'", cn);
            SqlDataAdapter d4 = new SqlDataAdapter(cmd);
            DataTable dt4 = new DataTable();
            d4.Fill(dt4);
            ResetReportViewer();

            // Creating a new ReportDataSource with the fetched data and setting the path to the .rdlc report file then adding new source to datasources
            ReportDataSource sourceActiveLoans = new ReportDataSource("ActiveLoansDataset", dt4);
            reportViewer.LocalReport.ReportPath = "C:/Users/Administrator/OneDrive/Desktop/Projects/EAC STAFF WELFARE LMS/ActiveLoansReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(sourceActiveLoans);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void btnIndivLoans_Click(object sender, EventArgs e)
        {

        }

        private void btnAllMembers_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM Members", cn);
            SqlDataAdapter d2 = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            d2.Fill(dt2);

            ResetReportViewer();

            // Creating a new ReportDataSource with the fetched data and setting the path to the .rdlc report file then adding new source to datasources
            ReportDataSource sourceMembers = new ReportDataSource("AllMembersDataset", dt2);

            reportViewer.LocalReport.ReportPath = "C:/Users/Administrator/OneDrive/Desktop/Projects/EAC STAFF WELFARE LMS/AllMembersReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(sourceMembers);


            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void btnIndivMembers_Click(object sender, EventArgs e)
        {
            // Prompt the user to enter the PF No
            string pfNo = Prompt.ShowDialog("Enter PF No:", "PF No Input");

            if (string.IsNullOrEmpty(pfNo))
            {
                MessageBox.Show("PF No cannot be empty. Please enter a valid PF No.");
                return;
            }

            string query = @"SELECT l.ApplicantName, 
                  m.JobTitle,
                  m.MemberPFNo,
                  m.EmailAddress,
                  m.PhoneNumber1,
                  m.ContractEndDate,
                  m.PhysicalAddress,
                  s.SavingsAccountBalance,
                  l.LoanID,
                  l.LoanAmount,
                  l.DueDate,
                  l.PendingBalance,
                  l.LoanStatus
              FROM Loans l
              INNER JOIN Members m ON l.PFNo = m.MemberPFNo
              INNER JOIN Savings s ON s.PFNo = m.MemberPFNo
              WHERE m.MemberPFNo = @PFNo";

            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.Parameters.AddWithValue("@PFNo", pfNo);

                SqlDataAdapter d6 = new SqlDataAdapter(cmd);
                DataTable dt6 = new DataTable();
                d6.Fill(dt6);

                ResetReportViewer();

                ReportDataSource sourceIndividualMemberDetails = new ReportDataSource("IndividualMemberDetails", dt6);
                reportViewer.LocalReport.ReportPath = "C:/Users/Administrator/OneDrive/Desktop/Projects/EAC STAFF WELFARE LMS/IndividualMemberReport.rdlc";
                reportViewer.LocalReport.DataSources.Add(sourceIndividualMemberDetails);

                // Setting the display mode and refreshing the report
                reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                reportViewer.ZoomPercent = 100;
                reportViewer.RefreshReport();
            }
        }

        // Prompt class to display an input dialog
        public static class Prompt
        {
            public static string ShowDialog(string text, string caption)
            {
                Form prompt = new Form()
                {
                    Width = 500,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };

                Label textLabel = new Label() { Left = 50, Top = 20, Text = text };
                TextBox inputBox = new TextBox() { Left = 50, Top = 50, Width = 400 };

                Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70 };
                confirmation.Click += (sender, e) => { prompt.Close(); };

                prompt.Controls.Add(textLabel);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);

                prompt.AcceptButton = confirmation;

                prompt.ShowDialog();
                return inputBox.Text;
            }
        }



        private void btnTotalSavings_Click(object sender, EventArgs e)
        {
            string query = @"SELECT s.SavingsId, 
               s.PFNo, 
               m.FirstName, 
               m.MiddleName, 
               m.LastName, 
               s.MonthlySavings, 
               s.SavingsAccountBalance, 
               s.LastUpdated
               FROM Savings s
               INNER JOIN Members m ON s.PFNo = m.MemberPFNo";

            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataAdapter d3 = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d3.Fill(dt);

            ResetReportViewer();

            ReportDataSource sourceSavings = new ReportDataSource("DataSetSavings", dt);
            reportViewer.LocalReport.ReportPath = "C:/Users/Administrator/OneDrive/Desktop/Projects/EAC STAFF WELFARE LMS/SavingsDetailsReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(sourceSavings);

            // Setting the display mode and refreshing the report
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
            reportViewer.ZoomPercent = 100;
            reportViewer.RefreshReport();
        }

        private void btnIndivSavings_Click(object sender, EventArgs e)
        {

        }

    }
}
