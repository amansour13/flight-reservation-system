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
using static AppTest.yourFlights;

namespace AppTest
{
    public partial class availableFlights : Form
    {
        public class flightsBookingDetails
        {
            public Panel main = new Panel();
            public Panel head = new Panel();
            public Panel center = new Panel();
            public Panel bottom = new Panel();

            public Panel space = new Panel();

            public Label flightid = new Label();
            public Label seatsNumber = new Label();
            public Label flightClass = new Label();
            public Label destination = new Label();
            public Label source = new Label();
            public Label outgoingDate = new Label();
            public Label arrivingDate = new Label();
            public Label price = new Label();
            public Label seatNum = new Label();
            public int CounterSeatNum = 1;

            public Button book = new Button();

            private Panel dataPanel;

            private availableFlights availableFlights;
            public flightsBookingDetails(Panel dataPanel, availableFlights availableFlights)
            {
                this.dataPanel = dataPanel;
                this.availableFlights = availableFlights;

                book.Click += new EventHandler(bookClick);

                space.Dock = DockStyle.Top;
                space.BackColor = Color.FromArgb(25, 11, 35);
                space.Height = 20;

                main.Dock = DockStyle.Top;
                main.Height = 120;

                addingheadContent();

                addingcenterContent();

                addingbottomContent();

                main.BackColor = Color.FromArgb(25, 11, 35);

                main.Controls.Add(head);
                main.Controls.Add(center);
                main.Controls.Add(bottom);

                head.BringToFront();
                center.BringToFront();
                bottom.BringToFront();

                main.BorderStyle = BorderStyle.Fixed3D;

            }

            public void readSeatNum(int flightID)
            {
                SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

                con.Open();

                string command = "UPDATE FLIGHT SET SEATSNUMBER = (SEATSNUMBER - 1)"
                    + "WHERE FLIGHTID = " + flightID + ";";
                SqlCommand comm = new SqlCommand(command, con);
                comm.ExecuteReader();

                con.Close();

            }


            private void bookClick(object sender, EventArgs e)
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

                    con.Open();

                    DataRow row = Program.CustomerData.Rows[0];

                    SqlCommand comm;

                    int flightIDInt = 0;
                    Int32.TryParse(flightid.Text.Substring(12), out flightIDInt);

                    int seatNumberInt = 0;
                    Int32.TryParse(seatNum.Text.Substring(14), out seatNumberInt);

                    char BClass = flightClass.Text[flightClass.Text.Length - 1];

                    string state = "Booked";

                    int Bprice = 0;
                    Int32.TryParse(price.Text.Substring(8), out Bprice);


                    string command = "INSERT INTO BOOKING VALUES(" + (int)row["SSN"]
                        + "," + flightIDInt + "," + seatNumberInt + ", '"
                        + BClass + "', '" + state + "', " + Bprice + ")";
                    comm = new SqlCommand(command, con);
                    comm.ExecuteNonQuery();

                    readSeatNum(flightIDInt);

                    CounterSeatNum++;
                    con.Close();

                    string message = "Book done Successfuly";
                    string title = "Success";
                    MessageBox.Show(message, title);


                    availableFlights.dataPanel.Controls.Clear();

                    availableFlights.dataPanel.Refresh();

                    availableFlights.searchBtn.PerformClick();


                }
                catch (Exception ex)
                {
                    // Handle the exception
                    string message = ex.Message;
                    string title = "FAILED";
                    MessageBox.Show(message, title);
                }
            }
            private void addingheadContent()
            {
                head.Dock = DockStyle.Top;
                head.Height = 30;

                flightid.Text = "Flight ID : ";
                seatsNumber.Text = "Available Seats Number : ";
                flightClass.Text = "Flight Class : ";
                price.Text = "Price : ";
                seatNum.Text = "Seat Number : ";

                seatsNumber.AutoSize = true;
                /*flightid.AutoSize = true;
                flightClass.AutoSize = true;
                price.AutoSize = true;*/

                seatNum.Dock = DockStyle.Left;
                seatsNumber.Dock = DockStyle.Left;
                flightid.Dock = DockStyle.Left;
                flightClass.Dock = DockStyle.Left;
                price.Dock = DockStyle.Left;


                seatNum.ForeColor = Color.White;
                flightid.ForeColor = Color.White;
                seatsNumber.ForeColor = Color.White;
                flightClass.ForeColor = Color.White;
                price.ForeColor = Color.White;

                head.Padding = new Padding(20, 5, 5, 5);

                head.Controls.Add(seatNum);
                head.Controls.Add(seatsNumber);
                head.Controls.Add(flightid);
                
                head.Controls.Add(flightClass);
                head.Controls.Add(price);
            }

            private void addingcenterContent()
            {
                center.Dock = DockStyle.Top;
                center.Height = 30;

                destination.Text = "To : ";
                source.Text = "From : ";
                arrivingDate.Text = "Arriving Date : ";
                outgoingDate.Text = "Outgoing Date : ";

                /*destination.AutoSize = true;
                source.AutoSize = true;*/
                arrivingDate.AutoSize = true;
                outgoingDate.AutoSize = true;

                destination.ForeColor = Color.White;
                source.ForeColor = Color.White;
                arrivingDate.ForeColor = Color.White;
                outgoingDate.ForeColor = Color.White;
                

                destination.Dock = DockStyle.Left;
                source.Dock = DockStyle.Left;
                arrivingDate.Dock = DockStyle.Left;
                outgoingDate.Dock = DockStyle.Left;
                

                center.Padding = new Padding(20, 5, 5, 5);

                center.Controls.Add(source);
                center.Controls.Add(destination);
                center.Controls.Add(outgoingDate);
                center.Controls.Add(arrivingDate);
                
            }

            private void addingbottomContent()
            {
                bottom.Dock = DockStyle.Top;
                bottom.Height = 50;

                book.Text = "Book this flight";
                book.Height = 45;
                book.Width = 332;
                book.BackColor = Color.FromArgb(204, 51, 102);
                book.FlatStyle = FlatStyle.Flat;

                book.Dock = DockStyle.Right;


                bottom.Padding = new Padding(5);

                bottom.Controls.Add(book);
            }

            public void setData(string flightId, string seatNumber, string flightClass, string to, string from, string outgoing, string arriving, string price)
            {
                this.flightid.Text += flightId;
                this.seatsNumber.Text += seatNumber;
                this.flightClass.Text += flightClass;
                this.destination.Text += to;
                this.source.Text += from;
                this.price.Text += price;
                this.outgoingDate.Text += outgoing;
                this.arrivingDate.Text += arriving;
                this.seatNum.Text += CounterSeatNum.ToString();
            }
        }

        public availableFlights()
        {
            InitializeComponent();
        }

        private void reloadAllDatainComboBoxs()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

                con.Open();

                string command = "SELECT SOURCE,DESTINATION,OUTGOINGDATE FROM FLIGHT";
                SqlCommand comm = new SqlCommand(command, con);
                SqlDataReader reader = comm.ExecuteReader();

                List<string> sourcesReader = new List<string>();
                List<string> destReader = new List<string>();
                List<string> dateReader = new List<string>();

                sourcesReader.Add("None");
                destReader.Add("None");
                dateReader.Add("None");

                while (reader.Read())
                {
                    string source = reader["SOURCE"].ToString();
                    string dest = reader["DESTINATION"].ToString();
                    string date = reader["OUTGOINGDATE"].ToString();
                    sourcesReader.Add(source);
                    destReader.Add(dest);
                    dateReader.Add(date);
                }


                reader.Close();
                con.Close();

                comboBox1.DataSource = sourcesReader;
                comboBox2.DataSource = destReader;
                comboBox3.DataSource = dateReader;
            }
            catch (Exception ex)
            {
                // Handle the exception
                string message = ex.Message;
                string title = "FAILED";
                MessageBox.Show(message, title);
            }
        }

        private void availableFlights_Load(object sender, EventArgs e)
        {
            reloadAllDatainComboBoxs();
            comboBox4.SelectedIndex = 0;
        }

        public string searchCommand(string com)
        {
            com = "SELECT * FROM FLIGHT ";

            if (comboBox1.Text != "None" || comboBox2.Text != "None" || comboBox3.Text != "None")
            {
                com += "WHERE ";

                if (comboBox1.Text != "None")
                {
                    com += "CONVERT(nvarchar(MAX), SOURCE) = '" + comboBox1.Text + "'";
                }

                if (comboBox2.Text != "None")
                {
                    if (comboBox1.Text != "None")
                    {
                        com += " AND ";
                    }
                    com += "CONVERT(nvarchar(MAX), DESTINATION) = '" + comboBox2.Text + "'";
                }

                if (comboBox3.Text != "None")
                {
                    if (comboBox1.Text != "None" || comboBox2.Text != "None")
                    {
                        com += " AND ";
                    }
                    com += "OUTGOINGDATE = '" + comboBox3.Text + "'";
                }
            }

            return com;

        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dataPanel.Controls.Clear();
                SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

                con.Open();
                DataTable flights = new DataTable();

                DataTable booking = new DataTable();

                string command = "SELECT * FROM FLIGHT";
                command = searchCommand(command);
                SqlCommand comm = new SqlCommand(command, con);
                SqlDataReader reader = comm.ExecuteReader();

                flights.Load(reader);



                DataRow flightsRow;

                for (int i = 0; i < flights.Rows.Count; i++)
                {
                    flightsRow = flights.Rows[i];

                    if ((int)flightsRow["SEATSNUMBER"] <= 0)
                    {
                        continue;
                    }
                    else
                    {
                        int d = (int)flightsRow["FLIGHTID"];
                        flightsBookingDetails f = new flightsBookingDetails(dataPanel, this);
                        command = "SELECT COUNT(SEATNUMBER) as number FROM BOOKING WHERE FLIGHTID = " + d;
                        comm = new SqlCommand(command, con);
                        reader = comm.ExecuteReader();
                       
                        int s = -99;
                        while (reader.Read())
                        {
                            s = (int)reader["number"];
                        }
        
                        int numberOfSeats = s;
                        reader.Close();

                        f.CounterSeatNum = numberOfSeats + 1;

                        float std = float.Parse(flightsRow["STANDARDPRICE"].ToString());
                        char c = comboBox4.Text[0];

                        string price = Program.priceFormula(std, c).ToString();

                        f.setData(flightsRow["FLIGHTID"].ToString(), flightsRow["SEATSNUMBER"].ToString()
                        , comboBox4.Text, flightsRow["DESTINATION"].ToString()
                        , flightsRow["SOURCE"].ToString(), flightsRow["OUTGOINGDATE"].ToString()
                        , flightsRow["ARRIVINGDATE"].ToString()
                        , price);


                        dataPanel.Controls.Add(f.space);
                        dataPanel.Controls.Add(f.main);
                    }

                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                // Handle the exception
                string message = ex.Message;
                string title = "FAILED";
                MessageBox.Show(message, title);
            }
        }
    }
}
