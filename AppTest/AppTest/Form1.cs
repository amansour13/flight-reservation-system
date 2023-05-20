using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace AppTest
{

    
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightReservationDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.flightReservationDataSet.CUSTOMER);
            // TODO: This line of code loads data into the 'flightReservationDataSet.AIRCRAFT' table. You can move, or remove it, as needed.
            this.aIRCRAFTTableAdapter.Fill(this.flightReservationDataSet.AIRCRAFT);
            // TODO: This line of code loads data into the 'flightReservationDataSet.ADMIN' table. You can move, or remove it, as needed.
            this.aDMINTableAdapter.Fill(this.flightReservationDataSet.ADMIN);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-C145KAF; Initial Catalog = FlightReservation; Integrated Security =True");
            
            con.Open();



           
            if (checkBox1.Checked)
            {
                string command = "SELECT ADMINID FROM ADMIN WHERE CONVERT(nvarchar(MAX), AMAIL) = '" +
                                 textBox1.Text + "' AND CONVERT(nvarchar(MAX), APASSWORD) = '" +
                                 textBox2.Text + "'";
                SqlCommand comm = new SqlCommand(command, con);
                SqlDataReader reader = comm.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        label3.Text = reader["ADMINID"].ToString();
                    }
                    
                }
                else
                {
                    label3.Text = "Invalid credentials";
                }

                reader.Close();
            }
            else
            {
                string command = "SELECT SSN FROM CUSTOMER WHERE CONVERT(nvarchar(MAX), CMAIL) = '" +
                                 textBox1.Text + "' AND CONVERT(nvarchar(MAX), CPASSWORD) = '" +
                                 textBox2.Text + "'";
                SqlCommand comm = new SqlCommand(command, con);
                SqlDataReader reader = comm.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        label3.Text = reader["SSN"].ToString();
                    }

                }
                else
                {
                    label3.Text = "Invalid credentials";
                }

                reader.Close();
            }

            con.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void signUp_Click(object sender, EventArgs e)
        {
            
            signUpForm signUpForm = new signUpForm();

            this.Hide();

            signUpForm.ShowDialog();

            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
