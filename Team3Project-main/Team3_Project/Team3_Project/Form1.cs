using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///////////////////////////////////
//* * * * * * * * * * * * * * * *//
//*  IBM and .NET Programming   *//
//*  Team 3                     *//
//*                             *//
//*  Dylan  Bradley             *//
//*  Daonte Dallas              *//
//*  Alex   Milchuck            *//
//*  Kevin  Carpenter           *//
//*                             *//
//*  Fall 2024                  *//
//*  Professor Pearson          *//
//* * * * * * * * * * * * * * * *//
///////////////////////////////////                


namespace Team3_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        ///////////////////////////////////////
        //* * * * * * * * * * * * * * * * * *//
        //* SEARCH:                         *//
        //*    These ones require the user  *//
        //*    to enter information in a    *// 
        //*    TextBox to query the info    *//
        //* * * * * * * * * * * * * * * * * *//
        ///////////////////////////////////////



        /////////////////////////////////////
        //   Flight Number Customer Button
        /////////////////////////////////////
        private void flightNumberCustomersButton_Click(object sender, EventArgs e)
        {
            FlightNumberCustomers flightNumberCustomers = new FlightNumberCustomers();
            flightNumberCustomers.Show();
        }

        private void flightNumberCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlightNumberCustomers flightNumberCustomers = new FlightNumberCustomers();
            flightNumberCustomers.Show();
        }


        /////////////////////////////////////
        //    Flight Number Seats Button
        /////////////////////////////////////

        private void button1_Click(object sender, EventArgs e)
        {
            FlightNumberSeats flightNumberSeats = new FlightNumberSeats();
            flightNumberSeats.Show();
        }

        private void flightNumberSeatsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlightNumberSeats flightNumberSeats = new FlightNumberSeats();
            flightNumberSeats.Show();
        }


        /////////////////////////////////////
        //  Customer Number Password Button
        /////////////////////////////////////

        private void customerNumberPasswordButton_Click(object sender, EventArgs e)
        {
            CustomerNumberPassword customerNumberPassword = new CustomerNumberPassword();
            customerNumberPassword.Show();
        }

        private void custNumberPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerNumberPassword customerNumberPassword = new CustomerNumberPassword();
            customerNumberPassword.Show();
        }


        /////////////////////////////////////
        //  Reservation Number Cust Button
        /////////////////////////////////////

        private void resNumberCustInfoButton_Click(object sender, EventArgs e)
        {
            ReservationNumberInfo reservationNumberInfo = new ReservationNumberInfo();
            reservationNumberInfo.Show();
        }

        private void resNumberCustInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReservationNumberInfo reservationNumberInfo = new ReservationNumberInfo();
            reservationNumberInfo.Show();
        }



        //*****************************************************************************\\



        ///////////////////////////////////////
        //* * * * * * * * * * * * * * * * * *//
        //* RETRIEVE:                       *//
        //*    These ones don't require     *//
        //*    much, can probably just do   *// 
        //*    gridBoxView and display it   *//
        //* * * * * * * * * * * * * * * * * *//
        ///////////////////////////////////////


        /////////////////////////////////////
        //    List all Customers Button
        /////////////////////////////////////

        private void listAllCustomersButton_Click(object sender, EventArgs e)
        {
            ListAllCustomers listAllCustomers = new ListAllCustomers();
            listAllCustomers.Show();
        }

        private void listAllCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListAllCustomers listAllCustomers = new ListAllCustomers();
            listAllCustomers.Show();
        }


        /////////////////////////////////////
        //    List all Countries Button
        /////////////////////////////////////

        private void listAllCountriesButton_Click(object sender, EventArgs e)
        {
            ListAllCountries listAllCountries = new ListAllCountries();
            listAllCountries.Show();
        }

        private void listAllCountriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListAllCountries listAllCountries = new ListAllCountries();
            listAllCountries.Show();
        }


        /////////////////////////////////////
        //     List all Records Button
        /////////////////////////////////////

        private void listRecordsButton_Click(object sender, EventArgs e)
        {
            ListAllRecords listAllRecords = new ListAllRecords();
            listAllRecords.Show();
        }

        private void listAllRecordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListAllRecords listAllRecords = new ListAllRecords();
            listAllRecords.Show();
        }



        //*****************************************************************************\\




        ///////////////////////////////////////
        //* * * * * * * * * * * * * * * * * *//
        //* DATA ENTRY:                     *//
        //*    These ones only need to      *//
        //*    have text fields for entry   *// 
        //*    and an INSERT SQL statement  *//
        //* * * * * * * * * * * * * * * * * *//
        ///////////////////////////////////////


        /////////////////////////////////////
        //      Add a Customer Button
        /////////////////////////////////////

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }

        private void addACustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
        }


        /////////////////////////////////////
        //      Add a Country Button
        /////////////////////////////////////

        private void addCountryButton_Click(object sender, EventArgs e)
        {
            AddCountry addCountry = new AddCountry();
            addCountry.Show();
        }

        private void addACountryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCountry addCountry = new AddCountry();
            addCountry.Show();
        }


        /////////////////////////////////////
        //        Add a Boat Button
        /////////////////////////////////////

        private void addBoatButton_Click(object sender, EventArgs e)
        {
            AddBoat addBoat = new AddBoat();
            addBoat.Show();
        }

        private void addABoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBoat addBoat = new AddBoat();
            addBoat.Show();
        }


        /////////////////////////////////////
        //        Add a Car Button
        /////////////////////////////////////

        private void addCarButton_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.Show();
        }

        private void addACarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.Show();
        }
    }
}
