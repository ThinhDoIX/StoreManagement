using StoreManager.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
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

            string auto_maNV = generateAutoMaNhanVien();

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

            conn.Close();
        }

        public DataTable selectAllNhanVien()
        {
            String query = "Select maNV, tenNV, sodienthoai, gioitinh, ngaysinh, email, diachi, tenloaiNV, username, userpassword " +
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

        private string generateAutoMaNhanVien()
        {
            /*
            using (conn) {
                conn.Open();
                using (SqlCommand sqlcmd = new SqlCommand(q, conn))
                {
                    SqlDataReader sdr = sqlcmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        // Lấy dữ liệu cho từng cột
                        maxMaNhanVien = (string)sdr["maxid"];
                    }
                }
            }
            */
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

            String query = "Select tenNV, sodienthoai, gioitinh, ngaysinh, email, diachi, tenloaiNV, username, userpassword " +
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

            String query = "Select tenNV, sodienthoai, gioitinh, ngaysinh, email, diachi, tenloaiNV, username, userpassword " +
                                "from NhanVien, LoaiNhanVien " +
                                    "where NhanVien.maloaiNV = LoaiNhanVien.maloaiNV " +
                                        "and LoaiNhanVien.tenloaiNV like @Chucvu" +
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
    }
}
