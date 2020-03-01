using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AllOrdersForm : Form
    {
        public AllOrdersForm()
        {
            InitializeComponent();
            RefreshData();
            //orderBindingSource.DataSource = FlowerShopClasses.Shop.GetShop().BouquetPartTemps;
            //dgvOrders.DataSource = orderBindingSource;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
        private void RefreshData()
        {
            dgvOrders.SuspendLayout();
            saleBindingSource.SuspendBinding();
            saleBindingSource.DataSource = FlowerShopClasses.Shop.GetShop().Orders;
            dgvOrders.DataSource = null;
            dgvOrders.DataSource = saleBindingSource;
            saleBindingSource.ResumeBinding();
            dgvOrders.ResumeLayout();
        }

        private void AllOrdersForm_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
