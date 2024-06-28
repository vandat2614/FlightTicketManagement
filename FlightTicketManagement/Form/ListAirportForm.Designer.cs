namespace FlightTicketManagement
{
    partial class ListAirportForm
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
            this.AirportCodeTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClearInfoBtn = new System.Windows.Forms.Button();
            this.DeleteAirportBtn = new System.Windows.Forms.Button();
            this.UpdateAirportBtn = new System.Windows.Forms.Button();
            this.AddAirportBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.AirportNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListAirportGv = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.AirportNoteTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AirportCityCbb = new System.Windows.Forms.ComboBox();
            this.AirportStatusCbb = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListAirportGv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.AirportStatusCbb);
            this.panel1.Controls.Add(this.AirportCityCbb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.AirportNoteTb);
            this.panel1.Controls.Add(this.ClearInfoBtn);
            this.panel1.Controls.Add(this.DeleteAirportBtn);
            this.panel1.Controls.Add(this.UpdateAirportBtn);
            this.panel1.Controls.Add(this.AddAirportBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AirportCodeTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AirportNameTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(152, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(830, 281);
            this.panel1.TabIndex = 0;
            // 
            // AirportCodeTb
            // 
            this.AirportCodeTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AirportCodeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirportCodeTb.Location = new System.Drawing.Point(112, 15);
            this.AirportCodeTb.Name = "AirportCodeTb";
            this.AirportCodeTb.Size = new System.Drawing.Size(247, 30);
            this.AirportCodeTb.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Code:";
            // 
            // ClearInfoBtn
            // 
            this.ClearInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ClearInfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearInfoBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearInfoBtn.ForeColor = System.Drawing.Color.White;
            this.ClearInfoBtn.Location = new System.Drawing.Point(657, 230);
            this.ClearInfoBtn.Name = "ClearInfoBtn";
            this.ClearInfoBtn.Size = new System.Drawing.Size(145, 40);
            this.ClearInfoBtn.TabIndex = 10;
            this.ClearInfoBtn.Text = "CLEAR";
            this.ClearInfoBtn.UseVisualStyleBackColor = false;
            this.ClearInfoBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DeleteAirportBtn
            // 
            this.DeleteAirportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.DeleteAirportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteAirportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAirportBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAirportBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteAirportBtn.Location = new System.Drawing.Point(474, 230);
            this.DeleteAirportBtn.Name = "DeleteAirportBtn";
            this.DeleteAirportBtn.Size = new System.Drawing.Size(145, 40);
            this.DeleteAirportBtn.TabIndex = 9;
            this.DeleteAirportBtn.Text = "DELETE";
            this.DeleteAirportBtn.UseVisualStyleBackColor = false;
            this.DeleteAirportBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateAirportBtn
            // 
            this.UpdateAirportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.UpdateAirportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateAirportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateAirportBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAirportBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateAirportBtn.Location = new System.Drawing.Point(299, 230);
            this.UpdateAirportBtn.Name = "UpdateAirportBtn";
            this.UpdateAirportBtn.Size = new System.Drawing.Size(145, 40);
            this.UpdateAirportBtn.TabIndex = 8;
            this.UpdateAirportBtn.Text = "UPDATE";
            this.UpdateAirportBtn.UseVisualStyleBackColor = false;
            this.UpdateAirportBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AddAirportBtn
            // 
            this.AddAirportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.AddAirportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAirportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAirportBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAirportBtn.ForeColor = System.Drawing.Color.White;
            this.AddAirportBtn.Location = new System.Drawing.Point(112, 230);
            this.AddAirportBtn.Name = "AddAirportBtn";
            this.AddAirportBtn.Size = new System.Drawing.Size(145, 40);
            this.AddAirportBtn.TabIndex = 7;
            this.AddAirportBtn.Text = "ADD";
            this.AddAirportBtn.UseVisualStyleBackColor = false;
            this.AddAirportBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "City:";
            // 
            // AirportNameTb
            // 
            this.AirportNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AirportNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirportNameTb.Location = new System.Drawing.Point(112, 72);
            this.AirportNameTb.Name = "AirportNameTb";
            this.AirportNameTb.Size = new System.Drawing.Size(247, 30);
            this.AirportNameTb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ListAirportGv);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(152, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 306);
            this.panel2.TabIndex = 1;
            // 
            // ListAirportGv
            // 
            this.ListAirportGv.AllowUserToAddRows = false;
            this.ListAirportGv.AllowUserToDeleteRows = false;
            this.ListAirportGv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListAirportGv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListAirportGv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListAirportGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListAirportGv.EnableHeadersVisualStyles = false;
            this.ListAirportGv.Location = new System.Drawing.Point(34, 44);
            this.ListAirportGv.Name = "ListAirportGv";
            this.ListAirportGv.ReadOnly = true;
            this.ListAirportGv.RowHeadersVisible = false;
            this.ListAirportGv.RowHeadersWidth = 51;
            this.ListAirportGv.RowTemplate.Height = 24;
            this.ListAirportGv.Size = new System.Drawing.Size(768, 242);
            this.ListAirportGv.TabIndex = 17;
            this.ListAirportGv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListAirportGv_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(29, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "List Airports";
            // 
            // AirportNoteTb
            // 
            this.AirportNoteTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AirportNoteTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirportNoteTb.Location = new System.Drawing.Point(394, 15);
            this.AirportNoteTb.Multiline = true;
            this.AirportNoteTb.Name = "AirportNoteTb";
            this.AirportNoteTb.Size = new System.Drawing.Size(409, 195);
            this.AirportNoteTb.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(755, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Status:";
            // 
            // AirportCityCbb
            // 
            this.AirportCityCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AirportCityCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirportCityCbb.FormattingEnabled = true;
            this.AirportCityCbb.Items.AddRange(new object[] {
            "Hà Nội",
            "Hồ Chí Minh (Thành phố Hồ Chí Minh)",
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
            this.AirportCityCbb.Location = new System.Drawing.Point(112, 130);
            this.AirportCityCbb.Name = "AirportCityCbb";
            this.AirportCityCbb.Size = new System.Drawing.Size(247, 30);
            this.AirportCityCbb.TabIndex = 24;
            // 
            // AirportStatusCbb
            // 
            this.AirportStatusCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AirportStatusCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirportStatusCbb.FormattingEnabled = true;
            this.AirportStatusCbb.Items.AddRange(new object[] {
            "Active",
            "Stop"});
            this.AirportStatusCbb.Location = new System.Drawing.Point(112, 185);
            this.AirportStatusCbb.Name = "AirportStatusCbb";
            this.AirportStatusCbb.Size = new System.Drawing.Size(247, 30);
            this.AirportStatusCbb.TabIndex = 25;
            // 
            // ListAirportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 633);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListAirportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AIRPORT";
            this.Load += new System.EventHandler(this.Admin_AirportForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListAirportGv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AirportNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearInfoBtn;
        private System.Windows.Forms.Button DeleteAirportBtn;
        private System.Windows.Forms.Button UpdateAirportBtn;
        private System.Windows.Forms.Button AddAirportBtn;
        private System.Windows.Forms.DataGridView ListAirportGv;
        private System.Windows.Forms.TextBox AirportCodeTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AirportNoteTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox AirportStatusCbb;
        private System.Windows.Forms.ComboBox AirportCityCbb;
    }
}