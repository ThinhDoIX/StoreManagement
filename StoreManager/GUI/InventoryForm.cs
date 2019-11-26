using StoreManager.DAL;
using StoreManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManager
{
    public partial class InventoryForm : Form
    {
        private int currentRowIndex;
        private CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");

        public InventoryForm()
        {
            InitializeComponent();
            cb_tenloaiHH.SelectedIndex = -1;
            showHangHoa();
        }

        private void showHangHoa()
        {
            DataProvider provider = new DataProvider();
            dgvHangHoa.DataSource = provider.SelectAllHangHoa();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRowIndex = e.RowIndex;
            
            if(e.RowIndex > -1)
            {
                txt_maHH.Text = dgvHangHoa[0, e.RowIndex].Value.ToString();
                txt_tenHH.Text = dgvHangHoa[1, e.RowIndex].Value.ToString();
                txt_soluong.Text = dgvHangHoa[2, e.RowIndex].Value.ToString();

                string dongia = dgvHangHoa[3, e.RowIndex].Value.ToString();
                if(!dongia.Equals(String.Empty))
                {
                    string dg = double.Parse(dongia).ToString("#,###", cul.NumberFormat);
                    txt_dongia.Text = dg;
                }
                else
                {
                    txt_dongia.Text = dongia;
                }
                

                txt_donvitinh.Text = dgvHangHoa[4, e.RowIndex].Value.ToString();
                cb_loaiHH.Text = dgvHangHoa[5, e.RowIndex].Value.ToString();
            }
            else
            {
                ;
            }
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDBDataSet3.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.storeDBDataSet3.NhaCungCap);
            // TODO: This line of code loads data into the 'storeDBDataSet2.LoaiHangHoa' table. You can move, or remove it, as needed.
            this.loaiHangHoaTableAdapter1.Fill(this.storeDBDataSet2.LoaiHangHoa);
            // TODO: This line of code loads data into the 'storeDBDataSet1.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.storeDBDataSet1.HangHoa);
            // TODO: This line of code loads data into the 'storeDBDataSet.LoaiHangHoa' table. You can move, or remove it, as needed.
            this.loaiHangHoaTableAdapter.Fill(this.storeDBDataSet.LoaiHangHoa);

            cb_tenloaiHH.SelectedIndex = -1;
            cb_nhacungcap.SelectedIndex = -1;

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dgvHangHoa.Rows[currentRowIndex];

            DataProvider provider = new DataProvider();
            int result = provider.Delete_HangHoa(row.Cells[0].Value.ToString());
            if (result > 0)
            {
                MessageBox.Show("Đã xóa hàng hóa mã số: " + row.Cells[0].Value.ToString(), "Thông báo");
                showHangHoa();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            int result = provider.Update_HangHoa(txt_tenHH.Text, txt_dongia.Text, txt_maHH.Text);
            if(result > 0)
            {
                MessageBox.Show("Đã cập nhật hàng hóa", "Thông báo");
                showHangHoa();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
            }
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            showHangHoa();
            cb_tenloaiHH.SelectedIndex = -1;
            cb_nhacungcap.SelectedIndex = -1;
        }

        private void txt_search_maHH_TextChanged(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            dgvHangHoa.DataSource = provider.selectHangHoa_ById(txt_search_maHH.Text);

            if ((txt_search_maHH.Text).Equals(String.Empty))
            {
                showHangHoa();
            }
        }

        private void txt_search_tenHH_TextChanged(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            dgvHangHoa.DataSource = provider.selectHangHoa_ByName(txt_search_tenHH.Text);

            if ((txt_search_tenHH.Text).Equals(String.Empty))
            {
                showHangHoa();
            }
        }

        private void cb_tenloaiHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            dgvHangHoa.DataSource = provider.selectHangHoa_ByLoaiHangHoa(cb_tenloaiHH.Text);
            
            if(cb_tenloaiHH.Text == "")
            {
                showHangHoa();
            }
        }

        private void cb_tinhtrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            dgvHangHoa.DataSource = provider.selectHangHoa_ByTinhTrang(cb_tinhtrang.Text.Trim().ToLower());
        }
    }
}
