namespace FlightTicketManagement
{
    partial class FlightForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListFlightData = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FlightDurationTb = new System.Windows.Forms.TextBox();
            this.ArrivalFlightBtn = new System.Windows.Forms.Button();
            this.DepatureFlightBtn = new System.Windows.Forms.Button();
            this.LoadIntermediateForm = new System.Windows.Forms.Button();
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
            this.ClearInfoBtn = new System.Windows.Forms.Button();
            this.DeleteFlightBtn = new System.Windows.Forms.Button();
            this.UpdateFlightBtn = new System.Windows.Forms.Button();
            this.AddFlightBtn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListFlightData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ListFlightData);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1176, 374);
            this.panel2.TabIndex = 2;
            // 
            // ListFlightData
            // 
            this.ListFlightData.AllowUserToAddRows = false;
            this.ListFlightData.AllowUserToDeleteRows = false;
            this.ListFlightData.AllowUserToResizeColumns = false;
            this.ListFlightData.AllowUserToResizeRows = false;
            this.ListFlightData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListFlightData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListFlightData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListFlightData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListFlightData.EnableHeadersVisualStyles = false;
            this.ListFlightData.Location = new System.Drawing.Point(25, 55);
            this.ListFlightData.Name = "ListFlightData";
            this.ListFlightData.ReadOnly = true;
            this.ListFlightData.RowHeadersVisible = false;
            this.ListFlightData.RowHeadersWidth = 51;
            this.ListFlightData.RowTemplate.Height = 24;
            this.ListFlightData.Size = new System.Drawing.Size(1111, 292);
            this.ListFlightData.TabIndex = 17;
            this.ListFlightData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListFlightData_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "Flights";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.FlightDurationTb);
            this.panel1.Controls.Add(this.ArrivalFlightBtn);
            this.panel1.Controls.Add(this.DepatureFlightBtn);
            this.panel1.Controls.Add(this.LoadIntermediateForm);
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
            this.panel1.Controls.Add(this.ClearInfoBtn);
            this.panel1.Controls.Add(this.DeleteFlightBtn);
            this.panel1.Controls.Add(this.UpdateFlightBtn);
            this.panel1.Controls.Add(this.AddFlightBtn);
            this.panel1.Location = new System.Drawing.Point(130, 392);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(904, 296);
            this.panel1.TabIndex = 3;
            // 
            // FlightDurationTb
            // 
            this.FlightDurationTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightDurationTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightDurationTb.Location = new System.Drawing.Point(654, 158);
            this.FlightDurationTb.Name = "FlightDurationTb";
            this.FlightDurationTb.Size = new System.Drawing.Size(231, 30);
            this.FlightDurationTb.TabIndex = 38;
            // 
            // ArrivalFlightBtn
            // 
            this.ArrivalFlightBtn.BackColor = System.Drawing.Color.DarkGray;
            this.ArrivalFlightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ArrivalFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ArrivalFlightBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArrivalFlightBtn.ForeColor = System.Drawing.Color.White;
            this.ArrivalFlightBtn.Location = new System.Drawing.Point(589, 60);
            this.ArrivalFlightBtn.Name = "ArrivalFlightBtn";
            this.ArrivalFlightBtn.Size = new System.Drawing.Size(296, 33);
            this.ArrivalFlightBtn.TabIndex = 37;
            this.ArrivalFlightBtn.Text = "SELECT";
            this.ArrivalFlightBtn.UseVisualStyleBackColor = false;
            this.ArrivalFlightBtn.Click += new System.EventHandler(this.ArrivalFlightBtn_Click);
            // 
            // DepatureFlightBtn
            // 
            this.DepatureFlightBtn.BackColor = System.Drawing.Color.DarkGray;
            this.DepatureFlightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DepatureFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepatureFlightBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepatureFlightBtn.ForeColor = System.Drawing.Color.White;
            this.DepatureFlightBtn.Location = new System.Drawing.Point(125, 60);
            this.DepatureFlightBtn.Name = "DepatureFlightBtn";
            this.DepatureFlightBtn.Size = new System.Drawing.Size(301, 33);
            this.DepatureFlightBtn.TabIndex = 36;
            this.DepatureFlightBtn.Text = "SELECT";
            this.DepatureFlightBtn.UseVisualStyleBackColor = false;
            this.DepatureFlightBtn.Click += new System.EventHandler(this.DepatureFlightBtn_Click);
            // 
            // LoadIntermediateForm
            // 
            this.LoadIntermediateForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.LoadIntermediateForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadIntermediateForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadIntermediateForm.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadIntermediateForm.ForeColor = System.Drawing.Color.White;
            this.LoadIntermediateForm.Location = new System.Drawing.Point(692, 222);
            this.LoadIntermediateForm.Name = "LoadIntermediateForm";
            this.LoadIntermediateForm.Size = new System.Drawing.Size(193, 40);
            this.LoadIntermediateForm.TabIndex = 35;
            this.LoadIntermediateForm.Text = "Intermediate";
            this.LoadIntermediateForm.UseVisualStyleBackColor = false;
            this.LoadIntermediateForm.Click += new System.EventHandler(this.LoadIntermediateForm_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(478, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 21);
            this.label9.TabIndex = 30;
            this.label9.Text = "Duration (hour):";
            // 
            // FlightDepatureTimePk
            // 
            this.FlightDepatureTimePk.CustomFormat = "\' \'";
            this.FlightDepatureTimePk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.FlightDepatureTimePk.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.FlightDepatureTimePk.Location = new System.Drawing.Point(283, 160);
            this.FlightDepatureTimePk.Name = "FlightDepatureTimePk";
            this.FlightDepatureTimePk.ShowUpDown = true;
            this.FlightDepatureTimePk.Size = new System.Drawing.Size(143, 28);
            this.FlightDepatureTimePk.TabIndex = 29;
            this.FlightDepatureTimePk.Value = new System.DateTime(2024, 6, 17, 0, 0, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 21);
            this.label8.TabIndex = 28;
            this.label8.Text = "Time:";
            // 
            // FlightCodeTb
            // 
            this.FlightCodeTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightCodeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightCodeTb.Location = new System.Drawing.Point(125, 20);
            this.FlightCodeTb.Name = "FlightCodeTb";
            this.FlightCodeTb.Size = new System.Drawing.Size(301, 30);
            this.FlightCodeTb.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 21);
            this.label6.TabIndex = 26;
            this.label6.Text = "Flight Code:";
            // 
            // FlightDepatureDatePk
            // 
            this.FlightDepatureDatePk.CustomFormat = "yyyy-MM-dd";
            this.FlightDepatureDatePk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightDepatureDatePk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FlightDepatureDatePk.Location = new System.Drawing.Point(125, 160);
            this.FlightDepatureDatePk.Name = "FlightDepatureDatePk";
            this.FlightDepatureDatePk.Size = new System.Drawing.Size(152, 28);
            this.FlightDepatureDatePk.TabIndex = 25;
            this.FlightDepatureDatePk.Value = new System.DateTime(2024, 7, 1, 0, 0, 0, 0);
            // 
            // FlightSeat2Tb
            // 
            this.FlightSeat2Tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightSeat2Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightSeat2Tb.Location = new System.Drawing.Point(589, 104);
            this.FlightSeat2Tb.Name = "FlightSeat2Tb";
            this.FlightSeat2Tb.Size = new System.Drawing.Size(296, 30);
            this.FlightSeat2Tb.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 23;
            this.label4.Text = "Seat 2:";
            // 
            // FlightSeat1Tb
            // 
            this.FlightSeat1Tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightSeat1Tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightSeat1Tb.Location = new System.Drawing.Point(125, 109);
            this.FlightSeat1Tb.Name = "FlightSeat1Tb";
            this.FlightSeat1Tb.Size = new System.Drawing.Size(296, 30);
            this.FlightSeat1Tb.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Seat 1:";
            // 
            // FlightPriceTb
            // 
            this.FlightPriceTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightPriceTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightPriceTb.Location = new System.Drawing.Point(589, 20);
            this.FlightPriceTb.Name = "FlightPriceTb";
            this.FlightPriceTb.Size = new System.Drawing.Size(296, 30);
            this.FlightPriceTb.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Price (vnd):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(478, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Arrival:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Depature:";
            // 
            // ClearInfoBtn
            // 
            this.ClearInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ClearInfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearInfoBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearInfoBtn.ForeColor = System.Drawing.Color.White;
            this.ClearInfoBtn.Location = new System.Drawing.Point(482, 222);
            this.ClearInfoBtn.Name = "ClearInfoBtn";
            this.ClearInfoBtn.Size = new System.Drawing.Size(145, 40);
            this.ClearInfoBtn.TabIndex = 14;
            this.ClearInfoBtn.Text = "CLEAR";
            this.ClearInfoBtn.UseVisualStyleBackColor = false;
            this.ClearInfoBtn.Click += new System.EventHandler(this.ClearInfoBtn_Click);
            // 
            // DeleteFlightBtn
            // 
            this.DeleteFlightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.DeleteFlightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteFlightBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFlightBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteFlightBtn.Location = new System.Drawing.Point(327, 222);
            this.DeleteFlightBtn.Name = "DeleteFlightBtn";
            this.DeleteFlightBtn.Size = new System.Drawing.Size(145, 40);
            this.DeleteFlightBtn.TabIndex = 13;
            this.DeleteFlightBtn.Text = "DELETE";
            this.DeleteFlightBtn.UseVisualStyleBackColor = false;
            this.DeleteFlightBtn.Click += new System.EventHandler(this.DeleteFlightBtn_Click);
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
            this.UpdateFlightBtn.Click += new System.EventHandler(this.UpdateFlightBtn_Click);
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
            this.AddFlightBtn.Click += new System.EventHandler(this.AddFlightBtn_Click);
            // 
            // FlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FlightForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Admin_FlightForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListFlightData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ListFlightData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClearInfoBtn;
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
        private System.Windows.Forms.DateTimePicker FlightDepatureTimePk;
        private System.Windows.Forms.Button LoadIntermediateForm;
        private System.Windows.Forms.Button ArrivalFlightBtn;
        private System.Windows.Forms.Button DepatureFlightBtn;
        private System.Windows.Forms.TextBox FlightDurationTb;
    }
}