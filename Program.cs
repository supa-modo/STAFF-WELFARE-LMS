using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAC_STAFF_WELFARE_LMS
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            loginScreen loginScreen = new loginScreen();
            if(loginScreen.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new MainScreen());
            }
            
        }
        
    }
}
