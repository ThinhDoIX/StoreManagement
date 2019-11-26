namespace StoreManager
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
            this.chatlieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
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
            this.txt_donvitinh = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.storeDBDataSet = new StoreManager.StoreDBDataSet();
            this.loaiHangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loaiHangHoaTableAdapter = new StoreManager.StoreDBDataSetTableAdapters.LoaiHangHoaTableAdapter();
            this.storeDBDataSet1 = new StoreManager.StoreDBDataSet1();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hangHoaTableAdapter = new StoreManager.StoreDBDataSet1TableAdapters.HangHoaTableAdapter();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangHoaBindingSource)).BeginInit();
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
            this.maHH.DataPropertyName = "maHH";
            this.maHH.HeaderText = "Mã Hàng Hóa";
            this.maHH.Name = "maHH";
            this.maHH.ReadOnly = true;
            // 
            // tenHH
            // 
            this.tenHH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenHH.DataPropertyName = "tenHH";
            this.tenHH.HeaderText = "Tên Hàng Hóa";
            this.tenHH.Name = "tenHH";
            // 
            // soluong
            // 
            this.soluong.DataPropertyName = "soluong";
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
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
            // chatlieu
            // 
            this.chatlieu.DataPropertyName = "chatlieu";
            this.chatlieu.HeaderText = "Chất liệu";
            this.chatlieu.Name = "chatlieu";
            this.chatlieu.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 626);
            this.panel1.TabIndex = 26;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(818, 493);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(252, 76);
            this.button6.TabIndex = 28;
            this.button6.Text = "Tìm kiếm";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.Black;
            this.button7.Location = new System.Drawing.Point(818, 577);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(252, 44);
            this.button7.TabIndex = 27;
            this.button7.Text = "Reset";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboBox4);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.comboBox3);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.comboBox1);
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
            this.label12.Location = new System.Drawing.Point(410, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 24);
            this.label12.TabIndex = 21;
            this.label12.Text = "Nhập tên:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(546, 102);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(255, 22);
            this.textBox6.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(6, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 24);
            this.label11.TabIndex = 17;
            this.label11.Text = "Nhập mã:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Còn hàng",
            "Hết hàng"});
            this.comboBox4.Location = new System.Drawing.Point(546, 22);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(255, 24);
            this.comboBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(142, 102);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(255, 22);
            this.textBox5.TabIndex = 16;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(410, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tình trạng:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(546, 62);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(255, 24);
            this.comboBox3.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(410, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Nhà cung cấp";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(142, 62);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(255, 24);
            this.comboBox2.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nhãn hiệu:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.loaiHangHoaBindingSource;
            this.comboBox1.DisplayMember = "tenloaiHH";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(142, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(255, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "tenloaiHH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Loại hàng hóa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản lý kho hàng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_donvitinh);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.button3);
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
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(3, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 408);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm (Tiền tệ: VND)";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Red;
            this.button5.Location = new System.Drawing.Point(6, 331);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(386, 71);
            this.button5.TabIndex = 15;
            this.button5.Text = "Import file Excel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 45);
            this.button2.TabIndex = 14;
            this.button2.Text = "Khôi phục";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(278, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 45);
            this.button3.TabIndex = 12;
            this.button3.Text = "Xóa";
            this.button3.UseVisualStyleBackColor = true;
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
            this.cb_loaiHH.FormattingEnabled = true;
            this.cb_loaiHH.Location = new System.Drawing.Point(142, 136);
            this.cb_loaiHH.Name = "cb_loaiHH";
            this.cb_loaiHH.Size = new System.Drawing.Size(255, 24);
            this.cb_loaiHH.TabIndex = 0;
            // 
            // txt_donvitinh
            // 
            this.txt_donvitinh.Location = new System.Drawing.Point(302, 190);
            this.txt_donvitinh.Name = "txt_donvitinh";
            this.txt_donvitinh.Size = new System.Drawing.Size(95, 22);
            this.txt_donvitinh.TabIndex = 16;
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
            // storeDBDataSet
            // 
            this.storeDBDataSet.DataSetName = "StoreDBDataSet";
            this.storeDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiHangHoaBindingSource
            // 
            this.loaiHangHoaBindingSource.DataMember = "LoaiHangHoa";
            this.loaiHangHoaBindingSource.DataSource = this.storeDBDataSet;
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiHangHoaBindingSource)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHH;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn dongia;
        private System.Windows.Forms.DataGridViewTextBoxColumn chatlieu;
        private System.Windows.Forms.TextBox txt_donvitinh;
        private System.Windows.Forms.Label label13;
        private StoreDBDataSet storeDBDataSet;
        private System.Windows.Forms.BindingSource loaiHangHoaBindingSource;
        private StoreDBDataSetTableAdapters.LoaiHangHoaTableAdapter loaiHangHoaTableAdapter;
        private StoreDBDataSet1 storeDBDataSet1;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private StoreDBDataSet1TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
    }
}