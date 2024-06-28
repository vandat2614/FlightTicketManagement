namespace FlightTicketManagement
{
    partial class ListAccountForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddAccountBtn = new System.Windows.Forms.Button();
            this.AccountTypeCbb = new System.Windows.Forms.ComboBox();
            this.UpdateAccountBtn = new System.Windows.Forms.Button();
            this.AccountPhoneTb = new System.Windows.Forms.TextBox();
            this.ClearInfoBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DeleteAccountBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AccountNameTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AccountPassTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AccountEmailTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.ListAccountData = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListAccountData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.AddAccountBtn);
            this.panel1.Controls.Add(this.AccountTypeCbb);
            this.panel1.Controls.Add(this.UpdateAccountBtn);
            this.panel1.Controls.Add(this.AccountPhoneTb);
            this.panel1.Controls.Add(this.ClearInfoBtn);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.DeleteAccountBtn);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AccountNameTb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.AccountPassTb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AccountEmailTb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 399);
            this.panel1.TabIndex = 2;
            // 
            // AddAccountBtn
            // 
            this.AddAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.AddAccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAccountBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddAccountBtn.ForeColor = System.Drawing.Color.White;
            this.AddAccountBtn.Location = new System.Drawing.Point(26, 268);
            this.AddAccountBtn.Name = "AddAccountBtn";
            this.AddAccountBtn.Size = new System.Drawing.Size(150, 40);
            this.AddAccountBtn.TabIndex = 5;
            this.AddAccountBtn.Text = "ADD";
            this.AddAccountBtn.UseVisualStyleBackColor = false;
            this.AddAccountBtn.Click += new System.EventHandler(this.AddAccountBtn_Click);
            // 
            // AccountTypeCbb
            // 
            this.AccountTypeCbb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AccountTypeCbb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountTypeCbb.FormattingEnabled = true;
            this.AccountTypeCbb.Items.AddRange(new object[] {
            "Admin",
            "Staff",
            "Customer"});
            this.AccountTypeCbb.Location = new System.Drawing.Point(109, 153);
            this.AccountTypeCbb.Name = "AccountTypeCbb";
            this.AccountTypeCbb.Size = new System.Drawing.Size(247, 30);
            this.AccountTypeCbb.TabIndex = 3;
            // 
            // UpdateAccountBtn
            // 
            this.UpdateAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.UpdateAccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateAccountBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateAccountBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateAccountBtn.Location = new System.Drawing.Point(206, 268);
            this.UpdateAccountBtn.Name = "UpdateAccountBtn";
            this.UpdateAccountBtn.Size = new System.Drawing.Size(150, 40);
            this.UpdateAccountBtn.TabIndex = 6;
            this.UpdateAccountBtn.Text = "UPDATE";
            this.UpdateAccountBtn.UseVisualStyleBackColor = false;
            this.UpdateAccountBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // AccountPhoneTb
            // 
            this.AccountPhoneTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountPhoneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountPhoneTb.Location = new System.Drawing.Point(109, 203);
            this.AccountPhoneTb.Name = "AccountPhoneTb";
            this.AccountPhoneTb.Size = new System.Drawing.Size(247, 30);
            this.AccountPhoneTb.TabIndex = 4;
            // 
            // ClearInfoBtn
            // 
            this.ClearInfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.ClearInfoBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearInfoBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearInfoBtn.ForeColor = System.Drawing.Color.White;
            this.ClearInfoBtn.Location = new System.Drawing.Point(26, 332);
            this.ClearInfoBtn.Name = "ClearInfoBtn";
            this.ClearInfoBtn.Size = new System.Drawing.Size(150, 40);
            this.ClearInfoBtn.TabIndex = 7;
            this.ClearInfoBtn.Text = "CLEAR";
            this.ClearInfoBtn.UseVisualStyleBackColor = false;
            this.ClearInfoBtn.Click += new System.EventHandler(this.ClearInfoBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 15;
            this.label6.Text = "Phone:";
            // 
            // DeleteAccountBtn
            // 
            this.DeleteAccountBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.DeleteAccountBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteAccountBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteAccountBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteAccountBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteAccountBtn.Location = new System.Drawing.Point(206, 332);
            this.DeleteAccountBtn.Name = "DeleteAccountBtn";
            this.DeleteAccountBtn.Size = new System.Drawing.Size(150, 40);
            this.DeleteAccountBtn.TabIndex = 8;
            this.DeleteAccountBtn.Text = "DELETE";
            this.DeleteAccountBtn.UseVisualStyleBackColor = false;
            this.DeleteAccountBtn.Click += new System.EventHandler(this.DeleteAccountBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Type";
            // 
            // AccountNameTb
            // 
            this.AccountNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountNameTb.Location = new System.Drawing.Point(109, 109);
            this.AccountNameTb.Name = "AccountNameTb";
            this.AccountNameTb.Size = new System.Drawing.Size(247, 30);
            this.AccountNameTb.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Name:";
            // 
            // AccountPassTb
            // 
            this.AccountPassTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountPassTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountPassTb.Location = new System.Drawing.Point(109, 63);
            this.AccountPassTb.Name = "AccountPassTb";
            this.AccountPassTb.Size = new System.Drawing.Size(247, 30);
            this.AccountPassTb.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pass:";
            // 
            // AccountEmailTb
            // 
            this.AccountEmailTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccountEmailTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountEmailTb.Location = new System.Drawing.Point(109, 20);
            this.AccountEmailTb.Name = "AccountEmailTb";
            this.AccountEmailTb.Size = new System.Drawing.Size(247, 30);
            this.AccountEmailTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.ListAccountData);
            this.panel2.Location = new System.Drawing.Point(424, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 592);
            this.panel2.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(29, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 27);
            this.label7.TabIndex = 16;
            this.label7.Text = "Account List";
            // 
            // ListAccountData
            // 
            this.ListAccountData.AllowUserToAddRows = false;
            this.ListAccountData.AllowUserToDeleteRows = false;
            this.ListAccountData.AllowUserToResizeColumns = false;
            this.ListAccountData.AllowUserToResizeRows = false;
            this.ListAccountData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListAccountData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListAccountData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ListAccountData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListAccountData.EnableHeadersVisualStyles = false;
            this.ListAccountData.Location = new System.Drawing.Point(34, 63);
            this.ListAccountData.Name = "ListAccountData";
            this.ListAccountData.ReadOnly = true;
            this.ListAccountData.RowHeadersVisible = false;
            this.ListAccountData.RowHeadersWidth = 51;
            this.ListAccountData.RowTemplate.Height = 24;
            this.ListAccountData.Size = new System.Drawing.Size(694, 490);
            this.ListAccountData.TabIndex = 0;
            this.ListAccountData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListAccountData_CellClick_1);
            // 
            // Admin_UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Admin_UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminUsers_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListAccountData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ClearInfoBtn;
        private System.Windows.Forms.Button DeleteAccountBtn;
        private System.Windows.Forms.Button UpdateAccountBtn;
        private System.Windows.Forms.Button AddAccountBtn;
        private System.Windows.Forms.TextBox AccountPassTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AccountEmailTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView ListAccountData;
        private System.Windows.Forms.TextBox AccountPhoneTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AccountNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AccountTypeCbb;
    }
}