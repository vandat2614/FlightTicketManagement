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
            this.LogoutBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TicketBtn = new System.Windows.Forms.Button();
            this.ListTicketBtn = new System.Windows.Forms.Button();
            this.RevenueBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
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
            this.panel2.Controls.Add(this.RevenueBtn);
            this.panel2.Controls.Add(this.ListTicketBtn);
            this.panel2.Controls.Add(this.TicketBtn);
            this.panel2.Controls.Add(this.LogoutBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 746);
            this.panel2.TabIndex = 5;
            // 
            // LogoutBtn
            // 
            this.LogoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.LogoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.LogoutBtn.ForeColor = System.Drawing.Color.White;
            this.LogoutBtn.Location = new System.Drawing.Point(12, 443);
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
            this.label7.Location = new System.Drawing.Point(60, 130);
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
            // TicketBtn
            // 
            this.TicketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.TicketBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TicketBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.TicketBtn.ForeColor = System.Drawing.Color.White;
            this.TicketBtn.Location = new System.Drawing.Point(12, 241);
            this.TicketBtn.Name = "TicketBtn";
            this.TicketBtn.Size = new System.Drawing.Size(248, 45);
            this.TicketBtn.TabIndex = 20;
            this.TicketBtn.Text = "Ticket";
            this.TicketBtn.UseVisualStyleBackColor = false;
            this.TicketBtn.Click += new System.EventHandler(this.TicketBtn_Click);
            // 
            // ListTicketBtn
            // 
            this.ListTicketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ListTicketBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ListTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListTicketBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.ListTicketBtn.ForeColor = System.Drawing.Color.White;
            this.ListTicketBtn.Location = new System.Drawing.Point(12, 307);
            this.ListTicketBtn.Name = "ListTicketBtn";
            this.ListTicketBtn.Size = new System.Drawing.Size(248, 45);
            this.ListTicketBtn.TabIndex = 21;
            this.ListTicketBtn.Text = "List Ticket";
            this.ListTicketBtn.UseVisualStyleBackColor = false;
            this.ListTicketBtn.Click += new System.EventHandler(this.ListTicketBtn_Click);
            // 
            // RevenueBtn
            // 
            this.RevenueBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.RevenueBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RevenueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RevenueBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.RevenueBtn.ForeColor = System.Drawing.Color.White;
            this.RevenueBtn.Location = new System.Drawing.Point(12, 373);
            this.RevenueBtn.Name = "RevenueBtn";
            this.RevenueBtn.Size = new System.Drawing.Size(248, 45);
            this.RevenueBtn.TabIndex = 22;
            this.RevenueBtn.Text = "Revenue";
            this.RevenueBtn.UseVisualStyleBackColor = false;
            this.RevenueBtn.Click += new System.EventHandler(this.RevenueBtn_Click);
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
        private System.Windows.Forms.Button LogoutBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button TicketBtn;
        private System.Windows.Forms.Button ListTicketBtn;
        private System.Windows.Forms.Button RevenueBtn;
    }
}