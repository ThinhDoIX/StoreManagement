using StoreManager.DAL;
using StoreManager.DTO;
using StoreManager.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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

        public EmployeeForm(NhanVien nhanvien)
        {
            this.nhanvien = nhanvien;
            InitializeComponent();
            connection = new ConnectionString();
        }

        private void showDetailEmployees()
        {
            // TODO: Show detail left panel
        }

        private void showEmployees()
        {
            DataProvider provider = new DataProvider();
            dgvEmployee.DataSource = provider.selectAllNhanVien();
            dgvEmployee.Columns["username"].Visible = false;
            dgvEmployee.Columns["userpassword"].Visible = false;
            dgvEmployee.Columns["diachi"].Visible = false;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            showEmployees();
            showDetailEmployees();
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
                showEmployees();
            }
        }

        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvEmployee.SelectedRows != null)
            {
                txt_hoten.Text = dgvEmployee[0, e.RowIndex].Value.ToString();
                txt_sodienthoai.Text = dgvEmployee[1, e.RowIndex].Value.ToString();
                txt_gioitinh.Text = dgvEmployee[2, e.RowIndex].Value.ToString();
                dtp_ngaysinh.Text = dgvEmployee[3, e.RowIndex].Value.ToString();
                txt_email.Text = dgvEmployee[4, e.RowIndex].Value.ToString();
                txt_diachi.Text = dgvEmployee[5, e.RowIndex].Value.ToString();
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
    }
}
