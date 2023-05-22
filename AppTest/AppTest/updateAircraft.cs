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

            SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

            con.Open();

            int aircraftID = 0;
            Int32.TryParse(search.Text, out aircraftID);

            string updateCommand = "SELECT * FROM AIRCRAFT WHERE AIRCRAFTID = " + aircraftID;
            SqlCommand updatComm = new SqlCommand(updateCommand, con);
            SqlDataReader reader = updatComm.ExecuteReader();

            globalAircraftID = aircraftID;

            while (reader.Read())
            {
                capacityText.Text = reader["CAPACITY"].ToString();
                manfactText.Text = reader["MANFACTURER"].ToString();
                distanceText.Text = reader["DISTANCEALLOWED"].ToString();
            }

            reader.Close();
            con.Close();

            mainSearchPanel.Visible = true;
            searchPanel.Visible = false;
        }

        public int globalAircraftID = new int(); 
        private void updateBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

            con.Open();

            SqlCommand comm;

            string command = "UPDATE AIRCRAFT SET CAPACITY = '"
                    + capacityText.Text.ToString() + "', MANFACTURER = '"
                    + manfactText.Text.ToString() + "', DISTANCEALLOWED = '"
                    + distanceText.Text.ToString() + "' WHERE AIRCRAFTID = " + globalAircraftID + ";";

            comm = new SqlCommand(command, con);
            comm.ExecuteNonQuery();

            string message = "Aircraft Updated Successfully\n";
            string title = "Success";
            MessageBox.Show(message, title);

            mainSearchPanel.Visible = false;
            searchPanel.Visible = true;
            search.Text = "";

            con.Close();
        }
    }
}
