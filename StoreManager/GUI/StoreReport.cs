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

namespace StoreManager.GUI
{
    public partial class StoreReport : Form
    {
        private NhanVien nhanvien;
        private DataProvider provider;
        private int rowindex = -1;

        public StoreReport(NhanVien nhanvien)
        {
            InitializeComponent();
            this.nhanvien = nhanvien;
            showHoaDon();
        }

        private void showHoaDon()
        {
            this.provider = new DataProvider();
            dgvReport.DataSource = provider.Select_Report();
        }

        private void dgvReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.rowindex = e.RowIndex;

            this.provider = new DataProvider();
            if(rowindex > -1)
            {
                dgvChiTiet.DataSource = this.provider.Select_Report_ChiTiet(dgvReport[0, rowindex].Value.ToString());
            }
            else
            {
                ;
            }
        }

        private void StoreReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDBDataSet8.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.storeDBDataSet8.NhanVien);

            cb_tenNV.SelectedIndex = -1;
        }

        private void cb_tenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cb_tenNV.SelectedIndex > -1)
            {
                this.provider = new DataProvider();
                dgvReport.DataSource = this.provider.Select_FindReportByName(cb_tenNV.Text);
            }
            else
            {
                showHoaDon();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cb_tenNV.SelectedIndex = -1;
        }
    }
}
