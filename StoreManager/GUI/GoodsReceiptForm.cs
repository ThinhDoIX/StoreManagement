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
            DataProvider provider = new DataProvider();
            txt_sophieu.Text = provider.SophieuGenerator();
            txt_ngaylap.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txt_tenNV.Text = nhanvien.TenVN;
            txt_maNV.Text = nhanvien.MaNV;
        }

        private void cb_tenHH_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataProvider provider = new DataProvider();
            DataTable product_dt = provider.selectHangHoa_ByTenHangHoa(cb_tenHH.Text);

            if(product_dt.Rows.Count > 0)
            {
                foreach(DataRow row in product_dt.Rows)
                {
                    txt_maHH.Text = row["maHH"].ToString();

                    string dg = row["dongia"].ToString();
                    if (dg != "")
                    {
                        dg = double.Parse(row["dongia"].ToString()).ToString("#,###", cul.NumberFormat);
                    }
                    txt_dongia.Text = dg;

                    txt_donvitinh.Text = row["donvitinh"].ToString();
                    break;
                }
            }
        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            double dg = 0.0;
            int sl = 0;

            if (txt_dongia.Text != "" && txt_soluong.Text != "")
            {
                dg = double.Parse(txt_dongia.Text);
                sl = Int32.Parse(txt_soluong.Text);
            }

            txt_thanhtien.Text = double.Parse((dg * sl).ToString()).ToString("#,###.000", cul.NumberFormat);
        }

        private void txt_dongia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        private void dgv_chitiethd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
