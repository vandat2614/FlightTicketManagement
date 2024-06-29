﻿namespace FlightTicketManagement
{
    partial class RegisterForm
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
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.PassRegisterTb = new System.Windows.Forms.TextBox();
            this.EmailRegisterTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ConfPassRegisterTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowPassCb = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.LoadLoginFormBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.RegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.RegisterBtn.ForeColor = System.Drawing.Color.White;
            this.RegisterBtn.Location = new System.Drawing.Point(375, 360);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(145, 40);
            this.RegisterBtn.TabIndex = 4;
            this.RegisterBtn.Text = "SIGN UP";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // PassRegisterTb
            // 
            this.PassRegisterTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassRegisterTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassRegisterTb.Location = new System.Drawing.Point(375, 195);
            this.PassRegisterTb.Name = "PassRegisterTb";
            this.PassRegisterTb.PasswordChar = '•';
            this.PassRegisterTb.Size = new System.Drawing.Size(259, 30);
            this.PassRegisterTb.TabIndex = 1;
            // 
            // EmailRegisterTb
            // 
            this.EmailRegisterTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EmailRegisterTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailRegisterTb.Location = new System.Drawing.Point(375, 127);
            this.EmailRegisterTb.Name = "EmailRegisterTb";
            this.EmailRegisterTb.Size = new System.Drawing.Size(259, 30);
            this.EmailRegisterTb.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.label2.Location = new System.Drawing.Point(371, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.label1.Location = new System.Drawing.Point(371, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email:";
            // 
            // ConfPassRegisterTb
            // 
            this.ConfPassRegisterTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfPassRegisterTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfPassRegisterTb.Location = new System.Drawing.Point(375, 260);
            this.ConfPassRegisterTb.Name = "ConfPassRegisterTb";
            this.ConfPassRegisterTb.PasswordChar = '•';
            this.ConfPassRegisterTb.Size = new System.Drawing.Size(259, 30);
            this.ConfPassRegisterTb.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.label3.Location = new System.Drawing.Point(371, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Confirm Password:";
            // 
            // ShowPassCb
            // 
            this.ShowPassCb.AutoSize = true;
            this.ShowPassCb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPassCb.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F);
            this.ShowPassCb.Location = new System.Drawing.Point(375, 311);
            this.ShowPassCb.Name = "ShowPassCb";
            this.ShowPassCb.Size = new System.Drawing.Size(174, 25);
            this.ShowPassCb.TabIndex = 3;
            this.ShowPassCb.Text = "Show Password";
            this.ShowPassCb.UseVisualStyleBackColor = true;
            this.ShowPassCb.CheckedChanged += new System.EventHandler(this.ShowPassCb_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LoadLoginFormBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(336, 484);
            this.panel1.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(306, 27);
            this.label7.TabIndex = 12;
            this.label7.Text = "Flight Ticket Management ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(122, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Already have an account";
            // 
            // LoadLoginFormBtn
            // 
            this.LoadLoginFormBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(99)))), ((int)(((byte)(102)))));
            this.LoadLoginFormBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoadLoginFormBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadLoginFormBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F);
            this.LoadLoginFormBtn.ForeColor = System.Drawing.Color.White;
            this.LoadLoginFormBtn.Location = new System.Drawing.Point(17, 424);
            this.LoadLoginFormBtn.Name = "LoadLoginFormBtn";
            this.LoadLoginFormBtn.Size = new System.Drawing.Size(301, 45);
            this.LoadLoginFormBtn.TabIndex = 5;
            this.LoadLoginFormBtn.Text = "SIGN IN";
            this.LoadLoginFormBtn.UseVisualStyleBackColor = false;
            this.LoadLoginFormBtn.Click += new System.EventHandler(this.LoadLoginFormBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(370, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 27);
            this.label4.TabIndex = 19;
            this.label4.Text = "SIGN UP";
            // 
            // ExitBtn
            // 
            this.ExitBtn.AutoSize = true;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(651, 9);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(22, 23);
            this.ExitBtn.TabIndex = 20;
            this.ExitBtn.Text = "X";
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 484);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ShowPassCb);
            this.Controls.Add(this.ConfPassRegisterTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.PassRegisterTb);
            this.Controls.Add(this.EmailRegisterTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.TextBox PassRegisterTb;
        private System.Windows.Forms.TextBox EmailRegisterTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ConfPassRegisterTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ShowPassCb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LoadLoginFormBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ExitBtn;
    }
}