﻿namespace StoreManager
{
    partial class InventoryForm
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
            this.components = new System.ComponentModel.Container();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.maHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donvitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenloaiHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chatlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_search_tenHH = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_tinhtrang = new System.Windows.Forms.ComboBox();
            this.txt_search_maHH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_nhacungcap = new System.Windows.Forms.ComboBox();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDBDataSet3 = new StoreManager.StoreDBDataSet3();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_tenloaiHH = new System.Windows.Forms.ComboBox();
            this.loaiHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDBDataSet = new StoreManager.StoreDBDataSet();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_donvitinh = new System.Windows.Forms.TextBox();
            this.btn_capnhat = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tenHH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maHH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_loaiHH = new System.Windows.Forms.ComboBox();
            this.loaiHangHoaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.storeDBDataSet2 = new StoreManager.StoreDBDataSet2();
            this.loaiHangHoaTableAdapter = new StoreManager.StoreDBDataSetTableAdapters.LoaiHangHoaTableAdapter();
            this.storeDBDataSet1 = new StoreManager.StoreDBDataSet1();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaTableAdapter = new StoreManager.StoreDBDataSet1TableAdapters.HangHoaTableAdapter();
            this.loaiHangHoaTableAdapter1 = new StoreManager.StoreDBDataSet2TableAdapters.LoaiHangHoaTableAdapter();
            this.nhaCungCapTableAdapter = new StoreManager.StoreDBDataSet3TableAdapters.NhaCungCapTableAdapter();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangHoaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvHangHoa);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point(412, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(661, 408);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh mục sản phẩm";
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHH,
            this.tenHH,
            this.soluong,
            this.donvitinh,
            this.dongia,
            this.tenloaiHH,
            this.chatlieu});
            this.dgvHangHoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHangHoa.Location = new System.Drawing.Point(3, 18);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.RowTemplate.Height = 24;
            this.dgvHangHoa.Size = new System.Drawing.Size(655, 387);
            this.dgvHangHoa.TabIndex = 5;
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
            // 
            // maHH
            // 
            this.maHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.maHH.DataPropertyName = "maHH";
            this.maHH.FillWeight = 178.7234F;
            this.maHH.HeaderText = "Mã Hàng Hóa";
            this.maHH.Name = "maHH";
            this.maHH.ReadOnly = true;
            this.maHH.Width = 124;
            // 
            // tenHH
            // 
            this.tenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenHH.DataPropertyName = "tenHH";
            this.tenHH.FillWeight = 21.2766F;
            this.tenHH.HeaderText = "Tên Hàng Hóa";
            this.tenHH.Name = "tenHH";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.Width = 50;
            // 
            // donvitinh
            // 
            this.donvitinh.DataPropertyName = "donvitinh";
            this.donvitinh.HeaderText = "Đơn vị tính";
            this.donvitinh.Name = "donvitinh";
            this.donvitinh.Visible = false;
            // 
            // dongia
            // 
            this.dongia.DataPropertyName = "dongia";
            this.dongia.HeaderText = "Đơn giá";
            this.dongia.Name = "dongia";
            // 
            // tenloaiHH
            // 
            this.tenloaiHH.DataPropertyName = "tenloaiHH";
            this.tenloaiHH.HeaderText = "Tên loại HH";
            this.tenloaiHH.Name = "tenloaiHH";
            this.tenloaiHH.Visible = false;
            // 
            // chatlieu
            // 
            this.chatlieu.DataPropertyName = "chatlieu";
            this.chatlieu.HeaderText = "Chất liệu";
            this.chatlieu.Name = "chatlieu";
            this.chatlieu.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_timkiem);
            this.panel1.Controls.Add(this.btn_reset);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 626);
            this.panel1.TabIndex = 26;
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Enabled = false;
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.ForeColor = System.Drawing.Color.Black;
            this.btn_timkiem.Location = new System.Drawing.Point(818, 493);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(252, 76);
            this.btn_timkiem.TabIndex = 28;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.Black;
            this.btn_reset.Location = new System.Drawing.Point(818, 577);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(252, 44);
            this.btn_reset.TabIndex = 27;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_search_tenHH);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cb_tinhtrang);
            this.groupBox2.Controls.Add(this.txt_search_maHH);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cb_nhacungcap);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cb_tenloaiHH);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(3, 488);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(809, 135);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc hàng hóa:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(410, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 24);
            this.label12.TabIndex = 21;
            this.label12.Text = "Nhập tên:";
            // 
            // txt_search_tenHH
            // 
            this.txt_search_tenHH.Location = new System.Drawing.Point(546, 99);
            this.txt_search_tenHH.Name = "txt_search_tenHH";
            this.txt_search_tenHH.Size = new System.Drawing.Size(255, 22);
            this.txt_search_tenHH.TabIndex = 20;
            this.txt_search_tenHH.TextChanged += new System.EventHandler(this.txt_search_tenHH_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(410, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "Nhập mã:";
            // 
            // cb_tinhtrang
            // 
            this.cb_tinhtrang.FormattingEnabled = true;
            this.cb_tinhtrang.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng"});
            this.cb_tinhtrang.Location = new System.Drawing.Point(143, 62);
            this.cb_tinhtrang.Name = "cb_tinhtrang";
            this.cb_tinhtrang.Size = new System.Drawing.Size(255, 24);
            this.cb_tinhtrang.TabIndex = 19;
            this.cb_tinhtrang.SelectedIndexChanged += new System.EventHandler(this.cb_tinhtrang_SelectedIndexChanged);
            // 
            // txt_search_maHH
            // 
            this.txt_search_maHH.Location = new System.Drawing.Point(546, 62);
            this.txt_search_maHH.Name = "txt_search_maHH";
            this.txt_search_maHH.Size = new System.Drawing.Size(255, 22);
            this.txt_search_maHH.TabIndex = 16;
            this.txt_search_maHH.TextChanged += new System.EventHandler(this.txt_search_maHH_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(8, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 24);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tình trạng:";
            // 
            // cb_nhacungcap
            // 
            this.cb_nhacungcap.DataSource = this.nhaCungCapBindingSource;
            this.cb_nhacungcap.DisplayMember = "tenNCC";
            this.cb_nhacungcap.FormattingEnabled = true;
            this.cb_nhacungcap.Location = new System.Drawing.Point(143, 21);
            this.cb_nhacungcap.Name = "cb_nhacungcap";
            this.cb_nhacungcap.Size = new System.Drawing.Size(255, 24);
            this.cb_nhacungcap.TabIndex = 17;
            this.cb_nhacungcap.ValueMember = "tenNCC";
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.storeDBDataSet3;
            // 
            // storeDBDataSet3
            // 
            this.storeDBDataSet3.DataSetName = "StoreDBDataSet3";
            this.storeDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 24);
            this.label10.TabIndex = 16;
            this.label10.Text = "Nhà cung cấp";
            // 
            // cb_tenloaiHH
            // 
            this.cb_tenloaiHH.DataSource = this.loaiHangHoaBindingSource;
            this.cb_tenloaiHH.DisplayMember = "tenloaiHH";
            this.cb_tenloaiHH.FormattingEnabled = true;
            this.cb_tenloaiHH.Location = new System.Drawing.Point(546, 23);
            this.cb_tenloaiHH.Name = "cb_tenloaiHH";
            this.cb_tenloaiHH.Size = new System.Drawing.Size(255, 24);
            this.cb_tenloaiHH.TabIndex = 2;
            this.cb_tenloaiHH.ValueMember = "tenloaiHH";
            this.cb_tenloaiHH.SelectedIndexChanged += new System.EventHandler(this.cb_tenloaiHH_SelectedIndexChanged);
            // 
            // loaiHangHoaBindingSource
            // 
            this.loaiHangHoaBindingSource.DataMember = "LoaiHangHoa";
            this.loaiHangHoaBindingSource.DataSource = this.storeDBDataSet;
            // 
            // storeDBDataSet
            // 
            this.storeDBDataSet.DataSetName = "StoreDBDataSet";
            this.storeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(410, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "Loại hàng hóa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý vật tư";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_donvitinh);
            this.groupBox1.Controls.Add(this.btn_capnhat);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_soluong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_dongia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_tenHH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_maHH);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_loaiHH);
            this.groupBox1.Location = new System.Drawing.Point(3, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 408);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm (Tiền tệ: VND)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(283, 192);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "/";
            // 
            // txt_donvitinh
            // 
            this.txt_donvitinh.Enabled = false;
            this.txt_donvitinh.Location = new System.Drawing.Point(302, 190);
            this.txt_donvitinh.Name = "txt_donvitinh";
            this.txt_donvitinh.Size = new System.Drawing.Size(95, 22);
            this.txt_donvitinh.TabIndex = 16;
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat.ForeColor = System.Drawing.Color.Black;
            this.btn_capnhat.Location = new System.Drawing.Point(130, 357);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(146, 45);
            this.btn_capnhat.TabIndex = 15;
            this.btn_capnhat.Text = "Sửa";
            this.btn_capnhat.UseVisualStyleBackColor = true;
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(10, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "Khôi phục";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Location = new System.Drawing.Point(282, 357);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(114, 45);
            this.btn_xoa.TabIndex = 12;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Số lượng tồn:";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Enabled = false;
            this.txt_soluong.Location = new System.Drawing.Point(142, 240);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(255, 22);
            this.txt_soluong.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Đơn giá:";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(142, 190);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(138, 22);
            this.txt_dongia.TabIndex = 6;
            this.txt_dongia.TextChanged += new System.EventHandler(this.txt_dongia_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tên hàng hóa:";
            // 
            // txt_tenHH
            // 
            this.txt_tenHH.Location = new System.Drawing.Point(142, 85);
            this.txt_tenHH.Name = "txt_tenHH";
            this.txt_tenHH.Size = new System.Drawing.Size(255, 22);
            this.txt_tenHH.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã hàng hóa";
            // 
            // txt_maHH
            // 
            this.txt_maHH.Enabled = false;
            this.txt_maHH.Location = new System.Drawing.Point(142, 34);
            this.txt_maHH.Name = "txt_maHH";
            this.txt_maHH.Size = new System.Drawing.Size(255, 22);
            this.txt_maHH.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại hàng hóa:";
            // 
            // cb_loaiHH
            // 
            this.cb_loaiHH.DataSource = this.loaiHangHoaBindingSource1;
            this.cb_loaiHH.DisplayMember = "tenloaiHH";
            this.cb_loaiHH.Enabled = false;
            this.cb_loaiHH.FormattingEnabled = true;
            this.cb_loaiHH.Location = new System.Drawing.Point(142, 136);
            this.cb_loaiHH.Name = "cb_loaiHH";
            this.cb_loaiHH.Size = new System.Drawing.Size(255, 24);
            this.cb_loaiHH.TabIndex = 0;
            this.cb_loaiHH.ValueMember = "tenloaiHH";
            // 
            // loaiHangHoaBindingSource1
            // 
            this.loaiHangHoaBindingSource1.DataMember = "LoaiHangHoa";
            this.loaiHangHoaBindingSource1.DataSource = this.storeDBDataSet2;
            // 
            // storeDBDataSet2
            // 
            this.storeDBDataSet2.DataSetName = "StoreDBDataSet2";
            this.storeDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiHangHoaTableAdapter
            // 
            this.loaiHangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // storeDBDataSet1
            // 
            this.storeDBDataSet1.DataSetName = "StoreDBDataSet1";
            this.storeDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.storeDBDataSet1;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // loaiHangHoaTableAdapter1
            // 
            this.loaiHangHoaTableAdapter1.ClearBeforeFill = true;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InventoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "InventoryForm";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangHoaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tenHH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_loaiHH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cb_tenloaiHH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_capnhat;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.ComboBox cb_nhacungcap;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_search_tenHH;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_tinhtrang;
        private System.Windows.Forms.TextBox txt_search_maHH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txt_donvitinh;
        private System.Windows.Forms.Label label13;
        private StoreDBDataSet storeDBDataSet;
        private System.Windows.Forms.BindingSource loaiHangHoaBindingSource;
        private StoreDBDataSetTableAdapters.LoaiHangHoaTableAdapter loaiHangHoaTableAdapter;
        private StoreDBDataSet1 storeDBDataSet1;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private StoreDBDataSet1TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
        private StoreDBDataSet2 storeDBDataSet2;
        private System.Windows.Forms.BindingSource loaiHangHoaBindingSource1;
        private StoreDBDataSet2TableAdapters.LoaiHangHoaTableAdapter loaiHangHoaTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenloaiHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn chatlieu;
        private StoreDBDataSet3 storeDBDataSet3;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private StoreDBDataSet3TableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
    }
}