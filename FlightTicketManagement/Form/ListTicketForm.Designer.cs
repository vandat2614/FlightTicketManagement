namespace FlightTicketManagement
{
    partial class ListTicketForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SearchFlightBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.FlightCodeCbb = new System.Windows.Forms.ComboBox();
            this.ListTicketData = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TicketTypeCbb = new System.Windows.Forms.ComboBox();
            this.TicketTypeTb = new System.Windows.Forms.Label();
            this.DeleteTicketBtn = new System.Windows.Forms.Button();
            this.UpdateTicketBtn = new System.Windows.Forms.Button();
            this.CMNDTb = new System.Windows.Forms.TextBox();
            this.TicketPriceTb = new System.Windows.Forms.TextBox();
            this.SeatTypeCbb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CustomerPhoneTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CustomerNameTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListTicketData)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.ListTicketData);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(179, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(844, 416);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SearchFlightBtn);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.FlightCodeCbb);
            this.panel3.Location = new System.Drawing.Point(15, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(497, 51);
            this.panel3.TabIndex = 50;
            // 
            // SearchFlightBtn
            // 
            this.SearchFlightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.SearchFlightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchFlightBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFlightBtn.ForeColor = System.Drawing.Color.White;
            this.SearchFlightBtn.Location = new System.Drawing.Point(341, 8);
            this.SearchFlightBtn.Name = "SearchFlightBtn";
            this.SearchFlightBtn.Size = new System.Drawing.Size(145, 40);
            this.SearchFlightBtn.TabIndex = 44;
            this.SearchFlightBtn.Text = "SEARCH";
            this.SearchFlightBtn.UseVisualStyleBackColor = false;
            this.SearchFlightBtn.Click += new System.EventHandler(this.SearchFlightBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 21);
            this.label9.TabIndex = 46;
            this.label9.Text = "Flight Code";
            // 
            // FlightCodeCbb
            // 
            this.FlightCodeCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlightCodeCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlightCodeCbb.FormattingEnabled = true;
            this.FlightCodeCbb.Items.AddRange(new object[] {
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
            this.FlightCodeCbb.Location = new System.Drawing.Point(144, 13);
            this.FlightCodeCbb.Name = "FlightCodeCbb";
            this.FlightCodeCbb.Size = new System.Drawing.Size(180, 30);
            this.FlightCodeCbb.TabIndex = 47;
            // 
            // ListTicketData
            // 
            this.ListTicketData.AllowUserToAddRows = false;
            this.ListTicketData.AllowUserToDeleteRows = false;
            this.ListTicketData.AllowUserToResizeColumns = false;
            this.ListTicketData.AllowUserToResizeRows = false;
            this.ListTicketData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListTicketData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListTicketData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListTicketData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListTicketData.EnableHeadersVisualStyles = false;
            this.ListTicketData.Location = new System.Drawing.Point(15, 94);
            this.ListTicketData.Name = "ListTicketData";
            this.ListTicketData.ReadOnly = true;
            this.ListTicketData.RowHeadersVisible = false;
            this.ListTicketData.RowHeadersWidth = 51;
            this.ListTicketData.RowTemplate.Height = 24;
            this.ListTicketData.Size = new System.Drawing.Size(798, 278);
            this.ListTicketData.TabIndex = 17;
            this.ListTicketData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListTicketData_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(29, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 27);
            this.label7.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.TicketTypeCbb);
            this.panel4.Controls.Add(this.TicketTypeTb);
            this.panel4.Controls.Add(this.DeleteTicketBtn);
            this.panel4.Controls.Add(this.UpdateTicketBtn);
            this.panel4.Controls.Add(this.CMNDTb);
            this.panel4.Controls.Add(this.TicketPriceTb);
            this.panel4.Controls.Add(this.SeatTypeCbb);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.CustomerPhoneTb);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.CustomerNameTb);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(49, 451);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1046, 190);
            this.panel4.TabIndex = 4;
            // 
            // TicketTypeCbb
            // 
            this.TicketTypeCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TicketTypeCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketTypeCbb.FormattingEnabled = true;
            this.TicketTypeCbb.Items.AddRange(new object[] {
            "buy",
            "book"});
            this.TicketTypeCbb.Location = new System.Drawing.Point(831, 77);
            this.TicketTypeCbb.Name = "TicketTypeCbb";
            this.TicketTypeCbb.Size = new System.Drawing.Size(192, 30);
            this.TicketTypeCbb.TabIndex = 53;
            // 
            // TicketTypeTb
            // 
            this.TicketTypeTb.AutoSize = true;
            this.TicketTypeTb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketTypeTb.Location = new System.Drawing.Point(707, 81);
            this.TicketTypeTb.Name = "TicketTypeTb";
            this.TicketTypeTb.Size = new System.Drawing.Size(112, 21);
            this.TicketTypeTb.TabIndex = 52;
            this.TicketTypeTb.Text = "Ticket Type";
            // 
            // DeleteTicketBtn
            // 
            this.DeleteTicketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.DeleteTicketBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteTicketBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTicketBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteTicketBtn.Location = new System.Drawing.Point(878, 136);
            this.DeleteTicketBtn.Name = "DeleteTicketBtn";
            this.DeleteTicketBtn.Size = new System.Drawing.Size(145, 40);
            this.DeleteTicketBtn.TabIndex = 51;
            this.DeleteTicketBtn.Text = "DELETE";
            this.DeleteTicketBtn.UseVisualStyleBackColor = false;
            this.DeleteTicketBtn.Click += new System.EventHandler(this.DeleteTicketBtn_Click);
            // 
            // UpdateTicketBtn
            // 
            this.UpdateTicketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.UpdateTicketBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateTicketBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateTicketBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateTicketBtn.Location = new System.Drawing.Point(711, 136);
            this.UpdateTicketBtn.Name = "UpdateTicketBtn";
            this.UpdateTicketBtn.Size = new System.Drawing.Size(145, 40);
            this.UpdateTicketBtn.TabIndex = 50;
            this.UpdateTicketBtn.Text = "UPDATE";
            this.UpdateTicketBtn.UseVisualStyleBackColor = false;
            this.UpdateTicketBtn.Click += new System.EventHandler(this.UpdateTicketBtn_Click);
            // 
            // CMNDTb
            // 
            this.CMNDTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CMNDTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMNDTb.Location = new System.Drawing.Point(486, 14);
            this.CMNDTb.Name = "CMNDTb";
            this.CMNDTb.Size = new System.Drawing.Size(183, 30);
            this.CMNDTb.TabIndex = 42;
            // 
            // TicketPriceTb
            // 
            this.TicketPriceTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TicketPriceTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TicketPriceTb.Location = new System.Drawing.Point(831, 20);
            this.TicketPriceTb.Name = "TicketPriceTb";
            this.TicketPriceTb.ReadOnly = true;
            this.TicketPriceTb.Size = new System.Drawing.Size(192, 30);
            this.TicketPriceTb.TabIndex = 49;
            // 
            // SeatTypeCbb
            // 
            this.SeatTypeCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeatTypeCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeatTypeCbb.FormattingEnabled = true;
            this.SeatTypeCbb.Items.AddRange(new object[] {
            "1",
            "2"});
            this.SeatTypeCbb.Location = new System.Drawing.Point(167, 72);
            this.SeatTypeCbb.Name = "SeatTypeCbb";
            this.SeatTypeCbb.Size = new System.Drawing.Size(192, 30);
            this.SeatTypeCbb.TabIndex = 41;
            this.SeatTypeCbb.SelectedIndexChanged += new System.EventHandler(this.SeatTypeCbb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(707, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Price";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(30, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 21);
            this.label11.TabIndex = 40;
            this.label11.Text = "Seat Type";
            // 
            // CustomerPhoneTb
            // 
            this.CustomerPhoneTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerPhoneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneTb.Location = new System.Drawing.Point(486, 72);
            this.CustomerPhoneTb.Name = "CustomerPhoneTb";
            this.CustomerPhoneTb.Size = new System.Drawing.Size(183, 30);
            this.CustomerPhoneTb.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(401, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 21);
            this.label12.TabIndex = 39;
            this.label12.Text = "CMND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(401, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 46;
            this.label5.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(613, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 45;
            // 
            // CustomerNameTb
            // 
            this.CustomerNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CustomerNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTb.Location = new System.Drawing.Point(167, 14);
            this.CustomerNameTb.Name = "CustomerNameTb";
            this.CustomerNameTb.Size = new System.Drawing.Size(192, 30);
            this.CustomerNameTb.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 21);
            this.label6.TabIndex = 43;
            this.label6.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(29, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 27);
            this.label2.TabIndex = 16;
            // 
            // ListTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListTicketForm";
            this.Load += new System.EventHandler(this.ListTicketForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListTicketData)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ListTicketData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SearchFlightBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox FlightCodeCbb;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TicketPriceTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustomerPhoneTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CustomerNameTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CMNDTb;
        private System.Windows.Forms.ComboBox SeatTypeCbb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button DeleteTicketBtn;
        private System.Windows.Forms.Button UpdateTicketBtn;
        private System.Windows.Forms.ComboBox TicketTypeCbb;
        private System.Windows.Forms.Label TicketTypeTb;
    }
}