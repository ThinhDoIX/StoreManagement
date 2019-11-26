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

        private void textBox5_TextChanged(object sender, EventArgs e)
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
            // TODO: This line of code loads data into the 'storeDBDataSet1.HangHoa' table. You can move, or remove it, as needed.
            this.hangHoaTableAdapter.Fill(this.storeDBDataSet1.HangHoa);
            // TODO: This line of code loads data into the 'storeDBDataSet.LoaiHangHoa' table. You can move, or remove it, as needed.
            this.loaiHangHoaTableAdapter.Fill(this.storeDBDataSet.LoaiHangHoa);

        }
    }
}
