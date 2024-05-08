﻿using System;
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
    public partial class MainScreen : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        dbConnect dbConn = new dbConnect();

        public MainScreen()
        {
            InitializeComponent();
            cn = new SqlConnection(dbConn.myConnection());
            cn.Open();
            MessageBox.Show("Database connected successfully");
        }


        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if(activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMainScreen.Controls.Add(childForm);
            panelMainScreen.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {

        }

        private void btnSavings_Click(object sender, EventArgs e)
        {
            openChildForm(new FullProfileView());
        }

        private void btnLoanApps_Click(object sender, EventArgs e)
        {
            openChildForm(new LoanApplications());
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            openChildForm(new Members());
        }

        private void btnReports_Click(object sender, EventArgs e)
        {

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

        }
    }
}