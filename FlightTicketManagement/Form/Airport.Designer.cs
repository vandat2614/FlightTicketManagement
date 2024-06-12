namespace FlightTicketManagement
{
    partial class Airport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AirportID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AirportName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AirportLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AirportID,
            this.AirportName,
            this.AirportLocation});
            this.dataGridView1.Location = new System.Drawing.Point(152, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 299);
            this.dataGridView1.TabIndex = 1;
            // 
            // AirportID
            // 
            this.AirportID.HeaderText = "ID";
            this.AirportID.MinimumWidth = 6;
            this.AirportID.Name = "AirportID";
            this.AirportID.Width = 125;
            // 
            // AirportName
            // 
            this.AirportName.HeaderText = "Sân Bay";
            this.AirportName.MinimumWidth = 6;
            this.AirportName.Name = "AirportName";
            this.AirportName.Width = 125;
            // 
            // AirportLocation
            // 
            this.AirportLocation.HeaderText = "Địa Điểm";
            this.AirportLocation.MinimumWidth = 6;
            this.AirportLocation.Name = "AirportLocation";
            this.AirportLocation.Width = 125;
            // 
            // Airport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 573);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Airport";
            this.Text = "AIRPORT";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn AirportID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AirportName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AirportLocation;
    }
}