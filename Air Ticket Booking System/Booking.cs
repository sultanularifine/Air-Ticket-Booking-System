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
    public partial class Booking : UserControl
    {
        DBFunction db = new DBFunction();
        int totalPrice = 0;
        public Booking()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowFlights_Click(object sender, EventArgs e)
        {
            if (FSrc.Text != "" && FDest.Text != "")
            {
                string src = FSrc.Text;
                string dest = FDest.Text;
                string date = FDate.Value.ToString("dd/MM/yyyy");
                string time = FTime.Value.ToString("hh:mm tt");
                var reader = db.GetData("SELECT * FROM FlightTbl");
                bool found = false;
                while (reader.Read())
                {
                    //string.Format("{0:yyyy-MM-dd}", reader2["depart_date"])
                    string tem_src = reader["fsrc"].ToString();
                    string tem_dest = reader["fDest"].ToString();
                    string tem_date = string.Format("{0:dd/MM/yyyy}", reader["fdate"]);
                    DateTime tem_time = DateTime.Parse(reader["fTime"].ToString());
                    if (tem_src == src && tem_dest == dest && tem_date == date && tem_time.ToString("hh:mm tt") == time)
                    {
                        FCodes.Text = reader["fcode"].ToString();
                        found = true;
                    }
                }

                if (found == false)
                {
                    MessageBox.Show("No Flight Found");
                }
            }
        }

        private void showPriceBtn_Click(object sender, EventArgs e)
        {
            if(FClass.Text != "")
            {
                var reader2 = db.GetData("SELECT * FROM FlightTbl");

                while (reader2.Read())
                {
                    string temp_flightCode = reader2["fcode"].ToString();

                    if(temp_flightCode == FCodes.Text)
                    {
                        if (FClass.Text == reader2["fClass"].ToString())
                        {
                            FPrice.Text = reader2["fPrice"].ToString();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Enter Your Class");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(FPrice.Text == "")
            {
                total.Text = "0 Taka";
            } else
            {
                try
                {
                    totalPriceAmount(Convert.ToInt32(SeatNum.Text));
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void totalPriceAmount(int seatNumber)
        {
            for(int i = 0; i < seatNumber; i++)
            {
                totalPrice += Convert.ToInt32(FPrice.Text);
            }
            total.Text=totalPrice.ToString() + " Taka";
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sulta\Documents\AirticketDb.mdf;Integrated Security=True;Connect Timeout=30");
        private object textResult;
        private object txtResult;

        private void button1_Click(object sender, EventArgs e)
        {
            if (FCodes.Text == String.Empty && FSrc.Text == String.Empty && FDest.Text == String.Empty && FDate.Text == String.Empty && FClass.Text == String.Empty && total.Text == String.Empty && MobNo.Text == String.Empty && PName.Text == String.Empty)
            {
                MessageBox.Show(" Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into PassengersTbl values('" + PName.Text + "','" + MobNo.Text + "','" + FCodes.Text + "','" + FSrc.SelectedItem.ToString() + "','" + FDest.SelectedItem.ToString() + "','" + FDate.Value.ToString() + "','" + FTime.Value.ToString("hh:mm tt") + "','" + SeatNum.Text + "','" + FClass.SelectedItem.ToString() + "','" + total.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booking Succesfully");
                    Con.Close();
                }
                catch (Exception Ex)

                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            FCodes.Text = "";
            PName.Text = "";
            MobNo.Text = "";
        }

        private void generate_Click(object sender, EventArgs e)
        {
           TxtBox.Clear();
            TxtBox.Text += "****************************\n";
            TxtBox.Text += "***     Air Ticket     *****\n";
            TxtBox.Text += "****************************\n";
            TxtBox.Text += "Name: " + PName.Text + "\n\n";
            TxtBox.Text += "Mobile: " + MobNo.Text + "\n\n";
            TxtBox.Text += "Source: " + FSrc.SelectedItem.ToString() + "\n\n";
            TxtBox.Text += "Destination: " + FDest.SelectedItem.ToString() + "\n\n";
            TxtBox.Text += "Date: " + FDate.Value.ToString() + "\n\n";
            TxtBox.Text += "Time: " + FTime.Value.ToString("hh:mm tt") + "\n\n";
            TxtBox.Text += "Flight Code: " + FCodes.Text + "\n\n";
            TxtBox.Text += "Class: " + FClass.SelectedItem.ToString() + "\n\n";
            TxtBox.Text += "Seat: " + SeatNum.Text + "\n\n";
            TxtBox.Text += "Total Price: " + total.Text + "\n\n";
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(TxtBox.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
