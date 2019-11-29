using StoreManager.DAL;
using StoreManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManager.GUI
{
    public partial class EmployeeRegisterForm : Form
    {
        private NhanVien nhanvien;

        public EmployeeRegisterForm(NhanVien nhanvien)
        {
            InitializeComponent();
            this.Text = "Thêm nhân viên mới";
            //txt_reg_fullname.Focus();
            this.nhanvien = nhanvien;
            showProfile();
        }

        private void showProfile()
        {
            if(this.nhanvien != null)
            {
                txt_reg_fullname.Text = nhanvien.TenVN;
                txt_reg_email.Text = nhanvien.Email;
                txt_reg_address.Text = nhanvien.Diachi;
                txt_reg_phone.Text = nhanvien.Sodienthoai;
                txt_reg_username.Text = nhanvien.Username;
                txt_reg_password.Text = nhanvien.Userpassword;
                if(nhanvien.Gioitinh.Equals("Nam"))
                {
                    ckb_male.Checked = true;
                }

                else
                {
                    ckb_female.Checked = true;
                }   
            }
        }

        private void btn_reg_reset_Click(object sender, EventArgs e)
        {
            txt_reg_fullname.Text = String.Empty;
            txt_reg_email.Text = String.Empty;
            txt_reg_address.Text = String.Empty;
            txt_reg_phone.Text = String.Empty;
            txt_reg_username.Text = String.Empty;
            txt_reg_password.Text = String.Empty;
            ckb_female.Checked = false;
            ckb_male.Checked = false;
            cb_role.SelectedIndex = -1;
        }

        private void btn_reg_register_Click(object sender, EventArgs e)
        {
            if(txt_reg_fullname.Text == String.Empty)
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo");
                txt_reg_fullname.Focus();
            }
            else if(txt_reg_username.Text == String.Empty)
            {
                MessageBox.Show("Bạn chưa nhập username", "Thông báo");
                txt_reg_username.Focus();
            }
            else if(txt_reg_password.Text == String.Empty)
            {
                MessageBox.Show("Bạn chưa nhập pasword", "Thông báo");
                txt_reg_password.Focus();
            }
            else if(ckb_male.Checked == true && ckb_female.Checked == true)
            {
                MessageBox.Show("Chỉ được chọn 1 giới tính", "Thông báo");
            }
            else if(ckb_male.Checked == false && ckb_female.Checked == false)
            {
                MessageBox.Show("Bạn chưa chọn giới tính", "Thông báo");
            }
            else if(cb_role.SelectedIndex < 0)
            {
                MessageBox.Show("Bạn chưa chọn chức vụ", "Thông báo");
                cb_role.Focus();
            }
            else
            {

                NhanVien newNV = new NhanVien();
                newNV.TenVN = txt_reg_fullname.Text;

                newNV.Diachi = txt_reg_address.Text;
                newNV.Email = txt_reg_email.Text;
                newNV.Sodienthoai = txt_reg_phone.Text;

                newNV.Username = txt_reg_username.Text;
                newNV.Userpassword = txt_reg_password.Text;
                
                if(ckb_male.Checked == true)
                {
                    newNV.Gioitinh = ckb_male.Text;
                }
                if(ckb_female.Checked == true)
                {
                    newNV.Gioitinh = ckb_female.Text;
                }
                
                switch(cb_role.SelectedIndex)
                {
                    case 0:
                        newNV.SetChucVu(new LoaiNhanVien("loainv02", "Nhân viên bán hàng"));
                        break;
                    case 1:
                        newNV.SetChucVu(new LoaiNhanVien("loainv03", "Thủ kho"));
                        break;
                }

                newNV.Ngaysinh = dtp_ngaysinh.Value;

                DataProvider provider = new DataProvider();
                provider.Insert_NhanVien(newNV);
                MessageBox.Show("Đã thêm thành công nhân viên mới.", "Thông báo");
                this.Close();
            }
        }

        private void txt_reg_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
