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
    public partial class Members : Form
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        dbConnect dbConn = new dbConnect();
        SqlDataReader dr;

        public Members()
        {
            InitializeComponent();
            cn = new SqlConnection(dbConn.myConnection());
            
        }

        public void loadMembers()
        {
            int i = 0;
            dgvMembers.Rows.Clear();
            cmd = new SqlCommand("SELECT ");

        }
    }
}
