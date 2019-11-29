using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.DTO
{
    class HoaDon
    {
        private string maHD;
        private NhanVien nhanvien;
        private DateTime ngaylap;
        private int soluong;
        private float tongtien;
        private List<ChiTietHoaDon> listChiTietHoaDon = new List<ChiTietHoaDon>();

        public HoaDon() { }

        public HoaDon(string maHD, NhanVien nhanvien, DateTime ngaylap, int soluong, float tongtien, List<ChiTietHoaDon> listChiTietHoaDon)
        {
            this.maHD = maHD;
            this.nhanvien = nhanvien;
            this.ngaylap = ngaylap;
            this.soluong = soluong;
            this.tongtien = tongtien;
            this.listChiTietHoaDon = listChiTietHoaDon;
        }

        public string MaHD { get { return this.maHD; } set { this.maHD = value; } }
        public NhanVien Nhanvien { get { return this.nhanvien; } set { this.nhanvien = value; } }
        public DateTime Ngaylap { get { return this.ngaylap; } set { this.ngaylap = value; } }
        public int Soluong { get { return this.soluong; } set { this.soluong = value; } }
        public float Tongtien { get { return this.tongtien; } set { this.tongtien = value; } }
        public List<ChiTietHoaDon> Listchitiethoadon { get { return this.listChiTietHoaDon; } set { this.listChiTietHoaDon = value; } }
    }
}
