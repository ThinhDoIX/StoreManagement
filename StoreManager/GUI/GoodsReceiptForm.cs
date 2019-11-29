using StoreManager.DAL;
using StoreManager.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreManager.GUI
{
    public partial class GoodsReceiptForm : Form
    {
        private NhanVien nhanvien;
        private CultureInfo cul = CultureInfo.GetCultureInfo("vi-VN");
        private float tongtienPNK = 0F;
        private int sl;
        private double dg;
        private DataProvider provider;
        private int rowIndex = -1;

        public GoodsReceiptForm(NhanVien nhanvien)
        {
            InitializeComponent();
            this.nhanvien = nhanvien;
        }

        private void GoodsReceiptForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDBDataSet5.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.storeDBDataSet5.HangHoa);
            // TODO: This line of code loads data into the 'storeDBDataSet4.NhaCungCap' table. You can move, or remove it, as needed.
            this.nhaCungCapTableAdapter.Fill(this.storeDBDataSet4.NhaCungCap);
            // Tạo số phiếu
            provider = new DataProvider();
            txt_sophieu.Text = provider.SophieuGenerator();
            dtp_ngaylap.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txt_tenNV.Text = nhanvien.TenVN;
            txt_maNV.Text = nhanvien.MaNV;

            provider = new DataProvider();
            string maNCC = provider.Select_NCCByName(cb_tenNCC.Text);
            txt_maNCC.Text = maNCC;
        }

        private void cb_tenHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            numeric_soluong.Value = 0;
            DataProvider provider = new DataProvider();
            DataTable product_dt = provider.selectHangHoa_ByTenHangHoa(cb_tenHH.Text);

            if(product_dt.Rows.Count > 0)
            {
                foreach(DataRow row in product_dt.Rows)
                {
                    txt_maHH.Text = row["maHH"].ToString();
                    
                    txt_dongia.Text = String.Format("{0:0,000.###}", double.Parse(row["dongia"].ToString()));

                    txt_donvitinh.Text = row["donvitinh"].ToString();
                    break;
                }
            }
        }

        private void txt_dongia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(Convert.ToInt32(numeric_soluong.Value) > 0)
            {
                // Tạo một dòng dữ liệu mới
                int rowIndex = dgv_chitietPNK.Rows.Add();

                DataGridViewRow newRow = new DataGridViewRow();
                newRow = dgv_chitietPNK.Rows[rowIndex];
                newRow.Cells[0].Value = txt_maHH.Text;
                newRow.Cells[1].Value = cb_tenHH.Text;
                newRow.Cells[2].Value = txt_dongia.Text;
                newRow.Cells[3].Value = numeric_soluong.Value.ToString();
                newRow.Cells[4].Value = txt_thanhtien.Text;

                this.tongtienPNK += float.Parse(txt_thanhtien.Text);
                lbl_thanhtien.Text = String.Format("{0:0,000.###}", double.Parse(this.tongtienPNK.ToString()));
            }
            else
            {
                MessageBox.Show("Chưa nhập số lượng", "Thông báo");
            }
        }

        private void dgv_chitiethd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            PhieuNhapKho pnk = new PhieuNhapKho();
            pnk.Nhanvien = nhanvien;
            pnk.MaPNK = txt_sophieu.Text;
            pnk.MaNCC = txt_maNCC.Text;
            pnk.Ngaylap = dtp_ngaylap.Value;
            pnk.Tongtien = float.Parse(lbl_thanhtien.Text);

            List<ChiTietPhieuNhapKho> listchitiet = new List<ChiTietPhieuNhapKho>();
            ChiTietPhieuNhapKho ctpnk;
            for (int i = 0; i < dgv_chitietPNK.Rows.Count - 1; i++)
            {
                ctpnk = new ChiTietPhieuNhapKho();

                if (dgv_chitietPNK[0, i].Value != null)
                {
                    ctpnk.SoPhieu = pnk.MaPNK;

                    ctpnk.MaHH = dgv_chitietPNK[0, i].Value.ToString();
                    ctpnk.TenHH = dgv_chitietPNK[1, i].Value.ToString();
                    ctpnk.Dongia = dgv_chitietPNK[2, i].Value.ToString();
                    ctpnk.Soluong = dgv_chitietPNK[3, i].Value.ToString();
                    ctpnk.Thanhtien = dgv_chitietPNK[4, i].Value.ToString();
                }
                listchitiet.Add(ctpnk);
            }
            pnk.ListchitietPNK = listchitiet;

            provider = new DataProvider();
            int pnk_success = provider.Insert_PhieuNhapKho(pnk);

            if (pnk_success > 0 && dgv_chitietPNK.Rows.Count > 0)
            {
                foreach (ChiTietPhieuNhapKho chitiet in listchitiet)
                {
                    provider = new DataProvider();
                    provider.Insert_ChiTietPhieuNhapKho(chitiet);
                }
            }

            if (pnk_success > 0)
            {
                MessageBox.Show("Lập phiếu thành công.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Lập phiếu thất bại", "Thông báo");
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
            }
        }

        private void cb_ncc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            string maNCC = provider.Select_NCCByName(cb_tenNCC.Text);
            if(!maNCC.Equals(String.Empty))
            {
                txt_maNCC.Text = maNCC;
            }
        }

        private void dgv_chitietPNK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.rowIndex = e.RowIndex;
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if(dgv_chitietPNK[0, 0].Value != null)
            {
                if (this.rowIndex > -1)
                {
                    DialogResult delete_commit = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo);
                    if (delete_commit == DialogResult.Yes)
                    {
                        dgv_chitietPNK.Rows.RemoveAt(this.rowIndex);
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
                MessageBox.Show("Chưa có mục nào để xóa", "Thông báo");
            }
        }
        
        private void cb_loaiPNK_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
