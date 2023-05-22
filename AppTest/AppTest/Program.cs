using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTest
{
    static class Program
    {
        // LAPTOP-H6PI0HTC
        // DESKTOP-C145KAF
        // DESKTOP-A34VKT1
        public static string serverName = "DESKTOP-C145KAF";


        public static DataTable CustomerData = new DataTable("CUSTOMER");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPage());
        }
    }
}
