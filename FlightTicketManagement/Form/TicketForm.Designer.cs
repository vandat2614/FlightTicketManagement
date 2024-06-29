namespace FlightTicketManagement
{
    partial class TicketForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BookTicketBtn = new System.Windows.Forms.Button();
            this.FlightCodeTb = new System.Windows.Forms.TextBox();
            this.TicketPriceTb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CustomerPhoneTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CMNDTb = new System.Windows.Forms.TextBox();
            this.TicketTypeCbb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BuyTicketBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.FlightDatePk = new System.Windows.Forms.DateTimePicker();
            this.SearchFlightBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.FlightArrivalCbb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.FlightDepatureCbb = new System.Windows.Forms.ComboBox();
            this.ListFlightData = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListFlightData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BookTicketBtn);
            this.panel1.Controls.Add(this.FlightCodeTb);
            this.panel1.Controls.Add(this.TicketPriceTb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.CustomerPhoneTb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CMNDTb);
            this.panel1.Controls.Add(this.TicketTypeCbb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.BuyTicketBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CustomerNameTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(147, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 229);
            this.panel1.TabIndex = 1;
            // 
            // BookTicketBtn
            // 
            this.BookTicketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.BookTicketBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BookTicketBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookTicketBtn.ForeColor = System.Drawing.Color.White;
            this.BookTicketBtn.Location = new System.Drawing.Point(691, 179);
            this.BookTicketBtn.Name = "BookTicketBtn";
            this.BookTicketBtn.Size = new System.Drawing.Size(145, 40);
            this.BookTicketBtn.TabIndex = 44;
            this.BookTicketBtn.Text = "BOOK";
            this.BookTicketBtn.UseVisualStyleBackColor = false;
            this.BookTicketBtn.Click += new System.EventHandler(this.BookTicketBtn_Click);
            // 
            // FlightCodeTb
            // 
            this.FlightCodeTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FlightCodeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightCodeTb.Location = new System.Drawing.Point(140, 16);
            this.FlightCodeTb.Name = "FlightCodeTb";
            this.FlightCodeTb.ReadOnly = true;
            this.FlightCodeTb.Size = new System.Drawing.Size(247, 30);
            this.FlightCodeTb.TabIndex = 43;
            // 
            // TicketPriceTb
            // 
            this.TicketPriceTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TicketPriceTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketPriceTb.Location = new System.Drawing.Point(589, 128);
            this.TicketPriceTb.Name = "TicketPriceTb";
            this.TicketPriceTb.ReadOnly = true;
            this.TicketPriceTb.Size = new System.Drawing.Size(247, 30);
            this.TicketPriceTb.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(507, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Price";
            // 
            // CustomerPhoneTb
            // 
            this.CustomerPhoneTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerPhoneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneTb.Location = new System.Drawing.Point(589, 68);
            this.CustomerPhoneTb.Name = "CustomerPhoneTb";
            this.CustomerPhoneTb.Size = new System.Drawing.Size(247, 30);
            this.CustomerPhoneTb.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(507, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "Phone";
            // 
            // CMNDTb
            // 
            this.CMNDTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CMNDTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMNDTb.Location = new System.Drawing.Point(140, 72);
            this.CMNDTb.Name = "CMNDTb";
            this.CMNDTb.Size = new System.Drawing.Size(247, 30);
            this.CMNDTb.TabIndex = 38;
            // 
            // TicketTypeCbb
            // 
            this.TicketTypeCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TicketTypeCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketTypeCbb.FormattingEnabled = true;
            this.TicketTypeCbb.Items.AddRange(new object[] {
            "1",
            "2"});
            this.TicketTypeCbb.Location = new System.Drawing.Point(140, 129);
            this.TicketTypeCbb.Name = "TicketTypeCbb";
            this.TicketTypeCbb.Size = new System.Drawing.Size(247, 30);
            this.TicketTypeCbb.TabIndex = 25;
            this.TicketTypeCbb.SelectedIndexChanged += new System.EventHandler(this.TicketTypeCbb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Seat Type";
            // 
            // BuyTicketBtn
            // 
            this.BuyTicketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.BuyTicketBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BuyTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuyTicketBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuyTicketBtn.ForeColor = System.Drawing.Color.White;
            this.BuyTicketBtn.Location = new System.Drawing.Point(540, 179);
            this.BuyTicketBtn.Name = "BuyTicketBtn";
            this.BuyTicketBtn.Size = new System.Drawing.Size(145, 40);
            this.BuyTicketBtn.TabIndex = 7;
            this.BuyTicketBtn.Text = "BUY";
            this.BuyTicketBtn.UseVisualStyleBackColor = false;
            this.BuyTicketBtn.Click += new System.EventHandler(this.AddTicketBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(762, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Flight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "CMND";
            // 
            // CustomerNameTb
            // 
            this.CustomerNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTb.Location = new System.Drawing.Point(589, 11);
            this.CustomerNameTb.Name = "CustomerNameTb";
            this.CustomerNameTb.Size = new System.Drawing.Size(247, 30);
            this.CustomerNameTb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(425, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.ListFlightData);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1176, 389);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.FlightDatePk);
            this.panel3.Controls.Add(this.SearchFlightBtn);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.FlightArrivalCbb);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.FlightDepatureCbb);
            this.panel3.Location = new System.Drawing.Point(49, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1065, 51);
            this.panel3.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(641, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 21);
            this.label8.TabIndex = 50;
            this.label8.Text = "Date";
            // 
            // FlightDatePk
            // 
            this.FlightDatePk.CustomFormat = "yyyy-MM-dd";
            this.FlightDatePk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightDatePk.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FlightDatePk.Location = new System.Drawing.Point(707, 10);
            this.FlightDatePk.Name = "FlightDatePk";
            this.FlightDatePk.Size = new System.Drawing.Size(161, 28);
            this.FlightDatePk.TabIndex = 49;
            this.FlightDatePk.Value = new System.DateTime(2024, 6, 18, 0, 0, 0, 0);
            // 
            // SearchFlightBtn
            // 
            this.SearchFlightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.SearchFlightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchFlightBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFlightBtn.ForeColor = System.Drawing.Color.White;
            this.SearchFlightBtn.Location = new System.Drawing.Point(900, 3);
            this.SearchFlightBtn.Name = "SearchFlightBtn";
            this.SearchFlightBtn.Size = new System.Drawing.Size(145, 40);
            this.SearchFlightBtn.TabIndex = 44;
            this.SearchFlightBtn.Text = "SEARCH";
            this.SearchFlightBtn.UseVisualStyleBackColor = false;
            this.SearchFlightBtn.Click += new System.EventHandler(this.SearchFlightBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(339, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 21);
            this.label10.TabIndex = 44;
            this.label10.Text = "Arrival";
            // 
            // FlightArrivalCbb
            // 
            this.FlightArrivalCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlightArrivalCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightArrivalCbb.FormattingEnabled = true;
            this.FlightArrivalCbb.Items.AddRange(new object[] {
            "Hà Nội",
            "Hồ Chí Minh",
            "Đà Nẵng",
            "Hải Phòng",
            "Biên Hòa",
            "Nha Trang",
            "Buôn Ma Thuột",
            "Huế",
            "Long Xuyên",
            "Thái Nguyên",
            "Bắc Giang",
            "Thanh Hóa",
            "Vinh",
            "Nam Định",
            "Quy Nhơn",
            "Vũng Tàu",
            "Tam Kỳ",
            "Phan Thiết",
            "Đồng Hới",
            "Sóc Trăng",
            "Pleiku",
            "Bạc Liêu",
            "Thủ Dầu Một",
            "Cà Mau",
            "Hưng Yên",
            "Buôn Hồ",
            "Đông Hà",
            "Thanh Hóa"});
            this.FlightArrivalCbb.Location = new System.Drawing.Point(415, 10);
            this.FlightArrivalCbb.Name = "FlightArrivalCbb";
            this.FlightArrivalCbb.Size = new System.Drawing.Size(180, 30);
            this.FlightArrivalCbb.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 21);
            this.label9.TabIndex = 46;
            this.label9.Text = "Depature";
            // 
            // FlightDepatureCbb
            // 
            this.FlightDepatureCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlightDepatureCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightDepatureCbb.FormattingEnabled = true;
            this.FlightDepatureCbb.Items.AddRange(new object[] {
            "Hà Nội",
            "Hồ Chí Minh",
            "Đà Nẵng",
            "Hải Phòng",
            "Biên Hòa",
            "Nha Trang",
            "Buôn Ma Thuột",
            "Huế",
            "Long Xuyên",
            "Thái Nguyên",
            "Bắc Giang",
            "Thanh Hóa",
            "Vinh",
            "Nam Định",
            "Quy Nhơn",
            "Vũng Tàu",
            "Tam Kỳ",
            "Phan Thiết",
            "Đồng Hới",
            "Sóc Trăng",
            "Pleiku",
            "Bạc Liêu",
            "Thủ Dầu Một",
            "Cà Mau",
            "Hưng Yên",
            "Buôn Hồ",
            "Đông Hà",
            "Thanh Hóa"});
            this.FlightDepatureCbb.Location = new System.Drawing.Point(116, 10);
            this.FlightDepatureCbb.Name = "FlightDepatureCbb";
            this.FlightDepatureCbb.Size = new System.Drawing.Size(180, 30);
            this.FlightDepatureCbb.TabIndex = 47;
            // 
            // ListFlightData
            // 
            this.ListFlightData.AllowUserToAddRows = false;
            this.ListFlightData.AllowUserToDeleteRows = false;
            this.ListFlightData.AllowUserToResizeColumns = false;
            this.ListFlightData.AllowUserToResizeRows = false;
            this.ListFlightData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListFlightData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListFlightData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListFlightData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListFlightData.EnableHeadersVisualStyles = false;
            this.ListFlightData.Location = new System.Drawing.Point(49, 82);
            this.ListFlightData.Name = "ListFlightData";
            this.ListFlightData.ReadOnly = true;
            this.ListFlightData.RowHeadersVisible = false;
            this.ListFlightData.RowHeadersWidth = 51;
            this.ListFlightData.RowTemplate.Height = 24;
            this.ListFlightData.Size = new System.Drawing.Size(1065, 283);
            this.ListFlightData.TabIndex = 17;
            this.ListFlightData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListFlightData_CellClick);
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.Load += new System.EventHandler(this.TicketForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListFlightData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox TicketTypeCbb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BuyTicketBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomerNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerPhoneTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CMNDTb;
        private System.Windows.Forms.TextBox TicketPriceTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ListFlightData;
        private System.Windows.Forms.TextBox FlightCodeTb;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SearchFlightBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox FlightArrivalCbb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox FlightDepatureCbb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker FlightDatePk;
        private System.Windows.Forms.Button BookTicketBtn;
    }
}