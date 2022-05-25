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

namespace Air_Ticket_Booking_System
{
    public partial class Setting : UserControl
    {
        SqlConnection Con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=Airticket;Integrated Security=True;Pooling=False");
        public Setting()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "delete from FlightTbl";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("All Flight Delete Succesfully");
                Con.Close();
               

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                string query = "delete from PassengersTbl";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("All Passengers Delete Succesfully");
                Con.Close();


            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
