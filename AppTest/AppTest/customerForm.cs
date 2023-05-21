using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AppTest
{
    public partial class customerForm : Form
    {
        
        public customerForm()
        {
            InitializeComponent();
        }

        public SqlDataReader CustomerData { get; set; }
        private void customerForm_Load(object sender, EventArgs e)
        {
            helloLabel.Text = "Hello " + CustomerData["CFNAME"].ToString() + " " + CustomerData["CLNAME"].ToString() + " :)";
        }

        private void logoPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            this.Hide();
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
            p.CustomerData = CustomerData;
            openChildFormInPanel(p);
        }

        private void flightsListButton_Click(object sender, EventArgs e)
        {
            yourFlights f = new yourFlights();
            // data to be initiliazed here ...
            openChildFormInPanel(f);
        }

        private void searchFlightsButton_Click(object sender, EventArgs e)
        {
            availableFlights f = new availableFlights();
            // data to be initiliazed here ...
            openChildFormInPanel(f);
        }
    }
}
