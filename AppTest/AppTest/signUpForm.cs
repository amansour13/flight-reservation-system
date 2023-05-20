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
    public partial class signUpForm : Form
    {
        public signUpForm()
        {
            InitializeComponent();
        }

        private void signUpForm_Load(object sender, EventArgs e)
        {
            /*CustomerPanel.Hide();*/
        }

        private void adminCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (adminCheckbox.Checked){
                SSNLabel.Hide();
                SSNTextBox.Hide();
                customerBirthDate.Hide();
                BirthdateLabel.Hide();
                hr7.Hide();
            }
            else if (!adminCheckbox.Checked)
            {
                SSNLabel.Show();
                SSNTextBox.Show();
                customerBirthDate.Show();
                BirthdateLabel.Show();
                hr7.Show();
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-C145KAF; Initial Catalog = FlightReservation; Integrated Security =True");

            con.Open();

            SqlCommand comm;

            if (adminCheckbox.Checked)
            {
                string command = "Insert Into ADMIN VALUES('" + firstNameText.Text.ToString() + "','" 
                    + lastNameText.Text.ToString()
                    + "','" + emailText.Text.ToString() + "','" 
                    + passwordText.Text.ToString() + "')" ;
                 comm = new SqlCommand(command, con);
            }
            else
            {
                int SSN = 0;
                Int32.TryParse(SSNTextBox.Text, out SSN);

                string command = "Insert Into CUSTOMER VALUES('"
                    + SSN + "','"
                    + firstNameText.Text.ToString() + "','"
                    + lastNameText.Text.ToString() + "','"
                    + passwordText.Text.ToString() + "','"
                    + customerBirthDate.Value + "','"
                    + emailText.Text.ToString() + "')";
                 comm = new SqlCommand(command, con);
            }

            comm.ExecuteNonQuery();

            string message = "Sign Up Successful \n you can now log in";
            string title = "Success";
            MessageBox.Show(message, title);

            LoginPage logIn = new LoginPage();

            this.Hide();
            logIn.ShowDialog();
            this.Close();

            con.Close();

        }

        private void customerBirthDate_ValueChanged(object sender, EventArgs e)
        {
            customerBirthDate.BackColor = Color.Red;
        }

        private void logInButton_Click(object sender, EventArgs e)
        {
            LoginPage logIn = new LoginPage();

            this.Hide();
            logIn.ShowDialog();
            this.Close();
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
