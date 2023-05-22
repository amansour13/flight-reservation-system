using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTest
{
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            this.Hide();
            Program.CustomerData.Rows.Clear();
            login.ShowDialog();
            this.Close();
        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            DataRow row = Program.CustomerData.Rows[0];
            helloLabel.Text = "Hello " + (string)row["AFNAME"].ToString() + " " + (string)row["ALNAME"].ToString() + " :)";
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            adminProfile profile = new adminProfile();
            openChildFormInPanel(profile);
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

        private void addAircraft_Click(object sender, EventArgs e)
        {
            newAircraft aircraft = new newAircraft();
            openChildFormInPanel(aircraft);
        }

        private void addFlight_Click(object sender, EventArgs e)
        {
            newFlight flight = new newFlight();
            openChildFormInPanel(flight);
        }

        private void updateAircraft_Click(object sender, EventArgs e)
        {
            updateAircraft updateAir = new updateAircraft();
            openChildFormInPanel(updateAir);
        }

        private void updateFlight_Click(object sender, EventArgs e)
        {
            updateFligh upateFlight = new updateFligh();
            openChildFormInPanel(upateFlight);
        }
    }
}
