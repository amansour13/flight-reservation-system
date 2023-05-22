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
    public partial class updateAircraft : Form
    {
        public updateAircraft()
        {
            InitializeComponent();
        }

        private void updateAircraft_Load(object sender, EventArgs e)
        {
            mainSearchPanel.Visible = false;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

                con.Open();

                if ((!Program.IsStringNumeric(search.Text)))
                {
                    throw new Exception("ERROR : can not add string in integer field\ncheck all integer fields");
                }

                int aircraftID = 0;
                Int32.TryParse(search.Text, out aircraftID);

                string updateCommand = "SELECT * FROM AIRCRAFT WHERE AIRCRAFTID = " + aircraftID;
                SqlCommand updatComm = new SqlCommand(updateCommand, con);
                SqlDataReader reader = updatComm.ExecuteReader();



                int tempID = 0;
                while (reader.Read())
                {
                    capacityText.Text = reader["CAPACITY"].ToString();
                    manfactText.Text = reader["MANFACTURER"].ToString();
                    distanceText.Text = reader["DISTANCEALLOWED"].ToString();
                    tempID = (int)reader["AIRCRAFTID"];
                }

                reader.Close();
                con.Close();

                if (aircraftID != tempID)
                {
                    string message = "Sorry this ID is NOT EXIST\n";
                    string title = "Success";
                    MessageBox.Show(message, title);
                }
                else
                {
                    mainSearchPanel.Visible = true;
                    searchPanel.Visible = false;
                    globalAircraftID = aircraftID;
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

        public int globalAircraftID = new int(); 
        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

                con.Open();

                if (!(Program.IsStringNumeric(capacityText.Text)) || !(Program.IsStringNumeric(distanceText.Text)))
                {
                    throw new Exception("ERROR : can not add string in integer field\ncheck all integer fields");
                }
                SqlCommand comm;

                string command = "UPDATE AIRCRAFT SET CAPACITY = '"
                        + capacityText.Text.ToString() + "', MANFACTURER = '"
                        + manfactText.Text.ToString() + "', DISTANCEALLOWED = '"
                        + distanceText.Text.ToString() + "' WHERE AIRCRAFTID = " + globalAircraftID + ";";

                comm = new SqlCommand(command, con);
                comm.ExecuteNonQuery();

                string message = "Aircraft with ID = " + globalAircraftID.ToString() + "\nUpdated Successfully\n";
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
