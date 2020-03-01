namespace WindowsFormsApplication1
{
    partial class ParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFlowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allFlowersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deliverHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bouquetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.flowersToolStripMenuItem,
            this.ordersToolStripMenuItem,
            this.bouquetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(662, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // allUsersToolStripMenuItem
            // 
            this.allUsersToolStripMenuItem.Name = "allUsersToolStripMenuItem";
            this.allUsersToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.allUsersToolStripMenuItem.Text = "All Users";
            this.allUsersToolStripMenuItem.Click += new System.EventHandler(this.allUsersToolStripMenuItem_Click);
            // 
            // flowersToolStripMenuItem
            // 
            this.flowersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFlowersToolStripMenuItem,
            this.allFlowersToolStripMenuItem,
            this.deliverHistoryToolStripMenuItem});
            this.flowersToolStripMenuItem.Name = "flowersToolStripMenuItem";
            this.flowersToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.flowersToolStripMenuItem.Text = "Flowers";
            // 
            // newFlowersToolStripMenuItem
            // 
            this.newFlowersToolStripMenuItem.Name = "newFlowersToolStripMenuItem";
            this.newFlowersToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.newFlowersToolStripMenuItem.Text = "New Flowers";
            this.newFlowersToolStripMenuItem.Click += new System.EventHandler(this.newFlowersToolStripMenuItem_Click);
            // 
            // allFlowersToolStripMenuItem
            // 
            this.allFlowersToolStripMenuItem.Name = "allFlowersToolStripMenuItem";
            this.allFlowersToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.allFlowersToolStripMenuItem.Text = "All Flowers";
            this.allFlowersToolStripMenuItem.Click += new System.EventHandler(this.allFlowersToolStripMenuItem_Click);
            // 
            // deliverHistoryToolStripMenuItem
            // 
            this.deliverHistoryToolStripMenuItem.Name = "deliverHistoryToolStripMenuItem";
            this.deliverHistoryToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.deliverHistoryToolStripMenuItem.Text = "Deliver History";
            this.deliverHistoryToolStripMenuItem.Click += new System.EventHandler(this.deliverHistoryToolStripMenuItem_Click);
            // 
            // ordersToolStripMenuItem
            // 
            this.ordersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allOrdersToolStripMenuItem});
            this.ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            this.ordersToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.ordersToolStripMenuItem.Text = "Sales";
            // 
            // allOrdersToolStripMenuItem
            // 
            this.allOrdersToolStripMenuItem.Name = "allOrdersToolStripMenuItem";
            this.allOrdersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.allOrdersToolStripMenuItem.Text = "All Sales";
            this.allOrdersToolStripMenuItem.Click += new System.EventHandler(this.allOrdersToolStripMenuItem_Click);
            // 
            // bouquetToolStripMenuItem
            // 
            this.bouquetToolStripMenuItem.Name = "bouquetToolStripMenuItem";
            this.bouquetToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.bouquetToolStripMenuItem.Text = "Bouquet";
            this.bouquetToolStripMenuItem.Click += new System.EventHandler(this.bouquetToolStripMenuItem_Click);
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(662, 421);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flower Shop Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFlowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allFlowersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bouquetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deliverHistoryToolStripMenuItem;
    }
}

