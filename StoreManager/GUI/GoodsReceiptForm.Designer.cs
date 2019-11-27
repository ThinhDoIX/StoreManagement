namespace StoreManager.GUI
{
    partial class GoodsReceiptForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_them = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dgv_chitiethd = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_tenHH = new System.Windows.Forms.ComboBox();
            this.hangHoaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDBDataSet5 = new StoreManager.StoreDBDataSet5();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_donvitinh = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_maHH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_ncc = new System.Windows.Forms.ComboBox();
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.storeDBDataSet4 = new StoreManager.StoreDBDataSet4();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tenNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_maNV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ngaylap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_sophieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nhaCungCapTableAdapter = new StoreManager.StoreDBDataSet4TableAdapters.NhaCungCapTableAdapter();
            this.hangHoaTableAdapter = new StoreManager.StoreDBDataSet5TableAdapters.HangHoaTableAdapter();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiethd)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet5)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_them);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.dgv_chitiethd);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 579);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Location = new System.Drawing.Point(428, 528);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(627, 48);
            this.panel2.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(339, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(260, 38);
            this.label14.TabIndex = 7;
            this.label14.Text = "180.000.000.000";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(200, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 25);
            this.label13.TabIndex = 6;
            this.label13.Text = "TỔNG CỘNG:";
            // 
            // btn_them
            // 
            this.btn_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_them.Location = new System.Drawing.Point(36, 528);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(116, 48);
            this.btn_them.TabIndex = 0;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = false;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 528);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 48);
            this.button3.TabIndex = 2;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgv_chitiethd
            // 
            this.dgv_chitiethd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitiethd.Location = new System.Drawing.Point(428, 169);
            this.dgv_chitiethd.Name = "dgv_chitiethd";
            this.dgv_chitiethd.RowTemplate.Height = 24;
            this.dgv_chitiethd.Size = new System.Drawing.Size(627, 353);
            this.dgv_chitiethd.TabIndex = 3;
            this.dgv_chitiethd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_chitiethd_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(280, 528);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 48);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_tenHH);
            this.groupBox2.Controls.Add(this.txt_thanhtien);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_donvitinh);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txt_soluong);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_maHH);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_dongia);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(3, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(419, 353);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết phiếu nhập";
            // 
            // cb_tenHH
            // 
            this.cb_tenHH.DataSource = this.hangHoaBindingSource;
            this.cb_tenHH.DisplayMember = "tenHH";
            this.cb_tenHH.FormattingEnabled = true;
            this.cb_tenHH.Location = new System.Drawing.Point(155, 41);
            this.cb_tenHH.Name = "cb_tenHH";
            this.cb_tenHH.Size = new System.Drawing.Size(254, 24);
            this.cb_tenHH.TabIndex = 22;
            this.cb_tenHH.SelectedIndexChanged += new System.EventHandler(this.cb_tenHH_SelectedIndexChanged);
            // 
            // hangHoaBindingSource
            // 
            this.hangHoaBindingSource.DataMember = "HangHoa";
            this.hangHoaBindingSource.DataSource = this.storeDBDataSet5;
            // 
            // storeDBDataSet5
            // 
            this.storeDBDataSet5.DataSetName = "StoreDBDataSet5";
            this.storeDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Enabled = false;
            this.txt_thanhtien.Location = new System.Drawing.Point(155, 316);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(254, 22);
            this.txt_thanhtien.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(2, 321);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(87, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Thành tiền";
            // 
            // txt_donvitinh
            // 
            this.txt_donvitinh.Enabled = false;
            this.txt_donvitinh.Location = new System.Drawing.Point(155, 261);
            this.txt_donvitinh.Name = "txt_donvitinh";
            this.txt_donvitinh.Size = new System.Drawing.Size(254, 22);
            this.txt_donvitinh.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(2, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Đơn vị tính";
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(155, 206);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(254, 22);
            this.txt_soluong.TabIndex = 17;
            this.txt_soluong.Text = "0";
            this.txt_soluong.TextChanged += new System.EventHandler(this.txt_soluong_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(2, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Số lượng";
            // 
            // txt_maHH
            // 
            this.txt_maHH.Enabled = false;
            this.txt_maHH.Location = new System.Drawing.Point(155, 96);
            this.txt_maHH.Name = "txt_maHH";
            this.txt_maHH.Size = new System.Drawing.Size(254, 22);
            this.txt_maHH.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(2, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Mã hàng hóa";
            // 
            // txt_dongia
            // 
            this.txt_dongia.Enabled = false;
            this.txt_dongia.Location = new System.Drawing.Point(155, 151);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(254, 22);
            this.txt_dongia.TabIndex = 13;
            this.txt_dongia.TextChanged += new System.EventHandler(this.txt_dongia_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(2, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Đơn giá";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tên hàng hóa";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_ncc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_tenNV);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_maNV);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_ngaylap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_sophieu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1052, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu nhập";
            // 
            // cb_ncc
            // 
            this.cb_ncc.DataSource = this.nhaCungCapBindingSource;
            this.cb_ncc.DisplayMember = "tenNCC";
            this.cb_ncc.FormattingEnabled = true;
            this.cb_ncc.Location = new System.Drawing.Point(840, 30);
            this.cb_ncc.Name = "cb_ncc";
            this.cb_ncc.Size = new System.Drawing.Size(196, 24);
            this.cb_ncc.TabIndex = 9;
            this.cb_ncc.ValueMember = "tenNCC";
            // 
            // nhaCungCapBindingSource
            // 
            this.nhaCungCapBindingSource.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource.DataSource = this.storeDBDataSet4;
            // 
            // storeDBDataSet4
            // 
            this.storeDBDataSet4.DataSetName = "StoreDBDataSet4";
            this.storeDBDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(713, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nhà cung cấp";
            // 
            // txt_tenNV
            // 
            this.txt_tenNV.Enabled = false;
            this.txt_tenNV.Location = new System.Drawing.Point(489, 60);
            this.txt_tenNV.Name = "txt_tenNV";
            this.txt_tenNV.Size = new System.Drawing.Size(196, 22);
            this.txt_tenNV.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên nhân viên";
            // 
            // txt_maNV
            // 
            this.txt_maNV.Enabled = false;
            this.txt_maNV.Location = new System.Drawing.Point(489, 30);
            this.txt_maNV.Name = "txt_maNV";
            this.txt_maNV.Size = new System.Drawing.Size(196, 22);
            this.txt_maNV.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(362, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã nhân viên";
            // 
            // txt_ngaylap
            // 
            this.txt_ngaylap.Enabled = false;
            this.txt_ngaylap.Location = new System.Drawing.Point(122, 60);
            this.txt_ngaylap.Name = "txt_ngaylap";
            this.txt_ngaylap.Size = new System.Drawing.Size(196, 22);
            this.txt_ngaylap.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày nhập";
            // 
            // txt_sophieu
            // 
            this.txt_sophieu.Enabled = false;
            this.txt_sophieu.Location = new System.Drawing.Point(122, 30);
            this.txt_sophieu.Name = "txt_sophieu";
            this.txt_sophieu.Size = new System.Drawing.Size(196, 22);
            this.txt_sophieu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu nhập kho";
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // hangHoaTableAdapter
            // 
            this.hangHoaTableAdapter.ClearBeforeFill = true;
            // 
            // GoodsReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoodsReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoodsReceiptForm";
            this.Load += new System.EventHandler(this.GoodsReceiptForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiethd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hangHoaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storeDBDataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgv_chitiethd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.ComboBox cb_ncc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tenNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_maNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ngaylap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_sophieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_donvitinh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_maHH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private StoreDBDataSet4 storeDBDataSet4;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private StoreDBDataSet4TableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cb_tenHH;
        private StoreDBDataSet5 storeDBDataSet5;
        private System.Windows.Forms.BindingSource hangHoaBindingSource;
        private StoreDBDataSet5TableAdapters.HangHoaTableAdapter hangHoaTableAdapter;
    }
}