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
    public partial class adminProfile : Form
    {
        public adminProfile()
        {
            InitializeComponent();


            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-C145KAF; Initial Catalog = FlightReservation; Integrated Security =True");

            con.Open();
            
            DataRow rowTemp = Program.CustomerData.Rows[0];
            
            
            string updateCommand = "SELECT * FROM ADMIN WHERE ADMINID = " + (int)rowTemp["ADMINID"];

            SqlCommand updatComm = new SqlCommand(updateCommand, con);
            SqlDataReader reader = updatComm.ExecuteReader();

            Program.CustomerData.Load(reader);

            DataRow row = Program.CustomerData.Rows[0];

            firstNameText.Text = (string)row["AFNAME"];
            lastNameText.Text = (string)row["ALNAME"];
            emailText.Text = (string)row["AMAIL"];
            passwordText.Text = (string)row["APASSWORD"];

            reader.Close();
            con.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-C145KAF; Initial Catalog = FlightReservation; Integrated Security =True");

            con.Open();

            SqlCommand comm;
            DataRow row = Program.CustomerData.Rows[0];

            string command = "UPDATE ADMIN SET AFNAME = '"
                    + firstNameText.Text.ToString() + "', ALNAME = '"
                    + lastNameText.Text.ToString() + "', APASSWORD = '"
                    + passwordText.Text.ToString() + "', AMAIL = '"
                    + emailText.Text.ToString() + "' WHERE ADMINID = " + (int)row["ADMINID"] + ";";

            comm = new SqlCommand(command, con);
            comm.ExecuteNonQuery();

            string updateCommand = "SELECT * FROM ADMIN WHERE ADMINID = " + (int)row["ADMINID"];
            SqlCommand updatComm = new SqlCommand(updateCommand, con);
            SqlDataReader reader = updatComm.ExecuteReader();

            Program.CustomerData.Rows.Clear();
            Program.CustomerData.Load(reader);

            reader.Close();
            con.Close();
        }
    }
}
