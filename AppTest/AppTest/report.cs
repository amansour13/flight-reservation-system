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
using static AppTest.availableFlights;
using static AppTest.FlightReservationDataSet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        public DataSet ExecuteMultipleCommands(string connectionString)
        {
            // Create a DataSet to hold the results
            DataSet results = new DataSet();

            // Define the SQL commands
            string[] sqlCommands = new string[]
            {
                "SELECT COUNT(AIRCRAFTID) as numOfAircrafts FROM AIRCRAFT",
                "SELECT AIRCRAFTID, COUNT(FLIGHTID) AS NumberOfFlights FROM FLIGHT GROUP BY AIRCRAFTID",
                "SELECT COUNT(CMAIL) as numOfCustomers FROM CUSTOMER",
                "SELECT COUNT(*) AS TotalBookings FROM BOOKING",
                "SELECT CLASS, AVG(SEATNUMBER) AS Average FROM BOOKING GROUP BY CLASS",
                "SELECT TOP 1 FLIGHTID, COUNT(*) AS BookingCount FROM BOOKING GROUP BY FLIGHTID ORDER BY BookingCount DESC"
            };

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Execute each SQL command and load the results into the DataSet
                foreach (string commandText in sqlCommands)
                {
                    SqlCommand command = new SqlCommand(commandText, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Create a DataTable to hold the results of each command
                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);

                    // Add the DataTable to the DataSet
                    results.Tables.Add(dataTable);

                    reader.Close();
                }

                connection.Close();
            }

            return results;
        }

        private void report_Load(object sender, EventArgs e)
        {
            try
            {
                String con = @"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True";

                DataSet results = ExecuteMultipleCommands(con);

                // Access the individual DataTables and their results
                DataTable numOfAircraftsTable = results.Tables[0];
                DataTable numberOfFlightsTable = results.Tables[1];
                DataTable numOfCustomersTable = results.Tables[2];
                DataTable totalBookingsTable = results.Tables[3];
                DataTable averageByClassTable = results.Tables[4];
                DataTable maxBookingsFlightTable = results.Tables[5];

                // number of Aircrafts
                lbl label1 = new lbl("Number of Aircrafts : " + numOfAircraftsTable.Rows[0]["numOfAircrafts"].ToString());
                mainPanel.Controls.Add(label1.l);
                label1.l.BringToFront();

                // number of flights for each aircrafts
                for (int i = 0; i < numberOfFlightsTable.Rows.Count; i++)
                {
                    string AircrafttID = numberOfFlightsTable.Rows[i]["AIRCRAFTID"].ToString();
                    string correspondigFlight = numberOfFlightsTable.Rows[i]["NumberOfFlights"].ToString();

                    lbl label2 = new lbl("Aircrafts with ID " + AircrafttID + " Contains : " + correspondigFlight + " Flights");
                    mainPanel.Controls.Add(label2.l);
                    label2.l.BringToFront();
                }

                // number of customers
                lbl label3 = new lbl("Number of Customers : " + numOfCustomersTable.Rows[0]["numOfCustomers"].ToString());
                mainPanel.Controls.Add(label3.l);
                label3.l.BringToFront();

                // number of AllBookings in the program
                lbl label4 = new lbl("Number of All Bookings : " + totalBookingsTable.Rows[0]["TotalBookings"].ToString());
                mainPanel.Controls.Add(label4.l);
                label4.l.BringToFront();

                // average of all flight classes
                for (int i = 0; i < averageByClassTable.Rows.Count; i++)
                {
                    string flightClass = averageByClassTable.Rows[i]["CLASS"].ToString();
                    string correspondigAVG = averageByClassTable.Rows[i]["Average"].ToString();

                    lbl label5 = new lbl("The average of booking (" + flightClass + ") Class is " + correspondigAVG);
                    mainPanel.Controls.Add(label5.l);
                    label5.l.BringToFront();
                }

                // flight that has maximum number of bookings
                lbl label6 = new lbl("The Flight " + maxBookingsFlightTable.Rows[0]["FLIGHTID"].ToString() + " has the maximum number of bookings which = " + maxBookingsFlightTable.Rows[0]["BookingCount"].ToString());
                mainPanel.Controls.Add(label6.l);
                label6.l.BringToFront();

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
