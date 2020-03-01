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
    public partial class EditUserForm : Form
    {
        private User FormUser { get; set; }
        private bool isNew { get; set; }


        public EditUserForm(User user, bool isNew)
        {
            // This call is required by the Windows Form Designer.
            InitializeComponent();
            // Add any initialization after the InitializeComponent() call.
            MdiParent = Application.OpenForms["ParentForm"];

            this.isNew = isNew;
            FormUser = user;

            //set form text
            if (isNew)
            {
                this.Text = "Edit User - New";
            }
            else
            {
                this.Text = "Edit User - Existing";
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
            dtPickerDOB.Value = DateTime.Now.AddYears(-20);
            dtPickerRegistration.Value = DateTime.Now;
            
        }
        private void DisplayObjectOnForm()
        {
            //show properties of the object in UI controls
            //show properties of the object in UI controls
            txtFirstName.Text = FormUser.FirstName;
            txtLastName.Text = FormUser.LastName;
            txtPhone.Text = FormUser.PhoneNumber;
            txtEmail.Text = FormUser.Email;
            txtAddress.Text = FormUser.Address;
            dtPickerDOB.Value = FormUser.DOB;
            dtPickerRegistration.Value = FormUser.RegistrationDate;
            txtPassport.Text = FormUser.PassportNumber;



        }
        private void BindObjectToControls()
        {
            //set values entered by user into UI to corresponding properties of the object
            FormUser.FirstName = txtFirstName.Text;
            FormUser.LastName = txtLastName.Text;
            FormUser.PhoneNumber = txtPhone.Text;
            FormUser.Email = txtEmail.Text;
            FormUser.Address = txtAddress.Text;
            FormUser.DOB = dtPickerDOB.Value;
            FormUser.RegistrationDate = dtPickerRegistration.Value;
            FormUser.PassportNumber = txtPassport.Text;
            
        }

        private void Save()
        {
            //call BindObjectsToControls methods
            //if isNew - register new user in the library
            //close the form
            BindObjectToControls();
            if (isNew)
                FlowerShopClasses.Shop.GetShop().Users.Add(FormUser);
            
            this.Close();

            if (Application.OpenForms["AllUsersForm"] != null)
                Application.OpenForms["AllUsersForm"].Refresh();
        }


        private void EditUserForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
