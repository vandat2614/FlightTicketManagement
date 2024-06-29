﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightTicketManagement
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }


        private void ExitBtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Sign out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().ShowDialog();
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to Sign out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                this.Hide();
                new LoginForm().ShowDialog();
            }
        }

        public void LoadForm(object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
                this.MainPanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(f);
            this.MainPanel.Tag = f;
            f.Show();

        }

        private void AirportBtn_Click_1(object sender, EventArgs e)
        {
            LoadForm(new ListAirportForm());
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new ListAccountForm());
        }

        private void FightBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new FlightForm());

        }

        private void SettingBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new SettingForm());
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TicketBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new TicketForm());

        }

        private void ListTicketBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new ListTicketForm());
        }

        private void RevenueBtn_Click(object sender, EventArgs e)
        {
            LoadForm(new RevenueForm());
        }
    }
}
