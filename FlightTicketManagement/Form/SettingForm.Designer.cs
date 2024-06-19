namespace FlightTicketManagement
{
    partial class SettingForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaxTimeStopTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MinTimeStopTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UpdateSettingBtn = new System.Windows.Forms.Button();
            this.MaxIntermediateAirportTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MinFlightDurationTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.MaxTimeStopTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.MinTimeStopTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.UpdateSettingBtn);
            this.panel1.Controls.Add(this.MaxIntermediateAirportTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.MinFlightDurationTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(44, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 359);
            this.panel1.TabIndex = 3;
            // 
            // MaxTimeStopTb
            // 
            this.MaxTimeStopTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxTimeStopTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxTimeStopTb.Location = new System.Drawing.Point(330, 172);
            this.MaxTimeStopTb.Name = "MaxTimeStopTb";
            this.MaxTimeStopTb.Size = new System.Drawing.Size(266, 30);
            this.MaxTimeStopTb.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Max Time Stop:";
            // 
            // MinTimeStopTb
            // 
            this.MinTimeStopTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinTimeStopTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinTimeStopTb.Location = new System.Drawing.Point(330, 124);
            this.MinTimeStopTb.Name = "MinTimeStopTb";
            this.MinTimeStopTb.Size = new System.Drawing.Size(266, 30);
            this.MinTimeStopTb.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Min Time Stop:";
            // 
            // UpdateSettingBtn
            // 
            this.UpdateSettingBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.UpdateSettingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateSettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateSettingBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSettingBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateSettingBtn.Location = new System.Drawing.Point(230, 269);
            this.UpdateSettingBtn.Name = "UpdateSettingBtn";
            this.UpdateSettingBtn.Size = new System.Drawing.Size(145, 40);
            this.UpdateSettingBtn.TabIndex = 8;
            this.UpdateSettingBtn.Text = "UPDATE";
            this.UpdateSettingBtn.UseVisualStyleBackColor = false;
            this.UpdateSettingBtn.Click += new System.EventHandler(this.UpdateSettingBtn_Click);
            // 
            // MaxIntermediateAirportTb
            // 
            this.MaxIntermediateAirportTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxIntermediateAirportTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxIntermediateAirportTb.Location = new System.Drawing.Point(330, 78);
            this.MaxIntermediateAirportTb.Name = "MaxIntermediateAirportTb";
            this.MaxIntermediateAirportTb.Size = new System.Drawing.Size(266, 30);
            this.MaxIntermediateAirportTb.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max Intermediate Airport:";
            // 
            // MinFlightDurationTb
            // 
            this.MinFlightDurationTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinFlightDurationTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinFlightDurationTb.Location = new System.Drawing.Point(330, 31);
            this.MinFlightDurationTb.Name = "MinFlightDurationTb";
            this.MinFlightDurationTb.Size = new System.Drawing.Size(266, 30);
            this.MinFlightDurationTb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Min Flight Duration:";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 436);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MinTimeStopTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateSettingBtn;
        private System.Windows.Forms.TextBox MaxIntermediateAirportTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MinFlightDurationTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaxTimeStopTb;
    }
}