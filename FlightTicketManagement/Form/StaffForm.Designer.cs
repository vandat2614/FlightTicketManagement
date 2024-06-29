namespace FlightTicketManagement
{
    partial class StaffForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.ListAccountBtn = new System.Windows.Forms.Button();
            this.ListFlightBtn = new System.Windows.Forms.Button();
            this.ListAirportBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Location = new System.Drawing.Point(269, 45);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1200, 700);
            this.MainPanel.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(272, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1199, 45);
            this.panel1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(307, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Flight Ticket Management System";
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(1437, 9);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(22, 23);
            this.ExitBtn.TabIndex = 12;
            this.ExitBtn.Text = "X";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.SettingBtn);
            this.panel2.Controls.Add(this.ListAccountBtn);
            this.panel2.Controls.Add(this.ListFlightBtn);
            this.panel2.Controls.Add(this.ListAirportBtn);
            this.panel2.Controls.Add(this.LogoutBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 746);
            this.panel2.TabIndex = 5;
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.SettingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.SettingBtn.ForeColor = System.Drawing.Color.White;
            this.SettingBtn.Location = new System.Drawing.Point(12, 465);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(248, 45);
            this.SettingBtn.TabIndex = 19;
            this.SettingBtn.Text = "Setting";
            this.SettingBtn.UseVisualStyleBackColor = false;
            // 
            // ListAccountBtn
            // 
            this.ListAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ListAccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListAccountBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.ListAccountBtn.ForeColor = System.Drawing.Color.White;
            this.ListAccountBtn.Location = new System.Drawing.Point(12, 276);
            this.ListAccountBtn.Name = "ListAccountBtn";
            this.ListAccountBtn.Size = new System.Drawing.Size(248, 45);
            this.ListAccountBtn.TabIndex = 18;
            this.ListAccountBtn.Text = "User Account";
            this.ListAccountBtn.UseVisualStyleBackColor = false;
            // 
            // ListFlightBtn
            // 
            this.ListFlightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ListFlightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListFlightBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.ListFlightBtn.ForeColor = System.Drawing.Color.White;
            this.ListFlightBtn.Location = new System.Drawing.Point(12, 343);
            this.ListFlightBtn.Name = "ListFlightBtn";
            this.ListFlightBtn.Size = new System.Drawing.Size(248, 45);
            this.ListFlightBtn.TabIndex = 17;
            this.ListFlightBtn.Text = "Add Filght";
            this.ListFlightBtn.UseVisualStyleBackColor = false;
            // 
            // ListAirportBtn
            // 
            this.ListAirportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ListAirportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListAirportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListAirportBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.ListAirportBtn.ForeColor = System.Drawing.Color.White;
            this.ListAirportBtn.Location = new System.Drawing.Point(12, 404);
            this.ListAirportBtn.Name = "ListAirportBtn";
            this.ListAirportBtn.Size = new System.Drawing.Size(248, 45);
            this.ListAirportBtn.TabIndex = 16;
            this.ListAirportBtn.Text = "Add Airport";
            this.ListAirportBtn.UseVisualStyleBackColor = false;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Location = new System.Drawing.Point(12, 526);
            this.LogoutBtn.Name = "LogoutBtn";
            this.LogoutBtn.Size = new System.Drawing.Size(248, 45);
            this.LogoutBtn.TabIndex = 15;
            this.LogoutBtn.Text = "Logout";
            this.LogoutBtn.UseVisualStyleBackColor = false;
            this.LogoutBtn.Click += new System.EventHandler(this.LogoutBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(47, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 27);
            this.label7.TabIndex = 14;
            this.label7.Text = "Staff\'s portal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlightTicketManagement.Properties.Resources.icons8_airplane_take_off_96;
            this.pictureBox1.Location = new System.Drawing.Point(84, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Flight Ticket Management System";
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 746);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffForm";
            this.Text = "Form1";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.Button ListAccountBtn;
        private System.Windows.Forms.Button ListFlightBtn;
        private System.Windows.Forms.Button ListAirportBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}