﻿namespace FlightTicketManagement
{
    partial class AdminForm
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
            this.ExitBtn = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.RevenueBtn = new System.Windows.Forms.Button();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.ListAccountBtn = new System.Windows.Forms.Button();
            this.ListFlightBtn = new System.Windows.Forms.Button();
            this.ListAirportBtn = new System.Windows.Forms.Button();
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1471, 45);
            this.panel1.TabIndex = 1;
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
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.RevenueBtn);
            this.panel2.Controls.Add(this.SettingBtn);
            this.panel2.Controls.Add(this.ListAccountBtn);
            this.panel2.Controls.Add(this.ListFlightBtn);
            this.panel2.Controls.Add(this.ListAirportBtn);
            this.panel2.Controls.Add(this.LogoutBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 701);
            this.panel2.TabIndex = 2;
            // 
            // RevenueBtn
            // 
            this.RevenueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.RevenueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RevenueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RevenueBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.RevenueBtn.ForeColor = System.Drawing.Color.White;
            this.RevenueBtn.Location = new System.Drawing.Point(12, 417);
            this.RevenueBtn.Name = "RevenueBtn";
            this.RevenueBtn.Size = new System.Drawing.Size(248, 45);
            this.RevenueBtn.TabIndex = 21;
            this.RevenueBtn.Text = "Revenue";
            this.RevenueBtn.UseVisualStyleBackColor = false;
            this.RevenueBtn.Click += new System.EventHandler(this.RevenueBtn_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.SettingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.SettingBtn.ForeColor = System.Drawing.Color.White;
            this.SettingBtn.Location = new System.Drawing.Point(12, 494);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(248, 45);
            this.SettingBtn.TabIndex = 19;
            this.SettingBtn.Text = "Setting";
            this.SettingBtn.UseVisualStyleBackColor = false;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // ListAccountBtn
            // 
            this.ListAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ListAccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListAccountBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.ListAccountBtn.ForeColor = System.Drawing.Color.White;
            this.ListAccountBtn.Location = new System.Drawing.Point(12, 204);
            this.ListAccountBtn.Name = "ListAccountBtn";
            this.ListAccountBtn.Size = new System.Drawing.Size(248, 45);
            this.ListAccountBtn.TabIndex = 18;
            this.ListAccountBtn.Text = "User Account";
            this.ListAccountBtn.UseVisualStyleBackColor = false;
            this.ListAccountBtn.Click += new System.EventHandler(this.AccountBtn_Click);
            // 
            // ListFlightBtn
            // 
            this.ListFlightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ListFlightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListFlightBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.ListFlightBtn.ForeColor = System.Drawing.Color.White;
            this.ListFlightBtn.Location = new System.Drawing.Point(12, 270);
            this.ListFlightBtn.Name = "ListFlightBtn";
            this.ListFlightBtn.Size = new System.Drawing.Size(248, 45);
            this.ListFlightBtn.TabIndex = 17;
            this.ListFlightBtn.Text = "Add Filght";
            this.ListFlightBtn.UseVisualStyleBackColor = false;
            this.ListFlightBtn.Click += new System.EventHandler(this.FightBtn_Click);
            // 
            // ListAirportBtn
            // 
            this.ListAirportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ListAirportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListAirportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListAirportBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.ListAirportBtn.ForeColor = System.Drawing.Color.White;
            this.ListAirportBtn.Location = new System.Drawing.Point(12, 343);
            this.ListAirportBtn.Name = "ListAirportBtn";
            this.ListAirportBtn.Size = new System.Drawing.Size(248, 45);
            this.ListAirportBtn.TabIndex = 16;
            this.ListAirportBtn.Text = "Add Airport";
            this.ListAirportBtn.UseVisualStyleBackColor = false;
            this.ListAirportBtn.Click += new System.EventHandler(this.AirportBtn_Click_1);
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Location = new System.Drawing.Point(12, 571);
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
            this.label7.Location = new System.Drawing.Point(54, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 27);
            this.label7.TabIndex = 14;
            this.label7.Text = "Admin\'s portal";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(84, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(271, 45);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1200, 701);
            this.MainPanel.TabIndex = 3;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 746);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ExitBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ListAirportBtn;
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Button ListFlightBtn;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button ListAccountBtn;
        private System.Windows.Forms.Button SettingBtn;
        private System.Windows.Forms.Button RevenueBtn;
    }
}