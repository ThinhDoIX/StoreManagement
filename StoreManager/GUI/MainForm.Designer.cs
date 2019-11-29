namespace StoreManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nhansuMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.banhangMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khohangMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.danhmuchanghoaMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpPhiếuNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đốiTácToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khachhangMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhacungcapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thongkeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chỉTiêuNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tùyChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuCửaHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhansuMenu,
            this.banhangMenu,
            this.khohangMenu,
            this.đốiTácToolStripMenuItem,
            this.thongkeMenu,
            this.tùyChọnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nhansuMenu
            // 
            this.nhansuMenu.Name = "nhansuMenu";
            this.nhansuMenu.Size = new System.Drawing.Size(75, 24);
            this.nhansuMenu.Text = "Nhân sự";
            this.nhansuMenu.Click += new System.EventHandler(this.nhansuMenu_Click);
            // 
            // banhangMenu
            // 
            this.banhangMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpHóaĐơnToolStripMenuItem});
            this.banhangMenu.Name = "banhangMenu";
            this.banhangMenu.Size = new System.Drawing.Size(83, 24);
            this.banhangMenu.Text = "Bán hàng";
            // 
            // lậpHóaĐơnToolStripMenuItem
            // 
            this.lậpHóaĐơnToolStripMenuItem.Name = "lậpHóaĐơnToolStripMenuItem";
            this.lậpHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.lậpHóaĐơnToolStripMenuItem.Text = "Lập hóa đơn";
            this.lậpHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.lậpHóaĐơnToolStripMenuItem_Click);
            // 
            // khohangMenu
            // 
            this.khohangMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.danhmuchanghoaMenuItem,
            this.lậpPhiếuNhậpToolStripMenuItem,
            this.nhậpHàngMớiToolStripMenuItem});
            this.khohangMenu.Name = "khohangMenu";
            this.khohangMenu.Size = new System.Drawing.Size(84, 24);
            this.khohangMenu.Text = "Kho hàng";
            // 
            // danhmuchanghoaMenuItem
            // 
            this.danhmuchanghoaMenuItem.Name = "danhmuchanghoaMenuItem";
            this.danhmuchanghoaMenuItem.Size = new System.Drawing.Size(217, 26);
            this.danhmuchanghoaMenuItem.Text = "Danh mục hàng hóa";
            this.danhmuchanghoaMenuItem.Click += new System.EventHandler(this.danhmuchanghoaMenuItem_Click);
            // 
            // lậpPhiếuNhậpToolStripMenuItem
            // 
            this.lậpPhiếuNhậpToolStripMenuItem.Name = "lậpPhiếuNhậpToolStripMenuItem";
            this.lậpPhiếuNhậpToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.lậpPhiếuNhậpToolStripMenuItem.Text = "Lập phiếu nhập";
            this.lậpPhiếuNhậpToolStripMenuItem.Click += new System.EventHandler(this.lậpPhiếuNhậpToolStripMenuItem_Click);
            // 
            // nhậpHàngMớiToolStripMenuItem
            // 
            this.nhậpHàngMớiToolStripMenuItem.Name = "nhậpHàngMớiToolStripMenuItem";
            this.nhậpHàngMớiToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
            this.nhậpHàngMớiToolStripMenuItem.Text = "Nhập hàng mới";
            this.nhậpHàngMớiToolStripMenuItem.Click += new System.EventHandler(this.nhậpHàngMớiToolStripMenuItem_Click);
            // 
            // đốiTácToolStripMenuItem
            // 
            this.đốiTácToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khachhangMenuItem,
            this.nhacungcapMenuItem});
            this.đốiTácToolStripMenuItem.Name = "đốiTácToolStripMenuItem";
            this.đốiTácToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.đốiTácToolStripMenuItem.Text = "Đối tác";
            // 
            // khachhangMenuItem
            // 
            this.khachhangMenuItem.Name = "khachhangMenuItem";
            this.khachhangMenuItem.Size = new System.Drawing.Size(243, 26);
            this.khachhangMenuItem.Text = "Danh mục khách hàng";
            // 
            // nhacungcapMenuItem
            // 
            this.nhacungcapMenuItem.Name = "nhacungcapMenuItem";
            this.nhacungcapMenuItem.Size = new System.Drawing.Size(243, 26);
            this.nhacungcapMenuItem.Text = "Danh mục nhà cung cấp";
            // 
            // thongkeMenu
            // 
            this.thongkeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuBánHàngToolStripMenuItem,
            this.chỉTiêuNhânViênToolStripMenuItem,
            this.doanhThuCửaHàngToolStripMenuItem});
            this.thongkeMenu.Name = "thongkeMenu";
            this.thongkeMenu.Size = new System.Drawing.Size(82, 24);
            this.thongkeMenu.Text = "Thống kê";
            // 
            // doanhThuBánHàngToolStripMenuItem
            // 
            this.doanhThuBánHàngToolStripMenuItem.Name = "doanhThuBánHàngToolStripMenuItem";
            this.doanhThuBánHàngToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.doanhThuBánHàngToolStripMenuItem.Text = "Lịch sử lập hóa đơn";
            this.doanhThuBánHàngToolStripMenuItem.Click += new System.EventHandler(this.doanhThuBánHàngToolStripMenuItem_Click);
            // 
            // chỉTiêuNhânViênToolStripMenuItem
            // 
            this.chỉTiêuNhânViênToolStripMenuItem.Name = "chỉTiêuNhânViênToolStripMenuItem";
            this.chỉTiêuNhânViênToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.chỉTiêuNhânViênToolStripMenuItem.Text = "Chỉ tiêu nhân viên";
            // 
            // tùyChọnToolStripMenuItem
            // 
            this.tùyChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.thôngTinCáNhânToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.tùyChọnToolStripMenuItem.Name = "tùyChọnToolStripMenuItem";
            this.tùyChọnToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.tùyChọnToolStripMenuItem.Text = "Tùy chọn";
            this.tùyChọnToolStripMenuItem.Click += new System.EventHandler(this.tùyChọnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            // 
            // doanhThuCửaHàngToolStripMenuItem
            // 
            this.doanhThuCửaHàngToolStripMenuItem.Name = "doanhThuCửaHàngToolStripMenuItem";
            this.doanhThuCửaHàngToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.doanhThuCửaHàngToolStripMenuItem.Text = "Doanh thu cửa hàng";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 683);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý cửa hàng điện nước";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nhansuMenu;
        private System.Windows.Forms.ToolStripMenuItem tùyChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khohangMenu;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đốiTácToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khachhangMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhacungcapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thongkeMenu;
        private System.Windows.Forms.ToolStripMenuItem doanhThuBánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhmuchanghoaMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banhangMenu;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHàngMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chỉTiêuNhânViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doanhThuCửaHàngToolStripMenuItem;
    }
}