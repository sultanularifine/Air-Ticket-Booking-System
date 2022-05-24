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
    public partial class Flights1 : UserControl
    {
        public Flights1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulta\OneDrive\Documents\AirticketDb.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            String query = "select * from FlightTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FlightDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Flights1_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FcodeTb.Text = "";
            SeatNum.Text = "";
            FPrice.Text = "";
        }

        private void FlightDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FcodeTb.Text = FlightDGV.CurrentRow.Cells[1].Value.ToString();
            FSrc.SelectedItem = FlightDGV.CurrentRow.Cells[2].Value.ToString();
            FDest.SelectedItem = FlightDGV.CurrentRow.Cells[3].Value.ToString();
            FDate.Text = FlightDGV.CurrentRow.Cells[4].Value.ToString();
            FTime.Text = FlightDGV.CurrentRow.Cells[5].Value.ToString();
            SeatNum.Text = FlightDGV.CurrentRow.Cells[6].Value.ToString();
            FClass.Text = FlightDGV.CurrentRow.Cells[7].Value.ToString();
            FPrice.Text = FlightDGV.CurrentRow.Cells[8].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (FcodeTb.Text == "")
            {
                MessageBox.Show("Enter The Flight to Delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from FlightTbl where Fcode ='" + FcodeTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query,Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight Delete Succesfully");
                    Con.Close();
                    populate();

                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(FcodeTb.Text == "" || FPrice.Text == "" || SeatNum.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = " update FlightTbl set fsrc='" + FSrc.SelectedItem.ToString() + "',fDest ='" + FDest.SelectedItem.ToString() + "',fDate = '" + FDate.Value.ToString() + "',fPrice=" + FPrice.Text + ",fcap=" + SeatNum.Text + " Where fcode ='" + FcodeTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Flight update Succesfully");
                    Con.Close();
                    populate();

                
                }
                catch ( Exception Ex)
                {
                    MessageBox.Show(" Missing Information");
                }
            }
        }
    }
}
