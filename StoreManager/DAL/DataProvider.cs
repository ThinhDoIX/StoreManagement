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
                    while (sdr.Read())
                    {
                        // Lấy dữ liệu cho từng cột
                        sophieu = sdr["sophieu"].ToString();
                    }
                }
                sophieu = Regex.Match(sophieu, @"\d+").Value;
                int num = Convert.ToInt32(sophieu) + 1;
                return "PNK" + num;
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
    }
}
