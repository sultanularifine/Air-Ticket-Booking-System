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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulta\Documents\AirticketDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (FcodeTb.Text == String.Empty && FSrc.Text == String.Empty && FDest.Text == String.Empty && FDate.Text == String.Empty &&  FClass.Text == String.Empty && FPrice.Text == String.Empty && SeatNum.Text == String.Empty )
            {
                MessageBox.Show(" Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into FlightTbl values('" + FcodeTb.Text + "','" + FSrc.SelectedItem.ToString() + "','" + FDest.SelectedItem.ToString() + "','" + FDate.Value.ToString() + "','" + SeatNum.Text + "','" + FClass.SelectedItem.ToString() + "','" + FPrice.Text +  "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Record Succesfully");
                    Con.Close();
                }
                catch (Exception Ex)

                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

       
    }
}
