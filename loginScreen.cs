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
    public partial class loginScreen : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        dbConnect dbConn = new dbConnect();

        public loginScreen()
        {
            InitializeComponent();
            cn = new SqlConnection(dbConn.myConnection());
            cn.Open();
        }

        private void picBxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (IsValidLogin())
            {
                // Set the dialog result to OK and close the form
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                // Show error message
                MessageBox.Show("Invalid login credentials.");
            }
        }

        private bool IsValidLogin()
        {
            return true;
        }
    }
}
