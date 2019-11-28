using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.DTO
{
    class PhieuNhapKho
    {
        private string maPNK;
        private NhanVien nhanvien;
        private string maNCC;
        private DateTime ngaylap;
        private float tongtien;
        private List<ChiTietPhieuNhapKho> listchitietPNK = new List<ChiTietPhieuNhapKho>();

        public PhieuNhapKho() { }

        public PhieuNhapKho(string maPNK, NhanVien nhanvien, string maNCC, DateTime ngaylap, float tongtien, List<ChiTietPhieuNhapKho> listchitietPNK)
        {
            this.maPNK = maPNK;
            this.nhanvien = nhanvien;
            this.maNCC = maNCC;
            this.ngaylap = ngaylap;
            this.tongtien = tongtien;
            this.listchitietPNK = listchitietPNK;
        }

        public string MaPNK { get { return this.maPNK; } set { this.maPNK = value; } }
        public NhanVien Nhanvien { get { return this.nhanvien; } set { this.nhanvien = value; } }
        public string MaNCC { get { return this.maNCC; } set { this.maNCC = value; } }
        public DateTime Ngaylap { get { return this.ngaylap; } set { this.ngaylap = value; } }
        public float Tongtien { get { return this.tongtien; } set { this.tongtien = value; } }
        public List<ChiTietPhieuNhapKho> ListchitietPNK { get { return this.listchitietPNK; } set { this.listchitietPNK = value; } }
    }
}
