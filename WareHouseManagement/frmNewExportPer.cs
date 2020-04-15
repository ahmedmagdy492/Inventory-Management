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
    public partial class frmNewExportPer : Form
    {
        private Warehouses warehouseDb;
        private Products prodDB;
        private Clients clientsDB;
        private Providers provDB;
        private WareHouseProdsDB wpDB;
        private DismissalPermissionDB dpDB;
        private DismissalPerProducts dppDB;
        private List<WareHouseProducts> AllProductsInView1;
        private List<WareHouseProducts> View2Products;        
        private bool isConfirmed = false;

        public frmNewExportPer()
        {
            InitializeComponent();
            warehouseDb = new Warehouses();
            prodDB = new Products();
            clientsDB = new Clients();
            provDB = new Providers();
            AllProductsInView1 = new List<WareHouseProducts>();
            View2Products = new List<WareHouseProducts>();
            wpDB = new WareHouseProdsDB();
            dpDB = new DismissalPermissionDB();
            dppDB = new DismissalPerProducts();
        }

        private async void AddToView(DataGridView dtProds, List<WareHouseProducts> allProds)
        {
            dtProds.Rows.Clear();
            foreach(var prod in allProds)
            {
                var provider = await provDB.GetProvider(prod.Product.ProviderId);
                dtProds.Rows.Add(prod.ProductId, prod.Product.Name, prod.Warehouse.Name, prod.Quantity, provider.Name);
                AllProductsInView1.Add(prod);
            }
        }

        private async void frmNewExportPer_Load(object sender, EventArgs e)
        {
            // loading warehouses
            cmbWarehouses.DataSource = await warehouseDb.GetWarehouses();
            cmbWarehouses.DisplayMember = "Name";
            cmbWarehouses.ValueMember = "Id";

            // loading customers
            cmbCustomers.DataSource = await clientsDB.GetCustomers();
            cmbCustomers.DisplayMember = "Name";
            cmbCustomers.ValueMember = "Id";

            btnAdd.Enabled = false;
            btnConfirm.Enabled = false;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            btnSearch.Enabled = false;
            btnSearch.Text = "يتم البحث الان...";
            // load products according to the chosen warehouse
            AddToView(dtProds, await prodDB.GetProductsOfWarehouse(Convert.ToInt32(cmbWarehouses.SelectedValue.ToString())));

            btnSearch.Enabled = true;
            btnSearch.Text = "بحث";
        }

        private async void lblAddCustomer_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmClients frm = new frmClients();
            frm.ShowDialog();
            // loading customers
            cmbCustomers.DataSource = await clientsDB.GetCustomers();
            cmbCustomers.DisplayMember = "Name";
            cmbCustomers.ValueMember = "Id";
        }

        private void dtProds_SelectionChanged(object sender, EventArgs e)
        {
            if(dtProds.SelectedRows.Count == 1)
            {
                nmQuantity.Maximum = Convert.ToInt32(dtProds.SelectedRows[0].Cells[3].Value.ToString());
                nmQuantity.Value = Convert.ToInt32(dtProds.SelectedRows[0].Cells[3].Value.ToString());
                btnAdd.Enabled = true;
            }
            else
            {
                btnAdd.Enabled = false;
                nmQuantity.Value = 0;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // adding products to the per products view
            if(nmQuantity.Value > 0 && Convert.ToInt32(dtProds.SelectedRows[0].Cells[3].Value.ToString()) > 0)
            {
                btnConfirm.Enabled = true;
                isConfirmed = false;
                int prodid = Convert.ToInt32(dtProds.SelectedRows[0].Cells[0].Value.ToString());
                var selectedProduct = AllProductsInView1.FirstOrDefault(prod => prod.ProductId == prodid);
                selectedProduct.Quantity = (int)nmQuantity.Value;
                if(View2Products.FirstOrDefault(vp => vp.ProductId == selectedProduct.ProductId && vp.WareHouseId == selectedProduct.WareHouseId) == null)
                {
                    // if the product is not exist yet in the view 2 products we will add it
                    View2Products.Add(selectedProduct);
                    AddToView(dtPerProds, View2Products);
                }
                else
                {
                    // otherwise we will change only the quantity
                    var product = View2Products.FirstOrDefault(vp => vp.ProductId == selectedProduct.ProductId);
                    product.Quantity += (int)nmQuantity.Value;
                }
                int Quantity = Convert.ToInt32(dtProds.SelectedRows[0].Cells[3].Value.ToString());
                dtProds.SelectedRows[0].Cells[3].Value = Quantity - nmQuantity.Value;
                cmbWarehouses.Enabled = false;
            }
            else
            {
                MessageBox.Show("لقد تم نفاذ الكمية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading | MessageBoxOptions.RtlReading);
                nmQuantity.Value = 0;
            }
        }

        private async void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("بالضغط علي ok سوف يتم خصم كميات كل صنف من المخزن", "تحذير", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);

            if(dr == DialogResult.OK)
            {
                // reducing the selected products from the db
                foreach(var prod in View2Products)
                {
                    await wpDB.ReduceProductQuantity(prod.ProductId, prod.Quantity, prod.WareHouseId);
                }
                //AddToView(dtProds, await wpDB.GetAll());
                btnConfirm.Enabled = false;
                isConfirmed = true;
            }
        }

        private async void btnAddExpPer_Click(object sender, EventArgs e)
        {
            if(dtPerProds.Rows.Count > 0 && isConfirmed == true)
            {
                /// adding
                /// 
                DismissalPermission dp = await dpDB.Create(new DismissalPermission
                {
                    PermissionDate = DateTime.Now,
                    WareHouseId = Convert.ToInt32(cmbWarehouses.SelectedValue.ToString())
                });

                foreach(var prod in View2Products)
                {
                    DismissalPermissionProducts dpp = new DismissalPermissionProducts
                    {
                        DismissalPerId = dp.Id,
                        ProductId = prod.ProductId,
                        Quantity = prod.Quantity,
                        CustomerId = Convert.ToInt32(cmbCustomers.SelectedValue.ToString())
                    };
                    await dppDB.Create(dpp);
                }
                this.Close();

            }
        }
    }
}
