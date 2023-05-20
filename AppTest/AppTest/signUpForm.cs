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
            }
            else if (!adminCheckbox.Checked)
            {
                SSNLabel.Show();
                SSNTextBox.Show();
                customerBirthDate.Show();
                BirthdateLabel.Show();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
