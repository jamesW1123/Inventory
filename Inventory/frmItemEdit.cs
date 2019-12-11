using Inventory.DB;
using Inventory.Objects;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Windows.Forms;

namespace Inventory.GUI
{
    public partial class frmItemEdit : Form
    {
        private bool isNew;
        private Item item;

        /// <summary>
        /// This constructor is for a new item
        /// </summary>
        public frmItemEdit()
        {
            InitializeComponent();
            isNew = true;

            List<object> vendors = new List<object>();
            try
            {
                using (OdbcConnection db = Database.OdbcAuthDB(modMain.connectionString))
                {
                    vendors = Database.GetDataAsString(db, "SELECT name FROM vendor");
                    cmbVendors.Items.AddRange(vendors.ToArray());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("exception: " + ex);
            }

            item = new Item();

            //number, name, manufacturer, vendorid, cost, sell, onorder, onhand, minonhand, description
            txtItemNo.Text = item.Number.ToString();
            txtBarcode.Text = item.Barcode.ToString();
            txtName.Text = item.Name;
            txtManufacturer.Text = item.Manufacturer;
            cmbVendors.SelectedIndex = item.Vendorid;
            txtCost.Text = item.Cost.ToString("0.00");
            txtSell.Text = item.Sell.ToString("0.00");
            txtQtyOnOrder.Text = item.Onorder.ToString();
            txtQtyOnHand.Text = item.Onhand.ToString();
            txtMinOnHand.Text = item.Minonhand.ToString();
            txtDescript.Text = item.Description;
        }

        /// <summary>
        /// This constructor is for editing an existing item
        /// </summary>
        /// <param name="id"></param>
        public frmItemEdit(int id)
        {
            InitializeComponent();
            isNew = false;

            List<object> vendors = new List<object>();
            try
            {
                using (OdbcConnection db = Database.OdbcAuthDB(modMain.connectionString))
                {
                    cmbVendors.Items.Add("");
                    vendors = Database.GetDataAsString(db, "SELECT name FROM vendor");
                    cmbVendors.Items.AddRange(vendors.ToArray());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("exception: " + ex);
            }

            item = new Item(id, false);

            //number, name, manufacturer, vendorid, cost, sell, onorder, onhand, minonhand, description
            txtItemNo.Text = item.Number.ToString();
            txtBarcode.Text = item.Barcode.ToString();
            txtName.Text = item.Name;
            txtManufacturer.Text = item.Manufacturer.ToString();
            cmbVendors.SelectedIndex = item.Vendorid;
            txtCost.Text = item.Cost.ToString("0.00");
            txtSell.Text = item.Sell.ToString("0.00");
            txtQtyOnOrder.Text = item.Onorder.ToString();
            txtQtyOnHand.Text = item.Onhand.ToString();
            txtMinOnHand.Text = item.Minonhand.ToString();
            txtDescript.Text = item.Description;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// If this is a new item, call the item object's Save_New function
        /// If this is an existing item, call the item object's Save_Update function
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            item.Number = Int32.Parse(txtItemNo.Text);
            item.Barcode = Int32.Parse(txtBarcode.Text);
            item.Name = txtName.Text;
            item.Manufacturer = txtManufacturer.Text;
            item.Vendorid = cmbVendors.SelectedIndex;
            item.Cost = Decimal.Parse(txtCost.Text);
            item.Sell = Decimal.Parse(txtSell.Text);
            item.Onorder = Int32.Parse(txtQtyOnOrder.Text);
            item.Onhand = Int32.Parse(txtQtyOnHand.Text);
            item.Minonhand = Int32.Parse(txtMinOnHand.Text);
            item.Description = txtDescript.Text;

            if (isNew)
            {
                if (item.saveNew(item))
                {
                    MessageBox.Show("Item Saved.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Item could not be saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (item.saveUpdate(item))
                {
                    MessageBox.Show("Item updated.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Item could not be updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
        }
    }
}
