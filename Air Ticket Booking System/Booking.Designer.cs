namespace Air_Ticket_Booking_System
{
    partial class Booking
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FDate = new System.Windows.Forms.DateTimePicker();
            this.FDest = new System.Windows.Forms.ComboBox();
            this.FSrc = new System.Windows.Forms.ComboBox();
            this.FPrice = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FCodes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MobNo = new System.Windows.Forms.TextBox();
            this.FClass = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SeatNum = new System.Windows.Forms.TextBox();
            this.btnShowFlights = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.FTime = new System.Windows.Forms.DateTimePicker();
            this.showPriceBtn = new System.Windows.Forms.Button();
            this.total = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.TxtBox = new System.Windows.Forms.RichTextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
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
            this.button2.Location = new System.Drawing.Point(811, -2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 33);
            this.button2.TabIndex = 20;
            this.button2.Text = "✖";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(345, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "BOOKING";
            // 
            // FDate
            // 
            this.FDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FDate.Location = new System.Drawing.Point(156, 165);
            this.FDate.Name = "FDate";
            this.FDate.Size = new System.Drawing.Size(141, 20);
            this.FDate.TabIndex = 34;
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
            this.FDest.Location = new System.Drawing.Point(156, 120);
            this.FDest.Name = "FDest";
            this.FDest.Size = new System.Drawing.Size(141, 21);
            this.FDest.TabIndex = 33;
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
            this.FSrc.Location = new System.Drawing.Point(156, 69);
            this.FSrc.Name = "FSrc";
            this.FSrc.Size = new System.Drawing.Size(141, 21);
            this.FSrc.TabIndex = 32;
            // 
            // FPrice
            // 
            this.FPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FPrice.Location = new System.Drawing.Point(499, 279);
            this.FPrice.Multiline = true;
            this.FPrice.Name = "FPrice";
            this.FPrice.Size = new System.Drawing.Size(141, 23);
            this.FPrice.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label10.Location = new System.Drawing.Point(333, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 22);
            this.label10.TabIndex = 29;
            this.label10.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(15, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 22);
            this.label7.TabIndex = 28;
            this.label7.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(15, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 22);
            this.label5.TabIndex = 27;
            this.label5.Text = "Destination";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(15, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 22);
            this.label3.TabIndex = 26;
            this.label3.Text = "Source";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(333, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "Passenger Name";
            // 
            // PName
            // 
            this.PName.Location = new System.Drawing.Point(499, 69);
            this.PName.Multiline = true;
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(141, 31);
            this.PName.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(15, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Flight Code";
            // 
            // FCodes
            // 
            this.FCodes.Location = new System.Drawing.Point(156, 335);
            this.FCodes.Multiline = true;
            this.FCodes.Name = "FCodes";
            this.FCodes.Size = new System.Drawing.Size(141, 29);
            this.FCodes.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.Location = new System.Drawing.Point(333, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 22);
            this.label9.TabIndex = 25;
            this.label9.Text = "Mobile No";
            // 
            // MobNo
            // 
            this.MobNo.Location = new System.Drawing.Point(499, 119);
            this.MobNo.Multiline = true;
            this.MobNo.Name = "MobNo";
            this.MobNo.Size = new System.Drawing.Size(141, 26);
            this.MobNo.TabIndex = 30;
            // 
            // FClass
            // 
            this.FClass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FClass.FormattingEnabled = true;
            this.FClass.Items.AddRange(new object[] {
            "Business",
            "Economic"});
            this.FClass.Location = new System.Drawing.Point(499, 168);
            this.FClass.Name = "FClass";
            this.FClass.Size = new System.Drawing.Size(141, 27);
            this.FClass.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.Location = new System.Drawing.Point(333, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 22);
            this.label11.TabIndex = 35;
            this.label11.Text = "Class";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.ForeColor = System.Drawing.Color.DarkGray;
            this.button1.Location = new System.Drawing.Point(91, 432);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 40);
            this.button1.TabIndex = 37;
            this.button1.Text = "BOOK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // generate
            // 
            this.generate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.generate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generate.ForeColor = System.Drawing.Color.DarkGray;
            this.generate.Location = new System.Drawing.Point(270, 432);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(143, 40);
            this.generate.TabIndex = 37;
            this.generate.Text = "GENERATE";
            this.generate.UseVisualStyleBackColor = false;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.ForeColor = System.Drawing.Color.DarkGray;
            this.button4.Location = new System.Drawing.Point(615, 432);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 40);
            this.button4.TabIndex = 37;
            this.button4.Text = "RESET";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(333, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 29;
            this.label4.Text = "No of Seats";
            // 
            // SeatNum
            // 
            this.SeatNum.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatNum.Location = new System.Drawing.Point(499, 318);
            this.SeatNum.Multiline = true;
            this.SeatNum.Name = "SeatNum";
            this.SeatNum.Size = new System.Drawing.Size(141, 31);
            this.SeatNum.TabIndex = 31;
            this.SeatNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnShowFlights
            // 
            this.btnShowFlights.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnShowFlights.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowFlights.ForeColor = System.Drawing.Color.DarkGray;
            this.btnShowFlights.Location = new System.Drawing.Point(156, 257);
            this.btnShowFlights.Name = "btnShowFlights";
            this.btnShowFlights.Size = new System.Drawing.Size(143, 40);
            this.btnShowFlights.TabIndex = 37;
            this.btnShowFlights.Text = "Show Flights";
            this.btnShowFlights.UseVisualStyleBackColor = false;
            this.btnShowFlights.Click += new System.EventHandler(this.btnShowFlights_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(15, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 22);
            this.label8.TabIndex = 28;
            this.label8.Text = "Time";
            // 
            // FTime
            // 
            this.FTime.CustomFormat = "hh:mm tt";
            this.FTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FTime.Location = new System.Drawing.Point(156, 210);
            this.FTime.Name = "FTime";
            this.FTime.Size = new System.Drawing.Size(141, 20);
            this.FTime.TabIndex = 34;
            // 
            // showPriceBtn
            // 
            this.showPriceBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showPriceBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPriceBtn.ForeColor = System.Drawing.Color.DarkGray;
            this.showPriceBtn.Location = new System.Drawing.Point(499, 214);
            this.showPriceBtn.Name = "showPriceBtn";
            this.showPriceBtn.Size = new System.Drawing.Size(143, 40);
            this.showPriceBtn.TabIndex = 37;
            this.showPriceBtn.Text = "Show Price";
            this.showPriceBtn.UseVisualStyleBackColor = false;
            this.showPriceBtn.Click += new System.EventHandler(this.showPriceBtn_Click);
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.SystemColors.WindowText;
            this.total.Location = new System.Drawing.Point(499, 370);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(92, 22);
            this.total.TabIndex = 29;
            this.total.Text = "Loading...";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label13.Location = new System.Drawing.Point(333, 370);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 22);
            this.label13.TabIndex = 29;
            this.label13.Text = "Total Price:";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.ForeColor = System.Drawing.Color.DarkGray;
            this.button5.Location = new System.Drawing.Point(450, 432);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(143, 40);
            this.button5.TabIndex = 37;
            this.button5.Text = "PRINT";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // TxtBox
            // 
            this.TxtBox.Location = new System.Drawing.Point(648, 69);
            this.TxtBox.Name = "TxtBox";
            this.TxtBox.Size = new System.Drawing.Size(191, 292);
            this.TxtBox.TabIndex = 38;
            this.TxtBox.Text = "";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(161)))), ((int)(((byte)(215)))));
            this.Controls.Add(this.TxtBox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.showPriceBtn);
            this.Controls.Add(this.btnShowFlights);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FClass);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.FTime);
            this.Controls.Add(this.FDate);
            this.Controls.Add(this.FDest);
            this.Controls.Add(this.FSrc);
            this.Controls.Add(this.SeatNum);
            this.Controls.Add(this.FPrice);
            this.Controls.Add(this.PName);
            this.Controls.Add(this.MobNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FCodes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Name = "Booking";
            this.Size = new System.Drawing.Size(842, 526);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker FDate;
        private System.Windows.Forms.ComboBox FDest;
        private System.Windows.Forms.ComboBox FSrc;
        private System.Windows.Forms.TextBox FPrice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox PName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FCodes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MobNo;
        private System.Windows.Forms.ComboBox FClass;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SeatNum;
        private System.Windows.Forms.Button btnShowFlights;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker FTime;
        private System.Windows.Forms.Button showPriceBtn;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RichTextBox TxtBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
