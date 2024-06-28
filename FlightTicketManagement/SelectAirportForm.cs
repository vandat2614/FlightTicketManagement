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
    public partial class SelectAirportForm : Form
    {
        public SelectAirportForm()
        {
            InitializeComponent();
        }

        public string SelectedName { get; set; }
        public string SelectedCode { get; set; }


        public void LoadListAirport()
        {
            List<AirportData> airports = Airport.Instance.GetListAirport();

            for (int i = airports.Count - 1; i >= 0; i--)
            {
                if (airports[i].status.ToLower() == "stop")
                {
                    airports.RemoveAt(i);
                }
            }

            ListAirportData.DataSource = airports;
        }

        private void ListAirportData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <0 || e.ColumnIndex <0) return;
            DataGridViewRow row = ListAirportData.Rows[e.RowIndex];
            SelectedCode = row.Cells[0].Value.ToString();
            SelectedName = row.Cells[1].Value.ToString();
        }

        private void SelectAirportForm_Load(object sender, EventArgs e)
        {
            LoadListAirport();
        }

        private void SelectBtn_Click(object sender, EventArgs e)
        {
           this.Hide();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            SelectedCode = SelectedName = null;
            this.Hide();
        }
    }
}
