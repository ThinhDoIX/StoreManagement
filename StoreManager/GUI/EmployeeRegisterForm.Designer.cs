namespace StoreManager.GUI
{
    partial class EmployeeRegisterForm
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
            this.btn_reg_reset = new System.Windows.Forms.Button();
            this.btn_reg_register = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_reg_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_reg_username = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_reg_phone = new System.Windows.Forms.MaskedTextBox();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.ckb_female = new System.Windows.Forms.CheckBox();
            this.ckb_male = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_reg_address = new System.Windows.Forms.TextBox();
            this.txt_reg_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_reg_fullname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_reg_reset);
            this.panel1.Controls.Add(this.btn_reg_register);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 412);
            this.panel1.TabIndex = 0;
            // 
            // btn_reg_reset
            // 
            this.btn_reg_reset.Location = new System.Drawing.Point(12, 367);
            this.btn_reg_reset.Name = "btn_reg_reset";
            this.btn_reg_reset.Size = new System.Drawing.Size(199, 42);
            this.btn_reg_reset.TabIndex = 5;
            this.btn_reg_reset.Text = "Reset";
            this.btn_reg_reset.UseVisualStyleBackColor = true;
            this.btn_reg_reset.Click += new System.EventHandler(this.btn_reg_reset_Click);
            // 
            // btn_reg_register
            // 
            this.btn_reg_register.Location = new System.Drawing.Point(217, 367);
            this.btn_reg_register.Name = "btn_reg_register";
            this.btn_reg_register.Size = new System.Drawing.Size(210, 42);
            this.btn_reg_register.TabIndex = 4;
            this.btn_reg_register.Text = "Tạo nhân viên";
            this.btn_reg_register.UseVisualStyleBackColor = true;
            this.btn_reg_register.Click += new System.EventHandler(this.btn_reg_register_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_reg_password);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txt_reg_username);
            this.groupBox2.Location = new System.Drawing.Point(3, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 107);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mật khẩu:";
            // 
            // txt_reg_password
            // 
            this.txt_reg_password.Location = new System.Drawing.Point(103, 68);
            this.txt_reg_password.Name = "txt_reg_password";
            this.txt_reg_password.Size = new System.Drawing.Size(321, 22);
            this.txt_reg_password.TabIndex = 3;
            this.txt_reg_password.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Usename:";
            // 
            // txt_reg_username
            // 
            this.txt_reg_username.Location = new System.Drawing.Point(103, 31);
            this.txt_reg_username.Name = "txt_reg_username";
            this.txt_reg_username.Size = new System.Drawing.Size(321, 22);
            this.txt_reg_username.TabIndex = 1;
            this.txt_reg_username.TextChanged += new System.EventHandler(this.txt_reg_username_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_ngaysinh);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_reg_phone);
            this.groupBox1.Controls.Add(this.cb_role);
            this.groupBox1.Controls.Add(this.ckb_female);
            this.groupBox1.Controls.Add(this.ckb_male);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_reg_address);
            this.groupBox1.Controls.Add(this.txt_reg_email);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_reg_fullname);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 245);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cá nhân";
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.CustomFormat = "yyyy-MM-dd";
            this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaysinh.Location = new System.Drawing.Point(104, 179);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(320, 22);
            this.dtp_ngaysinh.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Ngày sinh:";
            // 
            // txt_reg_phone
            // 
            this.txt_reg_phone.Location = new System.Drawing.Point(104, 84);
            this.txt_reg_phone.Mask = "(+84) 00-0000-000";
            this.txt_reg_phone.Name = "txt_reg_phone";
            this.txt_reg_phone.Size = new System.Drawing.Size(320, 22);
            this.txt_reg_phone.TabIndex = 15;
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "nhân viên bán hàng",
            "thủ kho"});
            this.cb_role.Location = new System.Drawing.Point(103, 208);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(321, 24);
            this.cb_role.TabIndex = 14;
            // 
            // ckb_female
            // 
            this.ckb_female.AutoSize = true;
            this.ckb_female.Location = new System.Drawing.Point(207, 60);
            this.ckb_female.Name = "ckb_female";
            this.ckb_female.Size = new System.Drawing.Size(48, 21);
            this.ckb_female.TabIndex = 13;
            this.ckb_female.Text = "Nữ";
            this.ckb_female.UseVisualStyleBackColor = true;
            // 
            // ckb_male
            // 
            this.ckb_male.AutoSize = true;
            this.ckb_male.Location = new System.Drawing.Point(103, 60);
            this.ckb_male.Name = "ckb_male";
            this.ckb_male.Size = new System.Drawing.Size(59, 21);
            this.ckb_male.TabIndex = 12;
            this.ckb_male.Text = "Nam";
            this.ckb_male.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Chức vụ:";
            // 
            // txt_reg_address
            // 
            this.txt_reg_address.Location = new System.Drawing.Point(103, 144);
            this.txt_reg_address.Multiline = true;
            this.txt_reg_address.Name = "txt_reg_address";
            this.txt_reg_address.Size = new System.Drawing.Size(321, 29);
            this.txt_reg_address.TabIndex = 7;
            // 
            // txt_reg_email
            // 
            this.txt_reg_email.Location = new System.Drawing.Point(103, 116);
            this.txt_reg_email.Name = "txt_reg_email";
            this.txt_reg_email.Size = new System.Drawing.Size(321, 22);
            this.txt_reg_email.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên:";
            // 
            // txt_reg_fullname
            // 
            this.txt_reg_fullname.Location = new System.Drawing.Point(103, 31);
            this.txt_reg_fullname.Name = "txt_reg_fullname";
            this.txt_reg_fullname.Size = new System.Drawing.Size(321, 22);
            this.txt_reg_fullname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điền thông tin";
            // 
            // EmployeeRegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 466);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeRegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  ";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_reg_reset;
        private System.Windows.Forms.Button btn_reg_register;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_reg_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_reg_username;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_reg_address;
        private System.Windows.Forms.TextBox txt_reg_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_reg_fullname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckb_female;
        private System.Windows.Forms.CheckBox ckb_male;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.MaskedTextBox txt_reg_phone;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.Label label10;
    }
}