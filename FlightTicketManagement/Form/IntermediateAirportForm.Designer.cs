namespace FlightTicketManagement
{
    partial class IntermediateAirportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ListIntermediateAirportData = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.AddFlightBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SelectIntermediateAirportBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.IntermediateAirportStopTimeTb = new System.Windows.Forms.TextBox();
            this.IntermediateAirportNoteTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListIntermediateAirportData)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.ListIntermediateAirportData);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(13, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 390);
            this.panel2.TabIndex = 4;
            // 
            // ListIntermediateAirportData
            // 
            this.ListIntermediateAirportData.AllowUserToAddRows = false;
            this.ListIntermediateAirportData.AllowUserToDeleteRows = false;
            this.ListIntermediateAirportData.AllowUserToResizeColumns = false;
            this.ListIntermediateAirportData.AllowUserToResizeRows = false;
            this.ListIntermediateAirportData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListIntermediateAirportData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListIntermediateAirportData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ListIntermediateAirportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListIntermediateAirportData.EnableHeadersVisualStyles = false;
            this.ListIntermediateAirportData.Location = new System.Drawing.Point(25, 55);
            this.ListIntermediateAirportData.Name = "ListIntermediateAirportData";
            this.ListIntermediateAirportData.ReadOnly = true;
            this.ListIntermediateAirportData.RowHeadersVisible = false;
            this.ListIntermediateAirportData.RowHeadersWidth = 51;
            this.ListIntermediateAirportData.RowTemplate.Height = 24;
            this.ListIntermediateAirportData.Size = new System.Drawing.Size(391, 307);
            this.ListIntermediateAirportData.TabIndex = 17;
            this.ListIntermediateAirportData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListIntermediateAirportData_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(20, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "Intermediate Airport";
            // 
            // AddFlightBtn
            // 
            this.AddFlightBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.AddFlightBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFlightBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFlightBtn.ForeColor = System.Drawing.Color.White;
            this.AddFlightBtn.Location = new System.Drawing.Point(3, 322);
            this.AddFlightBtn.Name = "AddFlightBtn";
            this.AddFlightBtn.Size = new System.Drawing.Size(140, 40);
            this.AddFlightBtn.TabIndex = 12;
            this.AddFlightBtn.Text = "ADD";
            this.AddFlightBtn.UseVisualStyleBackColor = false;
            this.AddFlightBtn.Click += new System.EventHandler(this.AddFlightBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Controls.Add(this.IntermediateAirportNoteTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AddFlightBtn);
            this.panel1.Controls.Add(this.IntermediateAirportStopTimeTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SelectIntermediateAirportBtn);
            this.panel1.Location = new System.Drawing.Point(474, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 390);
            this.panel1.TabIndex = 13;
            // 
            // SelectIntermediateAirportBtn
            // 
            this.SelectIntermediateAirportBtn.BackColor = System.Drawing.Color.DarkGray;
            this.SelectIntermediateAirportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectIntermediateAirportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelectIntermediateAirportBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectIntermediateAirportBtn.ForeColor = System.Drawing.Color.White;
            this.SelectIntermediateAirportBtn.Location = new System.Drawing.Point(114, 31);
            this.SelectIntermediateAirportBtn.Name = "SelectIntermediateAirportBtn";
            this.SelectIntermediateAirportBtn.Size = new System.Drawing.Size(127, 33);
            this.SelectIntermediateAirportBtn.TabIndex = 37;
            this.SelectIntermediateAirportBtn.Text = "SELECT";
            this.SelectIntermediateAirportBtn.UseVisualStyleBackColor = false;
            this.SelectIntermediateAirportBtn.Click += new System.EventHandler(this.SelectIntermediateAirportBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 27);
            this.label1.TabIndex = 38;
            this.label1.Text = "Airport";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(284, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 39;
            this.label2.Text = "Duration";
            // 
            // IntermediateAirportStopTimeTb
            // 
            this.IntermediateAirportStopTimeTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntermediateAirportStopTimeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntermediateAirportStopTimeTb.Location = new System.Drawing.Point(399, 33);
            this.IntermediateAirportStopTimeTb.Name = "IntermediateAirportStopTimeTb";
            this.IntermediateAirportStopTimeTb.Size = new System.Drawing.Size(148, 30);
            this.IntermediateAirportStopTimeTb.TabIndex = 40;
            // 
            // IntermediateAirportNoteTb
            // 
            this.IntermediateAirportNoteTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IntermediateAirportNoteTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntermediateAirportNoteTb.Location = new System.Drawing.Point(114, 93);
            this.IntermediateAirportNoteTb.Multiline = true;
            this.IntermediateAirportNoteTb.Name = "IntermediateAirportNoteTb";
            this.IntermediateAirportNoteTb.Size = new System.Drawing.Size(433, 213);
            this.IntermediateAirportNoteTb.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 27);
            this.label3.TabIndex = 41;
            this.label3.Text = "Note";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Location = new System.Drawing.Point(441, 322);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(140, 40);
            this.ExitBtn.TabIndex = 43;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(149, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 40);
            this.button1.TabIndex = 44;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(295, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 40);
            this.button2.TabIndex = 45;
            this.button2.Text = "UPDATE";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // IntermediateAirportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 423);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IntermediateAirportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.IntermediateAirportForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListIntermediateAirportData)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ListIntermediateAirportData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddFlightBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SelectIntermediateAirportBtn;
        private System.Windows.Forms.TextBox IntermediateAirportNoteTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IntermediateAirportStopTimeTb;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}