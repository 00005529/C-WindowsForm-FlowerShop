using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlowerShopClasses;
namespace WindowsFormsApplication1
{
    public partial class DeliverHistoryForm : Form
    {
        private Flower FlowerType { get; set; }
        public DeliverHistoryForm()
        {
            InitializeComponent();
            deliverBindingSource.DataSource = FlowerShopClasses.Shop.GetShop().Delivers;
            dgv_deliver.DataSource = deliverBindingSource;
        }
        public DeliverHistoryForm(Flower flw)
        {
            InitializeComponent();
            if (FlowerShopClasses.Shop.GetShop().Delivers.Count() > 0)
            {
                RefreshData();
                FlowerType = flw;
                deliverBindingSource.DataSource = FlowerShopClasses.Shop.GetShop().Delivers.Where(c => c.DeliveredFlower == FlowerType);



                dgv_deliver.DataSource = deliverBindingSource;
            }
        }
        private void RefreshData()
        {
            if (FlowerShopClasses.Shop.GetShop().Delivers.Count() > 0)
            {
                dgv_deliver.SuspendLayout();
                deliverBindingSource.SuspendBinding();
                if (FlowerType != null)
                {
                    deliverBindingSource.DataSource = FlowerShopClasses.Shop.GetShop().Delivers.Where(c => c.DeliveredFlower == FlowerType);
                }
                else
                {
                    deliverBindingSource.DataSource = FlowerShopClasses.Shop.GetShop().Delivers;
                }

                dgv_deliver.DataSource = null;
                dgv_deliver.DataSource = deliverBindingSource;
                deliverBindingSource.ResumeBinding();
                dgv_deliver.ResumeLayout();
            }
            
        }

        private void DeliverHistoryForm_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv_deliver.SelectedRows.Count > 0)
            {
                Deliver selected_deliver = (Deliver)dgv_deliver.SelectedRows[0].DataBoundItem;
                FlowerShopClasses.Shop.GetShop().Delivers.Remove(selected_deliver);
                RefreshData();
            }
        }


    }
}
