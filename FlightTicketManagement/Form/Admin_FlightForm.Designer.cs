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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListFlightGv = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DestCbb = new System.Windows.Forms.ComboBox();
            this.StartCbb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FlightTimePk = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.CodeTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FlightDatePk = new System.Windows.Forms.DateTimePicker();
            this.Seat2Tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Seat1Tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PriceTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.FlightDurationPk = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListFlightGv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ListFlightGv);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 324);
            this.panel2.TabIndex = 2;
            // 
            // ListFlightGv
            // 
            this.ListFlightGv.AllowUserToAddRows = false;
            this.ListFlightGv.AllowUserToDeleteRows = false;
            this.ListFlightGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListFlightGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListFlightGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ListFlightGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListFlightGv.EnableHeadersVisualStyles = false;
            this.ListFlightGv.Location = new System.Drawing.Point(25, 55);
            this.ListFlightGv.Name = "ListFlightGv";
            this.ListFlightGv.ReadOnly = true;
            this.ListFlightGv.RowHeadersVisible = false;
            this.ListFlightGv.RowHeadersWidth = 51;
            this.ListFlightGv.RowTemplate.Height = 24;
            this.ListFlightGv.Size = new System.Drawing.Size(783, 248);
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
            this.panel1.Controls.Add(this.DestCbb);
            this.panel1.Controls.Add(this.StartCbb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.FlightTimePk);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.CodeTb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.FlightDatePk);
            this.panel1.Controls.Add(this.Seat2Tb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Seat1Tb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PriceTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ClearBtn);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.AddBtn);
            this.panel1.Location = new System.Drawing.Point(12, 362);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 282);
            this.panel1.TabIndex = 3;
            // 
            // DestCbb
            // 
            this.DestCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestCbb.FormattingEnabled = true;
            this.DestCbb.Items.AddRange(new object[] {
            "Hồ Chí Minh",
            "Hà Nội",
            "Vinh",
            "Đà Nẵng"});
            this.DestCbb.Location = new System.Drawing.Point(572, 56);
            this.DestCbb.Name = "DestCbb";
            this.DestCbb.Size = new System.Drawing.Size(212, 30);
            this.DestCbb.TabIndex = 33;
            // 
            // StartCbb
            // 
            this.StartCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartCbb.FormattingEnabled = true;
            this.StartCbb.Items.AddRange(new object[] {
            "Hồ Chí Minh",
            "Hà Nội",
            "Vinh",
            "Đà Nẵng"});
            this.StartCbb.Location = new System.Drawing.Point(139, 55);
            this.StartCbb.Name = "StartCbb";
            this.StartCbb.Size = new System.Drawing.Size(279, 30);
            this.StartCbb.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(454, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "Time:";
            // 
            // FlightTimePk
            // 
            this.FlightTimePk.CustomFormat = "HH:MM";
            this.FlightTimePk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.FlightTimePk.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.FlightTimePk.Location = new System.Drawing.Point(278, 104);
            this.FlightTimePk.Name = "FlightTimePk";
            this.FlightTimePk.ShowUpDown = true;
            this.FlightTimePk.Size = new System.Drawing.Size(140, 28);
            this.FlightTimePk.TabIndex = 29;
            this.FlightTimePk.Value = new System.DateTime(2024, 6, 17, 8, 54, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Flight Time:";
            // 
            // CodeTb
            // 
            this.CodeTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CodeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeTb.Location = new System.Drawing.Point(139, 14);
            this.CodeTb.Name = "CodeTb";
            this.CodeTb.Size = new System.Drawing.Size(279, 30);
            this.CodeTb.TabIndex = 27;
            this.CodeTb.TextChanged += new System.EventHandler(this.CodeTb_TextChanged);
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
            // FlightDatePk
            // 
            this.FlightDatePk.CustomFormat = "yyyy-MM-dd";
            this.FlightDatePk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.FlightDatePk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FlightDatePk.Location = new System.Drawing.Point(141, 105);
            this.FlightDatePk.Name = "FlightDatePk";
            this.FlightDatePk.Size = new System.Drawing.Size(127, 28);
            this.FlightDatePk.TabIndex = 25;
            this.FlightDatePk.Value = new System.DateTime(2024, 6, 18, 0, 0, 0, 0);
            // 
            // Seat2Tb
            // 
            this.Seat2Tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Seat2Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seat2Tb.Location = new System.Drawing.Point(572, 155);
            this.Seat2Tb.Name = "Seat2Tb";
            this.Seat2Tb.Size = new System.Drawing.Size(212, 30);
            this.Seat2Tb.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(454, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Seat 2:";
            // 
            // Seat1Tb
            // 
            this.Seat1Tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Seat1Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Seat1Tb.Location = new System.Drawing.Point(141, 155);
            this.Seat1Tb.Name = "Seat1Tb";
            this.Seat1Tb.Size = new System.Drawing.Size(277, 30);
            this.Seat1Tb.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Seat 1:";
            // 
            // PriceTb
            // 
            this.PriceTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PriceTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTb.Location = new System.Drawing.Point(572, 9);
            this.PriceTb.Name = "PriceTb";
            this.PriceTb.Size = new System.Drawing.Size(212, 30);
            this.PriceTb.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(454, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Destination:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Start From:";
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.ForeColor = System.Drawing.Color.White;
            this.ClearBtn.Location = new System.Drawing.Point(480, 222);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(145, 40);
            this.ClearBtn.TabIndex = 14;
            this.ClearBtn.Text = "CLEAR";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(329, 222);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(145, 40);
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(176, 222);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(145, 40);
            this.UpdateBtn.TabIndex = 12;
            this.UpdateBtn.Text = "UPDATE";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.White;
            this.AddBtn.Location = new System.Drawing.Point(25, 222);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(145, 40);
            this.AddBtn.TabIndex = 11;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // FlightDurationPk
            // 
            this.FlightDurationPk.CustomFormat = "HH:mm";
            this.FlightDurationPk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.FlightDurationPk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FlightDurationPk.Location = new System.Drawing.Point(572, 111);
            this.FlightDurationPk.Name = "FlightDurationPk";
            this.FlightDurationPk.ShowUpDown = true;
            this.FlightDurationPk.Size = new System.Drawing.Size(212, 28);
            this.FlightDurationPk.TabIndex = 34;
            this.FlightDurationPk.Value = new System.DateTime(2024, 6, 17, 8, 54, 0, 0);
            // 
            // Admin_FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ListFlightGv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DateTimePicker FlightDatePk;
        private System.Windows.Forms.TextBox Seat2Tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Seat1Tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PriceTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodeTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox DestCbb;
        private System.Windows.Forms.ComboBox StartCbb;
        private System.Windows.Forms.DateTimePicker FlightTimePk;
        private System.Windows.Forms.DateTimePicker FlightDurationPk;
    }
}