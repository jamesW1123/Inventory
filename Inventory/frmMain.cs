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
using Inventory.API;

namespace Inventory.GUI
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
        }
        
        private void mnuItem_Click(object sender, EventArgs e)
        {
            frmItemList form = new frmItemList();
            form.MdiParent = this;
            form.Show();
        }

        private void mnuVendor_Click(object sender, EventArgs e)
        {
            frmVendorList form = new frmVendorList();
            form.MdiParent = this;
            form.Show();
        }

        private void tsTransaction_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Transaction.Get_Item_Details(123456));
            MessageBox.Show(Transaction.Get_Item_Details(654321));
        }

        private void mnuGetData_Click(object sender, EventArgs e)
        {
            //DataTable dt = null;
            //try
            //{
            //    using (OdbcConnection db = Database.OdbcAuthDB(modMain.connectionString))
            //    {
            //        dt = Database.ExecuteDataTable(db, "SELECT * FROM vendor");

            //        if (dt != null) dgvGrid.DataSource = dt;
            //        Console.WriteLine("Somehing went wrong");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("exception: " + ex);
            //}
        }

    }
}
