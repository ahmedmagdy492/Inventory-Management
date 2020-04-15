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
    public partial class frmMoveProdsAcrossWarehouses : Form
    {
        private Warehouses wdb;
        private Products warehouseProdsDb;
        private Providers provDb;
        private List<WareHouseProducts> prodsList;
        private List<WareHouseProducts> movedProdsList;
        private WareHouseProdsDB prodsDB;
        private DismissalPermissionDB dpDB;        
        private SupplyPermissions spDB;
        private DismissalPerProducts dppDB;
        private SupplyPermissionsProductsDB sppDB;
        public frmMoveProdsAcrossWarehouses()
        {
            InitializeComponent();
            wdb = new Warehouses();
            warehouseProdsDb = new Products();
            provDb = new Providers();
            prodsDB = new WareHouseProdsDB();
            prodsList = new List<WareHouseProducts>();
            movedProdsList = new List<WareHouseProducts>();
            dpDB = new DismissalPermissionDB();
            spDB = new SupplyPermissions();
            dppDB = new DismissalPerProducts();
            sppDB = new SupplyPermissionsProductsDB();
        }

        private async void frmMoveProdsAcrossWarehouses_Load(object sender, EventArgs e)
        {
            // loading data
            cmbWarehouseFrom.DataSource = await wdb.GetWarehouses();
            cmbWarehouseFrom.DisplayMember = "Name";
            cmbWarehouseFrom.ValueMember = "Id";
            cmbWarehouseTo.DataSource = await wdb.GetWarehouses();
            cmbWarehouseTo.DisplayMember = "Name";
            cmbWarehouseTo.ValueMember = "Id";
            btnAdd.Enabled = false;
        }

        private async void AddToView(DataGridView dtProds, List<WareHouseProducts> lsProds)
        {
            dtProds.Rows.Clear();
            foreach(var prod in lsProds)
            {
                var provider = await provDb.GetProvider(prod.Product.ProviderId);
                dtProds.Rows.Add(prod.ProductId, prod.Product.Name, prod.Quantity, prod.Product.ProductionDate, prod.Product.ExpirationDate, provider.Name);
            }
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if(dtProduction.Value < dtExpiration.Value)
            {
                btnSearch.Enabled = false;
                btnSearch.Text = "يتم البحث الان...";
                List<WareHouseProducts> listProds = (await warehouseProdsDb.GetProductsOfWarehouse(Convert.ToInt32(cmbWarehouseFrom.SelectedValue.ToString()))).Where(wp => wp.Product.ProductionDate >= dtProduction.Value && wp.Product.ExpirationDate <= dtExpiration.Value && wp.Quantity > 0).ToList();

                if(listProds.Count == 0)
                {
                    dtFromProds.Rows.Clear();
                    MessageBox.Show("لا يوجد نتائج", "بحث", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                }
                else
                {
                    AddToView(dtFromProds, listProds);
                }
                prodsList = listProds;
                btnSearch.Enabled = true;
                btnSearch.Text = "بحث";
            }
        }

        private void dtFromProds_SelectionChanged(object sender, EventArgs e)
        {
            if(dtFromProds.SelectedRows.Count == 1)
            {
                btnAdd.Enabled = true;
                int quantity = Convert.ToInt32(dtFromProds.SelectedRows[0].Cells[2].Value.ToString());
                nmQuantity.Maximum = quantity;
                nmQuantity.Value = quantity;
            }
            else
            {
                btnAdd.Enabled = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(cmbWarehouseFrom.SelectedValue.ToString() != cmbWarehouseTo.SelectedValue.ToString() && prodsList.Count > 0)
            {
                if(Convert.ToInt32(dtFromProds.SelectedRows[0].Cells[2].Value.ToString()) >= nmQuantity.Value)
                {
                    cmbWarehouseFrom.Enabled = false;
                    btnSearch.Enabled = false;
                    int prodId = Convert.ToInt32(dtFromProds.SelectedRows[0].Cells[0].Value.ToString());
                    var prod = prodsList.FirstOrDefault(p => p.ProductId == prodId);
                    prod.Quantity = (int)nmQuantity.Value;
                    var oldProd = movedProdsList.FirstOrDefault(p => p.Product.Name == prod.Product.Name);
                    if (oldProd == null)
                    {
                        movedProdsList.Add(prod);
                    }
                    else
                    {
                        oldProd.Quantity += prod.Quantity;
                    }
                    AddToView(dtToProds, movedProdsList);
                    dtFromProds.SelectedRows[0].Cells[2].Value = Convert.ToInt32(dtFromProds.SelectedRows[0].Cells[2].Value) - nmQuantity.Value;
                }
            }
            else
            {
                MessageBox.Show("لا يمكن تحويل اصناف لنفس المخزن", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }

        private async void btnDone_ClickAsync(object sender, EventArgs e)
        {
            if (dtToProds.Rows.Count > 0)
            {
                btnDone.Text = "تتم عملية التحويل الان...";
                btnDone.Enabled = false;
                // adding export permission to the from warehouse
                DismissalPermission ds = new DismissalPermission
                {
                    PermissionDate = DateTime.Now,
                    WareHouseId = Convert.ToInt32(cmbWarehouseFrom.SelectedValue.ToString()),
                };

                // adding import permission to the to warehouse
                SupplyPermission sp = new SupplyPermission
                {
                    PermissionDate = DateTime.Now,
                    WareHouseId = Convert.ToInt32(cmbWarehouseTo.SelectedValue.ToString())
                };

                // creating permissions first
                int dpsId = (await dpDB.Create(ds)).Id;
                int spsId = (await spDB.Create(sp)).Id;

                // reducing the products quantity
                foreach (var prod in movedProdsList)
                {
                    await prodsDB.ReduceProductQuantity(prod.ProductId, prod.Quantity, prod.WareHouseId);
                    prod.WareHouseId = Convert.ToInt32(cmbWarehouseTo.SelectedValue.ToString());
                    // add the products to the new warehouse                
                    await prodsDB.UpdateOrCreate(prod);

                    DismissalPermissionProducts dpp = new DismissalPermissionProducts
                    {
                        DismissalPerId = dpsId,
                        ProductId = prod.ProductId,
                        Quantity = prod.Quantity
                    };

                    await dppDB.Create(dpp);

                    SupplyPermissionProducts spp = new SupplyPermissionProducts
                    {
                        SupplyPerId = spsId,
                        ProductId = prod.ProductId,
                        Quantity = prod.Quantity
                    };

                    await sppDB.Create(spp);
                    btnDone.Text = "تأكيد التحويل";
                    btnDone.Enabled = true;
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("لا يوجد اصناف لنقلها", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
        }
    }
}
