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
    public partial class EditFlowersForm : Form
    {
        private Flower FormFlower { get; set; }
        private bool isNew { get; set; }
        private List<Flower> flws { get; set; }
        public EditFlowersForm(Flower flower, bool isNew)
        {
            InitializeComponent();
            MdiParent = Application.OpenForms["ParentForm"];
            this.isNew = isNew;
            FormFlower = flower;
             
            if (isNew)
            {
                this.Text = "Edit Flower - New";
            }
            else
            {
                this.Text = "Edit Flower - Existing";
            }

            //display object
            if (isNew)
            {
                ShowDefaultValues();
            }
            else
            {
                DisplayObjectOnForm();
            }
        }

        private void ShowDefaultValues()
        {
            //set default values to UI controls
            //set default values to UI controls
            numPrice.Value = 10000;
            dtPickerDeliveredDate.Value = DateTime.Now;


        }
        private void DisplayObjectOnForm()
        {
            //show properties of the object in UI controls
            //show properties of the object in UI controls
            txtDescription.Text = FormFlower.Description;
            txtColor.Text = FormFlower.Color;
            numPrice.Value = FormFlower.Price;
            dtPickerDeliveredDate.Value = FormFlower.DeliveredDate;
        }
        private void BindObjectToControls()
        {
            //set values entered by user into UI to corresponding properties of the object
            FormFlower.Description = txtDescription.Text;
            FormFlower.Color = txtColor.Text;
            FormFlower.Price = Convert.ToInt32(numPrice.Value);
            FormFlower.DeliveredDate = dtPickerDeliveredDate.Value;
        }
        private void Save()
        {
            //call BindObjectsToControls methods
            //if isNew - register new flower in the shop
            //close the form
            BindObjectToControls();
            if (isNew)
            {
                var matchingvalues = FlowerShopClasses.Shop.GetShop().Flowers
   .Where(f => f.Description.ToLowerInvariant()==FormFlower.Description.ToLowerInvariant()&&f.Color.ToLowerInvariant()==FormFlower.Color.ToLowerInvariant());
                if (matchingvalues.Count() > 0)
                {
                    MessageBox.Show("Flower with this description and color allready exists in the database.");
                }
                else {
                    FlowerShopClasses.Shop.GetShop().Flowers.Add(FormFlower);
                    this.Close();
                }


            }else
            {
                this.Close();
            }


            if (Application.OpenForms["AllUsersForm"] != null)
            {
                Application.OpenForms["AllUsersForm"].Refresh();
            }
            }

        private void EditFlowersForm_Load(object sender, EventArgs e)
        {

        }
        

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
 

       
    }
}
