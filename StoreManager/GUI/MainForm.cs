using StoreManager.DTO;
using System;
using System.Windows.Forms;

namespace StoreManager
{
    public partial class MainForm : Form
    {
        private NhanVien nhanvien;

        public MainForm(NhanVien nv)
        {
            InitializeComponent();
            this.nhanvien = nv;
            this.Text = "Phần mềm quản lý cửa hàng điện nước (Người dùng: " + nhanvien.TenVN + ", CV: " + nhanvien.getChucVu().TenloaiNV + ")";
            GetFunctionsArea(nhanvien);
        }

        private void GetFunctionsArea(NhanVien nv)
        {
            switch(nv.getChucVu().MaloaiNV)
            {
                case "loainv01":
                    MessageBox.Show("Chào mừng ADMIN", "Thông báo");
                    break;
                case "loainv02":
                    //MessageBox.Show("Quyền bán hàng", "Thông báo");
                    nhansuMenu.Visible = false;
                    khohangMenu.Visible = false;
                    nhacungcapMenuItem.Enabled = false;
                    thongkeMenu.Visible = false;
                    break;
                case "loainv03":
                    //MessageBox.Show("Quyền quản lý kho", "Thông báo");
                    nhansuMenu.Visible = false;
                    thongkeMenu.Visible = false;
                    banhangMenu.Visible = false;
                    break;
                default:
                    MessageBox.Show("Không tìm thấy quyền", "Thông báo");
                    break;
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void tùyChọnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lậpHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderForm order_form = new OrderForm();
            order_form.MdiParent = this;
            order_form.Dock = DockStyle.Fill;
            order_form.Top = 5;
            order_form.Left = 5;
            order_form.Size = this.ClientRectangle.Size;
            order_form.Show();
        }

        private void danhmuchanghoaMenuItem_Click(object sender, EventArgs e)
        {
            InventoryForm inventory_form = new InventoryForm();
            inventory_form.MdiParent = this;
            inventory_form.Dock = DockStyle.Fill;
            inventory_form.Top = 5;
            inventory_form.Left = 5;
            inventory_form.Size = this.ClientRectangle.Size;
            inventory_form.Show();
        }

        private void nhansuMenu_Click(object sender, EventArgs e)
        {
            EmployeeForm employee_form = new EmployeeForm(nhanvien);
            employee_form.MdiParent = this;
            employee_form.Dock = DockStyle.Fill;
            employee_form.Top = 5;
            employee_form.Left = 5;
            employee_form.Size = this.ClientRectangle.Size;
            employee_form.Show();
        }
    }
}
