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
    public partial class newFlight : Form
    {
        public newFlight()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

                con.Open();

                SqlCommand comm;

                string from = outgoing.Value.Year + "-" + outgoing.Value.Month + "-" + outgoing.Value.Day + " " + outgoing.Value.Hour + ":" + outgoing.Value.Minute + ":00";
                string to = arriving.Value.Year + "-" + arriving.Value.Month + "-" + arriving.Value.Day + " " + arriving.Value.Hour + ":" + arriving.Value.Minute + ":00";


                if ((!Program.IsStringNumeric(aircraftIdText.Text)) || (!Program.IsStringNumeric(seatsNumText.Text)) || (!Program.IsStringNumeric(standardPriceText.Text)))
                {
                    throw new Exception("ERROR : can not add string in integer field\ncheck all integer fields");
                }

                if (outgoing.Value > arriving.Value)
                {
                    throw new Exception("ERROR : OutGoing Date is after Arriving Date\nrecheck two dates");
                }

                int aircraftID = 0;
                Int32.TryParse(aircraftIdText.Text, out aircraftID);

                int seatsNum = 0;
                Int32.TryParse(seatsNumText.Text, out seatsNum);

                int standardPrice = 0;
                Int32.TryParse(standardPriceText.Text, out standardPrice);

                DataRow row = Program.CustomerData.Rows[0];

                string command = "Insert Into FLIGHT VALUES(" + aircraftID + ", " + (int)row["ADMINID"] + ", "
                        + seatsNum
                        + ", '" + sourceText.Text + "'"
                        + ", '" + destinationText.Text + "'"
                        + ", '" + from + "'"
                        + ", '" + to + "'"
                        + ", '" + standardPrice + "'"
                        + ")";
                comm = new SqlCommand(command, con);

                comm.ExecuteNonQuery();

                string message = "Flight Added Successfully\n";
                string title = "Success";
                MessageBox.Show(message, title);

                aircraftIdText.Text = "";
                seatsNumText.Text = "";
                sourceText.Text = "";
                destinationText.Text = "";
                standardPriceText.Text = "";
                outgoing.Value = DateTime.Now;
                arriving.Value = DateTime.Now;

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
