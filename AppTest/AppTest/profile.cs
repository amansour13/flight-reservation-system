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

namespace AppTest
{
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }
        public SqlDataReader CustomerData { get; set; }
        private void CustomerPanel_Paint(object sender, PaintEventArgs e)
        {
            firstNameText.Text = CustomerData["CFNAME"].ToString();
            
        }
    }
}
