using FlowerShopClasses;
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
    public partial class AllFlowersForm : Form
    {
        private List<Flower> flowers { get; set; }
        public AllFlowersForm()
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["ParentForm"];
            flowers= FlowerShopClasses.Shop.GetShop().Flowers;
        }

        private void AllFlowersForm_Load(object sender, EventArgs e)
        {
            RefreshData();
           
        }
        private void AllFlowersForm_VisibleChanged(object sender, EventArgs e)
        {

            if (this.Visible)
            {
                RefreshData();
            }
        }
        public void RefreshData()
        {
            dgv_flower.SuspendLayout();
            bindingSourceFlowers.SuspendBinding();
            bindingSourceFlowers.DataSource = flowers;
            dgv_flower.DataSource = null;
            dgv_flower.DataSource = bindingSourceFlowers;
            bindingSourceFlowers.ResumeBinding();
            dgv_flower.ResumeLayout();

        }


        private void btnAddFlower_Click(object sender, EventArgs e)
        {
            Flower new_flower = new Flower();
            EditFlowersForm edit_form = new EditFlowersForm(new_flower, true);
            edit_form.Show();
        }

        private void btnRefresh_Click_1(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            if (dgv_flower.SelectedRows.Count > 0)
            {
                //grab selected object
                Flower selected_flower = (Flower)dgv_flower.SelectedRows[0].DataBoundItem;
                //display on edit form
                EditFlowersForm edit_form = new EditFlowersForm(selected_flower, false);
                edit_form.Show();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dgv_flower.SelectedRows.Count > 0)
            {
                Flower selected_flower = (Flower)dgv_flower.SelectedRows[0].DataBoundItem;
                FlowerShopClasses.Shop.GetShop().Flowers.Remove(selected_flower);
                RefreshData();
            }
        }

        private void dgv_flower_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeliverFlower_Click(object sender, EventArgs e)
        {
            if (dgv_flower.SelectedRows.Count > 0)
            {
                //grab selected object
                Flower selected_flower = (Flower)dgv_flower.SelectedRows[0].DataBoundItem;
                //display on edit form
                AddFlower edit_form = new AddFlower(selected_flower);
                edit_form.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgv_flower.SelectedRows.Count > 0)
            {
                //grab selected object
                Flower selected_flower = (Flower)dgv_flower.SelectedRows[0].DataBoundItem;
                //display on edit form
                selected_flower.AvailableQuantity = 0;
            }
        }

        private void btnSeeHistory_Click(object sender, EventArgs e)
        {
            if (dgv_flower.SelectedRows.Count > 0)
            {
                //grab selected object
                Flower selected_flower = (Flower)dgv_flower.SelectedRows[0].DataBoundItem;
                //display on edit form
                DeliverHistoryForm form = new DeliverHistoryForm(selected_flower);
                form.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            flowers = FlowerShopClasses.Shop.GetShop().Flowers.Where(c => c.Description.ToLowerInvariant().Contains(textBox1.Text.ToLowerInvariant())).ToList();
            RefreshData();
        }
    }
}
