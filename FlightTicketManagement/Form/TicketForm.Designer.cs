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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AirportStatusCbb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ClearInfoBtn = new System.Windows.Forms.Button();
            this.DeleteAirportBtn = new System.Windows.Forms.Button();
            this.UpdateAirportBtn = new System.Windows.Forms.Button();
            this.AddAirportBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AirportNameTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DepatureFlightBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.DepatureFlightBtn);
            this.panel1.Controls.Add(this.AirportStatusCbb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ClearInfoBtn);
            this.panel1.Controls.Add(this.DeleteAirportBtn);
            this.panel1.Controls.Add(this.UpdateAirportBtn);
            this.panel1.Controls.Add(this.AddAirportBtn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AirportNameTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(175, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 281);
            this.panel1.TabIndex = 1;
            // 
            // AirportStatusCbb
            // 
            this.AirportStatusCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AirportStatusCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirportStatusCbb.FormattingEnabled = true;
            this.AirportStatusCbb.Items.AddRange(new object[] {
            "Active",
            "Stop"});
            this.AirportStatusCbb.Location = new System.Drawing.Point(133, 133);
            this.AirportStatusCbb.Name = "AirportStatusCbb";
            this.AirportStatusCbb.Size = new System.Drawing.Size(247, 30);
            this.AirportStatusCbb.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ticket Type";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Flight";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "CMND";
            // 
            // AirportNameTb
            // 
            this.AirportNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AirportNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AirportNameTb.Location = new System.Drawing.Point(582, 15);
            this.AirportNameTb.Name = "AirportNameTb";
            this.AirportNameTb.Size = new System.Drawing.Size(247, 30);
            this.AirportNameTb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name";
            // 
            // DepatureFlightBtn
            // 
            this.DepatureFlightBtn.BackColor = System.Drawing.Color.DarkGray;
            this.DepatureFlightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DepatureFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DepatureFlightBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepatureFlightBtn.ForeColor = System.Drawing.Color.White;
            this.DepatureFlightBtn.Location = new System.Drawing.Point(133, 15);
            this.DepatureFlightBtn.Name = "DepatureFlightBtn";
            this.DepatureFlightBtn.Size = new System.Drawing.Size(247, 33);
            this.DepatureFlightBtn.TabIndex = 37;
            this.DepatureFlightBtn.Text = "SELECT";
            this.DepatureFlightBtn.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(133, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 30);
            this.textBox1.TabIndex = 38;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(582, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 30);
            this.textBox2.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "Phone";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(582, 132);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(247, 30);
            this.textBox3.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(500, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Price";
            // 
            // TicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 653);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TicketForm";
            this.Text = "TicketForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox AirportStatusCbb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ClearInfoBtn;
        private System.Windows.Forms.Button DeleteAirportBtn;
        private System.Windows.Forms.Button UpdateAirportBtn;
        private System.Windows.Forms.Button AddAirportBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AirportNameTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button DepatureFlightBtn;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
    }
}