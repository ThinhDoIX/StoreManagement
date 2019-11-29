using StoreManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StoreManager.DAL
{
    class DataProvider
    {
        private SqlConnection conn;
        private string query;

        public DataProvider()
        {
            this.conn = (new ConnectionString()).getConnection();
        }

        public int Update_NhanVien(string hoten, string gioitinh, DateTime ngaysinh, string email, string diachi, string manv)
        {

            query = "UPDATE NhanVien " +
                        "SET tenNV = @Hoten, " +
                            "gioitinh = @Gioitinh, " +
                            "ngaysinh = @Ngaysinh, " +
                            "email = @Email, " +
                            "diachi = @Diachi " +
                                "where maNV = @MaNV";
            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@Hoten", SqlDbType.NVarChar).Value = hoten;
                    cmd.Parameters.Add("@Gioitinh", SqlDbType.NVarChar).Value = gioitinh;
                    cmd.Parameters.Add("@Ngaysinh", SqlDbType.Date).Value = ngaysinh.Date;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
                    cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = diachi;
                    cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = manv;
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public int Delete_NhanVien(string manv)
        {
            query = "Update NhanVien SET hidden = 0 where maNV = @MaNV";

            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = manv;
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public void Insert_NhanVien(NhanVien nhanvien)
        {
            
            query = "Insert into NhanVien (maNV, " +
                                         "tenNV, " +
                                         "gioitinh, " +
                                         "diachi, " +
                                         "sodienthoai, " +
                                         "ngaysinh, " +
                                         "email, " +
                                         "maloaiNV, " +
                                         "username, " +
                                         "userpassword, " +
                                         "avata) values (@MaNV, @TenNV, @Gioitinh, @Diachi, @Sodienthoai, @Ngaysinh, @Email, @MaloaiNV, @Username, @Userpassword, @Avata)";
            
           
            string auto_maNV = GenerateAutoMaNhanVien();

            using (conn)
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = auto_maNV;
                    cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = nhanvien.TenVN;
                    cmd.Parameters.Add("@Gioitinh", SqlDbType.NVarChar).Value = nhanvien.Gioitinh;
                    cmd.Parameters.Add("@Diachi", SqlDbType.NVarChar).Value = nhanvien.Diachi;
                    cmd.Parameters.Add("@Sodienthoai", SqlDbType.VarChar).Value = nhanvien.Sodienthoai;
                    cmd.Parameters.Add("@Ngaysinh", SqlDbType.Date).Value = nhanvien.Ngaysinh.Date;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = nhanvien.Email;
                    cmd.Parameters.Add("@MaloaiNV", SqlDbType.VarChar).Value = nhanvien.getChucVu().MaloaiNV;
                    cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = nhanvien.Username;
                    cmd.Parameters.Add("@Userpassword", SqlDbType.VarChar).Value = nhanvien.Userpassword;
                    cmd.Parameters.Add("@Avata", SqlDbType.VarChar).Value = "";
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable SelectAllNhanVien()
        {
            String query = "Select maNV, tenNV, sodienthoai, gioitinh, ngaysinh, email, diachi, tenloaiNV, username, userpassword, avata " +
                                "from NhanVien, LoaiNhanVien " +
                                    "where NhanVien.maloaiNV = LoaiNhanVien.maloaiNV " +
                                        "and hidden = 1";
            DataTable dataEmployees = new DataTable();
            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dataEmployees);
                    return dataEmployees;
                }
            }
        }

        private string GenerateAutoMaNhanVien()
        {
            string q = "select top 1 maNV as [maxid] from NhanVien order by maNV DESC";
            string maxMaNhanVien = "";

            using (SqlCommand sqlcmd = new SqlCommand(q, conn))
            {
                conn.Open();
                SqlDataReader sdr = sqlcmd.ExecuteReader();
                while (sdr.Read())
                {
                    // Lấy dữ liệu cho từng cột
                    maxMaNhanVien = (string)sdr["maxid"];
                }
                sdr.Close();
            }

            if (maxMaNhanVien != String.Empty)
            {
                // nv01
                int rightNo = int.Parse(maxMaNhanVien.Substring(2));
                rightNo += 1;
                if (rightNo.ToString().Count() == 1)
                {
                    return "nv0" + rightNo.ToString();
                }
                else if (rightNo.ToString().Count() == 2)
                {
                    return "nv" + rightNo.ToString();
                }
                else
                {
                    maxMaNhanVien = "error";
                }
            }
            else
            {
                maxMaNhanVien = "error";
            }
            return maxMaNhanVien;
        }

        public DataTable SelectNhanVien_ByName(string name)
        {

            String query = "Select maNV, tenNV, sodienthoai, gioitinh, ngaysinh, email, diachi, tenloaiNV, username, userpassword, avata " +
                                "from NhanVien, LoaiNhanVien " +
                                    "where NhanVien.maloaiNV = LoaiNhanVien.maloaiNV " +
                                        "and NhanVien.tenNV like @TenNV " +
                                            "and hidden = 1";
            DataTable dt = new DataTable();
            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = "%" + name.Trim() + "%";

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable SelectNhanVien_ByRole(string role)
        {

            String query = "Select maNV, tenNV, sodienthoai, gioitinh, ngaysinh, email, diachi, tenloaiNV, username, userpassword, avata " +
                                "from NhanVien, LoaiNhanVien " +
                                    "where NhanVien.maloaiNV = LoaiNhanVien.maloaiNV " +
                                        "and LoaiNhanVien.tenloaiNV like @Chucvu " +
                                            "and hidden = 1";
            DataTable dt = new DataTable();
            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@Chucvu", SqlDbType.NVarChar).Value = "%" + role.Trim().ToLower() + "%";

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable SelectAllHangHoa()
        {
            string query = "SELECT maHH, tenHH, soluong, dongia, donvitinh, tenloaiHH, chatlieu " +
                            "FROM HangHoa, LoaiHangHoa, DonViTinh " +
                             "WHERE HangHoa.maloaiHH = LoaiHangHoa.maloaiHH " +
                                "and HangHoa.donvitinh = DonViTinh.tenDV " + 
                                    "and hidden = 1";
            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        public int Delete_HangHoa(string mahh)
        {
            query = "Update HangHoa SET hidden = 0 where maHH = @MaHH";

            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@MaHH", SqlDbType.VarChar).Value = mahh;
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public int Update_HangHoa(string tenHH, string dongia, string maHH)
        {

            query = "UPDATE HangHoa " +
                        "SET tenHH = @TenHH, " +
                            "dongia = @Dongia " +
                                "WHERE maHH = @MaHH ";
            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@TenHH", SqlDbType.NVarChar).Value = tenHH;
                    cmd.Parameters.Add("@Dongia", SqlDbType.Float).Value = float.Parse(dongia);
                    cmd.Parameters.Add("@MaHH", SqlDbType.VarChar).Value = maHH;
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable selectHangHoa_ByTinhTrang(string tinhtrang)
        {


            query = "SELECT maHH, tenHH, soluong, dongia, donvitinh, tenloaiHH, chatlieu " +
                        "FROM HangHoa, LoaiHangHoa, DonViTinh " +
                         "WHERE HangHoa.maloaiHH = LoaiHangHoa.maloaiHH " +
                            "and HangHoa.donvitinh = DonViTinh.tenDV " +
                                    "and soluong <> 0 " +
                                        "and hidden = 1";
            if (tinhtrang.Equals("hết hàng"))
            {
                query = "SELECT maHH, tenHH, soluong, dongia, donvitinh, tenloaiHH, chatlieu " +
                           "FROM HangHoa, LoaiHangHoa, DonViTinh " +
                            "WHERE HangHoa.maloaiHH = LoaiHangHoa.maloaiHH " +
                               "and HangHoa.donvitinh = DonViTinh.tenDV " +
                                       "and soluong = 0 " +
                                            "and hidden = 1";
            } 

            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable selectHangHoa_ById(string maHH)
        {
            query = "SELECT maHH, tenHH, soluong, dongia, donvitinh, tenloaiHH, chatlieu " +
                            "FROM HangHoa, LoaiHangHoa, DonViTinh " +
                             "WHERE HangHoa.maloaiHH = LoaiHangHoa.maloaiHH " +
                                "and HangHoa.donvitinh = DonViTinh.tenDV " +
                                    "and maHH like @MaHH " +
                                    "and hidden = 1";
            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@MaHH", SqlDbType.VarChar).Value = "%" + maHH.Trim() + "%";

                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable selectHangHoa_ByName(string tenHH)
        {
            query = "SELECT maHH, tenHH, soluong, dongia, donvitinh, tenloaiHH, chatlieu " +
                            "FROM HangHoa, LoaiHangHoa, DonViTinh " +
                             "WHERE HangHoa.maloaiHH = LoaiHangHoa.maloaiHH " +
                                "and HangHoa.donvitinh = DonViTinh.tenDV " +
                                    "and tenHH like @TenHH " +
                                    "and hidden = 1";
            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@TenHH", SqlDbType.NVarChar).Value = "%" + tenHH.Trim() + "%";

                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable selectHangHoa_ByLoaiHangHoa(string tenloaiHH)
        {


            string query = "SELECT maHH, tenHH, soluong, dongia, donvitinh, tenloaiHH, chatlieu " +
                            "FROM HangHoa, LoaiHangHoa, DonViTinh " +
                             "WHERE HangHoa.maloaiHH = LoaiHangHoa.maloaiHH " +
                                "and HangHoa.donvitinh = DonViTinh.tenDV " +
                                    "and tenloaiHH = @TenloaiHH " +
                                        "and hidden = 1";

            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@TenloaiHH", SqlDbType.NVarChar).Value = tenloaiHH;

                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        public string SophieuGenerator()
        {
            query = "Select top 1 maPNK as [sophieu] from PhieuNhapKho ORDER BY maPNK DESC";

            
            using (conn)
            {
                string sophieu = "";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn)) {
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if(sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            // Lấy dữ liệu cho từng cột
                            sophieu = sdr["sophieu"].ToString();
                        }
                        sophieu = Regex.Match(sophieu, @"\d+").Value;
                        int num = Convert.ToInt32(sophieu) + 1;
                        return "PNK" + num.ToString();
                    }
                    else
                    {
                        return "PNK1";
                    }
                }
            }
        }

        public DataTable selectHangHoa_ByTenHangHoa(string tenHH)
        {


            string query = "SELECT maHH, tenHH, soluong, dongia, donvitinh, tenloaiHH, chatlieu " +
                            "FROM HangHoa, LoaiHangHoa, DonViTinh " +
                             "WHERE HangHoa.maloaiHH = LoaiHangHoa.maloaiHH " +
                                "and HangHoa.donvitinh = DonViTinh.tenDV " +
                                    "and tenHH = @TenHH " +
                                        "and hidden = 1";

            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@TenHH", SqlDbType.NVarChar).Value = tenHH;

                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        public int SaveImage(string path, string maNV)
        {
            query = "Update NhanVien Set avata = @Avata where maNV = @maNV";

            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@Avata", SqlDbType.VarChar).Value = path;
                    cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = maNV;

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public int Insert_PhieuNhapKho(PhieuNhapKho pnk)
        {
            query = "INSERT INTO PhieuNhapKho VALUES (@MaPNK, @Ngaylap, @Tongtien, @MaNV, @MaNCC)";

            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@MaPNK", SqlDbType.VarChar).Value = pnk.MaPNK;
                    cmd.Parameters.Add("@Ngaylap", SqlDbType.Date).Value = pnk.Ngaylap.Date;
                    cmd.Parameters.Add("@Tongtien", SqlDbType.Float).Value = pnk.Tongtien;
                    cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = pnk.Nhanvien.MaNV;
                    cmd.Parameters.Add("@MaNCC", SqlDbType.VarChar).Value = pnk.MaNCC;
                    
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public void Insert_ChiTietPhieuNhapKho(ChiTietPhieuNhapKho chitiet)
        {
            query = "INSERT INTO ChiTietPhieuNhapKho (maPNK, maHH, tenHH, soluong, dongia, thanhtien) " +
                                             "VALUES (@MaPNK, @MaHH, @TenHH, @Soluong, @Dongia, @Thanhtien)";
            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@MaPNK", SqlDbType.VarChar).Value = chitiet.SoPhieu;
                    cmd.Parameters.Add("@MaHH", SqlDbType.VarChar).Value = chitiet.MaHH;
                    cmd.Parameters.Add("@TenHH", SqlDbType.NVarChar).Value = chitiet.TenHH;
                    cmd.Parameters.Add("@Soluong", SqlDbType.Int).Value = chitiet.Soluong;
                    cmd.Parameters.Add("@Dongia", SqlDbType.Float).Value = float.Parse(chitiet.Dongia);
                    cmd.Parameters.Add("@Thanhtien", SqlDbType.Float).Value = double.Parse(chitiet.Thanhtien);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public string Select_NCCByName(String tenNCC)
        {
            query = "SELECT maNCC FROM NhaCungCap WHERE tenNCC = @TenNCC";

            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@TenNCC", SqlDbType.NVarChar).Value = tenNCC;
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while(sdr.Read())
                    {
                        return sdr["maNCC"].ToString();
                    }
                }
            }
            return "";
        }

        public string HoadonID_generator()
        {
            query = "Select top 1 maHD as [sohoadon] from HoaDon ORDER BY maHD DESC";


            using (conn)
            {
                string sohoadon = "";
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.HasRows)
                    {
                        while (sdr.Read())
                        {
                            // Lấy dữ liệu cho từng cột
                            sohoadon = sdr["sohoadon"].ToString();
                        }
                        sohoadon = Regex.Match(sohoadon, @"\d+").Value;
                        int num = Convert.ToInt32(sohoadon) + 1;
                        return "HD" + num.ToString();
                    }
                    else
                    {
                        return "HD1";
                    }
                }
            }
        }


        public int Insert_HoaDon(HoaDon hd)
        {
            query = "INSERT INTO HoaDon VALUES (@MaHD, @MaNV, @Ngaylap, @Soluong, @Tongtien)";

            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = hd.MaHD;
                    cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = hd.Nhanvien.MaNV;
                    cmd.Parameters.Add("@Ngaylap", SqlDbType.Date).Value = hd.Ngaylap.Date;
                    cmd.Parameters.Add("@Soluong", SqlDbType.Int).Value = (Int32)hd.Soluong;
                    cmd.Parameters.Add("@Tongtien", SqlDbType.Float).Value = hd.Tongtien;

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public void Insert_ChiTietHoaDon(ChiTietHoaDon chitiet)
        {
            query = "INSERT INTO ChiTietHoaDon (maHD, maHH, tenHH, dongia, soluong, thanhtien) " +
                                             "VALUES (@MaHD, @MaHH, @TenHH, @Dongia, @Soluong, @Thanhtien)";
            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = chitiet.MaHD;
                    cmd.Parameters.Add("@MaHH", SqlDbType.VarChar).Value = chitiet.MaHH;
                    cmd.Parameters.Add("@TenHH", SqlDbType.NVarChar).Value = chitiet.TenHH;
                    cmd.Parameters.Add("@Soluong", SqlDbType.Int).Value = chitiet.Soluong;
                    cmd.Parameters.Add("@Dongia", SqlDbType.Float).Value = float.Parse(chitiet.Dongia);
                    cmd.Parameters.Add("@Thanhtien", SqlDbType.Float).Value = double.Parse(chitiet.Thanhtien);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable Select_Report()
        {
            query = "select maHD, tenNV, ngaylap, soluong, tongtien from HoaDon, NhanVien WHERE HoaDon.maNV = NhanVien.maNV";

            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                { 
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable Select_Report_ChiTiet(string maHD)
        {
            query = "select HangHoa.tenHH, ChiTietHoaDon.soluong, ChiTietHoaDon.thanhtien " +
                        "FROM HoaDon, ChiTietHoaDon, HangHoa " +
                            "WHERE ChiTietHoaDon.maHH = HangHoa.maHH " +
                                "and ChiTietHoaDon.maHD = HoaDon.maHD " +
                                    "and ChiTietHoaDon.maHD = @MaHD";

            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@MaHD", SqlDbType.VarChar).Value = maHD;

                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        public DataTable Select_FindReportByName(string tenNV)
        {
            query = "select HoaDon.maHD, NhanVien.tenNV, HoaDon.ngaylap, HoaDon.soluong, HoaDon.tongtien " +
                        "FROM HoaDon, ChiTietHoaDon, HangHoa, NhanVien " +
                            "WHERE ChiTietHoaDon.maHH = HangHoa.maHH " +
                                "and ChiTietHoaDon.maHD = HoaDon.maHD " +
                                    "and HoaDon.maNV = NhanVien.maNV " +
                                        "and NhanVien.tenNV = @TenNV";

            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar).Value = tenNV;

                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
        }

        /*
        public DataTable Select_Report(NhanVien nhanvien)
        {
            query = "select maHD, tenNV, ngaylap, soluong, tongtien from HoaDon, NhanVien WHERE HoaDon.maNV = NhanVien.maNV and HoaDon.maNV = @MaNV";

            using (conn)
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@MaNV", SqlDbType.VarChar).Value = nhanvien.MaNV;

                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
        } */
    }
}
