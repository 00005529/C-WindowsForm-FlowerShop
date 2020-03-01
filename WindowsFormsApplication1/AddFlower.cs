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
    public partial class AddFlower : Form
    {
        private Flower FlowerType { get; set; }
        private Deliver nDeliver { get; set; }
        public AddFlower(Flower flw)
        {
            InitializeComponent();
            nDeliver = new Deliver();
            if (flw == null)
            {
                this.Close();
            }
            FlowerType = flw;
            this.Text = flw.Description +" "+flw.Color+ " - Deliver";
            MdiParent = Application.OpenForms["ParentForm"];
            userBindingSource.DataSource = FlowerShopClasses.Shop.GetShop().Users.Where(u => u.UserType == "Vendor");
            cmbVendors.DataSource = userBindingSource;
            employeeBindingSource.DataSource = FlowerShopClasses.Shop.GetShop().Users.Where(u => u.UserType == "Employee");
            cmbReciever.DataSource = employeeBindingSource;

        }

        private void AddFlower_Load(object sender, EventArgs e)
        {
            nudFlowerQuan.Value = 1000;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
                FlowerType.AvailableQuantity = FlowerType.AvailableQuantity + Convert.ToInt32(nudFlowerQuan.Value);
                nDeliver.DeliveredFlower = FlowerType;
                var vendor = FlowerShopClasses.Shop.GetShop().Users.Where(u => u.UserType == "Vendor" && u.FirstName == cmbVendors.Text);
                nDeliver.Vendor = vendor.ElementAt(0);
                nDeliver.quantityDelivered = Convert.ToInt32(nudFlowerQuan.Value);
                nDeliver.DeliveredDate = DateTime.Now;
                var employee = FlowerShopClasses.Shop.GetShop().Users.Where(u => u.UserType == "Employee" && u.FirstName == cmbReciever.Text);
                nDeliver.RecievedEmployee = employee.ElementAt(0);
                FlowerShopClasses.Shop.GetShop().Delivers.Add(nDeliver);
                this.Close();
            
          
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
