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
    }
}
