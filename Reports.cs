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
    }
}
