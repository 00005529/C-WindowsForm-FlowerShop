namespace WindowsFormsApplication1
{
    partial class AddFlower
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
            this.nudFlowerQuan = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbVendors = new System.Windows.Forms.ComboBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbReciever = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudFlowerQuan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nudFlowerQuan
            // 
            this.nudFlowerQuan.Location = new System.Drawing.Point(135, 91);
            this.nudFlowerQuan.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudFlowerQuan.Name = "nudFlowerQuan";
            this.nudFlowerQuan.Size = new System.Drawing.Size(120, 20);
            this.nudFlowerQuan.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(77, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 52);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add Flower";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbl
            // 
            this.lbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.Lime;
            this.lbl.Location = new System.Drawing.Point(38, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(217, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Deliver And Add flowers to this type of flower";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(197, 226);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbVendors
            // 
            this.cmbVendors.DataSource = this.userBindingSource;
            this.cmbVendors.DisplayMember = "FirstName";
            this.cmbVendors.FormattingEnabled = true;
            this.cmbVendors.Location = new System.Drawing.Point(134, 64);
            this.cmbVendors.Name = "cmbVendors";
            this.cmbVendors.Size = new System.Drawing.Size(121, 21);
            this.cmbVendors.TabIndex = 4;
            this.cmbVendors.ValueMember = "LastName";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FlowerShopClasses.User);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vendor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Flower Quantity";
            // 
            // cmbReciever
            // 
            this.cmbReciever.DataSource = this.employeeBindingSource;
            this.cmbReciever.DisplayMember = "FirstName";
            this.cmbReciever.FormattingEnabled = true;
            this.cmbReciever.Location = new System.Drawing.Point(134, 117);
            this.cmbReciever.Name = "cmbReciever";
            this.cmbReciever.Size = new System.Drawing.Size(121, 21);
            this.cmbReciever.TabIndex = 7;
            this.cmbReciever.ValueMember = "LastName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Recieved Employee";
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataSource = typeof(FlowerShopClasses.User);
            // 
            // AddFlower
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbReciever);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVendors);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.nudFlowerQuan);
            this.Name = "AddFlower";
            this.Text = "AddFlower";
            this.Load += new System.EventHandler(this.AddFlower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudFlowerQuan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudFlowerQuan;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbVendors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.ComboBox cmbReciever;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource employeeBindingSource;
    }
}