using StoreManager.DAL;
using StoreManager.DTO;
using StoreManager.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManager
{
    public partial class EmployeeForm : Form
    {
        private ConnectionString connection;
        private NhanVien nhanvien;
        private string username;
        private string password;
        private string avata;
        int rowindex;

        public EmployeeForm(NhanVien nhanvien)
        {
            this.nhanvien = nhanvien;
            InitializeComponent();
            connection = new ConnectionString();
        }

        private void ShowDetailEmployees()
        {
            // TODO: Show detail left panel
        }

        private void ShowEmployees()
        {
            DataProvider provider = new DataProvider();
            dgvEmployee.DataSource = provider.SelectAllNhanVien();
            dgvEmployee.Columns["username"].Visible = false;
            dgvEmployee.Columns["userpassword"].Visible = false;
            dgvEmployee.Columns["diachi"].Visible = false;
            dgvEmployee.Columns["maNV"].Visible = false;
            dgvEmployee.Columns["avata"].Visible = false;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            ShowEmployees();
            ShowDetailEmployees();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            
        }

        private void button_add_nhanvien_Click(object sender, EventArgs e)
        {
            EmployeeRegisterForm employeeRegisterForm = new EmployeeRegisterForm();
            employeeRegisterForm.ShowDialog();
            this.Refresh();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            int cb_index = cb_typesearch.SelectedIndex;
            string text = String.Empty;

            text = txt_search.Text.Trim();
            DataProvider provider = new DataProvider();

            //String query = "Select tenNV, sodienthoai, gioitinh, ngaysinh, email, LoaiNhanVien.tenloaiNV from NhanVien, LoaiNhanVien where NhanVien.maloaiNV = LoaiNhanVien.maloaiNV AND tenloaiNV like N\'%" + text +  "'";
            switch (cb_index)
            {
                case 0:
                    dgvEmployee.DataSource = provider.SelectNhanVien_ByName(text);
                    break;
                case 1:
                    dgvEmployee.DataSource = provider.SelectNhanVien_ByRole(text);
                    break;
                default:
                    break;
            }

            if (text == "")
            {
                ShowEmployees();
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowindex = e.RowIndex;
            avata = "";
            if(rowindex > -1)
            {
                txt_hoten.Text = dgvEmployee[1, e.RowIndex].Value.ToString();
                txt_sodienthoai.Text = dgvEmployee[2, e.RowIndex].Value.ToString();
                cb_gioitinh.Text = dgvEmployee[3, e.RowIndex].Value.ToString();
                dtp_ngaysinh.Text = dgvEmployee[4, e.RowIndex].Value.ToString();
                txt_email.Text = dgvEmployee[5, e.RowIndex].Value.ToString();
                txt_diachi.Text = dgvEmployee[6, e.RowIndex].Value.ToString();
                lbl_maNV.Text = dgvEmployee[0, e.RowIndex].Value.ToString();

                avata = dgvEmployee[10, e.RowIndex].Value.ToString();
                if(!avata.Equals(String.Empty))
                {
                    pic_avata.Image = Image.FromFile(avata);
                    pic_avata.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                else
                {
                    pic_avata.Image = Properties.Resources.No_picture;
                    pic_avata.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            else
            {
                ;
            }
        }

        private void cb_typesearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_typesearch.SelectedIndex > -1)
            {
                txt_search.Enabled = true;
            } else
            {
                txt_search.Enabled = false;
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            int result = provider.Update_NhanVien(txt_hoten.Text, cb_gioitinh.Text, dtp_ngaysinh.Value, txt_email.Text, txt_diachi.Text,lbl_maNV.Text);
            if(result > 0)
            {
                MessageBox.Show("Đã cập nhật thông tin nhân viên.", "Thông báo");
                ShowEmployees();
            } 
            else
            {
                MessageBox.Show("Cập nhật thông tin thất bại", "Thông báo");
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            EmployeeRegisterForm employeeRegisterForm = new EmployeeRegisterForm();
            employeeRegisterForm.ShowDialog();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvEmployee.Rows[rowindex];

            DataProvider provider = new DataProvider();
            int result = provider.Delete_NhanVien(row.Cells[0].Value.ToString());
            if(result > 0)
            {
                MessageBox.Show("Đã xóa nhân viên mã số: " + row.Cells[0].Value.ToString(), "Thông báo");
                ShowEmployees();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
        }

        private void btn_khoiphuc_Click(object sender, EventArgs e)
        {
        }

        private void txt_hoten_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pic_avata_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "PNG Files(*.PNG) | *.PNG";
            if (dlg.ShowDialog(this) == DialogResult.OK) {
                pic_avata.Image = Image.FromFile(dlg.FileName);
                pic_avata.SizeMode = PictureBoxSizeMode.StretchImage;

                FileInfo info = new FileInfo(dlg.FileName);
                string path_images = @"images/" + dgvEmployee[0, rowindex].Value.ToString() + ".png";
                info.CopyTo(path_images, true);

                DataProvider provider = new DataProvider();
                int result = provider.SaveImage(path_images, dgvEmployee[0, rowindex].Value.ToString());
                if(result > 0)
                {
                    MessageBox.Show("Cập nhật ảnh thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Cập nhật ảnh thất bại", "Thông báo");
                }
                //MessageBox.Show("Image filename: " + dlg.FileName, "Thông báo");
            }
        }
    }
}
