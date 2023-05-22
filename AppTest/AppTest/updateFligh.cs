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

namespace AppTest
{
    public partial class updateFligh : Form
    {
        public updateFligh()
        {
            InitializeComponent();
        }

        public int globalFlightID = new int();

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

            con.Open();

            int flightID = 0;
            Int32.TryParse(search.Text, out flightID) ;

            string updateCommand = "SELECT * FROM FLIGHT WHERE AIRCRAFTID = " + flightID;
            SqlCommand updatComm = new SqlCommand(updateCommand, con);
            SqlDataReader reader = updatComm.ExecuteReader();

            globalFlightID = flightID;

            while (reader.Read())
            {
                aircraftIdText.Text = reader["AIRCRAFTID"].ToString();
                seatsNumText.Text = reader["SEATSNUMBER"].ToString();
                sourceText.Text = reader["SOURCE"].ToString();
                destinationText.Text = reader["DESTINATION"].ToString();
                outgoing.Value = (DateTime)reader["OUTGOINGDATE"];
                arriving.Value = (DateTime)reader["ARRIVINGDATE"];
            }

            reader.Close();
            con.Close();

            mainSearchPanel.Height = 623;
            mainSearchPanel.Visible = true;
            searchPanel.Visible = false;
        }

        private void updateFligh_Load_1(object sender, EventArgs e)
        {
            mainSearchPanel.Visible = false;
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

            con.Open();

            SqlCommand comm;
            string from = outgoing.Value.Year + "-" + outgoing.Value.Month + "-" + outgoing.Value.Day + " " + outgoing.Value.Hour + ":" + outgoing.Value.Minute + ":00";
            string to = arriving.Value.Year + "-" + arriving.Value.Month + "-" + arriving.Value.Day + " " + arriving.Value.Hour + ":" + arriving.Value.Minute + ":00";

            DataRow row = Program.CustomerData.Rows[0];

            int airID = 0;
            Int32.TryParse(aircraftIdText.Text, out airID);

            string command = "UPDATE FLIGHT SET AIRCRAFTID = '"
                    + airID + "', ADMINID = '"
                    + (int)row["ADMINID"] + "', SEATSNUMBER = '"
                    + seatsNumText.Text.ToString() + "', SOURCE = '"
                    + sourceText.Text.ToString() + "', DESTINATION = '"
                    + destinationText.Text.ToString() + "', OUTGOINGDATE = '"
                    + from + "', ARRIVINGDATE = '"
                    + to + "' WHERE FLIGHTID = " + globalFlightID + ";";

            comm = new SqlCommand(command, con);
            comm.ExecuteNonQuery();

            string message = "Flight with ID = " + globalFlightID.ToString() + "\nUpdated Successfully\n";
            string title = "Success";
            MessageBox.Show(message, title);

            mainSearchPanel.Visible = false;
            searchPanel.Visible = true;
            search.Text = "";

            con.Close();
        }
    }
}
