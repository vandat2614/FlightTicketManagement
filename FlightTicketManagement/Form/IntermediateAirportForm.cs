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
    public partial class IntermediateAirportForm : Form
    {
        public string selected { get; set; }
        public IntermediateAirportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selected = TextHEHE.Text;
            this.Hide();
        }
    }
}
