namespace FlightTicketManagement
{
    partial class Admin_FlightForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListFlightGv = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FlightDurationPk = new System.Windows.Forms.DateTimePicker();
            this.FlightArrivalCbb = new System.Windows.Forms.ComboBox();
            this.FlightDepatureCbb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FlightDepatureTimePk = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.FlightCodeTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FlightDepatureDatePk = new System.Windows.Forms.DateTimePicker();
            this.FlightSeat2Tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.FlightSeat1Tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FlightPriceTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearFlightBtn = new System.Windows.Forms.Button();
            this.DeleteFlightBtn = new System.Windows.Forms.Button();
            this.UpdateFlightBtn = new System.Windows.Forms.Button();
            this.AddFlightBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ListIntermediateAirportGv = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.IntermediateAiportCodeTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.IntermediateAirportStopTimeTb = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.IntermediateAirportNoteTb = new System.Windows.Forms.TextBox();
            this.IntermediateAirportUpdateBtn = new System.Windows.Forms.Button();
            this.IntermediateAirportDeleteBtn = new System.Windows.Forms.Button();
            this.IntermediateAirportClearBTn = new System.Windows.Forms.Button();
            this.IntermediateAirportAddBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListFlightGv)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListIntermediateAirportGv)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ListFlightGv);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(767, 324);
            this.panel2.TabIndex = 2;
            // 
            // ListFlightGv
            // 
            this.ListFlightGv.AllowUserToAddRows = false;
            this.ListFlightGv.AllowUserToDeleteRows = false;
            this.ListFlightGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListFlightGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListFlightGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListFlightGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListFlightGv.EnableHeadersVisualStyles = false;
            this.ListFlightGv.Location = new System.Drawing.Point(25, 55);
            this.ListFlightGv.Name = "ListFlightGv";
            this.ListFlightGv.ReadOnly = true;
            this.ListFlightGv.RowHeadersVisible = false;
            this.ListFlightGv.RowHeadersWidth = 51;
            this.ListFlightGv.RowTemplate.Height = 24;
            this.ListFlightGv.Size = new System.Drawing.Size(716, 248);
            this.ListFlightGv.TabIndex = 17;
            this.ListFlightGv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListFlightGv_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(29, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "Flights";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.FlightDurationPk);
            this.panel1.Controls.Add(this.FlightArrivalCbb);
            this.panel1.Controls.Add(this.FlightDepatureCbb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.FlightDepatureTimePk);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.FlightCodeTb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.FlightDepatureDatePk);
            this.panel1.Controls.Add(this.FlightSeat2Tb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.FlightSeat1Tb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.FlightPriceTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ClearFlightBtn);
            this.panel1.Controls.Add(this.DeleteFlightBtn);
            this.panel1.Controls.Add(this.UpdateFlightBtn);
            this.panel1.Controls.Add(this.AddFlightBtn);
            this.panel1.Location = new System.Drawing.Point(12, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 282);
            this.panel1.TabIndex = 3;
            // 
            // FlightDurationPk
            // 
            this.FlightDurationPk.CustomFormat = "HH:mm";
            this.FlightDurationPk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.FlightDurationPk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FlightDurationPk.Location = new System.Drawing.Point(154, 154);
            this.FlightDurationPk.Name = "FlightDurationPk";
            this.FlightDurationPk.ShowUpDown = true;
            this.FlightDurationPk.Size = new System.Drawing.Size(217, 28);
            this.FlightDurationPk.TabIndex = 34;
            this.FlightDurationPk.Value = new System.DateTime(2024, 6, 17, 8, 54, 0, 0);
            // 
            // FlightArrivalCbb
            // 
            this.FlightArrivalCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightArrivalCbb.FormattingEnabled = true;
            this.FlightArrivalCbb.Items.AddRange(new object[] {
            "Hồ Chí Minh",
            "Hà Nội",
            "Vinh",
            "Đà Nẵng"});
            this.FlightArrivalCbb.Location = new System.Drawing.Point(529, 57);
            this.FlightArrivalCbb.Name = "FlightArrivalCbb";
            this.FlightArrivalCbb.Size = new System.Drawing.Size(217, 30);
            this.FlightArrivalCbb.TabIndex = 33;
            // 
            // FlightDepatureCbb
            // 
            this.FlightDepatureCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightDepatureCbb.FormattingEnabled = true;
            this.FlightDepatureCbb.Items.AddRange(new object[] {
            "Hồ Chí Minh",
            "Hà Nội",
            "Vinh",
            "Đà Nẵng"});
            this.FlightDepatureCbb.Location = new System.Drawing.Point(154, 56);
            this.FlightDepatureCbb.Name = "FlightDepatureCbb";
            this.FlightDepatureCbb.Size = new System.Drawing.Size(217, 30);
            this.FlightDepatureCbb.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(23, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "Duration:";
            // 
            // FlightDepatureTimePk
            // 
            this.FlightDepatureTimePk.CustomFormat = "HH:MM";
            this.FlightDepatureTimePk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F);
            this.FlightDepatureTimePk.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.FlightDepatureTimePk.Location = new System.Drawing.Point(260, 109);
            this.FlightDepatureTimePk.Name = "FlightDepatureTimePk";
            this.FlightDepatureTimePk.ShowUpDown = true;
            this.FlightDepatureTimePk.Size = new System.Drawing.Size(111, 23);
            this.FlightDepatureTimePk.TabIndex = 29;
            this.FlightDepatureTimePk.Value = new System.DateTime(2024, 6, 17, 8, 54, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Time:";
            // 
            // FlightCodeTb
            // 
            this.FlightCodeTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightCodeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightCodeTb.Location = new System.Drawing.Point(154, 14);
            this.FlightCodeTb.Name = "FlightCodeTb";
            this.FlightCodeTb.Size = new System.Drawing.Size(217, 30);
            this.FlightCodeTb.TabIndex = 27;
            this.FlightCodeTb.TextChanged += new System.EventHandler(this.CodeTb_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Flight Code:";
            // 
            // FlightDepatureDatePk
            // 
            this.FlightDepatureDatePk.CustomFormat = "yyyy-MM-dd";
            this.FlightDepatureDatePk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightDepatureDatePk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FlightDepatureDatePk.Location = new System.Drawing.Point(154, 109);
            this.FlightDepatureDatePk.Name = "FlightDepatureDatePk";
            this.FlightDepatureDatePk.Size = new System.Drawing.Size(100, 23);
            this.FlightDepatureDatePk.TabIndex = 25;
            this.FlightDepatureDatePk.Value = new System.DateTime(2024, 6, 18, 0, 0, 0, 0);
            // 
            // FlightSeat2Tb
            // 
            this.FlightSeat2Tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightSeat2Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightSeat2Tb.Location = new System.Drawing.Point(529, 156);
            this.FlightSeat2Tb.Name = "FlightSeat2Tb";
            this.FlightSeat2Tb.Size = new System.Drawing.Size(212, 30);
            this.FlightSeat2Tb.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(411, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Seat 2:";
            // 
            // FlightSeat1Tb
            // 
            this.FlightSeat1Tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightSeat1Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightSeat1Tb.Location = new System.Drawing.Point(529, 105);
            this.FlightSeat1Tb.Name = "FlightSeat1Tb";
            this.FlightSeat1Tb.Size = new System.Drawing.Size(217, 30);
            this.FlightSeat1Tb.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(411, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Seat 1:";
            // 
            // FlightPriceTb
            // 
            this.FlightPriceTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightPriceTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightPriceTb.Location = new System.Drawing.Point(529, 14);
            this.FlightPriceTb.Name = "FlightPriceTb";
            this.FlightPriceTb.Size = new System.Drawing.Size(217, 30);
            this.FlightPriceTb.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(411, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(411, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Arrival:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Depature:";
            // 
            // ClearFlightBtn
            // 
            this.ClearFlightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ClearFlightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearFlightBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFlightBtn.ForeColor = System.Drawing.Color.White;
            this.ClearFlightBtn.Location = new System.Drawing.Point(480, 222);
            this.ClearFlightBtn.Name = "ClearFlightBtn";
            this.ClearFlightBtn.Size = new System.Drawing.Size(145, 40);
            this.ClearFlightBtn.TabIndex = 14;
            this.ClearFlightBtn.Text = "CLEAR";
            this.ClearFlightBtn.UseVisualStyleBackColor = false;
            this.ClearFlightBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DeleteFlightBtn
            // 
            this.DeleteFlightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.DeleteFlightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteFlightBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFlightBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteFlightBtn.Location = new System.Drawing.Point(329, 222);
            this.DeleteFlightBtn.Name = "DeleteFlightBtn";
            this.DeleteFlightBtn.Size = new System.Drawing.Size(145, 40);
            this.DeleteFlightBtn.TabIndex = 13;
            this.DeleteFlightBtn.Text = "DELETE";
            this.DeleteFlightBtn.UseVisualStyleBackColor = false;
            this.DeleteFlightBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateFlightBtn
            // 
            this.UpdateFlightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.UpdateFlightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateFlightBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateFlightBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateFlightBtn.Location = new System.Drawing.Point(176, 222);
            this.UpdateFlightBtn.Name = "UpdateFlightBtn";
            this.UpdateFlightBtn.Size = new System.Drawing.Size(145, 40);
            this.UpdateFlightBtn.TabIndex = 12;
            this.UpdateFlightBtn.Text = "UPDATE";
            this.UpdateFlightBtn.UseVisualStyleBackColor = false;
            this.UpdateFlightBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddFlightBtn
            // 
            this.AddFlightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.AddFlightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFlightBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFlightBtn.ForeColor = System.Drawing.Color.White;
            this.AddFlightBtn.Location = new System.Drawing.Point(25, 222);
            this.AddFlightBtn.Name = "AddFlightBtn";
            this.AddFlightBtn.Size = new System.Drawing.Size(145, 40);
            this.AddFlightBtn.TabIndex = 11;
            this.AddFlightBtn.Text = "ADD";
            this.AddFlightBtn.UseVisualStyleBackColor = false;
            this.AddFlightBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ListIntermediateAirportGv);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(805, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 324);
            this.panel3.TabIndex = 4;
            // 
            // ListIntermediateAirportGv
            // 
            this.ListIntermediateAirportGv.AllowUserToAddRows = false;
            this.ListIntermediateAirportGv.AllowUserToDeleteRows = false;
            this.ListIntermediateAirportGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListIntermediateAirportGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListIntermediateAirportGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListIntermediateAirportGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListIntermediateAirportGv.EnableHeadersVisualStyles = false;
            this.ListIntermediateAirportGv.Location = new System.Drawing.Point(25, 55);
            this.ListIntermediateAirportGv.Name = "ListIntermediateAirportGv";
            this.ListIntermediateAirportGv.ReadOnly = true;
            this.ListIntermediateAirportGv.RowHeadersVisible = false;
            this.ListIntermediateAirportGv.RowHeadersWidth = 51;
            this.ListIntermediateAirportGv.RowTemplate.Height = 24;
            this.ListIntermediateAirportGv.Size = new System.Drawing.Size(307, 248);
            this.ListIntermediateAirportGv.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(29, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(240, 27);
            this.label10.TabIndex = 16;
            this.label10.Text = "Intermediate Airport";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.IntermediateAirportClearBTn);
            this.panel4.Controls.Add(this.IntermediateAirportDeleteBtn);
            this.panel4.Controls.Add(this.IntermediateAirportUpdateBtn);
            this.panel4.Controls.Add(this.IntermediateAirportAddBtn);
            this.panel4.Controls.Add(this.IntermediateAirportNoteTb);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.IntermediateAirportStopTimeTb);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.IntermediateAiportCodeTb);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(805, 362);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(350, 326);
            this.panel4.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "Intermediate Airport:";
            // 
            // IntermediateAiportCodeTb
            // 
            this.IntermediateAiportCodeTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntermediateAiportCodeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntermediateAiportCodeTb.Location = new System.Drawing.Point(205, 10);
            this.IntermediateAiportCodeTb.Name = "IntermediateAiportCodeTb";
            this.IntermediateAiportCodeTb.Size = new System.Drawing.Size(119, 30);
            this.IntermediateAiportCodeTb.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 21);
            this.label12.TabIndex = 35;
            this.label12.Text = "Stop Time: ";
            // 
            // IntermediateAirportStopTimeTb
            // 
            this.IntermediateAirportStopTimeTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntermediateAirportStopTimeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntermediateAirportStopTimeTb.Location = new System.Drawing.Point(205, 60);
            this.IntermediateAirportStopTimeTb.Name = "IntermediateAirportStopTimeTb";
            this.IntermediateAirportStopTimeTb.Size = new System.Drawing.Size(119, 30);
            this.IntermediateAirportStopTimeTb.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(3, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 21);
            this.label13.TabIndex = 37;
            this.label13.Text = "Note:";
            // 
            // IntermediateAirportNoteTb
            // 
            this.IntermediateAirportNoteTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntermediateAirportNoteTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntermediateAirportNoteTb.Location = new System.Drawing.Point(67, 122);
            this.IntermediateAirportNoteTb.Multiline = true;
            this.IntermediateAirportNoteTb.Name = "IntermediateAirportNoteTb";
            this.IntermediateAirportNoteTb.Size = new System.Drawing.Size(257, 103);
            this.IntermediateAirportNoteTb.TabIndex = 38;
            // 
            // IntermediateAirportUpdateBtn
            // 
            this.IntermediateAirportUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.IntermediateAirportUpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IntermediateAirportUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IntermediateAirportUpdateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntermediateAirportUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.IntermediateAirportUpdateBtn.Location = new System.Drawing.Point(179, 231);
            this.IntermediateAirportUpdateBtn.Name = "IntermediateAirportUpdateBtn";
            this.IntermediateAirportUpdateBtn.Size = new System.Drawing.Size(145, 40);
            this.IntermediateAirportUpdateBtn.TabIndex = 40;
            this.IntermediateAirportUpdateBtn.Text = "UPDATE";
            this.IntermediateAirportUpdateBtn.UseVisualStyleBackColor = false;
            // 
            // IntermediateAirportDeleteBtn
            // 
            this.IntermediateAirportDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.IntermediateAirportDeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IntermediateAirportDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IntermediateAirportDeleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntermediateAirportDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.IntermediateAirportDeleteBtn.Location = new System.Drawing.Point(7, 277);
            this.IntermediateAirportDeleteBtn.Name = "IntermediateAirportDeleteBtn";
            this.IntermediateAirportDeleteBtn.Size = new System.Drawing.Size(145, 40);
            this.IntermediateAirportDeleteBtn.TabIndex = 41;
            this.IntermediateAirportDeleteBtn.Text = "DELETE";
            this.IntermediateAirportDeleteBtn.UseVisualStyleBackColor = false;
            // 
            // IntermediateAirportClearBTn
            // 
            this.IntermediateAirportClearBTn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.IntermediateAirportClearBTn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IntermediateAirportClearBTn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IntermediateAirportClearBTn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntermediateAirportClearBTn.ForeColor = System.Drawing.Color.White;
            this.IntermediateAirportClearBTn.Location = new System.Drawing.Point(179, 277);
            this.IntermediateAirportClearBTn.Name = "IntermediateAirportClearBTn";
            this.IntermediateAirportClearBTn.Size = new System.Drawing.Size(145, 40);
            this.IntermediateAirportClearBTn.TabIndex = 35;
            this.IntermediateAirportClearBTn.Text = "CLEAR";
            this.IntermediateAirportClearBTn.UseVisualStyleBackColor = false;
            // 
            // IntermediateAirportAddBtn
            // 
            this.IntermediateAirportAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.IntermediateAirportAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IntermediateAirportAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IntermediateAirportAddBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntermediateAirportAddBtn.ForeColor = System.Drawing.Color.White;
            this.IntermediateAirportAddBtn.Location = new System.Drawing.Point(7, 231);
            this.IntermediateAirportAddBtn.Name = "IntermediateAirportAddBtn";
            this.IntermediateAirportAddBtn.Size = new System.Drawing.Size(145, 40);
            this.IntermediateAirportAddBtn.TabIndex = 39;
            this.IntermediateAirportAddBtn.Text = "ADD";
            this.IntermediateAirportAddBtn.UseVisualStyleBackColor = false;
            // 
            // Admin_FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 709);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_FlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Admin_FlightForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListFlightGv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListIntermediateAirportGv)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ListFlightGv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClearFlightBtn;
        private System.Windows.Forms.Button DeleteFlightBtn;
        private System.Windows.Forms.Button UpdateFlightBtn;
        private System.Windows.Forms.Button AddFlightBtn;
        private System.Windows.Forms.DateTimePicker FlightDepatureDatePk;
        private System.Windows.Forms.TextBox FlightSeat2Tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FlightSeat1Tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FlightPriceTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FlightCodeTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox FlightArrivalCbb;
        private System.Windows.Forms.ComboBox FlightDepatureCbb;
        private System.Windows.Forms.DateTimePicker FlightDepatureTimePk;
        private System.Windows.Forms.DateTimePicker FlightDurationPk;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView ListIntermediateAirportGv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button IntermediateAirportClearBTn;
        private System.Windows.Forms.Button IntermediateAirportDeleteBtn;
        private System.Windows.Forms.Button IntermediateAirportUpdateBtn;
        private System.Windows.Forms.TextBox IntermediateAirportNoteTb;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox IntermediateAirportStopTimeTb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox IntermediateAiportCodeTb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button IntermediateAirportAddBtn;
    }
}