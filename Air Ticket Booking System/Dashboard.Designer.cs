namespace Air_Ticket_Booking_System
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Flights = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.FDate = new System.Windows.Forms.DateTimePicker();
            this.FDest = new System.Windows.Forms.ComboBox();
            this.FClass = new System.Windows.Forms.ComboBox();
            this.FSrc = new System.Windows.Forms.ComboBox();
            this.FPrice = new System.Windows.Forms.TextBox();
            this.SeatNum = new System.Windows.Forms.TextBox();
            this.FcodeTb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(215)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 65);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(22, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "FLY HIGH";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(215)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(215)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Azure;
            this.button2.Location = new System.Drawing.Point(1025, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 33);
            this.button2.TabIndex = 2;
            this.button2.Text = "✖";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.Flights);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 461);
            this.panel2.TabIndex = 5;
            // 
            // Flights
            // 
            this.Flights.BackColor = System.Drawing.Color.Blue;
            this.Flights.ForeColor = System.Drawing.Color.White;
            this.Flights.Location = new System.Drawing.Point(25, 121);
            this.Flights.Name = "Flights";
            this.Flights.Size = new System.Drawing.Size(143, 40);
            this.Flights.TabIndex = 9;
            this.Flights.Text = " FLIGHTS";
            this.Flights.UseVisualStyleBackColor = false;
           
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(25, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 40);
            this.button3.TabIndex = 9;
            this.button3.Text = "ADD FLIGHT";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.FDate);
            this.panel3.Controls.Add(this.FDest);
            this.panel3.Controls.Add(this.FClass);
            this.panel3.Controls.Add(this.FSrc);
            this.panel3.Controls.Add(this.FPrice);
            this.panel3.Controls.Add(this.SeatNum);
            this.panel3.Controls.Add(this.FcodeTb);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(219, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(842, 461);
            this.panel3.TabIndex = 6;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.ForeColor = System.Drawing.Color.DarkGray;
            this.button5.Location = new System.Drawing.Point(627, 398);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 40);
            this.button5.TabIndex = 26;
            this.button5.Text = "RESET";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(159, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 40);
            this.button1.TabIndex = 25;
            this.button1.Text = "ADD FLIGHT";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FDate
            // 
            this.FDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FDate.Location = new System.Drawing.Point(627, 113);
            this.FDate.Name = "FDate";
            this.FDate.Size = new System.Drawing.Size(141, 20);
            this.FDate.TabIndex = 24;
            // 
            // FDest
            // 
            this.FDest.FormattingEnabled = true;
            this.FDest.Items.AddRange(new object[] {
            "Dhaka",
            "Barisal",
            "Sylhet ",
            "Rangpur",
            "Jessore",
            "Rajshashi"});
            this.FDest.Location = new System.Drawing.Point(254, 258);
            this.FDest.Name = "FDest";
            this.FDest.Size = new System.Drawing.Size(133, 21);
            this.FDest.TabIndex = 23;
            // 
            // FClass
            // 
            this.FClass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FClass.FormattingEnabled = true;
            this.FClass.Items.AddRange(new object[] {
            "Business",
            "Economic"});
            this.FClass.Location = new System.Drawing.Point(627, 188);
            this.FClass.Name = "FClass";
            this.FClass.Size = new System.Drawing.Size(141, 27);
            this.FClass.TabIndex = 22;
            // 
            // FSrc
            // 
            this.FSrc.FormattingEnabled = true;
            this.FSrc.Items.AddRange(new object[] {
            "Dhaka",
            "Barisal",
            "Sylhet ",
            "Rangpur",
            "Jessore",
            "Rajshashi"});
            this.FSrc.Location = new System.Drawing.Point(254, 182);
            this.FSrc.Name = "FSrc";
            this.FSrc.Size = new System.Drawing.Size(133, 21);
            this.FSrc.TabIndex = 21;
            // 
            // FPrice
            // 
            this.FPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPrice.Location = new System.Drawing.Point(627, 257);
            this.FPrice.Multiline = true;
            this.FPrice.Name = "FPrice";
            this.FPrice.Size = new System.Drawing.Size(141, 31);
            this.FPrice.TabIndex = 19;
            // 
            // SeatNum
            // 
            this.SeatNum.Location = new System.Drawing.Point(455, 323);
            this.SeatNum.Multiline = true;
            this.SeatNum.Name = "SeatNum";
            this.SeatNum.Size = new System.Drawing.Size(133, 31);
            this.SeatNum.TabIndex = 20;
            // 
            // FcodeTb
            // 
            this.FcodeTb.Location = new System.Drawing.Point(254, 102);
            this.FcodeTb.Multiline = true;
            this.FcodeTb.Name = "FcodeTb";
            this.FcodeTb.Size = new System.Drawing.Size(133, 31);
            this.FcodeTb.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label10.Location = new System.Drawing.Point(469, 257);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 31);
            this.label10.TabIndex = 16;
            this.label10.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label9.Location = new System.Drawing.Point(273, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 31);
            this.label9.TabIndex = 15;
            this.label9.Text = "Num of  Seats";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label8.Location = new System.Drawing.Point(469, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 31);
            this.label8.TabIndex = 14;
            this.label8.Text = "Class";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label7.Location = new System.Drawing.Point(469, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label5.Location = new System.Drawing.Point(72, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(72, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "Source";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Coral;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(322, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "ADD FLIGHT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(72, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Flight Code";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 526);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Flights;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker FDate;
        private System.Windows.Forms.ComboBox FDest;
        private System.Windows.Forms.ComboBox FClass;
        private System.Windows.Forms.ComboBox FSrc;
        private System.Windows.Forms.TextBox FPrice;
        private System.Windows.Forms.TextBox SeatNum;
        private System.Windows.Forms.TextBox FcodeTb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}