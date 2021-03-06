using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Air_Ticket_Booking_System
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        

      

        private void button3_Click(object sender, EventArgs e)
        {
            flights11.Hide();
            booking1.Hide();
            passengers1.Hide();
            addflight1.Show();
            setting1.Hide();
            addflight1.BringToFront();
            about1.Hide();
        }

        private void Flights_Click(object sender, EventArgs e)
        {
            addflight1.Hide();
            flights11.Show();
            booking1.Hide();
            passengers1.Hide();
            about1.Hide();
            setting1.Hide();
            flights11.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            addflight1.Hide();
            flights11.Hide();
            booking1.Show();
            passengers1.Hide();
            about1.Hide();
            setting1.Hide();
            booking1.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            addflight1.Hide();
            flights11.Hide();
            booking1.Hide();
            about1.Hide();
            passengers1.Show();
            setting1.Hide();
            passengers1.BringToFront();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            addflight1.Hide();
            flights11.Hide();
            booking1.Hide();
            passengers1.Hide();
            about1.Hide();
            setting1.Show();
           setting1.BringToFront();
        }

        private void Dashboard_Activated(object sender, EventArgs e)
        {
            //flights11.populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            addflight1.Hide();
            flights11.Hide();
            booking1.Hide();
            passengers1.Hide();
            about1.Show();
            setting1.Hide();
            setting1.BringToFront();
        }

       

        private void Dashboard_Load(object sender, EventArgs e)
        {

            addflight1.Hide();
            flights11.Hide();
            booking1.Hide();
            passengers1.Hide();
            setting1.Hide();
            about1.Hide();
        }
    }
}
