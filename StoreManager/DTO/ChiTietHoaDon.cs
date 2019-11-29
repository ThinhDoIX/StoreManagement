using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.DTO
{
    class ChiTietHoaDon
    {
        private string maHD;
        private string maHH;
        private string tenHH;
        private string dongia;
        private string soluong;
        private string thanhtien;

        public ChiTietHoaDon() { }

        public ChiTietHoaDon(string maHD, string maHH, string tenHH, string dongia, string soluong, string thanhtien)
        {
            this.maHD = maHD;
            this.maHH = maHH;
            this.dongia = dongia;
            this.soluong = soluong;
            this.thanhtien = thanhtien;
        }

        public string MaHD { get { return this.maHD; } set { this.maHD = value; } }
        public string MaHH { get { return this.maHH; } set { this.maHH = value; } }
        public string TenHH { get { return this.tenHH; } set { this.tenHH = value; } }
        public string Dongia { get { return this.dongia; } set { this.dongia = value; } }
        public string Soluong { get { return this.soluong; } set { this.soluong = value; } }
        public string Thanhtien { get { return this.thanhtien; } set { this.thanhtien = value; } }
    }
}
