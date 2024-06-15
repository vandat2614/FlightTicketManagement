using System;
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
    public partial class Admin_AirportForm : Form
    {
        public Admin_AirportForm()
        {
            InitializeComponent();
        }

        public bool CheckEmpty()
        {
            if (AirportNameTb.Text == "" || AirportCityCbb.Text == "")
                return true;
            return false;
        }

        public void LoadListAirport()
        {
            List<AirportInfo> airports = Airport.Instance.GetListAirport();
            ListAirportGv.DataSource = airports;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
             else
            {
                Airport.Instance.add_airport(AirportNameTb.Text, AirportCityCbb.Text);
                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListAirport();
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult result = MessageBox.Show("Are you want to update", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Airport.Instance.update_airport(id_airport_update, AirportNameTb.Text, AirportCityCbb.Text);
                    MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadListAirport();
                }
            }
        }

        public string id_airport_update = null;
        private void ListAirportGv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = ListAirportGv.Rows[e.RowIndex];
            id_airport_update = row.Cells[0].Value.ToString();
            AirportNameTb.Text = row.Cells[1].Value.ToString();
            AirportCityCbb.Text = row.Cells[2].Value.ToString();
        }

        private void Admin_AirportForm_Load(object sender, EventArgs e)
        {
            LoadListAirport();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            AirportNameTb.Text = "";
            AirportCityCbb.Text = "";
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Airport.Instance.delete_airport(id_airport_update);
                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListAirport();
            }
        }
    }
}
