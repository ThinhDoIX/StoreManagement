using StoreManager.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.DTO
{
    public class NhanVien
    {
        private String maNV;
        private String tenNV;
        private String gioitinh;
        private String diachi;
        private String sodienthoai;
        private DateTime ngaysinh;
        private string email;
        private String username;
        private String userpassword;
        private String image;
        //private int hidden;
        private LoaiNhanVien chucvu;
        //private List<HoaDon> danhsachHD;
        //private List<PhieuNhapKho> danhsachPNK;

        public NhanVien()
        {
            this.maNV = "";
            this.tenNV = "";
            this.gioitinh = "";
            this.sodienthoai = "";
            this.ngaysinh = DateTime.Today;
            this.diachi = "";
            this.chucvu = new LoaiNhanVien();
            this.email = "";
            this.image = "";
            this.username = "";
            this.userpassword = "";
            //this.hidden = 1;
        }

        public NhanVien(string maNV, string tenNV, String gioitinh, string sodienthoai, DateTime ngaysinh, LoaiNhanVien chucvu, string username, string userpassword, int hidden)
        {
            this.maNV = maNV;
            this.tenNV = tenNV;
            this.gioitinh = gioitinh;
            this.sodienthoai = sodienthoai;
            this.ngaysinh = ngaysinh;
            this.chucvu = chucvu;
            this.username = username;
            this.userpassword = userpassword;
            //this.hidden = 1;
        }

        public string MaNV { get { return this.maNV; } set { this.maNV = value; } }
        public string TenVN { get { return this.tenNV; } set { this.tenNV = value; } }
        public string Gioitinh { get { return this.gioitinh; } set { this.gioitinh = value; } }
        public string Diachi { get { return this.diachi; } set { this.diachi = value; } }
        public string Sodienthoai { get { return this.sodienthoai; } set { this.sodienthoai = value; } }
        public DateTime Ngaysinh { get { return this.ngaysinh; } set { this.ngaysinh = value; } }
        public string Email { get { return this.email; } set { this.email = value; } }
        public string Username { get { return this.username; } set { this.username = value; } }
        public string Userpassword { get { return this.userpassword; } set { this.userpassword = value; } }
        public string Image { get { return this.image; } set { this.image = value; } }
        //public int Hidden { get { return this.hidden; } set { this.hidden = value; } }
        public LoaiNhanVien getChucVu()
        {
            return this.chucvu;
        }
        public void SetChucVu(LoaiNhanVien chucvu)
        {
            this.chucvu = chucvu;
        }

        public void Copy(NhanVien nhanvien)
        {
            this.maNV = nhanvien.MaNV;
            this.tenNV = nhanvien.TenVN;
            this.gioitinh = nhanvien.Gioitinh;
            this.sodienthoai = nhanvien.Sodienthoai;
            this.ngaysinh = nhanvien.Ngaysinh;
            this.diachi = nhanvien.Diachi;
            this.chucvu = nhanvien.getChucVu();
            this.username = nhanvien.Username;
            this.userpassword = nhanvien.Userpassword;
            this.image = nhanvien.Image;
            this.email = nhanvien.Email;
            //this.hidden = 1;
        }

        public override bool Equals(object obj)
        {
            var vien = obj as NhanVien;
            return vien != null &&
                   username == vien.username &&
                   userpassword == vien.userpassword;
        }

        public override string ToString()
        {
            return "Nhân viên: " + this.tenNV + ", Giới tính: " + this.gioitinh + ", Chức vụ: " + this.chucvu.ToString();
        }
    }
}
