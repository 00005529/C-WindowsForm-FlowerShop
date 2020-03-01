namespace WindowsFormsApplication1
{
    partial class AllFlowersForm
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
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceFlowers = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddFlower = new System.Windows.Forms.Button();
            this.btnDeliverFlower = new System.Windows.Forms.Button();
            this.btnSeeHistory = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFlowers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_flower
            // 
            this.dgv_flower.AllowDrop = true;
            this.dgv_flower.AutoGenerateColumns = false;
            this.dgv_flower.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgv_flower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_flower.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descriptionDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.availableQuantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgv_flower.DataSource = this.bindingSourceFlowers;
            this.dgv_flower.Location = new System.Drawing.Point(12, 78);
            this.dgv_flower.Name = "dgv_flower";
            this.dgv_flower.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_flower.Size = new System.Drawing.Size(443, 404);
            this.dgv_flower.TabIndex = 0;
            this.dgv_flower.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_flower_CellContentClick);
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            // 
            // availableQuantityDataGridViewTextBoxColumn
            // 
            this.availableQuantityDataGridViewTextBoxColumn.DataPropertyName = "AvailableQuantity";
            this.availableQuantityDataGridViewTextBoxColumn.HeaderText = "AvailableQuantity";
            this.availableQuantityDataGridViewTextBoxColumn.Name = "availableQuantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // bindingSourceFlowers
            // 
            this.bindingSourceFlowers.DataSource = typeof(FlowerShopClasses.Flower);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Location = new System.Drawing.Point(482, 185);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDelete.Size = new System.Drawing.Size(117, 78);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Location = new System.Drawing.Point(482, 101);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEdit.Size = new System.Drawing.Size(117, 78);
            this.btnEdit.TabIndex = 7;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Lime;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRefresh.Location = new System.Drawing.Point(482, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 83);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click_1);
            // 
            // btnAddFlower
            // 
            this.btnAddFlower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddFlower.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddFlower.Location = new System.Drawing.Point(482, 269);
            this.btnAddFlower.Name = "btnAddFlower";
            this.btnAddFlower.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAddFlower.Size = new System.Drawing.Size(117, 78);
            this.btnAddFlower.TabIndex = 9;
            this.btnAddFlower.Text = "Add Flower";
            this.btnAddFlower.UseVisualStyleBackColor = false;
            this.btnAddFlower.Click += new System.EventHandler(this.btnAddFlower_Click);
            // 
            // btnDeliverFlower
            // 
            this.btnDeliverFlower.BackColor = System.Drawing.Color.Yellow;
            this.btnDeliverFlower.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeliverFlower.Location = new System.Drawing.Point(482, 353);
            this.btnDeliverFlower.Name = "btnDeliverFlower";
            this.btnDeliverFlower.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeliverFlower.Size = new System.Drawing.Size(117, 78);
            this.btnDeliverFlower.TabIndex = 10;
            this.btnDeliverFlower.Text = "Deliver Selected Flower";
            this.btnDeliverFlower.UseVisualStyleBackColor = false;
            this.btnDeliverFlower.Click += new System.EventHandler(this.btnDeliverFlower_Click);
            // 
            // btnSeeHistory
            // 
            this.btnSeeHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSeeHistory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeeHistory.Location = new System.Drawing.Point(482, 437);
            this.btnSeeHistory.Name = "btnSeeHistory";
            this.btnSeeHistory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSeeHistory.Size = new System.Drawing.Size(117, 78);
            this.btnSeeHistory.TabIndex = 11;
            this.btnSeeHistory.Text = "See Deliver History Of Selected Flower";
            this.btnSeeHistory.UseVisualStyleBackColor = false;
            this.btnSeeHistory.Click += new System.EventHandler(this.btnSeeHistory_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search by Description:";
            // 
            // AllFlowersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(624, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSeeHistory);
            this.Controls.Add(this.btnDeliverFlower);
            this.Controls.Add(this.btnAddFlower);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgv_flower);
            this.Name = "AllFlowersForm";
            this.Text = "AllFlowersForm";
            this.Load += new System.EventHandler(this.AllFlowersForm_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_flower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceFlowers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSourceFlowers;
        private System.Windows.Forms.DataGridView dgv_flower;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddFlower;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn availableQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDeliverFlower;
        private System.Windows.Forms.Button btnSeeHistory;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}