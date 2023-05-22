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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AppTest
{
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

                con.Open();

                int SSN = 0;
                Int32.TryParse(SSNTextBox.Text, out SSN);

                string updateCommand = "SELECT * FROM CUSTOMER WHERE SSN = " + SSN;
                SqlCommand updatComm = new SqlCommand(updateCommand, con);
                SqlDataReader reader = updatComm.ExecuteReader();

                Program.CustomerData.Load(reader);

                DataRow row = Program.CustomerData.Rows[0];

                firstNameText.Text = (string)row["CFNAME"];
                lastNameText.Text = (string)row["CLNAME"];
                emailText.Text = (string)row["CMAIL"];
                passwordText.Text = (string)row["CPASSWORD"];
                SSNTextBox.Text = row["SSN"].ToString();
                customerBirthDate.Text = row["BIRTHDATE"].ToString();

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
        // private SqlDataReader CustomerData { get; set; }
        private void CustomerPanel_Paint(object sender, PaintEventArgs e)
        {        
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

                con.Open();

                if ((!Program.IsStringNumeric(SSNTextBox.Text)))
                {
                    throw new Exception("ERROR : can not add string in integer field\ncheck all integer fields");
                }

                if (customerBirthDate.Value > DateTime.Now)
                {
                    throw new Exception("ERROR : can not add Birthdate after today");
                }

                SqlCommand comm;
                DataRow row = Program.CustomerData.Rows[0];

                int SSN = 0;
                Int32.TryParse(SSNTextBox.Text, out SSN);

                string command = "UPDATE CUSTOMER SET SSN = " + SSN + ", CFNAME = '"
                        + firstNameText.Text.ToString() + "', CLNAME = '"
                        + lastNameText.Text.ToString() + "', CPASSWORD = '"
                        + passwordText.Text.ToString() + "', BIRTHDATE = '"
                        + customerBirthDate.Value + "', CMAIL = '"
                        + emailText.Text.ToString() + "' WHERE SSN = " + (int)row["SSN"] + ";";
                comm = new SqlCommand(command, con);
                comm.ExecuteNonQuery();

                string updateCommand = "SELECT * FROM CUSTOMER WHERE SSN = " + SSN;
                SqlCommand updatComm = new SqlCommand(updateCommand, con);
                SqlDataReader reader = updatComm.ExecuteReader();
                /*while (reader.Read())
                {*/
                Program.CustomerData.Rows.Clear();
                Program.CustomerData.Load(reader);
                //}
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
