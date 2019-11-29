namespace StoreManager
{
    partial class OrderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tenloaiHH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_tenHH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.numeric_soluong = new System.Windows.Forms.NumericUpDown();
            this.ckb_bansi = new System.Windows.Forms.CheckBox();
            this.dgv_chitietHD = new System.Windows.Forms.DataGridView();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_tenHH = new System.Windows.Forms.ComboBox();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDBDataSet7 = new StoreManager.StoreDBDataSet7();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_maHH = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_ngaylap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_khachhang = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_maKH = new System.Windows.Forms.TextBox();
            this.txt_tenNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_maHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hangHoaTableAdapter = new StoreManager.StoreDBDataSet7TableAdapters.HangHoaTableAdapter();
            this.maHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dongia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhtien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_soluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet7)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 626);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_xoa);
            this.panel2.Controls.Add(this.btn_luu);
            this.panel2.Controls.Add(this.btn_timkiem);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(3, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1070, 562);
            this.panel2.TabIndex = 1;
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.White;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = global::StoreManager.Properties.Resources.remove;
            this.btn_xoa.Location = new System.Drawing.Point(724, 500);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 59);
            this.btn_xoa.TabIndex = 10;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.White;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Image = global::StoreManager.Properties.Resources.save;
            this.btn_luu.Location = new System.Drawing.Point(514, 500);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(100, 59);
            this.btn_luu.TabIndex = 9;
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.BackColor = System.Drawing.Color.White;
            this.btn_timkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Image = global::StoreManager.Properties.Resources.search1;
            this.btn_timkiem.Location = new System.Drawing.Point(619, 500);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(100, 59);
            this.btn_timkiem.TabIndex = 8;
            this.btn_timkiem.UseVisualStyleBackColor = false;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 556);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin sản phẩm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_dongia);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.txt_mota);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txt_soluong);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txt_tenloaiHH);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txt_tenHH);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(6, 296);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 254);
            this.panel3.TabIndex = 1;
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(82, 73);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.ReadOnly = true;
            this.txt_dongia.Size = new System.Drawing.Size(217, 22);
            this.txt_dongia.TabIndex = 9;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 17);
            this.label16.TabIndex = 8;
            this.label16.Text = "Giá bán";
            // 
            // txt_mota
            // 
            this.txt_mota.Location = new System.Drawing.Point(82, 108);
            this.txt_mota.Multiline = true;
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.ReadOnly = true;
            this.txt_mota.Size = new System.Drawing.Size(217, 111);
            this.txt_mota.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Mô tả:";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(191, 225);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.ReadOnly = true;
            this.txt_soluong.Size = new System.Drawing.Size(108, 22);
            this.txt_soluong.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 17);
            this.label10.TabIndex = 4;
            this.label10.Text = "Số lượng hàng còn lại:";
            // 
            // txt_tenloaiHH
            // 
            this.txt_tenloaiHH.Location = new System.Drawing.Point(82, 45);
            this.txt_tenloaiHH.Name = "txt_tenloaiHH";
            this.txt_tenloaiHH.ReadOnly = true;
            this.txt_tenloaiHH.Size = new System.Drawing.Size(217, 22);
            this.txt_tenloaiHH.TabIndex = 3;
            this.txt_tenloaiHH.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Loại hàng:";
            // 
            // txt_tenHH
            // 
            this.txt_tenHH.Location = new System.Drawing.Point(82, 16);
            this.txt_tenHH.Name = "txt_tenHH";
            this.txt_tenHH.ReadOnly = true;
            this.txt_tenHH.Size = new System.Drawing.Size(217, 22);
            this.txt_tenHH.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên hàng:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.Lime;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Image = global::StoreManager.Properties.Resources.add_icon2;
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(828, 500);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(233, 59);
            this.btn_them.TabIndex = 2;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_thanhtien);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.numeric_soluong);
            this.groupBox2.Controls.Add(this.ckb_bansi);
            this.groupBox2.Controls.Add(this.dgv_chitietHD);
            this.groupBox2.Controls.Add(this.txt_tongtien);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cb_tenHH);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txt_maHH);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(323, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 351);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết đơn hàng";
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Location = new System.Drawing.Point(506, 62);
            this.txt_thanhtien.Multiline = true;
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(232, 22);
            this.txt_thanhtien.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(406, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Thành tiền";
            // 
            // numeric_soluong
            // 
            this.numeric_soluong.Location = new System.Drawing.Point(505, 31);
            this.numeric_soluong.Name = "numeric_soluong";
            this.numeric_soluong.Size = new System.Drawing.Size(233, 22);
            this.numeric_soluong.TabIndex = 27;
            this.numeric_soluong.ValueChanged += new System.EventHandler(this.numeric_soluong_ValueChanged);
            // 
            // ckb_bansi
            // 
            this.ckb_bansi.AutoSize = true;
            this.ckb_bansi.Location = new System.Drawing.Point(8, 322);
            this.ckb_bansi.Name = "ckb_bansi";
            this.ckb_bansi.Size = new System.Drawing.Size(126, 21);
            this.ckb_bansi.TabIndex = 14;
            this.ckb_bansi.Text = "Hóa đơn bán sỉ";
            this.ckb_bansi.UseVisualStyleBackColor = true;
            this.ckb_bansi.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dgv_chitietHD
            // 
            this.dgv_chitietHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitietHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHH,
            this.tenHH,
            this.dongia,
            this.soluong,
            this.thanhtien});
            this.dgv_chitietHD.Location = new System.Drawing.Point(7, 92);
            this.dgv_chitietHD.Name = "dgv_chitietHD";
            this.dgv_chitietHD.RowTemplate.Height = 24;
            this.dgv_chitietHD.Size = new System.Drawing.Size(731, 224);
            this.dgv_chitietHD.TabIndex = 26;
            this.dgv_chitietHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitietHD_CellClick);
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(506, 322);
            this.txt_tongtien.Multiline = true;
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.ReadOnly = true;
            this.txt_tongtien.Size = new System.Drawing.Size(233, 22);
            this.txt_tongtien.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(406, 324);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 20);
            this.label17.TabIndex = 24;
            this.label17.Text = "Tổng tiền:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(406, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 20);
            this.label15.TabIndex = 20;
            this.label15.Text = "Số lượng";
            // 
            // cb_tenHH
            // 
            this.cb_tenHH.DataSource = this.hangHoaBindingSource;
            this.cb_tenHH.DisplayMember = "tenHH";
            this.cb_tenHH.FormattingEnabled = true;
            this.cb_tenHH.Location = new System.Drawing.Point(164, 62);
            this.cb_tenHH.Name = "cb_tenHH";
            this.cb_tenHH.Size = new System.Drawing.Size(233, 24);
            this.cb_tenHH.TabIndex = 17;
            this.cb_tenHH.ValueMember = "tenHH";
            this.cb_tenHH.SelectedIndexChanged += new System.EventHandler(this.cb_tenHH_SelectedIndexChanged);
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.storeDBDataSet7;
            // 
            // storeDBDataSet7
            // 
            this.storeDBDataSet7.DataSetName = "StoreDBDataSet7";
            this.storeDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(21, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Tên hàng:";
            // 
            // txt_maHH
            // 
            this.txt_maHH.Location = new System.Drawing.Point(164, 28);
            this.txt_maHH.Multiline = true;
            this.txt_maHH.Name = "txt_maHH";
            this.txt_maHH.Size = new System.Drawing.Size(155, 22);
            this.txt_maHH.TabIndex = 15;
            this.txt_maHH.TextChanged += new System.EventHandler(this.txt_maHH_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(21, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Mã hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_ngaylap);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_diachi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cb_khachhang);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txt_maKH);
            this.groupBox1.Controls.Add(this.txt_tenNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_maNV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_maHD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(323, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // dtp_ngaylap
            // 
            this.dtp_ngaylap.CustomFormat = "yyyy-MM-dd";
            this.dtp_ngaylap.Enabled = false;
            this.dtp_ngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_ngaylap.Location = new System.Drawing.Point(505, 99);
            this.dtp_ngaylap.Name = "dtp_ngaylap";
            this.dtp_ngaylap.Size = new System.Drawing.Size(233, 22);
            this.dtp_ngaylap.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(336, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ngày lập hóa đơn";
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(505, 66);
            this.txt_diachi.Multiline = true;
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(233, 22);
            this.txt_diachi.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(335, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Địa chỉ:";
            // 
            // cb_khachhang
            // 
            this.cb_khachhang.FormattingEnabled = true;
            this.cb_khachhang.Location = new System.Drawing.Point(506, 33);
            this.cb_khachhang.Name = "cb_khachhang";
            this.cb_khachhang.Size = new System.Drawing.Size(155, 24);
            this.cb_khachhang.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(335, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tên khách hàng";
            // 
            // txt_maKH
            // 
            this.txt_maKH.Location = new System.Drawing.Point(667, 33);
            this.txt_maKH.Multiline = true;
            this.txt_maKH.Name = "txt_maKH";
            this.txt_maKH.ReadOnly = true;
            this.txt_maKH.Size = new System.Drawing.Size(72, 24);
            this.txt_maKH.TabIndex = 9;
            // 
            // txt_tenNV
            // 
            this.txt_tenNV.Location = new System.Drawing.Point(164, 99);
            this.txt_tenNV.Multiline = true;
            this.txt_tenNV.Name = "txt_tenNV";
            this.txt_tenNV.ReadOnly = true;
            this.txt_tenNV.Size = new System.Drawing.Size(155, 22);
            this.txt_tenNV.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tên nhân viên";
            // 
            // txt_maNV
            // 
            this.txt_maNV.Location = new System.Drawing.Point(164, 66);
            this.txt_maNV.Multiline = true;
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.ReadOnly = true;
            this.txt_maNV.Size = new System.Drawing.Size(155, 22);
            this.txt_maNV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên";
            // 
            // txt_maHD
            // 
            this.txt_maHD.Location = new System.Drawing.Point(164, 33);
            this.txt_maHD.Multiline = true;
            this.txt_maHD.Name = "txt_maHD";
            this.txt_maHD.ReadOnly = true;
            this.txt_maHD.Size = new System.Drawing.Size(155, 22);
            this.txt_maHD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // maHH
            // 
            this.maHH.DataPropertyName = "maHH";
            this.maHH.HeaderText = "Mã hàng hóa";
            this.maHH.Name = "maHH";
            // 
            // tenHH
            // 
            this.tenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenHH.DataPropertyName = "tenHH";
            this.tenHH.HeaderText = "Tên hàng hóa";
            this.tenHH.Name = "tenHH";
            // 
            // dongia
            // 
            this.dongia.HeaderText = "Giá bán";
            this.dongia.Name = "dongia";
            // 
            // soluong
            // 
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            // 
            // thanhtien
            // 
            this.thanhtien.HeaderText = "Thành tiền";
            this.thanhtien.Name = "thanhtien";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_soluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitietHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet7)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tenloaiHH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_tenHH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_khachhang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_maKH;
        private System.Windows.Forms.TextBox txt_tenNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_maNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_maHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_chitietHD;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_tenHH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_maHH;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox ckb_bansi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numeric_soluong;
        private System.Windows.Forms.Button btn_timkiem;
        private StoreDBDataSet7 storeDBDataSet7;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private StoreDBDataSet7TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.DateTimePicker dtp_ngaylap;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhtien;
    }
}