using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.DB;
using Inventory.Objects;

namespace Inventory.GUI
{
    public partial class frmVendorEdit : Form
    {
        private bool isNew;
        private Vendor vendor;

        /// <summary>
        /// 
        /// </summary>
        public frmVendorEdit()
        {
            InitializeComponent();
            isNew = true;

            vendor = new Vendor();

            //name, street, city, state, zip, phone, fax, contact1, contact2, email1, email2
            txtName.Text = vendor.Name;
            txtStreet.Text = vendor.Street;
            txtCity.Text = vendor.City;
            txtState.Text = vendor.State;
            txtZip.Text = vendor.Zip;
            txtPhone.Text = vendor.Phone;
            txtFax.Text = vendor.Fax;
            txtContact1.Text = vendor.Contact1;
            txtEmail1.Text = vendor.Email1;
            txtContact2.Text = vendor.Contact2;
            txtEmail2.Text = vendor.Email2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public frmVendorEdit(int id)
        {
            InitializeComponent();
            isNew = false;

            vendor = new Vendor(id);

            //name, street, city, state, zip, phone, fax, contact1, contact2, email1, email2
            txtName.Text = vendor.Name;
            txtStreet.Text = vendor.Street;
            txtCity.Text = vendor.City;
            txtState.Text = vendor.State;
            txtZip.Text = vendor.Zip;
            txtPhone.Text = vendor.Phone;
            txtFax.Text = vendor.Fax;
            txtContact1.Text = vendor.Contact1;
            txtEmail1.Text = vendor.Email1;
            txtContact2.Text = vendor.Contact2;
            txtEmail2.Text = vendor.Email2;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// If this is a new vendor, call the vendor object's Save_New function
        /// If this is an existing vendor, call the vendor object's Save_Update function        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            //name, street, city, state, zip, phone, fax, contact1, contact2, email1, email2
            vendor.Name = txtName.Text;
            vendor.Street = txtStreet.Text;
            vendor.City = txtCity.Text;
            vendor.State = txtState.Text;
            vendor.Zip = txtZip.Text;
            vendor.Phone = txtPhone.Text;
            vendor.Fax = txtFax.Text;
            vendor.Contact1 = txtContact1.Text;
            vendor.Contact2 = txtContact2.Text;
            vendor.Email1 = txtEmail1.Text;
            vendor.Email2 = txtEmail2.Text;
            
            if (isNew)
            {
                if (vendor.saveNew(vendor))
                {
                    MessageBox.Show("Vendor Saved.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vendor could not be saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (vendor.saveUpdate(vendor))
                {
                    MessageBox.Show("Vendor updated.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Vendor could not be updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            this.Close();
        }
    }
}
