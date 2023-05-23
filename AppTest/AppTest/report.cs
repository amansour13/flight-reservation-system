using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTest
{
    public partial class report : Form
    {

        public class lbl
        {
            public Label l = new Label();
            public lbl(string data) 
            {
                l.Text = data;
                l.ForeColor = Color.White;
                l.AutoSize = false;
                l.Dock = DockStyle.Top;
                l.Height = 40;
                l.Font = new Font(l.Font.FontFamily, 12);
            }
        }
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

                con.Open();

                // number of Aircrafts
                // number of Flights for each Aircraft
                // number of Customers
                // number of bookings
                // average bookings for each class
                // maximum flight has bookings

                string updateCommand = "SELECT COUNT(AIRCRAFTID) as numOfAircrafts FROM AIRCRAFT";
                SqlCommand updatComm = new SqlCommand(updateCommand, con);
                SqlDataReader reader = updatComm.ExecuteReader();

                /*DataTable dt = new DataTable();
                dt.Load(reader);
                
                DataRow dr = dt.Rows[0];*/

                int numOfAircrafts = 0;
                while (reader.Read())
                {
                    numOfAircrafts = (int)reader["numOfAircrafts"];

                }

                lbl label1 = new lbl("Number of Aircrafts : " + numOfAircrafts.ToString());


                mainPanel.Controls.Add(label1.l);

                reader.Close();
                con.Close();

            }
            catch (Exception ex)
            {
                // Handle the exception
                string message = ex.Message;
                string title = "FAILED";
                MessageBox.Show(message, title);
            }

        }
    }
}
