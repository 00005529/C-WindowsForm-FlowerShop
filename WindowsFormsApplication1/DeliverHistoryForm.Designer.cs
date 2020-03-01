namespace WindowsFormsApplication1
{
    partial class DeliverHistoryForm
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
            this.dgv_deliver = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.deliverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FlowerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VendorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDeliveredDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveredDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deliver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_deliver
            // 
            this.dgv_deliver.AutoGenerateColumns = false;
            this.dgv_deliver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_deliver.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlowerName,
            this.VendorName,
            this.quantityDeliveredDataGridViewTextBoxColumn,
            this.deliveredDateDataGridViewTextBoxColumn,
            this.EmployeeName});
            this.dgv_deliver.DataSource = this.deliverBindingSource;
            this.dgv_deliver.Location = new System.Drawing.Point(27, 45);
            this.dgv_deliver.Name = "dgv_deliver";
            this.dgv_deliver.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_deliver.Size = new System.Drawing.Size(550, 221);
            this.dgv_deliver.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(633, 45);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(111, 75);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDelete.Location = new System.Drawing.Point(633, 126);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 75);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // deliverBindingSource
            // 
            this.deliverBindingSource.DataSource = typeof(FlowerShopClasses.Deliver);
            // 
            // FlowerName
            // 
            this.FlowerName.DataPropertyName = "FlowerName";
            this.FlowerName.HeaderText = "Flower";
            this.FlowerName.Name = "FlowerName";
            this.FlowerName.ReadOnly = true;
            // 
            // VendorName
            // 
            this.VendorName.DataPropertyName = "VendorName";
            this.VendorName.HeaderText = "Vendor";
            this.VendorName.Name = "VendorName";
            this.VendorName.ReadOnly = true;
            // 
            // quantityDeliveredDataGridViewTextBoxColumn
            // 
            this.quantityDeliveredDataGridViewTextBoxColumn.DataPropertyName = "quantityDelivered";
            this.quantityDeliveredDataGridViewTextBoxColumn.HeaderText = "Quantity Delivered";
            this.quantityDeliveredDataGridViewTextBoxColumn.Name = "quantityDeliveredDataGridViewTextBoxColumn";
            // 
            // deliveredDateDataGridViewTextBoxColumn
            // 
            this.deliveredDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveredDate";
            this.deliveredDateDataGridViewTextBoxColumn.HeaderText = "Delivered Date";
            this.deliveredDateDataGridViewTextBoxColumn.Name = "deliveredDateDataGridViewTextBoxColumn";
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.HeaderText = "Reciever";
            this.EmployeeName.Name = "EmployeeName";
            this.EmployeeName.ReadOnly = true;
            // 
            // DeliverHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 328);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgv_deliver);
            this.Name = "DeliverHistoryForm";
            this.Text = "DeliverHistoryForm";
            this.Load += new System.EventHandler(this.DeliverHistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_deliver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliverBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_deliver;
        private System.Windows.Forms.BindingSource deliverBindingSource;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlowerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VendorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDeliveredDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveredDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
    }
}