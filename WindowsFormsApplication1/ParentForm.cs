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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
            FlowerShopClasses.Shop.GetShop();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ParentForm_Load(object sender, EventArgs e)
        {
            //AllUsersForm allusers = new AllUsersForm();
            //allusers.Show();
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditUserForm uef = new EditUserForm(new FlowerShopClasses.Customer(), true);
            uef.Show();
        }

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllUsersForm allusers = new AllUsersForm();
            allusers.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AllUsersForm allusers = new AllUsersForm();
            allusers.Show();
        }

        private void newFlowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditFlowersForm editflower = new EditFlowersForm(new FlowerShopClasses.Flower(), true);
            editflower.Show();
        }

        private void allFlowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllFlowersForm allflowers = new AllFlowersForm();
            allflowers.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void bouquetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditBouquetForm bq = new EditBouquetForm();
            bq.Show();
        }

        private void deliverHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeliverHistoryForm form = new DeliverHistoryForm();
            form.Show();
        }

        private void allOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllOrdersForm form = new AllOrdersForm();
            form.Show();
        }
    }
}
