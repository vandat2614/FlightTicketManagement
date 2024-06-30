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
    public partial class RevenueForm : Form
    {
        public RevenueForm()
        {
            InitializeComponent();
        }

        public void LoadRevenueByMonth(string month)
        {
            if (SelectMonthCbb.SelectedIndex <= 0 && SelectYearCbb.SelectedIndex <= 0) return;
            List<MonthRevenueData> ListRevenue = Flight.Instance.GetRevenueByMonth(month);
            ListRevenueForm.DataSource = ListRevenue;
        }

        public void LoadRevenueByYear(string year)
        {
            if (SelectMonthCbb.SelectedIndex <= 0 && SelectYearCbb.SelectedIndex <= 0) return;
            List<YearRevenueData> ListRevenue = Flight.Instance.GetRevenueByYear(year);
            MessageBox.Show(ListRevenue.Count.ToString());
            ListRevenueForm.DataSource = ListRevenue;
        }

        private void RevenueForm_Load(object sender, EventArgs e)
        {
        }

        private void SelectMonthCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectMonthCbb.SelectedIndex <= 0) return;
            LoadRevenueByMonth(SelectMonthCbb.Text);
        }

        private void SelectYearCbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectYearCbb.SelectedIndex <= 0) return;
            LoadRevenueByYear(SelectYearCbb.Text);
        }
    }
}
