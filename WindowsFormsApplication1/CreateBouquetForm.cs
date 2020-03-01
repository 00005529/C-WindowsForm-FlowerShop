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
    public partial class EditBouquetForm : Form
    {
        private BouquetPartTemp bouquetpart = new BouquetPartTemp();
        private List<BouquetPartTemp> usedBouquets { get; set; }
        private Bouquet newBouquet { get; set; } 
   
        private List<Flower> selectedFlowers = new List<Flower>();
        private Sale ord = new Sale();
        public EditBouquetForm()
        {
            InitializeComponent();
            RefreshData();//calling refreshdata method to refresh data in datagridviews

            newBouquet = new Bouquet();
            usedBouquets = new List<BouquetPartTemp>();

            selectedFlowers.Add(new Flower() { Description = "qwerty", Color = "qwerty" });
   

        }
        private void EditBouquetForm_VisibleChanged(object sender, EventArgs e)
        {
            RefreshData();

            if (this.Visible)
            {
                RefreshData();
               
            }
        }
        public void RefreshData()
        {
            AddAvailableFlowers(); //calling method that adds available flowers into AvailableFlowers list
            RemoveUnavailableFlowers(); //calling method that removes unavailable flowers from AvailableFlowers list

            //refreshing data in available flowers list in datagridview
            dgv_flower.SuspendLayout();
            flowerBindingSource.SuspendBinding();
            flowerBindingSource.DataSource = FlowerShopClasses.Shop.GetShop().AvailableFlowers.Except(selectedFlowers);//populating datagridview with Available Flowers except selectedFlowers list
            dgv_flower.DataSource = null;
            dgv_flower.DataSource = flowerBindingSource;
            flowerBindingSource.ResumeBinding();
            dgv_flower.ResumeLayout();
            
           //refreshing data in BouquetParts list
            dgv_bouquetpart.SuspendLayout();
            tempBouquetPartbindsrc.SuspendBinding();
            tempBouquetPartbindsrc.DataSource = FlowerShopClasses.Shop.GetShop().BouquetPartTemps;
            dgv_bouquetpart.DataSource = null;
            dgv_bouquetpart.DataSource = tempBouquetPartbindsrc;
            tempBouquetPartbindsrc.ResumeBinding();
            dgv_bouquetpart.ResumeLayout();

            //populating cmbCustomers combobox with instances of Customer class
            userBindingSource.DataSource = FlowerShopClasses.Shop.GetShop().Users.Where(u => u.UserType == "Customer");
        
            cmbCustomers.DataSource = userBindingSource;

        }

        private void EditBouquetForm_Load(object sender, EventArgs e)
        {
            MdiParent = Application.OpenForms["ParentForm"];

            RefreshData();

        }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (dgv_flower.SelectedRows.Count > 0)//checking if object selected
            {
                
           
                Flower selected_flower = (Flower)dgv_flower.SelectedRows[0].DataBoundItem;//grab selected object
                bouquetpart.UsedFlowerTemp = selected_flower; //adding selected Flower into instance of BouquetPart
                FlowerShopClasses.Shop.GetShop().AvailableFlowers.Remove(selected_flower);//Removing selected flower from Available flowers list
                var matchingvalues = FlowerShopClasses.Shop.GetShop().BouquetPartTemps.Where(
                    f => f.UsedFlowerTemp.Description == selected_flower.Description.ToLowerInvariant()
                    && f.UsedFlowerTemp.Color.ToLowerInvariant() == selected_flower.Color.ToLowerInvariant()); //checking if BouquetPart allready has selected flower
                if (matchingvalues.Count() == 0)
                {
                    selectedFlowers.Add(selected_flower);//Adding selected flower into selectedFlowers list that Available Flowers list removes from itself instances of it.
                    FlowerShopClasses.Shop.GetShop().BouquetPartTemps.Add(bouquetpart);////adding bouquetPart into BouquetParts list

                    bouquetpart = new BouquetPartTemp();
                    RefreshData();
                }
               
               

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)//button that removes selected instance of BouquetPart from bouquetParts list and add flower of instance of Bouquetpart to AvailableFlowers List to use again
        {
            if (dgv_bouquetpart.SelectedRows.Count > 0)
            {
                //grab selected object

                BouquetPartTemp selected_bouquetpart = (BouquetPartTemp)dgv_bouquetpart.SelectedRows[0].DataBoundItem;
                
                 var f = selectedFlowers.Where(c => c.Description==selected_bouquetpart.UsedFlowerTemp.Description && c.Color== selected_bouquetpart.UsedFlowerTemp.Color);
                var v = f.ElementAt(0);
                selectedFlowers.Remove(v);
                FlowerShopClasses.Shop.GetShop().BouquetPartTemps.Remove(selected_bouquetpart);
                RefreshData();

            }
        }
        public void AddAvailableFlowers()
        {
            

            foreach (Flower flower in FlowerShopClasses.Shop.GetShop().Flowers)
            {
                if (flower.AvailableQuantity > 0)
                {
                    if (FlowerShopClasses.Shop.GetShop().AvailableFlowers.Count > 0)
                    {
                        var matchingvalues = FlowerShopClasses.Shop.GetShop().AvailableFlowers.Where(f => f.Description.ToLowerInvariant() == flower.Description.ToLowerInvariant() && f.Color.ToLowerInvariant() == flower.Color.ToLowerInvariant());
                        if (matchingvalues.Count() == 0)
                        {
                            FlowerShopClasses.Shop.GetShop().AvailableFlowers.Add(flower);
                        }
                    }
                }
            }

        }
        public void RemoveUnavailableFlowers()
        {

            if (FlowerShopClasses.Shop.GetShop().AvailableFlowers.Count > 0)
            {

               
                    for(int i = 0;i< FlowerShopClasses.Shop.GetShop().AvailableFlowers.Count(); i++)
                    {
                    if (FlowerShopClasses.Shop.GetShop().AvailableFlowers[i].AvailableQuantity == 0)
                    {
                        Flower flower = FlowerShopClasses.Shop.GetShop().AvailableFlowers[i];
                        FlowerShopClasses.Shop.GetShop().AvailableFlowers.Remove(flower);

                    }
                }
                
                  
                }
            

        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void btnSpecifyQuantity_Click(object sender, EventArgs e)
        {

                
                if (dgv_bouquetpart.SelectedRows.Count > 0)
                {
                    //grab selected object

                    BouquetPartTemp selected_flower = (BouquetPartTemp)dgv_bouquetpart.SelectedRows[0].DataBoundItem;
                    AddQuanToBouquetFlowersForm form = new AddQuanToBouquetFlowersForm(selected_flower);
                form.Show();
                }
            
        }

        
        private void CreateBouquet()
        {
            
        }

        private void btnCreateBouquet_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Shop.GetShop().BouquetPartTemps.Count; i++)
            {
                    usedBouquets.Add(Shop.GetShop().BouquetPartTemps[i]);
                    var f = Shop.GetShop().Flowers.Where(fl => fl.Description == Shop.GetShop().BouquetPartTemps[i].UsedFlowerTemp.Description
                    && fl.Color == Shop.GetShop().BouquetPartTemps[i].UsedFlowerTemp.Color);
                    var v = f.ElementAt(0);
                    

                    v.AvailableQuantity = v.AvailableQuantity - Shop.GetShop().BouquetPartTemps[i].quantityOfUserFlower;
                    selectedFlowers.Remove(v);
                FlowerShopClasses.Shop.GetShop().BouquetPartTemps.Remove(Shop.GetShop().BouquetPartTemps[i]);
                i = i - 1;
                
            }
            newBouquet.UsedFlowersList = usedBouquets;
            Shop.GetShop().Bouquets.Add(newBouquet);
            var c = FlowerShopClasses.Shop.GetShop().Users.Where(cus =>cus.UserType=="Customer"&& cus.FirstName.ToLowerInvariant() == cmbCustomers.Text.ToLowerInvariant());
            User customer = c.ElementAt(0);
            ord.Customer = customer;
            ord.Bouquet = newBouquet;
            FlowerShopClasses.Shop.GetShop().Orders.Add(ord);
            MessageBox.Show("Price of Bouquet: " + newBouquet.PriceOfBouquet+" \n"+"Customer: "+ord.Customer.FirstName+" "+ord.Customer.LastName);
            RefreshData();
        }

        private void EditBouquetForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (Shop.GetShop().BouquetPartTemps.Count() > 0)
            {
                if (Shop.GetShop().BouquetPartTemps[Shop.GetShop().BouquetPartTemps.Count() - 1].quantityOfUserFlower > 0)
                {
                    RefreshData();
                }
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
