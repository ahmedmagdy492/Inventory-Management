using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouseManagement.Models;

namespace WareHouseManagement
{
    public partial class frmProducts : Form
    {
        private Products prodDb;
        private Warehouses warehouseDb;
        private Providers provDb;
        public frmProducts()
        {
            InitializeComponent();
            prodDb = new Products();
            warehouseDb = new Warehouses();
            provDb = new Providers();
        }

        private async void AddToView()
        {
            dtProds.Rows.Clear();
            var ds = await prodDb.GetProductsOfWarehouse(Convert.ToInt32(cmbWarehouses.SelectedValue.ToString()));
            foreach (var prod in ds)
            {
                var provider = await provDb.GetProvider(prod.Product.ProviderId);
                dtProds.Rows.Add(prod.Product.Name, provider.Name, prod.Warehouse.Name, prod.Quantity);
            }
        }

        private async void frmProducts_Load(object sender, EventArgs e)
        {            
            // loading all warehouses
            cmbWarehouses.DataSource = await warehouseDb.GetWarehouses();
            cmbWarehouses.DisplayMember = "Name";
            cmbWarehouses.ValueMember = "Id";

            // loading products for the currently selected warehouse
            AddToView();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Text = "يتم البحث الان...";
            btnSearch.Enabled = false;
            // loading products for the currently selected warehouse
            AddToView();
            btnSearch.Text = "بحث";
            btnSearch.Enabled = true;
        }
    }
}
