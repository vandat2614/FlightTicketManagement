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
    public partial class Admin_FlightForm : Form
    {
        public Admin_FlightForm()
        {
            InitializeComponent();
        }

        public void LoadListFlight()
        {
            List<FlightInfo> flights = Flight.Instance.GetListFlightt();
            ListFlightGv.DataSource = flights;
        }

        private void Admin_FlightForm_Load(object sender, EventArgs e)
        {
            LoadListFlight();
        }

        public bool CheckEmpty()
        {
            if(CodeTb.Text == "" || PriceTb.Text == "" || StartCbb.Text == "" || DesCbb.Text == "" || Seat1Tb.Text == "" || Seat2Tb.Text == "")
                return true;
            return false;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (CheckEmpty())
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (Flight.Instance.check_flight_code(CodeTb.Text))
                MessageBox.Show("This flight code is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Flight.Instance.add_flight(CodeTb.Text, StartCbb.Text, DesCbb.Text, DatePk.Text + DateTimePk.Text, TimeFlightPk.Text, PriceTb.Text, Seat1Tb.Text, Seat2Tb.Text);
                MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListFlight();
            }
        }
    }
}
