using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAC_STAFF_WELFARE_LMS
{
    internal class dbConnect
    {
        private string _connectionString;
        public string myConnection() {
            _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Administrator\OneDrive\Documentos\EACLMS.mdf;Integrated Security=True;Connect Timeout=30";
            return _connectionString; 
        }
    }
}
