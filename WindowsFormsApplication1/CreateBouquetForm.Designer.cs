namespace WindowsFormsApplication1
{
    partial class EditBouquetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_flower = new System.Windows.Forms.DataGridView();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dgv_bouquetpart = new System.Windows.Forms.DataGridView();
            this.FlowerDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityOfUserFlowerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceOfBouquetPartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempBouquetPartbindsrc = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnSpecifyQuantity = new System.Windows.Forms.Button();
            this.cmbCustomers = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSellBouquet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bouquetpart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempBouquetPartbindsrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_flower
            // 
            this.dgv_flower.AllowDrop = true;
            this.dgv_flower.AutoGenerateColumns = false;
            this.dgv_flower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_flower.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.AvailableQuantity,
            this.Color,
            this.Price});
            this.dgv_flower.DataSource = this.flowerBindingSource;
            this.dgv_flower.Location = new System.Drawing.Point(12, 39);
            this.dgv_flower.Name = "dgv_flower";
            this.dgv_flower.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_flower.Size = new System.Drawing.Size(437, 230);
            this.dgv_flower.TabIndex = 0;
            this.dgv_flower.VisibleChanged += new System.EventHandler(this.EditBouquetForm_VisibleChanged);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // AvailableQuantity
            // 
            this.AvailableQuantity.DataPropertyName = "AvailableQuantity";
            this.AvailableQuantity.HeaderText = "AvailableQuantity";
            this.AvailableQuantity.Name = "AvailableQuantity";
            // 
            // Color
            // 
            this.Color.DataPropertyName = "Color";
            this.Color.HeaderText = "Color";
            this.Color.Name = "Color";
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // flowerBindingSource
            // 
            this.flowerBindingSource.AllowNew = true;
            this.flowerBindingSource.DataSource = typeof(FlowerShopClasses.Flower);
            // 
            // dgv_bouquetpart
            // 
            this.dgv_bouquetpart.AllowDrop = true;
            this.dgv_bouquetpart.AllowUserToOrderColumns = true;
            this.dgv_bouquetpart.AutoGenerateColumns = false;
            this.dgv_bouquetpart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bouquetpart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlowerDesc,
            this.quantityOfUserFlowerDataGridViewTextBoxColumn,
            this.priceOfBouquetPartDataGridViewTextBoxColumn});
            this.dgv_bouquetpart.DataSource = this.tempBouquetPartbindsrc;
            this.dgv_bouquetpart.Location = new System.Drawing.Point(536, 39);
            this.dgv_bouquetpart.Name = "dgv_bouquetpart";
            this.dgv_bouquetpart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bouquetpart.Size = new System.Drawing.Size(346, 230);
            this.dgv_bouquetpart.TabIndex = 1;
            this.dgv_bouquetpart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FlowerDesc
            // 
            this.FlowerDesc.DataPropertyName = "FlowerDesc";
            this.FlowerDesc.HeaderText = "Flower";
            this.FlowerDesc.Name = "FlowerDesc";
            this.FlowerDesc.ReadOnly = true;
            // 
            // quantityOfUserFlowerDataGridViewTextBoxColumn
            // 
            this.quantityOfUserFlowerDataGridViewTextBoxColumn.DataPropertyName = "quantityOfUserFlower";
            this.quantityOfUserFlowerDataGridViewTextBoxColumn.HeaderText = "Quantity Used Flowers";
            this.quantityOfUserFlowerDataGridViewTextBoxColumn.Name = "quantityOfUserFlowerDataGridViewTextBoxColumn";
            // 
            // priceOfBouquetPartDataGridViewTextBoxColumn
            // 
            this.priceOfBouquetPartDataGridViewTextBoxColumn.DataPropertyName = "PriceOfBouquetPart";
            this.priceOfBouquetPartDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceOfBouquetPartDataGridViewTextBoxColumn.Name = "priceOfBouquetPartDataGridViewTextBoxColumn";
            this.priceOfBouquetPartDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tempBouquetPartbindsrc
            // 
            this.tempBouquetPartbindsrc.DataSource = typeof(FlowerShopClasses.BouquetPartTemp);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(455, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add=>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(455, 142);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "<=Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Lime;
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Location = new System.Drawing.Point(0, 333);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(1002, 57);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh Lists";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSpecifyQuantity
            // 
            this.btnSpecifyQuantity.Location = new System.Drawing.Point(890, 12);
            this.btnSpecifyQuantity.Name = "btnSpecifyQuantity";
            this.btnSpecifyQuantity.Size = new System.Drawing.Size(100, 78);
            this.btnSpecifyQuantity.TabIndex = 5;
            this.btnSpecifyQuantity.Text = "Declare Quantity";
            this.btnSpecifyQuantity.UseVisualStyleBackColor = true;
            this.btnSpecifyQuantity.Click += new System.EventHandler(this.btnSpecifyQuantity_Click);
            // 
            // cmbCustomers
            // 
            this.cmbCustomers.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userBindingSource, "FirstName", true));
            this.cmbCustomers.DataSource = this.userBindingSource;
            this.cmbCustomers.DisplayMember = "FirstName";
            this.cmbCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCustomers.FormattingEnabled = true;
            this.cmbCustomers.Location = new System.Drawing.Point(646, 275);
            this.cmbCustomers.Name = "cmbCustomers";
            this.cmbCustomers.Size = new System.Drawing.Size(236, 21);
            this.cmbCustomers.TabIndex = 6;
            this.cmbCustomers.ValueMember = "FirstName";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FlowerShopClasses.Customer);
            // 
            // btnSellBouquet
            // 
            this.btnSellBouquet.Location = new System.Drawing.Point(890, 96);
            this.btnSellBouquet.Name = "btnSellBouquet";
            this.btnSellBouquet.Size = new System.Drawing.Size(100, 78);
            this.btnSellBouquet.TabIndex = 7;
            this.btnSellBouquet.Text = "Sell This Bouquet To This Customer";
            this.btnSellBouquet.UseVisualStyleBackColor = true;
            this.btnSellBouquet.Click += new System.EventHandler(this.btnCreateBouquet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose Customer:";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(FlowerShopClasses.Employee);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Available Flowers List To Use In New Bouquet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(231, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Flowers List That Will Be Used In New Bouquet";
            // 
            // EditBouquetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1002, 390);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSellBouquet);
            this.Controls.Add(this.cmbCustomers);
            this.Controls.Add(this.btnSpecifyQuantity);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgv_bouquetpart);
            this.Controls.Add(this.dgv_flower);
            this.Name = "EditBouquetForm";
            this.Text = "Create and Sell New Bouquet";
            this.Load += new System.EventHandler(this.EditBouquetForm_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditBouquetForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bouquetpart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempBouquetPartbindsrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource flowerBindingSource;
        private System.Windows.Forms.DataGridView dgv_flower;
        private System.Windows.Forms.DataGridView dgv_bouquetpart;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableQuantity;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.BindingSource tempBouquetPartbindsrc;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityOfUserFlowerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceOfBouquetPartDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Color;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button btnSpecifyQuantity;
        private System.Windows.Forms.ComboBox cmbCustomers;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.Button btnSellBouquet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}