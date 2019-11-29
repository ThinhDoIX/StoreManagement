using StoreManager.DAL;
using StoreManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManager
{
    public partial class OrderForm : Form
    {
        private DataProvider provider;
        private NhanVien nhanvien;
        private float tongtienHD = 0;
        private double dg;
        private int sl;
        private int rowIndex = -1;

        public OrderForm(NhanVien nhanvien)
        {
            InitializeComponent();

            this.nhanvien = nhanvien;

            generateDefaultInfomation();
        }

        private void generateDefaultInfomation()
        {
            // Tạo ID tự động cho hóa đơn
            this.provider = new DataProvider();
            txt_maHD.Text = this.provider.HoadonID_generator();

            // Lấy thông tin nhân viên hiện tại đăng nhập
            txt_maNV.Text = nhanvien.MaNV;
            txt_tenNV.Text = nhanvien.TenVN;

            //

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_maHH_TextChanged(object sender, EventArgs e)
        {
            /*
            if(txt_maHH.Text != "")
            {
                cb_tenHH.Enabled = false;
                btn_timkiem.Enabled = true;
            }
            else
            {
                cb_tenHH.Enabled = true;
            }
            */
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            if(txt_maHH.Text != "")
            {
                this.provider = new DataProvider();

                DataTable dt = this.provider.selectHangHoa_ById(txt_maHH.Text);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        txt_maHH.Text = row["maHH"].ToString();
                        txt_tenHH.Text = row["tenHH"].ToString();
                        txt_tenloaiHH.Text = row["tenloaiHH"].ToString();
                        txt_mota.Text = row["chatlieu"].ToString();
                        txt_soluong.Text = row["soluong"].ToString();
                        txt_dongia.Text = String.Format("{0:0,000.###}", 1.4 * double.Parse(row["dongia"].ToString()));
                        break;
                    }
                }
                if (txt_soluong.Text == "0")
                {
                    MessageBox.Show("Sản phẩm này đã hết hàng", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã hàng hóa", "Thông báo");
            }
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDBDataSet7.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.storeDBDataSet7.HangHoa);

        }

        private void cb_tenHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tenHH.Text != null)
            {
                btn_timkiem.Enabled = false;

                this.provider = new DataProvider();

                DataTable dt = this.provider.selectHangHoa_ByName(cb_tenHH.Text);

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        txt_maHH.Text = row["maHH"].ToString();
                        txt_tenHH.Text = row["tenHH"].ToString();
                        txt_tenloaiHH.Text = row["tenloaiHH"].ToString();
                        txt_mota.Text = row["chatlieu"].ToString();
                        txt_soluong.Text = row["soluong"].ToString();
                        txt_dongia.Text = String.Format("{0:0,000.###}", 1.4 * double.Parse(row["dongia"].ToString()));
                        break;
                    }
                }
                if (txt_soluong.Text == "0")
                {
                    MessageBox.Show("Sản phẩm này đã hết hàng", "Thông báo");
                }
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numeric_soluong.Value) > 0)
            {
                if(Convert.ToInt32(numeric_soluong.Value) <= Convert.ToInt32(txt_soluong.Text))
                {
                    // Tạo một dòng dữ liệu mới
                    int rowIndex = dgv_chitietHD.Rows.Add();

                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow = dgv_chitietHD.Rows[rowIndex];
                    newRow.Cells["maHH"].Value = txt_maHH.Text;
                    newRow.Cells["tenHH"].Value = cb_tenHH.Text;
                    newRow.Cells["dongia"].Value = String.Format("{0:0,000.###}", double.Parse(txt_dongia.Text));
                    newRow.Cells["soluong"].Value = numeric_soluong.Value.ToString();
                    newRow.Cells["thanhtien"].Value = txt_thanhtien.Text;

                    this.tongtienHD += float.Parse(txt_thanhtien.Text);
                    txt_tongtien.Text = String.Format("{0:0,000.###}", double.Parse(this.tongtienHD.ToString()));
                }
                else
                {
                    MessageBox.Show("Vượt quá số lượng tồn", "Thông báo");
                    numeric_soluong.Value = Convert.ToInt32(txt_soluong.Text);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập số lượng", "Thông báo");
            }
        }

        private void numeric_soluong_ValueChanged(object sender, EventArgs e)
        {
            if(numeric_soluong.Value > 0)
            {
                dg = double.Parse(txt_dongia.Text);
                sl = Convert.ToInt32(numeric_soluong.Value);

                txt_thanhtien.Text = String.Format("{0:0,000.###}", double.Parse((dg * sl).ToString()));
            }
            else
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Thông báo");
                numeric_soluong.Value = 0;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(dgv_chitietHD[0,0].Value != null)
            {
                if (this.rowIndex > -1)
                {
                    DialogResult delete_commit = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                    if (delete_commit == DialogResult.Yes)
                    {
                        dgv_chitietHD.Rows.RemoveAt(this.rowIndex);
                        this.rowIndex = -1;
                    }
                    else if (delete_commit == DialogResult.No)
                    {
                        ;
                    }
                    else
                    {
                        ;
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa chọn mục để xóa.", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Chưa có mục nào dể xóa", "Thông báo");
            }
            
        }

        private void dgv_chitietHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.rowIndex = e.RowIndex;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon();
            hd.MaHD = txt_maHD.Text;
            hd.Nhanvien = nhanvien;
            hd.Ngaylap = dtp_ngaylap.Value;
            hd.Tongtien = float.Parse(txt_tongtien.Text);

            List<ChiTietHoaDon> listchitiet = new List<ChiTietHoaDon>();
            ChiTietHoaDon cthd;
            for (int i = 0; i < dgv_chitietHD.Rows.Count - 1; i++)
            {
                cthd = new ChiTietHoaDon();

                if (dgv_chitietHD[0, i].Value != null)
                {
                    cthd.MaHD = txt_maHD.Text;

                    cthd.MaHH = dgv_chitietHD[0, i].Value.ToString();
                    cthd.TenHH = dgv_chitietHD[1, i].Value.ToString();
                    cthd.Dongia = dgv_chitietHD[2, i].Value.ToString();
                    cthd.Soluong = dgv_chitietHD[3, i].Value.ToString();

                    hd.Soluong += Int32.Parse(cthd.Soluong);

                    cthd.Thanhtien = dgv_chitietHD[4, i].Value.ToString();
                }
                listchitiet.Add(cthd);
            }
            hd.Listchitiethoadon = listchitiet;

            provider = new DataProvider();

            // STOP
            int hd_success = provider.Insert_HoaDon(hd);

            if (hd_success > 0 && dgv_chitietHD.Rows.Count > 0)
            {
                foreach (ChiTietHoaDon chitiet in listchitiet)
                {
                    provider = new DataProvider();
                    provider.Insert_ChiTietHoaDon(chitiet);
                }
            }

            if (hd_success > 0)
            {
                MessageBox.Show("Lập hóa đơn thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lập hóa đơn thất bại", "Thông báo");
            }
        }
    }
}
