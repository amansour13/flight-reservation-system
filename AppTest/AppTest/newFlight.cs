﻿using System;
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
    public partial class newFlight : Form
    {
        public newFlight()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            // LAPTOP-H6PI0HTC
            // DESKTOP-C145KAF
            // DESKTOP - A34VKT1
            SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

            con.Open();

            SqlCommand comm;
            
            string from = outgoing.Value.Year + "-" + outgoing.Value.Month + "-" + outgoing.Value.Day + " " + outgoing.Value.Hour + ":" + outgoing.Value.Minute + ":00";
            string to = arriving.Value.Year + "-" + arriving.Value.Month + "-" + arriving.Value.Day + " " + arriving.Value.Hour + ":" + arriving.Value.Minute + ":00";


            int aircraftID = 0;
            Int32.TryParse(aircraftIdText.Text, out aircraftID);

            int seatsNum = 0;
            Int32.TryParse(seatsNumText.Text, out seatsNum);

            DataRow row = Program.CustomerData.Rows[0];

            string command = "Insert Into FLIGHT VALUES(" + aircraftID + ", " + (int)row["ADMINID"] + ", "
                    + seatsNum
                    + ", '" + sourceText.Text + "'"
                    + ", '" + destinationText.Text + "'"
                    + ", '" + from + "'"
                    + ", '" + to + "'"
                    + ")";
            comm = new SqlCommand(command, con);

            comm.ExecuteNonQuery();

            string message = "Flight Added Successful\n";
            string title = "Success";
            MessageBox.Show(message, title);

            aircraftIdText.Text = "";
            seatsNumText.Text = "";
            sourceText.Text = "";
            destinationText.Text = "";
            outgoing.Value = DateTime.Now;
            arriving.Value = DateTime.Now;
        }
    }
}