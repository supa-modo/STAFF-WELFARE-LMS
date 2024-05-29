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

        private void button1_Click(object sender, EventArgs e)
        {
            // Set up the SQL command to fetch data
            cmd = new SqlCommand("SELECT LoanID, PFNo, ApplicantName, LoanAmount, ApplicationDate, DueDate FROM Loans", cn);
            SqlDataAdapter d = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d.Fill(dt);

            // Clear any existing data sources from the ReportViewer
            reportViewer.LocalReport.DataSources.Clear();

            // Create a new ReportDataSource with the fetched data, Set the path to the .rdlc report file and add the new source to datasources
            ReportDataSource sourceLoans = new ReportDataSource("LoansDataset", dt);
            reportViewer.LocalReport.ReportPath = "C:/Users/Administrator/OneDrive/Desktop/Projects/EAC STAFF WELFARE LMS/LoansReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(sourceLoans);

            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.RefreshReport();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            // Set up the SQL command to fetch data
            cmd = new SqlCommand("SELECT * FROM Members", cn);
            SqlDataAdapter d2 = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            d2.Fill(dt2);

            // Clear any existing data sources from the ReportViewer
            reportViewer.LocalReport.DataSources.Clear();

            // Create a new ReportDataSource with the fetched data, Set the path to the .rdlc report file and add the new source to datasources
            ReportDataSource sourceMembers = new ReportDataSource("AllMembersDataset", dt2);
            
            reportViewer.LocalReport.ReportPath = "C:/Users/Administrator/OneDrive/Desktop/Projects/EAC STAFF WELFARE LMS/AllMembersReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(sourceMembers);


            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.RefreshReport();
        }

        private void btnSavingsReport_Click(object sender, EventArgs e)
        {
            string query = @"
        SELECT s.SavingsId, 
               s.PFNo, 
               m.FirstName, 
               m.MiddleName, 
               m.LastName, 
               s.MonthlySavings, 
               s.SavingsAccountBalance, 
               s.LastUpdated
        FROM Savings s
        INNER JOIN Members m ON s.PFNo = m.MemberPFNo";

            // Create the SqlCommand and SqlDataAdapter
            SqlCommand cmd = new SqlCommand(query, cn);
            SqlDataAdapter d3 = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            d3.Fill(dt);

            // Clear any existing data sources from the ReportViewer
            reportViewer.LocalReport.DataSources.Clear();

            // Create a new ReportDataSource with the fetched data
            ReportDataSource sourceSavings = new ReportDataSource("DataSetSavings", dt);
            reportViewer.LocalReport.ReportPath = "C:/Users/Administrator/OneDrive/Desktop/Projects/EAC STAFF WELFARE LMS/SavingsDetailsReport.rdlc";
            reportViewer.LocalReport.DataSources.Add(sourceSavings);

            // Set display mode and refresh the report
            reportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer.RefreshReport();
        }

    }
}
