using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAC_STAFF_WELFARE_LMS
{
    public partial class loginScreen : Form
    {
        public loginScreen()
        {
            InitializeComponent();
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
