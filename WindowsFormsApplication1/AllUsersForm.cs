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
    public partial class AllUsersForm : Form
    {
        public AllUsersForm()
        {
            InitializeComponent();
        }

        private void AllUsersForm_Load(object sender, EventArgs e)
        {
            cmdUserType.Text = "Any";
            RefreshData();
            this.MdiParent = Application.OpenForms["ParentForm"];
        }
        private void AllUsersForm_VisibleChanged(object sender, EventArgs e)
        {
            
            if (this.Visible)
            {
                RefreshData();
            }
        }
        public void RefreshData()
        {
            if (cmdUserType.Text == "Customer")
            {
                dgv_user.SuspendLayout();
                bindingSourceUsers.SuspendBinding();
                bindingSourceUsers.DataSource = FlowerShopClasses.Shop.GetShop().Users.Where(u => u.UserType == "Customer");
                dgv_user.DataSource = null;
                dgv_user.DataSource = bindingSourceUsers;
                bindingSourceUsers.ResumeBinding();
                dgv_user.ResumeLayout();
            }
            else if (cmdUserType.Text == "Employee")
            {
                dgv_user.SuspendLayout();
                bindingSourceUsers.SuspendBinding();
                bindingSourceUsers.DataSource = FlowerShopClasses.Shop.GetShop().Users.Where(u => u.UserType == "Employee");
                dgv_user.DataSource = null;
                dgv_user.DataSource = bindingSourceUsers;
                bindingSourceUsers.ResumeBinding();
                dgv_user.ResumeLayout();
            }
            else if (cmdUserType.Text == "Vendor")
            {
                dgv_user.SuspendLayout();
                bindingSourceUsers.SuspendBinding();
                bindingSourceUsers.DataSource = FlowerShopClasses.Shop.GetShop().Users.Where(u => u.UserType == "Vendor");
                dgv_user.DataSource = null;
                dgv_user.DataSource = bindingSourceUsers;
                bindingSourceUsers.ResumeBinding();
                dgv_user.ResumeLayout();
            }
            else
            {
                dgv_user.SuspendLayout();
                bindingSourceUsers.SuspendBinding();
                bindingSourceUsers.DataSource = FlowerShopClasses.Shop.GetShop().Users;
                dgv_user.DataSource = null;
                dgv_user.DataSource = bindingSourceUsers;
                bindingSourceUsers.ResumeBinding();
                dgv_user.ResumeLayout();
            }

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv_user.SelectedRows.Count > 0)
            {
                //grab selected object
                User selected_user = (User)dgv_user.SelectedRows[0].DataBoundItem;
                //display on edit form
                EditUserForm edit_form = new EditUserForm(selected_user, false);
                edit_form.Show();
            }
        }

        private void addCustomer_Click(object sender, EventArgs e)
        {
            User new_user = new Customer();
            EditUserForm edit_form = new EditUserForm(new_user, true);
            edit_form.Show();
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            User new_user = new Employee();
            EditUserForm edit_form = new EditUserForm(new_user, true);
            edit_form.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv_user.SelectedRows.Count > 0)
            {
                User selected_user = (User)dgv_user.SelectedRows[0].DataBoundItem;
                FlowerShopClasses.Shop.GetShop().Users.Remove(selected_user);
                RefreshData();
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            RefreshData();

        }

        private void btnAddVendor_Click(object sender, EventArgs e)
        {
            User new_user = new Vendor();
            EditUserForm edit_form = new EditUserForm(new_user, true);
            edit_form.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dgv_user.SuspendLayout();
            bindingSourceUsers.SuspendBinding();
            bindingSourceUsers.DataSource = FlowerShopClasses.Shop.GetShop().Users.Where(u => u.FirstName.ToLowerInvariant().Contains(textBox1.Text.ToLowerInvariant())).ToList();
            dgv_user.DataSource = null;
            dgv_user.DataSource = bindingSourceUsers;
            bindingSourceUsers.ResumeBinding();
            dgv_user.ResumeLayout();
        }
    }
}
