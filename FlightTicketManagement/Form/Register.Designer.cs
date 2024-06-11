namespace FlightTicketManagement
{
    partial class Register
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
            this.HidePassLb = new System.Windows.Forms.Label();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.PassTb = new System.Windows.Forms.TextBox();
            this.EmailTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PassAgainTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BackToLoginLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HidePassLb
            // 
            this.HidePassLb.AutoSize = true;
            this.HidePassLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HidePassLb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HidePassLb.Location = new System.Drawing.Point(425, 223);
            this.HidePassLb.Name = "HidePassLb";
            this.HidePassLb.Size = new System.Drawing.Size(128, 19);
            this.HidePassLb.TabIndex = 13;
            this.HidePassLb.Text = "Hiển thị mật khẩu";
            this.HidePassLb.Click += new System.EventHandler(this.HidePassLb_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Location = new System.Drawing.Point(201, 263);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(251, 52);
            this.RegisterBtn.TabIndex = 12;
            this.RegisterBtn.Text = "Đăng ký";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // PassTb
            // 
            this.PassTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassTb.Location = new System.Drawing.Point(294, 108);
            this.PassTb.Name = "PassTb";
            this.PassTb.PasswordChar = '•';
            this.PassTb.Size = new System.Drawing.Size(259, 30);
            this.PassTb.TabIndex = 10;
            // 
            // EmailTb
            // 
            this.EmailTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTb.Location = new System.Drawing.Point(294, 46);
            this.EmailTb.Name = "EmailTb";
            this.EmailTb.Size = new System.Drawing.Size(259, 30);
            this.EmailTb.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Địa chỉ emali";
            // 
            // PassAgainTb
            // 
            this.PassAgainTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassAgainTb.Location = new System.Drawing.Point(294, 171);
            this.PassAgainTb.Name = "PassAgainTb";
            this.PassAgainTb.PasswordChar = '•';
            this.PassAgainTb.Size = new System.Drawing.Size(259, 30);
            this.PassAgainTb.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(74, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Xác nhận mật khẩu";
            // 
            // BackToLoginLb
            // 
            this.BackToLoginLb.AutoSize = true;
            this.BackToLoginLb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackToLoginLb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackToLoginLb.Location = new System.Drawing.Point(281, 333);
            this.BackToLoginLb.Name = "BackToLoginLb";
            this.BackToLoginLb.Size = new System.Drawing.Size(125, 19);
            this.BackToLoginLb.TabIndex = 16;
            this.BackToLoginLb.Text = "Đã có tài khoản ?";
            this.BackToLoginLb.Click += new System.EventHandler(this.BackToLoginLb_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 373);
            this.Controls.Add(this.BackToLoginLb);
            this.Controls.Add(this.PassAgainTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HidePassLb);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.PassTb);
            this.Controls.Add(this.EmailTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HidePassLb;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.TextBox PassTb;
        private System.Windows.Forms.TextBox EmailTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PassAgainTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BackToLoginLb;
    }
}