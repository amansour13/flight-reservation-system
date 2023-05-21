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
            public flightsDetails()
            {
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
                head.Dock = DockStyle.Top;
                head.Height = 30;

                flightid.Text = "Flight ID : ";
                seatNumber.Text = "Seat Number : ";
                flightClass.Text = "Flight Class : ";
                state.Text = "State : ";

                flightid.Dock = DockStyle.Left;
                seatNumber.Dock = DockStyle.Left;
                flightClass.Dock = DockStyle.Left;
                state.Dock = DockStyle.Left;

                flightid.ForeColor = Color.White;
                seatNumber.ForeColor = Color.White;
                flightClass.ForeColor = Color.White;
                state.ForeColor = Color.White;

                head.Padding = new Padding(20,5,5,5);

                head.Controls.Add(flightid);
                head.Controls.Add(seatNumber);
                head.Controls.Add(flightClass);
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

                cancelFlight.Text = "Cancel Flight";
                cancelFlight.Height = 45;
                cancelFlight.Width = 332;
                cancelFlight.BackColor = Color.FromArgb(204, 51, 102);
                cancelFlight.FlatStyle = FlatStyle.Flat;

                changeClass.Dock = DockStyle.Left;
                cancelFlight.Dock = DockStyle.Left;


                bottom.Padding = new Padding(5);

                bottom.Controls.Add(changeClass);
                bottom.Controls.Add(cancelFlight);
            }

            public void setData(string flightId, string seatNumber, string flightClass, string state, string to, string from, string outgoing, string arriving, string price) {
                this.flightid.Text += flightId;
                this.seatNumber.Text = seatNumber;
                this.flightClass.Text = flightClass;
                this.state.Text = state;
                this.destination.Text = to;
                this.source.Text = from;
                this.price.Text = price;
                this.outgoingDate.Text = outgoing;
                this.arrivingDate.Text = arriving;
            }
        }
        public yourFlights()
        {
            InitializeComponent();
        }

        private void yourFlights_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightReservationDataSet.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.flightReservationDataSet.CUSTOMER);

            flightsDetails a = new flightsDetails();


            // this to add new ticket
            flightsDetails f = new flightsDetails();
            panel1.Controls.Add(f.space);
            f.space.BringToFront();
            panel1.Controls.Add(f.main);
            f.main.BringToFront();
            // end of adding one ticket


            panel1.Controls.Add(a.space);
            a.space.BringToFront();
            panel1.Controls.Add(a.main);
            a.main.BringToFront();
            
        }
    }
}
