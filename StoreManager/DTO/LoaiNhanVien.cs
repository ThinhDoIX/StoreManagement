using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreManager.DTO
{
    public class LoaiNhanVien
    {
        private string maloaiNV;
        private string tenloaiNV;

        public LoaiNhanVien()
        {
            this.maloaiNV = "";
            this.tenloaiNV = "";
        }

        public LoaiNhanVien(string maloaiNV, string tenloaiNV)
        {
            this.maloaiNV = maloaiNV;
            this.tenloaiNV = tenloaiNV;
        }

        public string MaloaiNV { get { return this.maloaiNV; } set { this.maloaiNV = value; } }
        public string TenloaiNV { get { return this.tenloaiNV; } set { this.tenloaiNV = value; } }

        public override string ToString()
        {
            return "Loại nhân viên: " + this.tenloaiNV;
        }
    }
}
