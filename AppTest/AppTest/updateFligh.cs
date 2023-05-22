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
            try { 
                SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

                con.Open();

                if ((!Program.IsStringNumeric(search.Text)))
                {
                    throw new Exception("ERROR : can not add string in integer field\ncheck all integer fields");
                }

                int flightID = 0;
                Int32.TryParse(search.Text, out flightID) ;

                string updateCommand = "SELECT * FROM FLIGHT WHERE FLIGHTID = " + flightID;
                SqlCommand updatComm = new SqlCommand(updateCommand, con);
                SqlDataReader reader = updatComm.ExecuteReader();

            

                int tempID = 0;
                while (reader.Read())
                {
                    aircraftIdText.Text = reader["AIRCRAFTID"].ToString();
                    seatsNumText.Text = reader["SEATSNUMBER"].ToString();
                    sourceText.Text = reader["SOURCE"].ToString();
                    destinationText.Text = reader["DESTINATION"].ToString();
                    outgoing.Value = (DateTime)reader["OUTGOINGDATE"];
                    arriving.Value = (DateTime)reader["ARRIVINGDATE"];
                    standardPriceText.Text =reader["STANDARDPRICE"].ToString();

                    tempID = (int)reader["FLIGHTID"];
                }



                reader.Close();
                con.Close();


                if (flightID != tempID)
                {
                    string message = "Sorry this ID is NOT EXIST\n";
                    string title = "Success";
                    MessageBox.Show(message, title);
                }
                else
                {
                    mainSearchPanel.Height = 623;
                    mainSearchPanel.Visible = true;
                    searchPanel.Visible = false;
                    globalFlightID = flightID;
                }

            }
            catch (Exception ex)
            {
                // Handle the exception
                string message = ex.Message;
                string title = "FAILED";
                MessageBox.Show(message, title);
            }

        }

        private void updateFligh_Load_1(object sender, EventArgs e)
        {
            mainSearchPanel.Visible = false;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void updateBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

                con.Open();

                SqlCommand comm, getAircraftSeatsNum;
                string from = outgoing.Value.Year + "-" + outgoing.Value.Month + "-" + outgoing.Value.Day + " " + outgoing.Value.Hour + ":" + outgoing.Value.Minute + ":00";
                string to = arriving.Value.Year + "-" + arriving.Value.Month + "-" + arriving.Value.Day + " " + arriving.Value.Hour + ":" + arriving.Value.Minute + ":00";

                DataRow row = Program.CustomerData.Rows[0];

                if ((!Program.IsStringNumeric(aircraftIdText.Text)) || (!Program.IsStringNumeric(seatsNumText.Text)) || (!Program.IsStringNumeric(standardPriceText.Text)))
                {
                    throw new Exception("ERROR : can not add string in integer field\ncheck all integer fields");
                }

                if (outgoing.Value > arriving.Value)
                {
                    throw new Exception("ERROR : OutGoing Date is after Arriving Date\nrecheck two dates");
                }

                int airID = 0;
                Int32.TryParse(aircraftIdText.Text, out airID);

                float standardPrice = float.Parse(standardPriceText.Text);
                
                int seatsNum = 0;
                Int32.TryParse(seatsNumText.Text, out seatsNum);


                string getAircraftSeatsNumCommand = "select CAPACITY from AIRCRAFT where AIRCRAFTID = " + airID;
                getAircraftSeatsNum = new SqlCommand(getAircraftSeatsNumCommand, con);
                SqlDataReader reader = getAircraftSeatsNum.ExecuteReader();

                int cap = 0;
                while (reader.Read())
                {
                    cap = (int)reader["CAPACITY"];
                }
                reader.Close();

                if (seatsNum > cap)
                {
                    throw new Exception("ERROR: The Seats Number Added is smaller than corresponding\n Aircraft Seats Number which = " + cap);
                }

                string command = "UPDATE FLIGHT SET AIRCRAFTID = '"
                        + airID + "', ADMINID = '"
                        + (int)row["ADMINID"] + "', SEATSNUMBER = '"
                        + seatsNumText.Text.ToString() + "', SOURCE = '"
                        + sourceText.Text.ToString() + "', DESTINATION = '"
                        + destinationText.Text.ToString() + "', OUTGOINGDATE = '"
                        + from + "', ARRIVINGDATE = '"
                        + to + "', STANDARDPRICE = " + standardPrice
                        + " WHERE FLIGHTID = " + globalFlightID + ";";

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
