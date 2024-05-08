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
            MessageBox.Show("Database connected successfully");
        }

        private void picBxClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picBxPwd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            MainScreen mScreen = new MainScreen();
            mScreen.ShowDialog();
            
            this.Close();
        }
    }
}
