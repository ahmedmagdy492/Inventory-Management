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
    public partial class ProductsInSuppPer : Form
    {
        private List<SupplyPermissionProducts> sp;
        private SupplyPermissions spDb;
        private Warehouses whDb;
        public ProductsInSuppPer(List<SupplyPermissionProducts> _spp)
        {
            InitializeComponent();
            sp = _spp;
            spDb = new SupplyPermissions();
            whDb = new Warehouses();
        }

        private async void ProductsInSuppPer_Load(object sender, EventArgs e)
        {
            this.Text += "اذن توريد رقم " + sp[0].SupplyPermission.Id + " بتاريخ " + sp[0].SupplyPermission.PermissionDate;
            // loading this specific Supply permission products
            foreach (var sprod in sp)
            {
                var warehouse = await whDb.GetOne(sprod.SupplyPermission.WareHouseId);
                dtProducts.Rows.Add(sprod.Product.Name, warehouse.Name, sprod.Quantity);
            }
        }
    }
}
