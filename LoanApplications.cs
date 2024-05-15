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
    public partial class LoanApplications : Form
    {
        public LoanApplications()
        {
            InitializeComponent();
        }

        private void metroBtnNewLoan_Click(object sender, EventArgs e)
        {
            NewLoan newLoan = new NewLoan();
            newLoan.ShowDialog();  
            
        }
    }
}
