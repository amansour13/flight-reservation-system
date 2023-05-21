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

namespace AppTest
{
    public partial class customerForm : Form
    {
        
        public customerForm()
        {
            InitializeComponent();
        }
        public string Fname { get; set; }
        public string Lname { get; set; }
        private void customerForm_Load(object sender, EventArgs e)
        {
            helloLabel.Text = "Hello " + Fname + " " + Lname + " :)";
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
    }
}
