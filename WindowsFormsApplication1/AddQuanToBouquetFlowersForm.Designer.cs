namespace WindowsFormsApplication1
{
    partial class AddQuanToBouquetFlowersForm
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
            this.nudQuanFlower = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateQuan = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuanFlower)).BeginInit();
            this.SuspendLayout();
            // 
            // nudQuanFlower
            // 
            this.nudQuanFlower.Location = new System.Drawing.Point(75, 28);
            this.nudQuanFlower.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudQuanFlower.Name = "nudQuanFlower";
            this.nudQuanFlower.Size = new System.Drawing.Size(178, 20);
            this.nudQuanFlower.TabIndex = 0;
            // 
            // btnUpdateQuan
            // 
            this.btnUpdateQuan.Location = new System.Drawing.Point(75, 70);
            this.btnUpdateQuan.Name = "btnUpdateQuan";
            this.btnUpdateQuan.Size = new System.Drawing.Size(178, 62);
            this.btnUpdateQuan.TabIndex = 1;
            this.btnUpdateQuan.Text = "Update Quantity";
            this.btnUpdateQuan.UseVisualStyleBackColor = true;
            this.btnUpdateQuan.Click += new System.EventHandler(this.btnUpdateQuan_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(241, 226);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Lime;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(175, 13);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Update Quantity of Selected Flower";
            // 
            // AddQuanToBouquetFlowersForm
            // 
            this.AcceptButton = this.btnUpdateQuan;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(326, 261);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdateQuan);
            this.Controls.Add(this.nudQuanFlower);
            this.Name = "AddQuanToBouquetFlowersForm";
            this.Text = "Update Quantity of Selected Flower";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuanFlower)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudQuanFlower;
        private System.Windows.Forms.Button btnUpdateQuan;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblHeader;
    }
}