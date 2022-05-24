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
    public partial class Passengers : UserControl
    {
        public Passengers()
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
            String query = "select * from PassengersTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PassengersDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Passengers_Load(object sender, EventArgs e)
        {
            populate();
        }

       
        private void PassengersDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            P_Id.Text = PassengersDGV.CurrentRow.Cells[0].Value.ToString();
            PName.Text=PassengersDGV.CurrentRow.Cells[1].Value.ToString();
            MobNo.Text = PassengersDGV.CurrentRow.Cells[2].Value.ToString();
            FDate.Text = PassengersDGV.CurrentRow.Cells[6].Value.ToString();
            FTime1.Text = PassengersDGV.CurrentRow.Cells[7].Value.ToString();
            SeatNum1.Text = PassengersDGV.CurrentRow.Cells[8].Value.ToString();
           
            total.Text = PassengersDGV.CurrentRow.Cells[10].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (PName.Text == "")
            {
                MessageBox.Show("Enter The Passenger to Delete");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from PassengersTbl where PName ='" + PName.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passengers Delete Succesfully");
                    Con.Close();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {


            PName.Text = "";
            total.Text = "";
            MobNo.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PName.Text == "" || MobNo.Text == "" || SeatNum1.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update PassengersTbl set PName = '" + PName.Text.ToString() + "',MobNo='"+MobNo.Text.ToString()+"', FDate = '" + FDate.Value.ToString() + "',/*TPrice=" + total.Text + ",*/FCap=" + SeatNum1.Text + " Where P_ID ='" + P_Id.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Passengers update Succesfully");
                    Con.Close();
                    populate();


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(" Missing Information");
                }
            }
        }
    }

}
