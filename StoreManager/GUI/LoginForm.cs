using StoreManager.DAL;
using StoreManager.DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace StoreManager
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            txt_username.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hệ thống quản lý cửa hàng điện nước v1.0", "Giới thiệu");
        }

        private void Form_Login_FormClosing(object sender, FormClosingEventArgs e)
        {  
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận thoát", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            NhanVien user = Authetication(); 
            if (user!=null)
            {
                MainForm main_form = new MainForm(user);
                this.Hide();
                main_form.ShowDialog();
                this.Show();
            } else
            {
                MessageBox.Show("Không thể tìm thấy tài khoản này.", "Thông báo");
                txt_username.Focus();
            }
        }
        
        private NhanVien Authetication()
        {

            String query = "dbo.p_findUser";
            NhanVien nv = null;
            ConnectionString connection = new ConnectionString();

            using(connection.getConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, connection.getConnection()))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@Username", SqlDbType.VarChar).Value = txt_username.Text.Trim();
                    cmd.Parameters.Add("@Userpassword", SqlDbType.VarChar).Value = txt_password.Text.Trim();

                    connection.openConnection();

                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);

                    if(dt.Rows.Count > 0)
                    {
                        nv = new NhanVien();
                        foreach(DataRow row in dt.Rows)
                        {
                            nv.MaNV = row["maNV"].ToString();
                            nv.TenVN = row["tenNV"].ToString();
                            nv.Diachi = row["diachi"].ToString();
                            nv.Sodienthoai = row["sodienthoai"].ToString();
                            nv.Username = row["username"].ToString();
                            nv.Userpassword = row["userpassword"].ToString();
                            nv.Ngaysinh = DateTime.Parse(row["ngaysinh"].ToString());
                            nv.Email = row["email"].ToString();
                            nv.Gioitinh = row["gioitinh"].ToString();
                            LoaiNhanVien cv = new LoaiNhanVien();
                            //cv.TenloaiNV = getLoaiNhanVien(cv.MaloaiNV, connection);
                            //MessageBox.Show("Info: " + cv.ToString(), "Thông báo");
                            nv.SetChucVu(new LoaiNhanVien(row["maloaiNV"].ToString(), row["tenloaiNV"].ToString()));
                            return nv;
                        }
                    } else
                    {
                        return nv;
                    }

                    connection.closeConnection();
                }
            }
            return nv;
        }

        private string getLoaiNhanVien(string maloaiNV, ConnectionString connection)
        {
            return "";
        }

        /*
        void searchForUser()
        {
            for (int i = 0; i <= 500; i++)
            {
                Thread.Sleep(10);
            }
        }
        */

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                txt_password.Focus();
            }
        }

        private void txt_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                btn_login.Focus();
            }
        }

        private void btn_login_KeyDown(object sender, KeyEventArgs e)
        {
            NhanVien user = Authetication();
            if (user != null)
            {
                MainForm main_form = new MainForm(user);
                this.Hide();
                main_form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Không thể tìm thấy tài khoản này.", "Thông báo");
                txt_username.Focus();
            }
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            if(txt_username.Text != "")
            {
                txt_username.Text = "";
            }
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if(txt_username.Text == "")
            {
                txt_username.Text = "Nhập username";
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text != "")
            {
                txt_password.Text = "";
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "Nhập password";
            }
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            if(txt_username.Text == "")
            {
                txt_username.ForeColor = SystemColors.InactiveCaption;
            }
            else
            {
                txt_username.ForeColor = Color.Black;
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.ForeColor = SystemColors.InactiveCaption;
            }
            else
            {
                txt_password.ForeColor = Color.Black;
            }
        }
    }
}
