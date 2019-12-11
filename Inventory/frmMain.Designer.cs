namespace Inventory.GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVendor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGetData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsItem = new System.Windows.Forms.ToolStripButton();
            this.tsVendor = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tsTransaction = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItem,
            this.mnuVendor,
            this.mnuGetData,
            this.mnuWindow});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.mnuWindow;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(825, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "File";
            // 
            // mnuItem
            // 
            this.mnuItem.Name = "mnuItem";
            this.mnuItem.Size = new System.Drawing.Size(43, 20);
            this.mnuItem.Text = "Item";
            this.mnuItem.Click += new System.EventHandler(this.mnuItem_Click);
            // 
            // mnuVendor
            // 
            this.mnuVendor.Name = "mnuVendor";
            this.mnuVendor.Size = new System.Drawing.Size(56, 20);
            this.mnuVendor.Text = "Vendor";
            this.mnuVendor.Click += new System.EventHandler(this.mnuVendor_Click);
            // 
            // mnuGetData
            // 
            this.mnuGetData.Name = "mnuGetData";
            this.mnuGetData.Size = new System.Drawing.Size(64, 20);
            this.mnuGetData.Text = "Get Data";
            this.mnuGetData.Click += new System.EventHandler(this.mnuGetData_Click);
            // 
            // mnuWindow
            // 
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(63, 20);
            this.mnuWindow.Text = "Window";
            this.mnuWindow.Visible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsItem,
            this.tsVendor,
            this.tsTransaction});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(825, 25);
            this.toolStrip1.TabIndex = 2;
            // 
            // tsItem
            // 
            this.tsItem.Image = ((System.Drawing.Image)(resources.GetObject("tsItem.Image")));
            this.tsItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsItem.Name = "tsItem";
            this.tsItem.Size = new System.Drawing.Size(51, 22);
            this.tsItem.Text = "Item";
            this.tsItem.Click += new System.EventHandler(this.mnuItem_Click);
            // 
            // tsVendor
            // 
            this.tsVendor.Image = ((System.Drawing.Image)(resources.GetObject("tsVendor.Image")));
            this.tsVendor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsVendor.Name = "tsVendor";
            this.tsVendor.Size = new System.Drawing.Size(64, 22);
            this.tsVendor.Text = "Vendor";
            this.tsVendor.Click += new System.EventHandler(this.mnuVendor_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(825, 49);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tsTransaction
            // 
            this.tsTransaction.Image = ((System.Drawing.Image)(resources.GetObject("tsTransaction.Image")));
            this.tsTransaction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsTransaction.Name = "tsTransaction";
            this.tsTransaction.Size = new System.Drawing.Size(88, 22);
            this.tsTransaction.Text = "Transaction";
            this.tsTransaction.Click += new System.EventHandler(this.tsTransaction_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(825, 625);
            this.Controls.Add(this.tableLayoutPanel1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Text = "Inventory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuVendor;
        private System.Windows.Forms.ToolStripMenuItem mnuGetData;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsItem;
        private System.Windows.Forms.ToolStripButton tsVendor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripButton tsTransaction;
    }
}

