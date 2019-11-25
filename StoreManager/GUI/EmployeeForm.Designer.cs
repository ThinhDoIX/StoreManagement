namespace StoreManager
{
    partial class EmployeeForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_maNV = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_gioitinh = new System.Windows.Forms.ComboBox();
            this.txt_sodienthoai = new System.Windows.Forms.MaskedTextBox();
            this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.lbl_sodiennthoai = new System.Windows.Forms.Label();
            this.txt_luong = new System.Windows.Forms.TextBox();
            this.lbl_luong = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.lbl_diachi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_typechoice = new System.Windows.Forms.Label();
            this.cb_typesearch = new System.Windows.Forms.ComboBox();
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.cltenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clsodienthoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clgioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clchucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_khoiphuc = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 626);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lbl_maNV);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(3, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 489);
            this.panel2.TabIndex = 1;
            // 
            // lbl_maNV
            // 
            this.lbl_maNV.AutoSize = true;
            this.lbl_maNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_maNV.Location = new System.Drawing.Point(269, 145);
            this.lbl_maNV.Name = "lbl_maNV";
            this.lbl_maNV.Size = new System.Drawing.Size(63, 29);
            this.lbl_maNV.TabIndex = 7;
            this.lbl_maNV.Text = "nv01";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cb_gioitinh);
            this.panel4.Controls.Add(this.txt_sodienthoai);
            this.panel4.Controls.Add(this.dtp_ngaysinh);
            this.panel4.Controls.Add(this.lbl_sodiennthoai);
            this.panel4.Controls.Add(this.txt_luong);
            this.panel4.Controls.Add(this.lbl_luong);
            this.panel4.Controls.Add(this.txt_diachi);
            this.panel4.Controls.Add(this.lbl_diachi);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.txt_email);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txt_hoten);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(6, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(348, 306);
            this.panel4.TabIndex = 18;
            // 
            // cb_gioitinh
            // 
            this.cb_gioitinh.FormattingEnabled = true;
            this.cb_gioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cb_gioitinh.Location = new System.Drawing.Point(115, 50);
            this.cb_gioitinh.Name = "cb_gioitinh";
            this.cb_gioitinh.Size = new System.Drawing.Size(218, 24);
            this.cb_gioitinh.TabIndex = 26;
            // 
            // txt_sodienthoai
            // 
            this.txt_sodienthoai.Location = new System.Drawing.Point(115, 165);
            this.txt_sodienthoai.Mask = "(+84) 00-0000-000";
            this.txt_sodienthoai.Name = "txt_sodienthoai";
            this.txt_sodienthoai.Size = new System.Drawing.Size(218, 22);
            this.txt_sodienthoai.TabIndex = 25;
            // 
            // dtp_ngaysinh
            // 
            this.dtp_ngaysinh.Location = new System.Drawing.Point(115, 87);
            this.dtp_ngaysinh.Name = "dtp_ngaysinh";
            this.dtp_ngaysinh.Size = new System.Drawing.Size(218, 22);
            this.dtp_ngaysinh.TabIndex = 24;
            // 
            // lbl_sodiennthoai
            // 
            this.lbl_sodiennthoai.AutoSize = true;
            this.lbl_sodiennthoai.Location = new System.Drawing.Point(10, 168);
            this.lbl_sodiennthoai.Name = "lbl_sodiennthoai";
            this.lbl_sodiennthoai.Size = new System.Drawing.Size(95, 17);
            this.lbl_sodiennthoai.TabIndex = 22;
            this.lbl_sodiennthoai.Text = "Số điện thoại:";
            // 
            // txt_luong
            // 
            this.txt_luong.Location = new System.Drawing.Point(115, 204);
            this.txt_luong.Name = "txt_luong";
            this.txt_luong.Size = new System.Drawing.Size(218, 22);
            this.txt_luong.TabIndex = 21;
            // 
            // lbl_luong
            // 
            this.lbl_luong.AutoSize = true;
            this.lbl_luong.Location = new System.Drawing.Point(11, 207);
            this.lbl_luong.Name = "lbl_luong";
            this.lbl_luong.Size = new System.Drawing.Size(52, 17);
            this.lbl_luong.TabIndex = 20;
            this.lbl_luong.Text = "Lương:";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(115, 243);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(218, 42);
            this.txt_diachi.TabIndex = 19;
            // 
            // lbl_diachi
            // 
            this.lbl_diachi.AutoSize = true;
            this.lbl_diachi.Location = new System.Drawing.Point(10, 243);
            this.lbl_diachi.Name = "lbl_diachi";
            this.lbl_diachi.Size = new System.Drawing.Size(51, 17);
            this.lbl_diachi.TabIndex = 18;
            this.lbl_diachi.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Giới tính:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(115, 128);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(218, 22);
            this.txt_email.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày sinh";
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(115, 11);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(218, 22);
            this.txt_hoten.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ và tên:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StoreManager.Properties.Resources.white_cate;
            this.pictureBox1.Location = new System.Drawing.Point(88, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.lbl_typechoice);
            this.groupBox1.Controls.Add(this.cb_typesearch);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm nhân viên";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tìm kiếm:";
            // 
            // txt_search
            // 
            this.txt_search.Enabled = false;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(140, 71);
            this.txt_search.Multiline = true;
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(209, 48);
            this.txt_search.TabIndex = 3;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // lbl_typechoice
            // 
            this.lbl_typechoice.AutoSize = true;
            this.lbl_typechoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_typechoice.Location = new System.Drawing.Point(16, 42);
            this.lbl_typechoice.Name = "lbl_typechoice";
            this.lbl_typechoice.Size = new System.Drawing.Size(106, 18);
            this.lbl_typechoice.TabIndex = 2;
            this.lbl_typechoice.Text = "Tìm kiếm theo:";
            // 
            // cb_typesearch
            // 
            this.cb_typesearch.FormattingEnabled = true;
            this.cb_typesearch.Items.AddRange(new object[] {
            "Tên nhân viên",
            "Chức vụ",
            "Mã nhân viên"});
            this.cb_typesearch.Location = new System.Drawing.Point(140, 41);
            this.cb_typesearch.Name = "cb_typesearch";
            this.cb_typesearch.Size = new System.Drawing.Size(159, 24);
            this.cb_typesearch.TabIndex = 0;
            this.cb_typesearch.SelectedIndexChanged += new System.EventHandler(this.cb_typesearch_SelectedIndexChanged);
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cltenNV,
            this.clsodienthoai,
            this.clgioitinh,
            this.clngaysinh,
            this.clemail,
            this.clchucvu});
            this.dgvEmployee.Location = new System.Drawing.Point(385, 146);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.RowTemplate.Height = 24;
            this.dgvEmployee.Size = new System.Drawing.Size(703, 440);
            this.dgvEmployee.TabIndex = 2;
            this.dgvEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployee_CellClick);
            // 
            // cltenNV
            // 
            this.cltenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cltenNV.DataPropertyName = "tenNV";
            this.cltenNV.HeaderText = "Họ và tên";
            this.cltenNV.Name = "cltenNV";
            // 
            // clsodienthoai
            // 
            this.clsodienthoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clsodienthoai.DataPropertyName = "sodienthoai";
            this.clsodienthoai.HeaderText = "Số điện thoại";
            this.clsodienthoai.Name = "clsodienthoai";
            // 
            // clgioitinh
            // 
            this.clgioitinh.DataPropertyName = "gioitinh";
            this.clgioitinh.HeaderText = "Giới tính";
            this.clgioitinh.Name = "clgioitinh";
            // 
            // clngaysinh
            // 
            this.clngaysinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clngaysinh.DataPropertyName = "ngaysinh";
            this.clngaysinh.HeaderText = "Ngày sinh";
            this.clngaysinh.Name = "clngaysinh";
            // 
            // clemail
            // 
            this.clemail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clemail.DataPropertyName = "email";
            this.clemail.HeaderText = "Email";
            this.clemail.Name = "clemail";
            // 
            // clchucvu
            // 
            this.clchucvu.DataPropertyName = "tenloaiNV";
            this.clchucvu.HeaderText = "Chức vụ";
            this.clchucvu.Name = "clchucvu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(483, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 69);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý nhân viên";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(449, 295);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(349, 150);
            this.panel3.TabIndex = 6;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Location = new System.Drawing.Point(694, 592);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(127, 46);
            this.btn_capnhat.TabIndex = 7;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(827, 592);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(127, 46);
            this.btn_xoa.TabIndex = 8;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_khoiphuc
            // 
            this.btn_khoiphuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_khoiphuc.Location = new System.Drawing.Point(385, 592);
            this.btn_khoiphuc.Name = "btn_khoiphuc";
            this.btn_khoiphuc.Size = new System.Drawing.Size(127, 46);
            this.btn_khoiphuc.TabIndex = 9;
            this.btn_khoiphuc.Text = "Khôi phục";
            this.btn_khoiphuc.UseVisualStyleBackColor = true;
            this.btn_khoiphuc.Click += new System.EventHandler(this.btn_khoiphuc_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(960, 592);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(127, 46);
            this.btn_them.TabIndex = 10;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.ControlBox = false;
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.btn_khoiphuc);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_capnhat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmployee);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EmployeeForm";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cltenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn clsodienthoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn clgioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn clemail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clchucvu;
        private System.Windows.Forms.Label lbl_typechoice;
        private System.Windows.Forms.ComboBox cb_typesearch;
        private System.Windows.Forms.TextBox txt_luong;
        private System.Windows.Forms.Label lbl_luong;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label lbl_diachi;
        private System.Windows.Forms.Label lbl_sodiennthoai;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_maNV;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.MaskedTextBox txt_sodienthoai;
        private System.Windows.Forms.ComboBox cb_gioitinh;
        private System.Windows.Forms.Button btn_khoiphuc;
        private System.Windows.Forms.Button btn_them;
    }
}