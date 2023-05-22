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
        // private SqlDataReader CustomerData { get; set; }
        private void CustomerPanel_Paint(object sender, PaintEventArgs e)
        {        
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

            con.Open();

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
        
    }
}
