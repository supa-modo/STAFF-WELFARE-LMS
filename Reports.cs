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
            loanReportViewer.LocalReport.DataSources.Clear();

            // Create a new ReportDataSource with the fetched data, Set the path to the .rdlc report file and add the new source to datasources
            ReportDataSource source = new ReportDataSource("LoansDataset", dt);
            loanReportViewer.LocalReport.ReportPath = "C:/Users/Administrator/OneDrive/Desktop/Projects/EAC STAFF WELFARE LMS/LoansReport.rdlc";
            loanReportViewer.LocalReport.DataSources.Add(source);

            loanReportViewer.SetDisplayMode(DisplayMode.PrintLayout);
            loanReportViewer.RefreshReport();
        }


        private void Reports_Load(object sender, EventArgs e)
        {

            this.loanReportViewer.RefreshReport();
        }

     
    }
}
