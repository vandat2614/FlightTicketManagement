namespace FlightTicketManagement
{
    partial class RevenueForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListRevenueForm = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.SelectMonthCbb = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectYearCbb = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListRevenueForm)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.ListRevenueForm);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1176, 629);
            this.panel2.TabIndex = 3;
            // 
            // ListRevenueForm
            // 
            this.ListRevenueForm.AllowUserToAddRows = false;
            this.ListRevenueForm.AllowUserToDeleteRows = false;
            this.ListRevenueForm.AllowUserToResizeColumns = false;
            this.ListRevenueForm.AllowUserToResizeRows = false;
            this.ListRevenueForm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListRevenueForm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListRevenueForm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.ListRevenueForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListRevenueForm.EnableHeadersVisualStyles = false;
            this.ListRevenueForm.Location = new System.Drawing.Point(30, 94);
            this.ListRevenueForm.Name = "ListRevenueForm";
            this.ListRevenueForm.ReadOnly = true;
            this.ListRevenueForm.RowHeadersVisible = false;
            this.ListRevenueForm.RowHeadersWidth = 51;
            this.ListRevenueForm.RowTemplate.Height = 24;
            this.ListRevenueForm.Size = new System.Drawing.Size(1124, 392);
            this.ListRevenueForm.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.SelectYearCbb);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.SelectMonthCbb);
            this.panel3.Location = new System.Drawing.Point(30, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1124, 51);
            this.panel3.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 21);
            this.label9.TabIndex = 46;
            this.label9.Text = "Month";
            // 
            // SelectMonthCbb
            // 
            this.SelectMonthCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectMonthCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectMonthCbb.FormattingEnabled = true;
            this.SelectMonthCbb.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.SelectMonthCbb.Location = new System.Drawing.Point(78, 13);
            this.SelectMonthCbb.Name = "SelectMonthCbb";
            this.SelectMonthCbb.Size = new System.Drawing.Size(180, 30);
            this.SelectMonthCbb.TabIndex = 47;
            this.SelectMonthCbb.SelectedIndexChanged += new System.EventHandler(this.SelectMonthCbb_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(357, 301);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 27);
            this.label7.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(860, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 48;
            this.label1.Text = "Year";
            // 
            // SelectYearCbb
            // 
            this.SelectYearCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectYearCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectYearCbb.FormattingEnabled = true;
            this.SelectYearCbb.Items.AddRange(new object[] {
            "None",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.SelectYearCbb.Location = new System.Drawing.Point(917, 13);
            this.SelectYearCbb.Name = "SelectYearCbb";
            this.SelectYearCbb.Size = new System.Drawing.Size(180, 30);
            this.SelectYearCbb.TabIndex = 49;
            this.SelectYearCbb.SelectedIndexChanged += new System.EventHandler(this.SelectYearCbb_SelectedIndexChanged);
            // 
            // RevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RevenueForm";
            this.Text = "RevenueForm";
            this.Load += new System.EventHandler(this.RevenueForm_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListRevenueForm)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ListRevenueForm;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox SelectMonthCbb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox SelectYearCbb;
    }
}