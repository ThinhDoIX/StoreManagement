using StoreManager.DTO;
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
    public partial class InventoryForm : Form
    {
        private ConnectionString connection;

        public InventoryForm()
        {
            InitializeComponent();
            connection = new ConnectionString();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {
            string query = "Select maHH as [Mã hàng hóa], tenHH as [Tên hàng hóa], dongia as [Đơn giá], soluong as [Số lượng], tenloaiHH as [Loại], chatlieu as [Chất liệu]" +
                            " from HangHoa, LoaiHangHoa" +
                             " where HangHoa.maloaiHH = LoaiHangHoa.maloaiHH and flag = 1";
            using (connection.getConnection()) {
                connection.openConnection();
                using(SqlCommand cmd = new SqlCommand(query, connection.getConnection()))
                {
                    DataTable data = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    sda.Fill(data);

                    dgvHangHoa.DataSource = data;
                }
                connection.closeConnection();
            }
        }
    }
}
