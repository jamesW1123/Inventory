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

namespace Inventory.GUI
{
    public partial class frmItemList : Form
    {
        public frmItemList()
        {
            InitializeComponent();

            refreshData();
        }

        private void dgvGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmItemEdit")
                {
                    return;
                }
            }
            frmItemEdit form = new frmItemEdit((int) dgvGrid.Rows[e.RowIndex].Cells[1].Value);
            form.MdiParent = this.MdiParent;
            form.Show();

            refreshData();
        }

        private void refreshData()
        {
            DataTable dt = null;
            try
            {
                using (OdbcConnection db = Database.OdbcAuthDB(modMain.connectionString))
                {
                    dt = Database.ExecuteDataTable(db, "SELECT * FROM item");

                    if (dt != null) dgvGrid.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception: " + ex);
            }
        }

        private void frmItemList_Activated(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                if (f.Name == "frmItemEdit")
                {
                    f.Activate();
                }
            }
            refreshData();
        }
    }
}
