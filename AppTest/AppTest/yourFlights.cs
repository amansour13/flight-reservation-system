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

    public partial class yourFlights : Form
    {
        public class flightsDetails
        {
            public Panel main = new Panel();
            public Panel head = new Panel();
            public Panel center = new Panel();
            public Panel bottom = new Panel();

            public Panel space = new Panel();

            public Label flightid = new Label();
            public Label seatNumber = new Label();
            public Label flightClass = new Label();
            public Label state = new Label();
            public Label destination = new Label();
            public Label source = new Label();
            public Label outgoingDate = new Label();
            public Label arrivingDate = new Label();
            public Label price = new Label();

            public Button changeClass = new Button();
            public Button cancelFlight = new Button();
            public Button chooseClass = new Button();



            public ComboBox flightClassList = new ComboBox();

            private yourFlights yourFlight;
            public flightsDetails(yourFlights yourFlight)
            {
                this.yourFlight = yourFlight;

                changeClass.Click += new EventHandler(changeClassClick);
                chooseClass.Click += new EventHandler(chooseClassClick);
                cancelFlight.Click += new EventHandler(cancelFlightClick);


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

            private void addingheadContent()
            {
                flightClassList.Items.Add("A");
                flightClassList.Items.Add("B");
                flightClassList.Items.Add("C");
                head.Dock = DockStyle.Top;
                head.Height = 30;

                flightid.Text = "Flight ID : ";
                seatNumber.Text = "Seat Number : ";
                flightClass.Text = "Flight Class : ";
                state.Text = "State : ";

                flightid.Dock = DockStyle.Left;
                seatNumber.Dock = DockStyle.Left;
                flightClassList.Dock = DockStyle.Left;
                flightClass.Dock = DockStyle.Left;
                state.Dock = DockStyle.Left;

                flightid.ForeColor = Color.White;
                seatNumber.ForeColor = Color.White;
                flightClass.ForeColor = Color.White;
                state.ForeColor = Color.White;

                head.Padding = new Padding(20, 5, 5, 5);

                head.Controls.Add(flightClass);
                head.Controls.Add(flightid);
                head.Controls.Add(seatNumber);

                head.Controls.Add(state);

            }

            private void addingcenterContent()
            {
                center.Dock = DockStyle.Top;
                center.Height = 30;

                destination.Text = "To : ";
                source.Text = "From : ";
                arrivingDate.Text = "Arriving Date : ";
                outgoingDate.Text = "Outgoing Date : ";
                price.Text = "Price : ";

                arrivingDate.AutoSize = true;
                outgoingDate.AutoSize = true;

                destination.ForeColor = Color.White;
                source.ForeColor = Color.White;
                arrivingDate.ForeColor = Color.White;
                outgoingDate.ForeColor = Color.White;
                price.ForeColor = Color.White;

                destination.Dock = DockStyle.Left;
                source.Dock = DockStyle.Left;
                arrivingDate.Dock = DockStyle.Left;
                outgoingDate.Dock = DockStyle.Left;
                price.Dock = DockStyle.Left;

                center.Padding = new Padding(20, 5, 5, 5);

                center.Controls.Add(source);
                center.Controls.Add(destination);
                center.Controls.Add(outgoingDate);
                center.Controls.Add(arrivingDate);
                center.Controls.Add(price);
            }

            private void addingbottomContent()
            {
                bottom.Dock = DockStyle.Top;
                bottom.Height = 50;

                changeClass.Text = "Change Class";
                changeClass.Height = 45;
                changeClass.Width = 332;
                changeClass.BackColor = Color.FromArgb(204, 51, 102);
                changeClass.FlatStyle = FlatStyle.Flat;

                chooseClass.Text = "Choose Class";
                chooseClass.Height = 45;
                chooseClass.Width = 332;
                chooseClass.BackColor = Color.FromArgb(204, 51, 102);
                chooseClass.FlatStyle = FlatStyle.Flat;

                cancelFlight.Text = "Cancel Flight";
                cancelFlight.Height = 45;
                cancelFlight.Width = 332;
                cancelFlight.BackColor = Color.FromArgb(204, 51, 102);
                cancelFlight.FlatStyle = FlatStyle.Flat;

                changeClass.Dock = DockStyle.Left;
                cancelFlight.Dock = DockStyle.Left;
                chooseClass.Dock = DockStyle.Left;


                bottom.Padding = new Padding(5);

                bottom.Controls.Add(changeClass);
                bottom.Controls.Add(cancelFlight);
            }

            public void setData(string flightId, string seatNumber, string flightClass, string state, string to, string from, string outgoing, string arriving, string price)
            {
                this.flightid.Text += flightId;  //flight
                this.seatNumber.Text += seatNumber;  //booking
                this.flightClass.Text += flightClass;  // booking
                this.state.Text += state;  //booking 
                this.destination.Text += to;  //flight
                this.source.Text += from;  //flight
                this.price.Text += price;  //booking
                this.outgoingDate.Text += outgoing;  //flight
                this.arrivingDate.Text += arriving;  //flight
            }

            private void changeClassClick(object sender, EventArgs e)
            {
                head.Controls.Add(flightClassList);
                flightClassList.BringToFront();

                changeClass.Hide();
                bottom.Controls.Add(chooseClass);
                chooseClass.BringToFront();

            }

            private void chooseClassClick(object sender, EventArgs e)
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
                    Int32.TryParse(seatNumber.Text.Substring(14), out seatNumberInt);


                    string command = "UPDATE BOOKING SET CLASS = '" + flightClassList.Text
                        + "' WHERE SSN = " + (int)row["SSN"] + " AND FLIGHTID = " + flightIDInt
                        + " AND SEATNUMBER = " + seatNumberInt;
                    comm = new SqlCommand(command, con);
                    comm.ExecuteNonQuery();

                    con.Close();

                    string message = "Class Changed Successfuly";
                    string title = "Success";
                    MessageBox.Show(message, title);

                    yourFlight.Controls.Clear();


                    yourFlight.InitializeComponent();
                    yourFlight.yourFlights_Load(sender, e);
                }
                catch (Exception ex)
                {
                    // Handle the exception
                    string message = ex.Message;
                    string title = "FAILED";
                    MessageBox.Show(message, title);
                }
            }

            private void cancelFlightClick(object sender, EventArgs e)
            {
                try
                {
                    string message = "Are you sure you want to cancel this flight?";
                    string title = "Cancel Flight";
                    DialogResult dialogResult = MessageBox.Show(message, title, MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

                        con.Open();

                        DataRow row = Program.CustomerData.Rows[0];

                        SqlCommand comm;

                        int flightIDInt = 0;
                        Int32.TryParse(flightid.Text.Substring(12), out flightIDInt);

                        int seatNumberInt = 0;
                        Int32.TryParse(seatNumber.Text.Substring(14), out seatNumberInt);


                        string command = "DELETE FROM BOOKING WHERE SSN = "
                            + (int)row["SSN"] + " AND FLIGHTID = " + flightIDInt
                            + " AND SEATNUMBER = " + seatNumberInt;
                        comm = new SqlCommand(command, con);
                        comm.ExecuteNonQuery();

                        command = "UPDATE FLIGHT SET SEATSNUMBER = (SEATSNUMBER + 1) WHERE FLIGHTID = "
                            + flightIDInt;
                        comm = new SqlCommand(command, con);
                        comm.ExecuteNonQuery();

                        con.Close();

                        yourFlight.Controls.Clear();
                        yourFlight.InitializeComponent();
                        yourFlight.yourFlights_Load(sender, e);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
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
        public yourFlights()
        {
            InitializeComponent();
        }

        public void yourFlights_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

                con.Open();
                DataTable flights = new DataTable();
                DataTable bookings = new DataTable();
                // TODO: This line of code loads data into the 'flightReservationDataSet.CUSTOMER' table. You can move, or remove it, as needed.
                this.cUSTOMERTableAdapter.Fill(this.flightReservationDataSet.CUSTOMER);

                DataRow row = Program.CustomerData.Rows[0];

                string command = "SELECT * FROM BOOKING WHERE SSN = " + (int)row["SSN"];
                SqlCommand comm = new SqlCommand(command, con);
                SqlDataReader reader = comm.ExecuteReader();

                bookings.Load(reader);


                command = "SELECT * FROM FLIGHT, BOOKING WHERE FLIGHT.FLIGHTID = BOOKING.FLIGHTID AND BOOKING.SSN = " + (int)row["SSN"];
                comm = new SqlCommand(command, con);
                reader = comm.ExecuteReader();

                flights.Load(reader);

                DataRow flightsRow;
                DataRow bookingsRow;

                if (flights.Rows.Count == 0)
                {
                    Label noFlightsLabel = new Label();

                    noFlightsLabel.Dock = DockStyle.Fill;
                    noFlightsLabel.ForeColor = Color.FromArgb(204, 51, 102);
                    noFlightsLabel.BackColor = Color.FromArgb(25, 11, 35);
                    noFlightsLabel.TextAlign = ContentAlignment.MiddleCenter;
                    noFlightsLabel.Text = "You don't have any booked flights \n start booking by pressing Available Flights :D";
                    noFlightsLabel.Font = new Font(noFlightsLabel.Font.FontFamily, 18);
                    panel1.Controls.Add(noFlightsLabel);
                }

                for (int i = 0; i < flights.Rows.Count; i++)
                {
                    flightsRow = flights.Rows[i];
                    bookingsRow = bookings.Rows[i];

                    flightsDetails f = new flightsDetails(this);
                    panel1.Controls.Add(f.space);
                    f.space.BringToFront();
                    panel1.Controls.Add(f.main);
                    f.main.BringToFront();

                    float std = float.Parse(flightsRow["STANDARDPRICE"].ToString());
                    char c = char.Parse(bookingsRow["CLASS"].ToString());

                    string price = Program.priceFormula(std, c).ToString();

                    f.setData(flightsRow["FLIGHTID"].ToString(), bookingsRow["SEATNUMBER"].ToString(),
                        bookingsRow["CLASS"].ToString(), bookingsRow["STATE"].ToString(),
                        flightsRow["DESTINATION"].ToString(),
                        flightsRow["SOURCE"].ToString(), flightsRow["OUTGOINGDATE"].ToString(),
                        flightsRow["ARRIVINGDATE"].ToString(),
                        price);
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