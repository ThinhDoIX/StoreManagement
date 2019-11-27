namespace StoreManager
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_forgetPassword = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_about);
            this.groupBox1.Controls.Add(this.btn_forgetPassword);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Controls.Add(this.lbl_password);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(this.lbl_username);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 185);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_about
            // 
            this.btn_about.Location = new System.Drawing.Point(204, 130);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(115, 40);
            this.btn_about.TabIndex = 5;
            this.btn_about.Text = "Giới thiệu";
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_forgetPassword
            // 
            this.btn_forgetPassword.Location = new System.Drawing.Point(28, 130);
            this.btn_forgetPassword.Name = "btn_forgetPassword";
            this.btn_forgetPassword.Size = new System.Drawing.Size(140, 40);
            this.btn_forgetPassword.TabIndex = 4;
            this.btn_forgetPassword.Text = "Quên mật khẩu";
            this.btn_forgetPassword.UseVisualStyleBackColor = true;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(325, 130);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(115, 40);
            this.btn_login.TabIndex = 3;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            this.btn_login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_login_KeyDown);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_password.Location = new System.Drawing.Point(204, 81);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(236, 30);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "password";
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_password_KeyDown);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(23, 86);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(93, 25);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Mật khẩu";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_username.Location = new System.Drawing.Point(204, 35);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(236, 30);
            this.txt_username.TabIndex = 1;
            this.txt_username.Text = "Nhập username";
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            this.txt_username.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_username_KeyDown);
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(23, 40);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(145, 25);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "Tên đăng nhập";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 205);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Login_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_about;
        private System.Windows.Forms.Button btn_forgetPassword;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_password;
    }
}

