using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouseLib;
using WareHouseManagement.Models;

namespace WareHouseManagement
{
    public partial class frmReportPord : Form
    {
        private Warehouses warehousesDB;
        private WareHouseProdsDB wpdB;
        private Providers provDB;
        public frmReportPord()
        {
            InitializeComponent();
            warehousesDB = new Warehouses();
            wpdB = new WareHouseProdsDB();
            provDB = new Providers();
        }

        private async void AddToView(List<WareHouseProducts> prods)
        {
            dtProds.Rows.Clear();
            foreach(var prod in prods)
            {
                var provider = await provDB.GetProvider(prod.Product.ProviderId);
                dtProds.Rows.Add(prod.Product.Name, prod.Quantity, prod.Product.ProductionDate, prod.Product.ExpirationDate, prod.Warehouse.Name, provider.Name);
            }
        }

        private async void frmReportPord_Load(object sender, EventArgs e)
        {
            // loading all warehouses
            lsWares.DataSource = await warehousesDB.GetWarehouses();
            lsWares.DisplayMember = "Name";
            lsWares.ValueMember = "Id";

            dtFrom.Enabled = false;
            dtTo.Enabled = false;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int[] ids = new int[lsWares.SelectedItems.Count];
            int c = 0;
            foreach (var id in lsWares.SelectedItems)
            {
                ids[c] = ((Warehouse)id).Id;
                c++;
            }
            if (chckDate.Checked)
            {
                AddToView(wpdB.GetProdsWithWarehousesAndDate(ids, dtFrom.Value, dtTo.Value));
            }
            else
            {                
                AddToView(wpdB.GetProdsFromSeveralWarehouses(ids));                
            }
        }

        private void chckDate_CheckedChanged(object sender, EventArgs e)
        {
            if(chckDate.Checked)
            {
                dtTo.Enabled = true;
                dtFrom.Enabled = true;
            }
            else
            {
                dtTo.Enabled = false;
                dtFrom.Enabled = false;
            }
        }
    }
}
