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
    public partial class NewLoan : Form
    {
        public NewLoan()
        {
            InitializeComponent();
            getLoanID();
        }

        private void picBxClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void getLoanID()
        {
            string sdate = DateTime.Now.ToString("yyyyMMddhhmmss");
            string loanID = "101" + sdate;
            labelLoanID.Text = loanID;

        }
    }
}
