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
    public partial class newAircraft : Form
    {
        public newAircraft()
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
                

                if ((!Program.IsStringNumeric(capacityText.Text)) || (!Program.IsStringNumeric(distanceText.Text)))
                {
                    throw new Exception("ERROR : can not add string in integer field\ncheck all integer fields");
                }
                
                int capacity = 0;
                Int32.TryParse(capacityText.Text, out capacity);

                int distance = 0;
                Int32.TryParse(distanceText.Text, out distance);

                DataRow row = Program.CustomerData.Rows[0];


                string command = "Insert Into AIRCRAFT VALUES(" + (int)row["ADMINID"] + ", " + capacity + ",'"
                        + manfactText.Text.ToString()
                        + "'," + distance + ")";
                comm = new SqlCommand(command, con);

                comm.ExecuteNonQuery();

                string message = "Aircraft Added Successfully\n";
                string title = "Success";
                MessageBox.Show(message, title);

                capacityText.Text = "";
                manfactText.Text = "";
                distanceText.Text = "";

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
