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

            SqlConnection con = new SqlConnection(@"Data Source = LAPTOP-H6PI0HTC; Initial Catalog = FlightReservation; Integrated Security =True");

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
            /*string command = "SELECT * FROM CUSTOMER WHERE CONVERT(nvarchar(MAX), CMAIL) = '" +
                                 textBox1.Text + "' AND CONVERT(nvarchar(MAX), CPASSWORD) = '" +
                                 textBox2.Text + "'";
            SqlCommand comm = new SqlCommand(command, con);
            SqlDataReader reader = comm.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    customerForm cForm = new customerForm();
                    cForm.CustomerData = reader;

                    this.Hide();

                    cForm.ShowDialog();

                    this.Close();
                }

            }
            else
            {
                invalid.Text = "* inavlid Ceredentials";
            }

            reader.Close();*/
            
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = LAPTOP-H6PI0HTC; Initial Catalog = FlightReservation; Integrated Security =True");

            con.Open();

            SqlCommand comm;
            DataRow row = Program.CustomerData.Rows[0];
            // CustomerData["CFNAME"] = "SSSS";

            /*UPDATE CUSTOMER
            SET SSN = 5, CFNAME = 'AYMAN', CLNAME = 'ABOU', CPASSWORD = '12',
            BIRTHDATE = '2003-04-07', CMAIL = 'ayman@gmail.com'
            where SSN = 1;*/
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

            string message = "Profile Information Updated";
            string title = "Success";
            MessageBox.Show(message, title);
        }
    }
}
