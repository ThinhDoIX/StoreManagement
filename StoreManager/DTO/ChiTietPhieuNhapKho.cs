using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.DTO
{
    class ChiTietPhieuNhapKho
    {
        private string sophieu;
        private string maHH;
        private string tenHH;
        private string soluong;
        private string dongia;
        private string thanhtien;

        public ChiTietPhieuNhapKho() { }

        public ChiTietPhieuNhapKho(string sophieu, string maHH, string tenHH, string soluong, string dongia, string thanhtien)
        {
            this.sophieu = sophieu;
            this.maHH = maHH;
            this.tenHH = tenHH;
            this.soluong = soluong;
            this.dongia = dongia;
            this.thanhtien = thanhtien;
        }

        public string SoPhieu { get { return this.sophieu;  } set { this.sophieu = value; } }
        public string MaHH { get { return this.maHH; } set { this.maHH = value; } }
        public string TenHH { get { return this.tenHH; } set { this.tenHH = value; } }
        public string Soluong { get { return this.soluong; } set { this.soluong = value; } }
        public string Dongia { get { return this.dongia; } set { this.dongia = value; } }
        public string Thanhtien { get { return this.thanhtien; } set { this.thanhtien = value; } }
    }
}
