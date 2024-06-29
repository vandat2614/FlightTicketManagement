using FlightTicketManagement.QuerySQL;
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
    public partial class ListTicketForm : Form
    {
        public ListTicketForm()
        {
            InitializeComponent();
        }


        public void LoadListFlight()
        {

            FlightCodeCbb.Items.Clear();
            FlightCodeCbb.DataSource = Flight.Instance.GetListFlightCode();
        }

        private void ListTicketForm_Load(object sender, EventArgs e)
        {
            LoadListFlight();
            LoadListTicket(Ticket.Instance.GetListTicket());
            FlightCodeCbb.SelectedIndex = -1;
        }

        public void LoadListTicket(List<TicketData> ListTicket)
        {
            ListTicketData.DataSource = ListTicket;
        }
        
        private void SearchFlightBtn_Click(object sender, EventArgs e)
        {
            if (FlightCodeCbb.SelectedIndex == -1) return;
            LoadListTicket(Ticket.Instance.GetListTicket(FlightCodeCbb.Text));

        }

        public string SelectedTicketCode = null;
        private void ListTicketData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0 || e.ColumnIndex < 0) return;
            DataGridViewRow row = ListTicketData.Rows[e.RowIndex];
            SelectedTicketCode = row.Cells[0].Value.ToString();

            CustomerNameTb.Text = row.Cells[2].Value.ToString();
            CMNDTb.Text = row.Cells[3].Value.ToString();
            CustomerPhoneTb.Text = row.Cells[4].Value.ToString();
            SeatTypeCbb.SelectedIndex = int.Parse(row.Cells[5].Value.ToString())-1;
            TicketPriceTb.Text = row.Cells[6].Value.ToString();

            if (row.Cells[7].Value.ToString() == "buy")
                TicketTypeCbb.SelectedIndex = 0;
            else
                TicketTypeCbb.SelectedIndex = 1;
        }

        private void DeleteTicketBtn_Click(object sender, EventArgs e)
        {
            if (SelectedTicketCode == null) return;
            DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Ticket.Instance.DeleteTicket(SelectedTicketCode);
                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListTicket(Ticket.Instance.GetListTicket(FlightCodeCbb.Text));
            }
        }

        private void UpdateTicketBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you want to update", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Ticket.Instance.UpdateTicket(SelectedTicketCode, CustomerNameTb.Text, CMNDTb.Text, CustomerPhoneTb.Text, SeatTypeCbb.Text, TicketPriceTb.Text, TicketTypeCbb.Text); 
                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListTicket(Ticket.Instance.GetListTicket(FlightCodeCbb.Text));

            }
        }
    }
}
