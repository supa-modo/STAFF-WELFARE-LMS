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
    public partial class addMemberModule : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        dbConnect dbConn = new dbConnect();

        public addMemberModule()
        {
            InitializeComponent();
            cn = new SqlConnection(dbConn.myConnection());
        }

        private void picBxClose_Click(object sender, EventArgs e)
        {

        }
    }
}
