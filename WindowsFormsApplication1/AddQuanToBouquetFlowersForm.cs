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
    public partial class AddQuanToBouquetFlowersForm : Form
    {
        private BouquetPartTemp FlowerType { get; set; }
        private Bouquet nBouquet { get; set; }
        public AddQuanToBouquetFlowersForm(BouquetPartTemp b)
        {
            InitializeComponent();
            if (b == null)
            {
                this.Close();
            }
            FlowerType = b;
            
            lblHeader.Text= "Specify the quantity of " +FlowerType.UsedFlowerTemp.Color+" "+ FlowerType.FlowerDesc + " to use in new Bouquet";
            nudQuanFlower.Value = 10;//default value
            MdiParent = Application.OpenForms["ParentForm"];
        }

        private void btnUpdateQuan_Click(object sender, EventArgs e)
        {
            if (nudQuanFlower.Value <= FlowerType.UsedFlowerTemp.AvailableQuantity)
            {
                FlowerType.quantityOfUserFlower = Convert.ToInt32(nudQuanFlower.Value);
                
        
                this.Close();
            }
            else
            {
                MessageBox.Show("The Flower Shop Store has "+FlowerType.UsedFlowerTemp.AvailableQuantity+" of this flower type.");
            }
          
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
