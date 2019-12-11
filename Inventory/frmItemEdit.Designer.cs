namespace Inventory.GUI
{
    partial class frmItemEdit
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
            this.lblItemNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDescript = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblQtyOnHand = new System.Windows.Forms.Label();
            this.lblQtyOnOrder = new System.Windows.Forms.Label();
            this.lblMinOnHand = new System.Windows.Forms.Label();
            this.lblManufacturer = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblSell = new System.Windows.Forms.Label();
            this.txtItemNo = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSell = new System.Windows.Forms.TextBox();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.txtQtyOnOrder = new System.Windows.Forms.TextBox();
            this.txtQtyOnHand = new System.Windows.Forms.TextBox();
            this.txtMinOnHand = new System.Windows.Forms.TextBox();
            this.txtDescript = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.cmbVendors = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBarcode = new System.Windows.Forms.Label();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblItemNo
            // 
            this.lblItemNo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblItemNo.AutoSize = true;
            this.lblItemNo.Location = new System.Drawing.Point(6, 32);
            this.lblItemNo.Name = "lblItemNo";
            this.lblItemNo.Size = new System.Drawing.Size(70, 13);
            this.lblItemNo.TabIndex = 0;
            this.lblItemNo.Text = "Item Number:";
            this.lblItemNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(15, 6);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(61, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Item Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescript
            // 
            this.lblDescript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescript.AutoSize = true;
            this.lblDescript.Location = new System.Drawing.Point(13, 131);
            this.lblDescript.Name = "lblDescript";
            this.lblDescript.Size = new System.Drawing.Size(63, 13);
            this.lblDescript.TabIndex = 2;
            this.lblDescript.Text = "Description:";
            // 
            // lblCost
            // 
            this.lblCost.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(437, 6);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(70, 13);
            this.lblCost.TabIndex = 3;
            this.lblCost.Text = "Cost Amount:";
            this.lblCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQtyOnHand
            // 
            this.lblQtyOnHand.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQtyOnHand.AutoSize = true;
            this.lblQtyOnHand.Location = new System.Drawing.Point(412, 84);
            this.lblQtyOnHand.Name = "lblQtyOnHand";
            this.lblQtyOnHand.Size = new System.Drawing.Size(95, 13);
            this.lblQtyOnHand.TabIndex = 4;
            this.lblQtyOnHand.Text = "Quantity On-Hand:";
            this.lblQtyOnHand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblQtyOnOrder
            // 
            this.lblQtyOnOrder.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQtyOnOrder.AutoSize = true;
            this.lblQtyOnOrder.Location = new System.Drawing.Point(415, 58);
            this.lblQtyOnOrder.Name = "lblQtyOnOrder";
            this.lblQtyOnOrder.Size = new System.Drawing.Size(92, 13);
            this.lblQtyOnOrder.TabIndex = 5;
            this.lblQtyOnOrder.Text = "Quanity On-Order:";
            this.lblQtyOnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMinOnHand
            // 
            this.lblMinOnHand.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblMinOnHand.AutoSize = true;
            this.lblMinOnHand.Location = new System.Drawing.Point(413, 111);
            this.lblMinOnHand.Name = "lblMinOnHand";
            this.lblMinOnHand.Size = new System.Drawing.Size(94, 13);
            this.lblMinOnHand.TabIndex = 6;
            this.lblMinOnHand.Text = "Minimum On-Hand";
            this.lblMinOnHand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblManufacturer
            // 
            this.lblManufacturer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblManufacturer.AutoSize = true;
            this.lblManufacturer.Location = new System.Drawing.Point(3, 84);
            this.lblManufacturer.Name = "lblManufacturer";
            this.lblManufacturer.Size = new System.Drawing.Size(73, 13);
            this.lblManufacturer.TabIndex = 7;
            this.lblManufacturer.Text = "Manufacturer:";
            this.lblManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVendor
            // 
            this.lblVendor.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblVendor.AutoSize = true;
            this.lblVendor.Location = new System.Drawing.Point(32, 111);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(44, 13);
            this.lblVendor.TabIndex = 8;
            this.lblVendor.Text = "Vendor:";
            this.lblVendor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSell
            // 
            this.lblSell.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSell.AutoSize = true;
            this.lblSell.Location = new System.Drawing.Point(453, 32);
            this.lblSell.Name = "lblSell";
            this.lblSell.Size = new System.Drawing.Size(54, 13);
            this.lblSell.TabIndex = 9;
            this.lblSell.Text = "Sell Price:";
            this.lblSell.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtItemNo
            // 
            this.txtItemNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtItemNo.Location = new System.Drawing.Point(82, 29);
            this.txtItemNo.Name = "txtItemNo";
            this.txtItemNo.Size = new System.Drawing.Size(248, 20);
            this.txtItemNo.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.Location = new System.Drawing.Point(82, 3);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(248, 20);
            this.txtName.TabIndex = 11;
            // 
            // txtSell
            // 
            this.txtSell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSell.Location = new System.Drawing.Point(513, 29);
            this.txtSell.Name = "txtSell";
            this.txtSell.Size = new System.Drawing.Size(59, 20);
            this.txtSell.TabIndex = 12;
            // 
            // txtCost
            // 
            this.txtCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCost.Location = new System.Drawing.Point(513, 3);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(59, 20);
            this.txtCost.TabIndex = 13;
            // 
            // txtQtyOnOrder
            // 
            this.txtQtyOnOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQtyOnOrder.Location = new System.Drawing.Point(513, 55);
            this.txtQtyOnOrder.Name = "txtQtyOnOrder";
            this.txtQtyOnOrder.Size = new System.Drawing.Size(59, 20);
            this.txtQtyOnOrder.TabIndex = 14;
            // 
            // txtQtyOnHand
            // 
            this.txtQtyOnHand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQtyOnHand.Location = new System.Drawing.Point(513, 81);
            this.txtQtyOnHand.Name = "txtQtyOnHand";
            this.txtQtyOnHand.Size = new System.Drawing.Size(59, 20);
            this.txtQtyOnHand.TabIndex = 15;
            // 
            // txtMinOnHand
            // 
            this.txtMinOnHand.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMinOnHand.Location = new System.Drawing.Point(513, 107);
            this.txtMinOnHand.Name = "txtMinOnHand";
            this.txtMinOnHand.Size = new System.Drawing.Size(59, 20);
            this.txtMinOnHand.TabIndex = 16;
            // 
            // txtDescript
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtDescript, 4);
            this.txtDescript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescript.Location = new System.Drawing.Point(82, 134);
            this.txtDescript.Multiline = true;
            this.txtDescript.Name = "txtDescript";
            this.txtDescript.Size = new System.Drawing.Size(490, 156);
            this.txtDescript.TabIndex = 17;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtManufacturer.Location = new System.Drawing.Point(82, 81);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(248, 20);
            this.txtManufacturer.TabIndex = 18;
            // 
            // cmbVendors
            // 
            this.cmbVendors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbVendors.FormattingEnabled = true;
            this.cmbVendors.Location = new System.Drawing.Point(82, 107);
            this.cmbVendors.Name = "cmbVendors";
            this.cmbVendors.Size = new System.Drawing.Size(248, 21);
            this.cmbVendors.TabIndex = 19;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 302);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 40);
            this.panel2.TabIndex = 21;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(111, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(20, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 254F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.Controls.Add(this.txtBarcode, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblBarcode, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblItemNo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtItemNo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbVendors, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDescript, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSell, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMinOnHand, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMinOnHand, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtQtyOnHand, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQtyOnHand, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSell, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtManufacturer, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtQtyOnOrder, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCost, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblQtyOnOrder, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblManufacturer, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtCost, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtDescript, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblVendor, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(575, 293);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(583, 345);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // lblBarcode
            // 
            this.lblBarcode.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblBarcode.AutoSize = true;
            this.lblBarcode.Location = new System.Drawing.Point(26, 58);
            this.lblBarcode.Name = "lblBarcode";
            this.lblBarcode.Size = new System.Drawing.Size(50, 13);
            this.lblBarcode.TabIndex = 20;
            this.lblBarcode.Text = "Barcode:";
            this.lblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBarcode.Location = new System.Drawing.Point(82, 55);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(248, 20);
            this.txtBarcode.TabIndex = 21;
            // 
            // frmItemEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 345);
            this.Controls.Add(this.tableLayoutPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmItemEdit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add/Edit Items";
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblItemNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDescript;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblQtyOnHand;
        private System.Windows.Forms.Label lblQtyOnOrder;
        private System.Windows.Forms.Label lblMinOnHand;
        private System.Windows.Forms.Label lblManufacturer;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lblSell;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSell;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.TextBox txtQtyOnOrder;
        private System.Windows.Forms.TextBox txtQtyOnHand;
        private System.Windows.Forms.TextBox txtMinOnHand;
        private System.Windows.Forms.TextBox txtDescript;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.ComboBox cmbVendors;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.Label lblBarcode;
    }
}