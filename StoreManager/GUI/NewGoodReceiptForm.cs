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
    public partial class NewGoodReceiptForm : Form
    {
        public NewGoodReceiptForm()
        {
            InitializeComponent();
        }

        private void NewGoodReceiptForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'storeDBDataSet6.DonViTinh' table. You can move, or remove it, as needed.
            this.donViTinhTableAdapter.Fill(this.storeDBDataSet6.DonViTinh);

        }

        private void btn_them_Click(object sender, EventArgs e)
        {

        }
    }
}
