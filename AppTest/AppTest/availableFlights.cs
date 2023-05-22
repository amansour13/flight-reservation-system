﻿using System;
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

            public Button book = new Button();
            public flightsBookingDetails()
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
                seatsNumber.Text = "Available Seats Number : ";
                flightClass.Text = "Flight Class : ";
                price.Text = "Price : ";

                seatsNumber.AutoSize = true;
                /*flightid.AutoSize = true;
                flightClass.AutoSize = true;
                price.AutoSize = true;*/

                seatsNumber.Dock = DockStyle.Left;
                flightid.Dock = DockStyle.Left;
                flightClass.Dock = DockStyle.Left;
                price.Dock = DockStyle.Left;
                

                flightid.ForeColor = Color.White;
                seatsNumber.ForeColor = Color.White;
                flightClass.ForeColor = Color.White;
                price.ForeColor = Color.White;

                head.Padding = new Padding(20, 5, 5, 5);


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
            }
        }

        public availableFlights()
        {
            InitializeComponent();
        }

        private void availableFlights_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flightReservationDataSet2.FLIGHT' table. You can move, or remove it, as needed.
            this.fLIGHTTableAdapter.Fill(this.flightReservationDataSet2.FLIGHT);
            // TODO: This line of code loads data into the 'flightReservationDataSet2.FLIGHT' table. You can move, or remove it, as needed.
            this.fLIGHTTableAdapter.Fill(this.flightReservationDataSet2.FLIGHT);
            // TODO: This line of code loads data into the 'flightReservationDataSet2.FLIGHT' table. You can move, or remove it, as needed.
            this.fLIGHTTableAdapter.Fill(this.flightReservationDataSet2.FLIGHT);
            comboBox4.SelectedIndex = 0;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            dataPanel.Controls.Clear(); 
            SqlConnection con = new SqlConnection(@"Data Source = " + Program.serverName + "; Initial Catalog = FlightReservation; Integrated Security =True");

            con.Open();
            DataTable flights = new DataTable();

            string command = "SELECT * FROM FLIGHT WHERE CONVERT(nvarchar(MAX), SOURCE) = '" + comboBox1.Text
                + "'AND CONVERT(nvarchar(MAX), DESTINATION) = '" + comboBox2.Text
                + "'AND OUTGOINGDATE = '" + comboBox3.Text + "'";
            SqlCommand comm = new SqlCommand(command, con);
            SqlDataReader reader = comm.ExecuteReader();

            flights.Load(reader);

            DataRow flightsRow;

            for (int i = 0; i < flights.Rows.Count; i++)
            {
                flightsRow = flights.Rows[i];

                flightsBookingDetails f = new flightsBookingDetails();

                float std = float.Parse(flightsRow["STANDARDPRICE"].ToString());
                char c = comboBox4.Text[0];

                string price = priceFormula(std, c).ToString();
                f.setData(flightsRow["FLIGHTID"].ToString(), flightsRow["SEATSNUMBER"].ToString()
                , comboBox4.Text, flightsRow["DESTINATION"].ToString()
                , flightsRow["SOURCE"].ToString(), flightsRow["OUTGOINGDATE"].ToString()
                , flightsRow["ARRIVINGDATE"].ToString()
                , price);


                dataPanel.Controls.Add(f.space);
                dataPanel.Controls.Add(f.main);

            }


            reader.Close();
            con.Close();
        }

        // Remove befor push
        public float priceFormula(float standardPrice, char flightClass)
        {
            float newPrice = standardPrice;
            if (flightClass == 'A')
            {
                newPrice += 100;
            }
            else if (flightClass == 'B')
            {
                newPrice += 50;
            }

            return newPrice;
        }
    }
}
