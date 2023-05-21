using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTest
{
    public partial class customerForm : Form
    {
        
        public customerForm()
        {
            InitializeComponent();
        }
        // public SqlDataReader CustomerData { get; set; }
        private void customerForm_Load(object sender, EventArgs e)
        {
            DataRow row = Program.CustomerData.Rows[0];
            helloLabel.Text = "Hello " + (string)row["CFNAME"].ToString() + " " + (string)row["CLNAME"].ToString() + " :)";
        }

        private void logoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            this.Hide();
            Program.CustomerData.Rows.Clear();
            login.ShowDialog();
            this.Close();

        }

        private void helloLabel_Click(object sender, EventArgs e)
        {
          
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            profile p = new profile();
            // Program.CustomerData = CustomerData;
            openChildFormInPanel(p);
        }

        private void flightsListButton_Click(object sender, EventArgs e)
        {
            yourFlights yourFlights = new yourFlights();

            openChildFormInPanel(yourFlights);
        }

        private void searchFlightsButton_Click(object sender, EventArgs e)
        {
            availableFlights availableFlights = new availableFlights();
            openChildFormInPanel(availableFlights);
        }
    }
}
