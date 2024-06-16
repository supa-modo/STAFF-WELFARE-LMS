using Microsoft.Reporting.WebForms;
using Microsoft.Reporting.WinForms;
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

        private void btnAllLoans_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT LoanID, PFNo, ApplicantName, LoanAmount, DurationOfPayment, ApplicationDate, DueDate, PendingBalance, LoanStatus FROM Loans", cn);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);
            reportViewer.LocalReport.DataSources.Clear();

            // Creating a new ReportDataSource with the fetched data and setting the path to the .rdlc report file then adding new source to datasources
            ReportDataSource sourceLoans = new ReportDataSource("AllLoansDataset", dt);
            reportViewer.LocalReport.ReportPath = "C:/Users/Administrator/OneDrive/Desktop/Projects/EAC STAFF WELFARE LMS/LoansReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(sourceLoans);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.RefreshReport();
        }

        private void btnActiveLoans_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT LoanID, PFNo, ApplicantName, LoanAmount, DurationOfPayment, ApplicationDate, DueDate, PendingBalance, LoanStatus FROM Loans WHERE LoanStatus = 'Active'", cn);
            SqlDataAdapter d4 = new SqlDataAdapter(cmd);
            DataTable dt4 = new DataTable();
            d4.Fill(dt4);
            reportViewer.LocalReport.DataSources.Clear();

            // Creating a new ReportDataSource with the fetched data and setting the path to the .rdlc report file then adding new source to datasources
            ReportDataSource sourceActiveLoans = new ReportDataSource("ActiveLoansDataset", dt4);
            reportViewer.LocalReport.ReportPath = "C:/Users/Administrator/OneDrive/Desktop/Projects/EAC STAFF WELFARE LMS/ActiveLoansReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(sourceActiveLoans);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
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

            // Clearing any existing data sources from the ReportViewer
            reportViewer.LocalReport.DataSources.Clear();

            // Creating a new ReportDataSource with the fetched data and setting the path to the .rdlc report file then adding new source to datasources
            ReportDataSource sourceMembers = new ReportDataSource("AllMembersDataset", dt2);

            reportViewer.LocalReport.ReportPath = "C:/Users/Administrator/OneDrive/Desktop/Projects/EAC STAFF WELFARE LMS/AllMembersReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(sourceMembers);


            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.RefreshReport();
        }

        private void btnIndivMembers_Click(object sender, EventArgs e)
        {

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

            reportViewer.LocalReport.DataSources.Clear();

            ReportDataSource sourceSavings = new ReportDataSource("DataSetSavings", dt);
            reportViewer.LocalReport.ReportPath = "C:/Users/Administrator/OneDrive/Desktop/Projects/EAC STAFF WELFARE LMS/SavingsDetailsReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(sourceSavings);

            // Setting the display mode and refreshing the report
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.RefreshReport();
        }

        private void btnIndivSavings_Click(object sender, EventArgs e)
        {

        }

    }
}
